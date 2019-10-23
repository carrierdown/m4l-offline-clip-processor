﻿namespace Mutate4l.Cli
{
    public enum TokenType
    {
        NoToken,
        CommandName,
        OptionHeader,
        OptionValue,

        _CommandsBegin,
        Arpeggiate,
        Concat,
        Crop,
        Filter,
        Interleave,
        InterleaveEvent,
        Legato,
        Mask,
        Monophonize,
        Quantize,
        Ratchet,
        Relength,
        Resize,
        Scan,
        SetLength,
        SetRhythm,
        Scale,
        Shuffle,
        Slice,
        Sustain,
        Take,
        Transpose,

        _OptionsBegin,
        Skip,     // Need to find a better way of supporting token names that can signify both options and commands. Time to stop using an enum for this I guess. For now we have this quick fix though. 
        _CommandsEnd,
        Amount,
        AutoScale,
        By,
        ChunkChords,
        ControlMax,
        ControlMin,
        Count,
        Divisions,
        Duration,
        EnableMask,
        Factor,
        Invert,
        Lengths,
        Magnetic,
        Max,
        Min,
        Mode,
        Pitch,
        Ranges,
        RatchetValues,
        RemoveOffset,
        Repeats,
        Rescale,
        Shape,
        ShuffleValues,
        SkipCounts,
        Solo,
        Start,
        Strength,
        Strict,
        TakeCounts,
        TransposeValues,
        Threshold,
        VelocityToStrength,
        Window,
        With,
        _OptionsEnd,

        _EnumValuesBegin,
        Absolute,
        Both,
        EaseIn,
        EaseInOut,
        EaseOut,
        Event,
        Linear,
        Overwrite,
        Velocity,
        Pitches, // todo: Quickfix to avoid conflict with Pitch. Need to find a better solution here...
        Relative,
        Rhythm,
        Time,
        _EnumValuesEnd,

        _ValuesBegin,
        ClipReference,
        Decimal,
        InlineClip,
        MusicalDivision,
        BarsBeatsSixteenths,
        Number,
        _ValuesEnd,

        Colon,
        Destination,
        AddToDestination,
        Unset,

        _TestOptionsBegin,
        DecimalValue,
        DecimalValues,
        IntValue,
        IntValues,
        EnumValue,
        SimpleBoolFlag,
        _TestOptionsEnd,

        _TestEnumValuesBegin,
        EnumValue1,
        EnumValue2,
        _TestEnumValuesEnd
    }
}
