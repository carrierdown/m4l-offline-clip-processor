using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using Mutate4l.Compiler;
using Mutate4l.Core;
using Mutate4l.State;
using static Mutate4l.State.InternalCommandType;

namespace Mutate4l.IO
{
    public static class CommandHandler
    {
        public static void OutputString(byte[] data)
        {
            var text = Decoder.GetText(data);
            Console.WriteLine(text);
        }

        public static void SetFormulaOnServer(byte[] data, ClipSet clipSet)
        {
            var (trackNo, clipNo, formula) = Decoder.GetFormula(data[4..]);
                    
            var parsedFormula = Parser.ParseFormula(formula);
            if (parsedFormula.Success)
            {
                Console.WriteLine($"{trackNo}, {clipNo}: Incoming formula {formula}");
                var clipRef = new ClipReference(trackNo, clipNo);
                var clipSlot = new ClipSlot(formula, new Clip(clipRef), parsedFormula.Result);
                clipSet[clipSlot.ClipReference] = clipSlot;
            }
        }

        public static void SetClipDataOnServer(byte[] data, ClipSet clipSet)
        {
            Clip clip;
            if (data[2] == Decoder.TypedDataThirdByteLive11Mode)
                clip = Decoder.GetSingleLive11Clip(data[4..]);
            else
                clip = Decoder.GetSingleClip(data[4..]);

            Console.WriteLine($"{clip.ClipReference.Track}, {clip.ClipReference.Clip} Incoming clip data");
            if (clip != Clip.Empty)
            {
                var clipSlot = new ClipSlot("", clip, Formula.Empty);
                clipSet[clipSlot.ClipReference] = clipSlot;
            }
        }

        public static void EvaluateFormulas(byte[] data, ClipSet clipSet, ChannelWriter<InternalCommand> writer)
        {
            if (!clipSet.AllReferencedClipsValid()) return;
            var isLive11 = data[2] == Decoder.TypedDataThirdByteLive11Mode;

            var orderedClipRefs = clipSet.GetClipReferencesInProcessableOrder();
            if (!orderedClipRefs.Success) return;
            Console.WriteLine($"Clips to process: {string.Join(", ", orderedClipRefs.Result.Select(x => x.ToString()))}");

            var clipsToProcess = clipSet.GetClipSlotsFromClipReferences(orderedClipRefs.Result);
            var (successfulClips, errors) = clipSet.ProcessClips(clipsToProcess);
            PrintErrors(errors);        
            
            foreach (var clipRef in successfulClips)
            {
                writer.WriteAsync(new InternalCommand(isLive11 ? SetClipDataOnClientLive11 : SetClipDataOnClient, clipSet[clipRef]));
            }
        }

        private static void PrintErrors(List<string> errorMessages)
        {
            foreach (var errorMessage in errorMessages)
            {
                Console.WriteLine(errorMessage);
            }
        }

        public static void SetAndEvaluateClipDataOnServer(byte[] data, ClipSet clipSet, ChannelWriter<InternalCommand> writer)
        {
            Clip clipToEvaluate;
            var isLive11 = data[2] == Decoder.TypedDataThirdByteLive11Mode;
            if (isLive11)
                clipToEvaluate = Decoder.GetSingleLive11Clip(data[4..]);
            else
                clipToEvaluate = Decoder.GetSingleClip(data[4..]);

            Console.WriteLine($"{clipToEvaluate.ClipReference.Track}, {clipToEvaluate.ClipReference.Clip} Incoming clip data to evaluate");

            if (clipToEvaluate != Clip.Empty)
            {
                var clipSlot = new ClipSlot("", clipToEvaluate, Formula.Empty);
                clipSet[clipSlot.ClipReference] = clipSlot;
                var clipReferences = clipSet.GetAllDependentClipRefsFromClipRef(clipSlot.ClipReference);
                var allClipsByClipRef = clipSet.GetAllReferencedClipsByClipRef();
                var orderedClipReferences = clipSet.GetClipReferencesInProcessableOrder(
                    clipReferences.Distinct().ToDictionary(
                        key => key,
                        key => allClipsByClipRef[key]
                            .Where(x => clipReferences.Contains(x))
                            .ToList()));

                Console.WriteLine($"Found dependencies: {string.Join(' ', clipReferences.Select(x => x.ToString()))}");
                Console.WriteLine($"Found sorted: {string.Join(' ', orderedClipReferences.Result.Select(x => x.ToString()))}");
                
                var clipsToProcess = clipSet.GetClipSlotsFromClipReferences(orderedClipReferences.Result);
                var (successfulClips, errors) = clipSet.ProcessClips(clipsToProcess);
                PrintErrors(errors);

                foreach (var clipRef in successfulClips)
                {
                    writer.WriteAsync(new InternalCommand(isLive11 ? SetClipDataOnClientLive11 : SetClipDataOnClient, clipSet[clipRef]));
                }
            }
        }        
        
        public static void SetAndEvaluateFormulaOnServer(byte[] data, ClipSet clipSet, ChannelWriter<InternalCommand> writer)
        {
            var isLive11 = data[2] == Decoder.TypedDataThirdByteLive11Mode;
            var (trackNo, clipNo, formula) = Decoder.GetFormula(data[4..]);
            Console.WriteLine($"{trackNo}, {clipNo} Incoming formula to evaluate");
            
            var parsedFormula = Parser.ParseFormula(formula);
            if (parsedFormula.Success)
            {
                Console.WriteLine($"{trackNo}, {clipNo}: Incoming formula {formula}");
                var clipRef = new ClipReference(trackNo, clipNo);
                var clipSlot = new ClipSlot(formula, new Clip(clipRef), parsedFormula.Result);
                clipSet[clipSlot.ClipReference] = clipSlot;
                var (successfulClips, errors) = clipSet.ProcessClips(new [] {clipSlot});
                PrintErrors(errors);
                
                foreach (var clip in successfulClips)
                {
                    writer.WriteAsync(new InternalCommand(isLive11 ? SetClipDataOnClientLive11 : SetClipDataOnClient, clipSet[clip]));
                }
            }
        }
    }
}