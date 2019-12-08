using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mutate4lTests
{
    [TestClass]
    public class FormulaTests
    {
        // Test generated by mutate4l from formula: [0] ratchet -by [1] -shape easein -velocitytostrength
        [TestMethod]
        public void RatchetShapeEaseinVelocitytostrength()
        {
            byte[] input =
            {
                99, 0, 0, 2, 0, 0, 0, 0, 128, 64, 1, 6, 0, 65, 0, 0, 160, 63, 0, 0, 0, 63, 100, 65, 0, 0, 0, 64, 0, 0, 128, 63,
                70, 67, 0, 0, 64, 64, 0, 0, 0, 63, 100, 68, 0, 0, 0, 0, 0, 0, 64, 63, 96, 69, 0, 0, 128, 63, 0, 0, 0, 63, 1, 72,
                0, 0, 96, 64, 0, 0, 0, 63, 100, 0, 1, 0, 0, 128, 64, 1, 5, 0, 60, 0, 0, 0, 0, 0, 0, 64, 63, 25, 62, 0, 0, 128, 63,
                0, 0, 64, 63, 50, 62, 0, 0, 64, 64, 0, 0, 0, 63, 67, 64, 0, 0, 0, 64, 0, 0, 128, 63, 75, 72, 0, 0, 96, 64, 0, 0,
                0, 63, 83, 91, 48, 93, 32, 114, 97, 116, 99, 104, 101, 116, 32, 45, 98, 121, 32, 91, 49, 93, 32, 45, 115, 104, 97,
                112, 101, 32, 101, 97, 115, 101, 105, 110, 32, 45, 118, 101, 108, 111, 99, 105, 116, 121, 116, 111, 115, 116, 114,
                101, 110, 103, 116, 104
            };
            byte[] output =
            {
                99, 0, 0, 0, 128, 64, 1, 28, 0, 68, 0, 0, 0, 0, 0, 0, 64, 63, 96, 69, 0, 0, 128, 63, 154, 204, 41, 62, 1, 69, 147,
                57, 149, 63, 228, 168, 42, 62, 1, 65, 0, 0, 160, 63, 106, 216, 167, 61, 100, 65, 135, 125, 170, 63, 233, 248, 41,
                62, 100, 69, 176, 142, 170, 63, 130, 138, 43, 62, 1, 65, 164, 188, 191, 63, 113, 13, 129, 62, 100, 65, 0, 0, 0,
                64, 169, 222, 236, 61, 70, 65, 245, 102, 7, 64, 161, 126, 33, 62, 70, 65, 223, 126, 17, 64, 194, 241, 73, 62, 70,
                65, 251, 29, 30, 64, 163, 50, 118, 62, 70, 65, 38, 129, 45, 64, 211, 246, 147, 62, 70, 67, 0, 0, 64, 64, 106, 216,
                167, 61, 100, 67, 195, 62, 69, 64, 233, 248, 41, 62, 100, 67, 82, 222, 79, 64, 113, 13, 129, 62, 100, 72, 0, 0,
                96, 64, 105, 234, 91, 60, 100, 72, 234, 219, 96, 64, 101, 234, 91, 60, 100, 72, 213, 183, 97, 64, 79, 174, 181,
                60, 100, 72, 49, 35, 99, 64, 79, 199, 189, 60, 100, 72, 192, 158, 100, 64, 250, 226, 253, 60, 100, 72, 134, 154,
                102, 64, 105, 165, 3, 61, 100, 72, 28, 169, 104, 64, 92, 57, 34, 61, 100, 72, 1, 50, 107, 64, 251, 211, 43, 61,
                100, 72, 81, 225, 109, 64, 81, 224, 62, 61, 100, 72, 210, 220, 112, 64, 19, 27, 84, 61, 100, 72, 63, 45, 116, 64,
                225, 250, 100, 61, 100, 72, 42, 193, 119, 64, 25, 40, 122, 61, 100, 72, 202, 169, 123, 64, 177, 198, 138, 61, 100
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [0] ratchet -by [1] -shape easein -strength 0.5
        [TestMethod]
        public void RatchetShapeEaseinStrength0P5()
        {
            byte[] input =
            {
                99, 0, 0, 2, 0, 0, 0, 0, 128, 64, 1, 6, 0, 65, 0, 0, 160, 63, 0, 0, 0, 63, 100, 65, 0, 0, 0, 64, 0, 0, 128, 63,
                70, 67, 0, 0, 64, 64, 0, 0, 0, 63, 100, 68, 0, 0, 0, 0, 0, 0, 64, 63, 96, 69, 0, 0, 128, 63, 0, 0, 0, 63, 1, 72,
                0, 0, 96, 64, 0, 0, 0, 63, 100, 0, 1, 0, 0, 128, 64, 1, 5, 0, 60, 0, 0, 0, 0, 0, 0, 64, 63, 25, 62, 0, 0, 128, 63,
                0, 0, 64, 63, 50, 62, 0, 0, 64, 64, 0, 0, 0, 63, 67, 64, 0, 0, 0, 64, 0, 0, 128, 63, 75, 72, 0, 0, 96, 64, 0, 0,
                0, 63, 83, 91, 48, 93, 32, 114, 97, 116, 99, 104, 101, 116, 32, 45, 98, 121, 32, 91, 49, 93, 32, 45, 115, 104, 97,
                112, 101, 32, 101, 97, 115, 101, 105, 110, 32, 45, 115, 116, 114, 101, 110, 103, 116, 104, 32, 48, 46, 53
            };
            byte[] output =
            {
                99, 0, 0, 0, 128, 64, 1, 28, 0, 68, 0, 0, 0, 0, 0, 0, 64, 63, 96, 69, 0, 0, 128, 63, 176, 164, 217, 61, 1, 69, 75,
                154, 141, 63, 43, 252, 57, 62, 1, 65, 0, 0, 160, 63, 176, 164, 217, 61, 100, 69, 208, 217, 164, 63, 125, 49, 89,
                62, 1, 65, 75, 154, 173, 63, 43, 252, 57, 62, 100, 65, 208, 217, 196, 63, 125, 49, 89, 62, 100, 65, 0, 0, 0, 64,
                42, 249, 199, 61, 70, 65, 201, 63, 6, 64, 70, 158, 58, 62, 70, 65, 174, 233, 17, 64, 237, 208, 93, 62, 70, 65,
                188, 198, 31, 64, 29, 86, 120, 62, 70, 65, 30, 76, 47, 64, 13, 159, 133, 62, 70, 67, 0, 0, 64, 64, 176, 164, 217,
                61, 100, 67, 38, 205, 70, 64, 43, 252, 57, 62, 100, 67, 232, 108, 82, 64, 125, 49, 89, 62, 100, 72, 0, 0, 96, 64,
                134, 18, 58, 60, 100, 72, 19, 186, 96, 64, 13, 187, 181, 60, 100, 72, 137, 37, 98, 64, 219, 71, 227, 60, 100, 72,
                24, 236, 99, 64, 123, 50, 10, 61, 100, 72, 226, 20, 102, 64, 181, 229, 23, 61, 100, 72, 121, 116, 104, 64, 99,
                117, 32, 61, 100, 72, 79, 246, 106, 64, 12, 78, 46, 61, 100, 72, 135, 175, 109, 64, 69, 17, 50, 61, 100, 72, 204,
                119, 112, 64, 146, 234, 59, 61, 100, 72, 118, 103, 115, 64, 186, 220, 64, 61, 100, 72, 233, 106, 118, 64, 103,
                235, 69, 61, 100, 72, 151, 130, 121, 64, 99, 53, 76, 61, 100, 72, 108, 179, 124, 64, 240, 36, 83, 61, 100
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [0] ratchet -by [1] -shape easein -strength 1
        [TestMethod]
        public void RatchetShapeEaseinStrength1()
        {
            byte[] input =
            {
                99, 0, 0, 2, 0, 0, 0, 0, 128, 64, 1, 6, 0, 65, 0, 0, 160, 63, 0, 0, 0, 63, 100, 65, 0, 0, 0, 64, 0, 0, 128, 63,
                70, 67, 0, 0, 64, 64, 0, 0, 0, 63, 100, 68, 0, 0, 0, 0, 0, 0, 64, 63, 96, 69, 0, 0, 128, 63, 0, 0, 0, 63, 1, 72,
                0, 0, 96, 64, 0, 0, 0, 63, 100, 0, 1, 0, 0, 128, 64, 1, 5, 0, 60, 0, 0, 0, 0, 0, 0, 64, 63, 25, 62, 0, 0, 128, 63,
                0, 0, 64, 63, 50, 62, 0, 0, 64, 64, 0, 0, 0, 63, 67, 64, 0, 0, 0, 64, 0, 0, 128, 63, 75, 72, 0, 0, 96, 64, 0, 0,
                0, 63, 83, 91, 48, 93, 32, 114, 97, 116, 99, 104, 101, 116, 32, 45, 98, 121, 32, 91, 49, 93, 32, 45, 115, 104, 97,
                112, 101, 32, 101, 97, 115, 101, 105, 110, 32, 45, 115, 116, 114, 101, 110, 103, 116, 104, 32, 49
            };
            byte[] output =
            {
                99, 0, 0, 0, 128, 64, 1, 28, 0, 68, 0, 0, 0, 0, 0, 0, 64, 63, 96, 69, 0, 0, 128, 63, 219, 1, 114, 61, 1, 69, 15,
                144, 135, 63, 235, 200, 41, 62, 1, 69, 44, 201, 156, 63, 79, 219, 140, 62, 1, 65, 0, 0, 160, 63, 219, 1, 114, 61,
                100, 65, 15, 144, 167, 63, 235, 200, 41, 62, 100, 65, 44, 201, 188, 63, 79, 219, 140, 62, 100, 65, 0, 0, 0, 64,
                159, 111, 64, 61, 70, 65, 190, 1, 3, 64, 162, 118, 252, 61, 70, 65, 116, 229, 10, 64, 124, 158, 71, 62, 70, 65,
                91, 95, 23, 64, 39, 244, 139, 62, 70, 65, 224, 221, 40, 64, 255, 16, 185, 62, 70, 67, 0, 0, 64, 64, 219, 1, 114,
                61, 100, 67, 7, 200, 67, 64, 235, 200, 41, 62, 100, 67, 150, 100, 78, 64, 79, 219, 140, 62, 100, 72, 0, 0, 96, 64,
                126, 77, 218, 59, 100, 72, 39, 109, 96, 64, 116, 77, 218, 59, 100, 72, 77, 218, 96, 64, 249, 169, 145, 60, 100,
                72, 161, 253, 97, 64, 176, 242, 155, 60, 100, 72, 135, 53, 99, 64, 129, 93, 237, 60, 100, 72, 66, 16, 101, 64,
                119, 79, 249, 60, 100, 72, 225, 2, 103, 64, 59, 125, 35, 61, 100, 72, 214, 144, 105, 64, 174, 175, 47, 61, 100,
                72, 148, 79, 108, 64, 159, 224, 71, 61, 100, 72, 23, 111, 111, 64, 197, 214, 98, 61, 100, 72, 114, 250, 114, 64,
                235, 68, 120, 61, 100, 72, 134, 219, 118, 64, 239, 148, 137, 61, 100, 72, 45, 40, 123, 64, 94, 250, 154, 61, 100
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [0] ratchet -by [1] -shape easein -strength 0
        [TestMethod]
        public void RatchetShapeEaseinStrength0()
        {
            byte[] input =
            {
                99, 0, 0, 2, 0, 0, 0, 0, 128, 64, 1, 6, 0, 65, 0, 0, 160, 63, 0, 0, 0, 63, 100, 65, 0, 0, 0, 64, 0, 0, 128, 63,
                70, 67, 0, 0, 64, 64, 0, 0, 0, 63, 100, 68, 0, 0, 0, 0, 0, 0, 64, 63, 96, 69, 0, 0, 128, 63, 0, 0, 0, 63, 1, 72,
                0, 0, 96, 64, 0, 0, 0, 63, 100, 0, 1, 0, 0, 128, 64, 1, 5, 0, 60, 0, 0, 0, 0, 0, 0, 64, 63, 25, 62, 0, 0, 128, 63,
                0, 0, 64, 63, 50, 62, 0, 0, 64, 64, 0, 0, 0, 63, 67, 64, 0, 0, 0, 64, 0, 0, 128, 63, 75, 72, 0, 0, 96, 64, 0, 0,
                0, 63, 83, 91, 48, 93, 32, 114, 97, 116, 99, 104, 101, 116, 32, 45, 98, 121, 32, 91, 49, 93, 32, 45, 115, 104, 97,
                112, 101, 32, 101, 97, 115, 101, 105, 110, 32, 45, 115, 116, 114, 101, 110, 103, 116, 104, 32, 48
            };
            byte[] output =
            {
                99, 0, 0, 0, 128, 64, 1, 28, 0, 68, 0, 0, 0, 0, 0, 0, 64, 63, 96, 69, 0, 0, 128, 63, 170, 170, 42, 62, 1, 69, 85,
                85, 149, 63, 173, 170, 42, 62, 1, 65, 0, 0, 160, 63, 170, 170, 42, 62, 100, 69, 171, 170, 170, 63, 170, 170, 42,
                62, 1, 65, 85, 85, 181, 63, 173, 170, 42, 62, 100, 65, 171, 170, 202, 63, 170, 170, 42, 62, 100, 65, 0, 0, 0, 64,
                205, 204, 76, 62, 70, 65, 205, 204, 12, 64, 205, 204, 76, 62, 70, 65, 154, 153, 25, 64, 205, 204, 76, 62, 70, 65,
                102, 102, 38, 64, 205, 204, 76, 62, 70, 65, 51, 51, 51, 64, 205, 204, 76, 62, 70, 67, 0, 0, 64, 64, 170, 170, 42,
                62, 100, 67, 171, 170, 74, 64, 173, 170, 42, 62, 100, 67, 85, 85, 85, 64, 170, 170, 42, 62, 100, 72, 0, 0, 96, 64,
                217, 137, 29, 61, 100, 72, 39, 118, 98, 64, 222, 137, 29, 61, 100, 72, 79, 236, 100, 64, 206, 137, 29, 61, 100,
                72, 118, 98, 103, 64, 220, 137, 29, 61, 100, 72, 158, 216, 105, 64, 220, 137, 29, 61, 100, 72, 197, 78, 108, 64,
                220, 137, 29, 61, 100, 72, 236, 196, 110, 64, 220, 137, 29, 61, 100, 72, 20, 59, 113, 64, 206, 137, 29, 61, 100,
                72, 59, 177, 115, 64, 220, 137, 29, 61, 100, 72, 98, 39, 118, 64, 220, 137, 29, 61, 100, 72, 138, 157, 120, 64,
                220, 137, 29, 61, 100, 72, 177, 19, 123, 64, 206, 137, 29, 61, 100, 72, 217, 137, 125, 64, 220, 137, 29, 61, 100
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [0] resize 0.25
        [TestMethod]
        public void Resize0P25()
        {
            byte[] input =
            {
                100, 0, 0, 1, 0, 1, 0, 0, 128, 64, 1, 5, 0, 60, 0, 0, 0, 0, 0, 0, 64, 63, 25, 62, 0, 0, 128, 63, 0, 0, 64, 63, 50,
                62, 0, 0, 64, 64, 0, 0, 0, 63, 67, 64, 0, 0, 0, 64, 0, 0, 128, 63, 75, 72, 0, 0, 96, 64, 0, 0, 0, 63, 83, 91, 48,
                93, 32, 114, 101, 115, 105, 122, 101, 32, 48, 46, 50, 53
            };
            byte[] output =
            {
                100, 0, 0, 0, 128, 63, 1, 5, 0, 60, 0, 0, 0, 0, 0, 0, 64, 62, 25, 62, 0, 0, 128, 62, 0, 0, 64, 62, 50, 64, 0, 0,
                0, 63, 0, 0, 128, 62, 75, 62, 0, 0, 64, 63, 0, 0, 0, 62, 67, 72, 0, 0, 96, 63, 0, 0, 0, 62, 83
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [0] [1] interleave take 1
        /*[TestMethod]
        public void InterleaveTakeDuration()
        {
            byte[] input =
            {
                101, 0, 0, 2, 0, 0, 0, 0, 128, 64, 1, 6, 0, 65, 0, 0, 160, 63, 0, 0, 0, 63, 100, 65, 0, 0, 0, 64, 0, 0, 128, 63,
                70, 67, 0, 0, 64, 64, 0, 0, 0, 63, 100, 68, 0, 0, 0, 0, 0, 0, 64, 63, 96, 69, 0, 0, 128, 63, 0, 0, 0, 63, 1, 72,
                0, 0, 96, 64, 0, 0, 0, 63, 100, 0, 5, 0, 0, 0, 64, 1, 6, 0, 65, 0, 0, 32, 63, 0, 0, 128, 62, 100, 65, 0, 0, 128,
                63, 0, 0, 0, 63, 70, 67, 0, 0, 192, 63, 0, 0, 128, 62, 100, 68, 0, 0, 0, 0, 0, 0, 192, 62, 96, 69, 0, 0, 0, 63, 0,
                0, 128, 62, 1, 72, 0, 0, 224, 63, 0, 0, 128, 62, 100, 91, 48, 93, 32, 91, 49, 93, 32, 105, 110, 116, 101, 114,
                108, 101, 97, 118, 101, 32, 116, 97, 107, 101, 32, 49
            };
            byte[] output =
            {
                101, 0, 0, 0, 128, 64, 1, 9, 0, 68, 0, 0, 0, 0, 0, 0, 64, 63, 96, 68, 0, 0, 128, 63, 0, 0, 192, 62, 96, 69, 0, 0,
                192, 63, 0, 0, 128, 62, 1, 65, 0, 0, 208, 63, 0, 0, 128, 62, 100, 69, 0, 0, 0, 64, 0, 0, 0, 63, 1, 65, 0, 0, 16,
                64, 0, 0, 0, 63, 100, 65, 0, 0, 64, 64, 0, 0, 0, 63, 70, 67, 0, 0, 96, 64, 0, 0, 128, 62, 100, 72, 0, 0, 112, 64,
                0, 0, 128, 62, 100
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [0] [1] interleave take 1/4 1
        [TestMethod]
        public void InterleaveTakeStartAndDuration()
        {
            byte[] input =
            {
                101, 0, 0, 2, 0, 0, 0, 0, 128, 64, 1, 6, 0, 65, 0, 0, 160, 63, 0, 0, 0, 63, 100, 65, 0, 0, 0, 64, 0, 0, 128, 63,
                70, 67, 0, 0, 64, 64, 0, 0, 0, 63, 100, 68, 0, 0, 0, 0, 0, 0, 64, 63, 96, 69, 0, 0, 128, 63, 0, 0, 0, 63, 1, 72,
                0, 0, 96, 64, 0, 0, 0, 63, 100, 0, 5, 0, 0, 0, 64, 1, 6, 0, 65, 0, 0, 32, 63, 0, 0, 128, 62, 100, 65, 0, 0, 128,
                63, 0, 0, 0, 63, 70, 67, 0, 0, 192, 63, 0, 0, 128, 62, 100, 68, 0, 0, 0, 0, 0, 0, 192, 62, 96, 69, 0, 0, 0, 63, 0,
                0, 128, 62, 1, 72, 0, 0, 224, 63, 0, 0, 128, 62, 100, 91, 48, 93, 32, 91, 49, 93, 32, 105, 110, 116, 101, 114,
                108, 101, 97, 118, 101, 32, 116, 97, 107, 101, 32, 49, 47, 52, 32, 49
            };
            byte[] output =
            {
                101, 0, 0, 0, 128, 64, 1, 9, 0, 68, 0, 0, 0, 0, 0, 0, 192, 62, 96, 69, 0, 0, 0, 63, 0, 0, 128, 62, 1, 65, 0, 0,
                32, 63, 0, 0, 128, 62, 100, 69, 0, 0, 128, 63, 0, 0, 0, 63, 1, 65, 0, 0, 160, 63, 0, 0, 0, 63, 100, 65, 0, 0, 0,
                64, 0, 0, 0, 63, 70, 67, 0, 0, 32, 64, 0, 0, 128, 62, 100, 72, 0, 0, 48, 64, 0, 0, 128, 62, 100, 65, 0, 0, 64, 64,
                0, 0, 128, 63, 70
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }*/

        // Test generated by mutate4l from formula: [0] mask
        [TestMethod]
        public void InverseMask()
        {
            byte[] input =
            {
                160, 0, 0, 1, 0, 11, 0, 0, 128, 64, 1, 3, 0, 67, 0, 0, 0, 64, 0, 0, 128, 62, 100, 70, 0, 0, 160, 63, 0, 0, 128,
                62, 100, 72, 0, 0, 64, 63, 0, 0, 128, 62, 100, 91, 48, 93, 32, 109, 97, 115, 107
            };
            byte[] output =
            {
                160, 0, 0, 0, 128, 64, 1, 4, 0, 72, 0, 0, 0, 0, 0, 0, 64, 63, 100, 70, 0, 0, 128, 63, 0, 0, 128, 62, 100, 67, 0,
                0, 192, 63, 0, 0, 0, 63, 100, 67, 0, 0, 16, 64, 0, 0, 224, 63, 100
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [0] mask -by [1]
        [TestMethod]
        public void MaskByOtherClip()
        {
            byte[] input =
            {
                165, 0, 0, 2, 0, 11, 0, 0, 128, 64, 1, 3, 0, 67, 0, 0, 0, 64, 0, 0, 128, 62, 100, 70, 0, 0, 160, 63, 0, 0, 128,
                62, 100, 72, 0, 0, 64, 63, 0, 0, 128, 62, 100, 0, 28, 0, 0, 128, 64, 1, 3, 0, 70, 0, 0, 144, 63, 0, 0, 128, 62,
                100, 72, 0, 0, 96, 63, 0, 0, 128, 62, 100, 73, 0, 0, 8, 64, 0, 0, 0, 62, 100, 91, 48, 93, 32, 109, 97, 115, 107,
                32, 45, 98, 121, 32, 91, 49, 93
            };
            byte[] output =
            {
                165, 0, 0, 0, 128, 64, 1, 3, 0, 72, 0, 0, 64, 63, 0, 0, 0, 62, 100, 70, 0, 0, 176, 63, 0, 0, 0, 62, 100, 73, 0, 0,
                0, 64, 0, 0, 0, 62, 100
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [0] [1] sr
        [TestMethod]
        public void SetRhythmOverlappingNotes()
        {
            byte[] input =
            {
                174, 0, 0, 2, 0, 31, 0, 0, 128, 64, 1, 8, 0, 67, 203, 229, 190, 61, 26, 141, 32, 62, 100, 67, 220, 44, 233, 62,
                141, 70, 208, 62, 100, 67, 93, 238, 139, 63, 26, 141, 32, 62, 100, 67, 0, 0, 224, 63, 141, 70, 208, 62, 100, 67,
                96, 10, 24, 64, 141, 70, 208, 62, 100, 67, 0, 0, 96, 64, 224, 133, 52, 62, 100, 69, 208, 174, 26, 64, 141, 70,
                208, 62, 100, 69, 162, 183, 68, 64, 224, 133, 52, 62, 100, 0, 32, 0, 0, 128, 64, 1, 13, 0, 60, 0, 0, 64, 63, 0, 0,
                128, 62, 100, 61, 0, 0, 64, 64, 0, 0, 128, 62, 100, 62, 0, 0, 128, 63, 0, 0, 128, 62, 100, 62, 0, 0, 48, 64, 0, 0,
                128, 62, 100, 63, 0, 0, 0, 0, 0, 0, 128, 62, 100, 63, 0, 0, 32, 64, 0, 0, 128, 62, 100, 64, 0, 0, 160, 63, 0, 0,
                128, 62, 100, 64, 0, 0, 16, 64, 0, 0, 128, 62, 100, 65, 0, 0, 0, 64, 0, 0, 128, 62, 100, 66, 0, 0, 128, 62, 0, 0,
                128, 62, 100, 66, 0, 0, 224, 63, 0, 0, 128, 62, 100, 67, 0, 0, 192, 63, 0, 0, 128, 62, 100, 68, 0, 0, 0, 63, 0, 0,
                128, 62, 100, 91, 48, 93, 32, 91, 49, 93, 32, 115, 114
            };
            byte[] output =
            {
                174, 0, 0, 0, 224, 64, 1, 13, 0, 63, 203, 229, 190, 61, 29, 141, 32, 62, 100, 66, 221, 44, 233, 62, 142, 70, 208,
                62, 100, 68, 95, 238, 139, 63, 29, 141, 32, 62, 100, 60, 0, 0, 224, 63, 142, 70, 208, 62, 100, 62, 95, 10, 24, 64,
                142, 70, 208, 62, 100, 64, 209, 174, 26, 64, 142, 70, 208, 62, 100, 67, 162, 183, 68, 64, 221, 133, 52, 62, 100,
                66, 0, 0, 96, 64, 221, 133, 52, 62, 100, 65, 151, 251, 130, 64, 29, 141, 32, 62, 100, 64, 206, 146, 142, 64, 142,
                70, 208, 62, 100, 63, 152, 251, 162, 64, 29, 141, 32, 62, 100, 62, 0, 0, 184, 64, 142, 70, 208, 62, 100, 61, 47,
                5, 204, 64, 142, 70, 208, 62, 100
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [0] sr -by [1]
        [TestMethod]
        public void SetRhythm()
        {
            byte[] input =
            {
                174, 0, 0, 2, 0, 32, 0, 0, 128, 64, 1, 9, 0, 60, 0, 0, 64, 63, 0, 0, 128, 62, 100, 62, 0, 0, 128, 63, 0, 0, 128,
                62, 100, 63, 0, 0, 0, 0, 0, 0, 128, 62, 100, 64, 0, 0, 160, 63, 0, 0, 128, 62, 100, 66, 0, 0, 128, 62, 0, 0, 128,
                62, 100, 67, 0, 0, 192, 63, 0, 0, 128, 62, 100, 67, 0, 0, 224, 63, 0, 0, 128, 62, 100, 67, 0, 0, 0, 64, 0, 0, 128,
                62, 100, 68, 0, 0, 0, 63, 0, 0, 128, 62, 100, 0, 31, 0, 0, 128, 64, 1, 8, 0, 67, 203, 229, 190, 61, 26, 141, 32,
                62, 100, 67, 220, 44, 233, 62, 141, 70, 208, 62, 100, 67, 93, 238, 139, 63, 26, 141, 32, 62, 100, 67, 0, 0, 224,
                63, 141, 70, 208, 62, 100, 67, 96, 10, 24, 64, 141, 70, 208, 62, 100, 67, 0, 0, 96, 64, 224, 133, 52, 62, 100, 69,
                208, 174, 26, 64, 141, 70, 208, 62, 100, 69, 162, 183, 68, 64, 224, 133, 52, 62, 100, 91, 48, 93, 32, 115, 114,
                32, 45, 98, 121, 32, 91, 49, 93
            };
            byte[] output =
            {
                174, 0, 0, 0, 144, 64, 1, 9, 0, 63, 203, 229, 190, 61, 29, 141, 32, 62, 100, 66, 221, 44, 233, 62, 142, 70, 208,
                62, 100, 68, 95, 238, 139, 63, 29, 141, 32, 62, 100, 60, 0, 0, 224, 63, 142, 70, 208, 62, 100, 62, 95, 10, 24, 64,
                142, 70, 208, 62, 100, 64, 209, 174, 26, 64, 142, 70, 208, 62, 100, 67, 162, 183, 68, 64, 221, 133, 52, 62, 100,
                67, 0, 0, 96, 64, 221, 133, 52, 62, 100, 67, 151, 251, 130, 64, 29, 141, 32, 62, 100
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [0] legato
        [TestMethod]
        public void TestLegatoChordAndLastSingleNote()
        {
            byte[] input =
            {
                203, 0, 0, 1, 0, 28, 0, 0, 128, 64, 1, 5, 0, 72, 0, 0, 96, 63, 0, 0, 128, 62, 100, 73, 51, 19, 98, 63, 0, 0, 128,
                62, 100, 73, 0, 0, 8, 64, 0, 0, 0, 62, 100, 74, 153, 9, 97, 63, 0, 0, 128, 62, 100, 75, 148, 57, 102, 63, 99, 51,
                206, 61, 100, 91, 48, 93, 32, 108, 101, 103, 97, 116, 111
            };
            byte[] output =
            {
                203, 0, 0, 0, 128, 64, 1, 5, 0, 72, 0, 0, 96, 63, 0, 0, 160, 63, 100, 74, 153, 9, 97, 63, 51, 123, 159, 63, 100,
                73, 52, 19, 98, 63, 102, 246, 158, 63, 100, 75, 148, 57, 102, 63, 54, 227, 156, 63, 100, 73, 0, 0, 8, 64, 0, 0,
                240, 63, 100
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [0] legato
        [TestMethod]
        public void TestLegatoChordAndTwoLastNotes()
        {
            byte[] input =
            {
                203, 0, 0, 1, 0, 28, 0, 0, 128, 64, 1, 6, 0, 72, 0, 0, 96, 63, 0, 0, 128, 62, 100, 73, 51, 19, 98, 63, 0, 0, 128,
                62, 100, 73, 0, 0, 208, 63, 0, 0, 0, 62, 100, 73, 0, 0, 8, 64, 0, 0, 0, 62, 100, 74, 153, 9, 97, 63, 0, 0, 128,
                62, 100, 75, 148, 57, 102, 63, 99, 51, 206, 61, 100, 91, 48, 93, 32, 108, 101, 103, 97, 116, 111
            };
            byte[] output =
            {
                203, 0, 0, 0, 128, 64, 1, 6, 0, 72, 0, 0, 96, 63, 0, 0, 64, 63, 100, 74, 153, 9, 97, 63, 103, 246, 62, 63, 100,
                73, 52, 19, 98, 63, 204, 236, 61, 63, 100, 75, 148, 57, 102, 63, 108, 198, 57, 63, 100, 73, 0, 0, 208, 63, 0, 0,
                0, 63, 100, 73, 0, 0, 8, 64, 0, 0, 240, 63, 100
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [0] quantize -by [1]
        [TestMethod]
        public void TestQuantizeByClip()
        {
            byte[] input =
            {
                205, 0, 0, 2, 0, 33, 0, 0, 128, 64, 1, 5, 0, 62, 48, 19, 194, 63, 0, 0, 128, 62, 100, 64, 141, 188, 203, 62, 0, 0,
                128, 62, 100, 67, 173, 25, 39, 63, 219, 9, 46, 62, 100, 67, 48, 185, 50, 64, 121, 241, 167, 62, 100, 68, 201, 0,
                231, 63, 0, 0, 128, 62, 100, 0, 29, 0, 0, 128, 64, 1, 4, 0, 67, 0, 0, 192, 63, 0, 0, 0, 63, 100, 67, 0, 0, 16, 64,
                0, 0, 224, 63, 100, 70, 41, 115, 140, 63, 0, 0, 128, 62, 100, 72, 208, 77, 188, 61, 0, 0, 64, 63, 100, 91, 48, 93,
                32, 113, 117, 97, 110, 116, 105, 122, 101, 32, 45, 98, 121, 32, 91, 49, 93
            };
            byte[] output =
            {
                205, 0, 0, 0, 128, 64, 1, 5, 0, 64, 208, 77, 188, 61, 0, 0, 128, 62, 100, 67, 38, 115, 140, 63, 221, 9, 46, 62,
                100, 62, 0, 0, 192, 63, 0, 0, 128, 62, 100, 68, 0, 0, 192, 63, 0, 0, 128, 62, 100, 67, 0, 0, 16, 64, 122, 241,
                167, 62, 100
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [0] quantize 1/16 1/32
        [TestMethod]
        public void TestQuantizeBySpecifiedValues()
        {
            byte[] input =
            {
                205, 0, 0, 1, 0, 33, 0, 0, 128, 64, 1, 5, 0, 62, 48, 19, 194, 63, 0, 0, 128, 62, 100, 64, 141, 188, 203, 62, 0, 0,
                128, 62, 100, 67, 173, 25, 39, 63, 219, 9, 46, 62, 100, 67, 48, 185, 50, 64, 121, 241, 167, 62, 100, 68, 201, 0,
                231, 63, 0, 0, 128, 62, 100, 91, 48, 93, 32, 113, 117, 97, 110, 116, 105, 122, 101, 32, 49, 47, 49, 54, 32, 49,
                47, 51, 50
            };
            byte[] output =
            {
                205, 0, 0, 0, 128, 64, 1, 5, 0, 64, 0, 0, 192, 62, 0, 0, 128, 62, 100, 67, 0, 0, 32, 63, 221, 9, 46, 62, 100, 62,
                0, 0, 192, 63, 0, 0, 128, 62, 100, 68, 0, 0, 224, 63, 0, 0, 128, 62, 100, 67, 0, 0, 56, 64, 122, 241, 167, 62, 100
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [<a2>0] take 2 3 4 1
        [TestMethod]
        public void TestTake()
        {
            byte[] input =
            {
                104, 2, 0, 1, 0, 1, 0, 0, 128, 64, 1, 13, 0, 60, 0, 0, 0, 0, 0, 0, 128, 62, 100, 61, 0, 0, 128, 62, 0, 0, 128, 62,
                100, 62, 0, 0, 0, 63, 0, 0, 128, 62, 100, 63, 0, 0, 64, 63, 0, 0, 128, 62, 100, 64, 0, 0, 128, 63, 0, 0, 128, 62,
                100, 65, 0, 0, 160, 63, 0, 0, 128, 62, 100, 66, 0, 0, 192, 63, 0, 0, 128, 62, 100, 67, 0, 0, 224, 63, 0, 0, 128,
                62, 100, 68, 0, 0, 0, 64, 0, 0, 128, 62, 100, 69, 0, 0, 16, 64, 0, 0, 128, 62, 100, 70, 0, 0, 32, 64, 0, 0, 128,
                62, 100, 71, 0, 0, 48, 64, 0, 0, 128, 62, 100, 72, 0, 0, 64, 64, 0, 0, 128, 62, 100, 91, 60, 97, 50, 62, 48, 93,
                32, 116, 97, 107, 101, 32, 50, 32, 51, 32, 52, 32, 49
            };
            byte[] output =
            {
                104, 2, 0, 0, 128, 64, 1, 15, 0, 61, 0, 0, 0, 0, 0, 0, 128, 62, 100, 64, 0, 0, 128, 62, 0, 0, 128, 62, 100, 68, 0,
                0, 0, 63, 0, 0, 128, 62, 100, 69, 0, 0, 64, 63, 0, 0, 128, 62, 100, 71, 0, 0, 128, 63, 0, 0, 128, 62, 100, 61, 0,
                0, 160, 63, 0, 0, 128, 62, 100, 65, 0, 0, 192, 63, 0, 0, 128, 62, 100, 66, 0, 0, 224, 63, 0, 0, 128, 62, 100, 68,
                0, 0, 0, 64, 0, 0, 128, 62, 100, 71, 0, 0, 16, 64, 0, 0, 128, 62, 100, 62, 0, 0, 32, 64, 0, 0, 128, 62, 100, 63,
                0, 0, 48, 64, 0, 0, 128, 62, 100, 65, 0, 0, 64, 64, 0, 0, 128, 62, 100, 68, 0, 0, 80, 64, 0, 0, 128, 62, 100, 72,
                0, 0, 96, 64, 0, 0, 128, 62, 100
            };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [<a2>0] skip 2 3 4 1
        [TestMethod]
        public void TestSkip()
        {
            byte[] input = { 104, 2, 0, 1, 0, 1, 0, 0, 128, 64, 1, 13, 0, 60, 0, 0, 0, 0, 0, 0, 128, 62, 100, 61, 0, 0, 128, 62, 0, 0, 128, 62, 100, 62, 0, 0, 0, 63, 0, 0, 128, 62, 100, 63, 0, 0, 64, 63, 0, 0, 128, 62, 100, 64, 0, 0, 128, 63, 0, 0, 128, 62, 100, 65, 0, 0, 160, 63, 0, 0, 128, 62, 100, 66, 0, 0, 192, 63, 0, 0, 128, 62, 100, 67, 0, 0, 224, 63, 0, 0, 128, 62, 100, 68, 0, 0, 0, 64, 0, 0, 128, 62, 100, 69, 0, 0, 16, 64, 0, 0, 128, 62, 100, 70, 0, 0, 32, 64, 0, 0, 128, 62, 100, 71, 0, 0, 48, 64, 0, 0, 128, 62, 100, 72, 0, 0, 64, 64, 0, 0, 128, 62, 100, 91, 60, 97, 50, 62, 48, 93, 32, 115, 107, 105, 112, 32, 50, 32, 51, 32, 52, 32, 49 };
            byte[] output = { 104, 2, 0, 0, 128, 64, 1, 13, 0, 60, 0, 0, 0, 0, 0, 0, 128, 62, 100, 62, 0, 0, 128, 62, 0, 0, 128, 62, 100, 63, 0, 0, 0, 63, 0, 0, 128, 62, 100, 65, 0, 0, 64, 63, 0, 0, 128, 62, 100, 66, 0, 0, 128, 63, 0, 0, 128, 62, 100, 67, 0, 0, 160, 63, 0, 0, 128, 62, 100, 70, 0, 0, 192, 63, 0, 0, 128, 62, 100, 72, 0, 0, 224, 63, 0, 0, 128, 62, 100, 60, 0, 0, 48, 64, 0, 0, 128, 62, 100, 62, 0, 0, 64, 64, 0, 0, 128, 62, 100, 63, 0, 0, 80, 64, 0, 0, 128, 62, 100, 64, 0, 0, 96, 64, 0, 0, 128, 62, 100, 67, 0, 0, 112, 64, 0, 0, 128, 62, 100 };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }
        
        // Test generated by mutate4l from formula: [<c8>0] remap -to [<c13>1]
        [TestMethod]
        public void TestRemapToClip()
        {
            byte[] input = { 193, 0, 2, 2, 2, 7, 0, 0, 128, 64, 1, 8, 0, 60, 0, 0, 0, 0, 0, 0, 0, 63, 100, 61, 0, 0, 80, 64, 0, 0, 0, 63, 100, 64, 0, 0, 224, 63, 0, 0, 128, 62, 100, 65, 0, 0, 128, 62, 0, 0, 64, 63, 100, 65, 0, 0, 48, 64, 0, 0, 64, 63, 100, 67, 0, 0, 224, 63, 0, 0, 0, 63, 100, 69, 0, 0, 64, 63, 0, 0, 64, 63, 100, 69, 0, 0, 224, 63, 0, 0, 64, 63, 100, 2, 12, 0, 0, 128, 64, 1, 2, 0, 36, 0, 0, 0, 0, 0, 0, 128, 62, 100, 37, 0, 0, 0, 0, 0, 0, 128, 62, 100, 91, 60, 99, 56, 62, 48, 93, 32, 114, 101, 109, 97, 112, 32, 45, 116, 111, 32, 91, 60, 99, 49, 51, 62, 49, 93 };
            byte[] output = { 193, 0, 0, 0, 128, 64, 1, 7, 0, 36, 0, 0, 0, 0, 0, 0, 0, 63, 100, 37, 0, 0, 128, 62, 0, 0, 0, 63, 100, 37, 0, 0, 64, 63, 0, 0, 64, 63, 100, 36, 0, 0, 224, 63, 0, 0, 128, 62, 100, 37, 0, 0, 224, 63, 0, 0, 0, 63, 100, 37, 0, 0, 48, 64, 0, 0, 64, 63, 100, 36, 0, 0, 80, 64, 0, 0, 0, 63, 100 };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [<c8>0] remap
        [TestMethod]
        public void TestRemap()
        {
            byte[] input = { 193, 0, 2, 1, 2, 7, 0, 0, 128, 64, 1, 8, 0, 60, 0, 0, 0, 0, 0, 0, 0, 63, 100, 61, 0, 0, 80, 64, 0, 0, 0, 63, 100, 64, 0, 0, 224, 63, 0, 0, 128, 62, 100, 65, 0, 0, 128, 62, 0, 0, 64, 63, 100, 65, 0, 0, 48, 64, 0, 0, 64, 63, 100, 67, 0, 0, 224, 63, 0, 0, 0, 63, 100, 69, 0, 0, 64, 63, 0, 0, 64, 63, 100, 69, 0, 0, 224, 63, 0, 0, 64, 63, 100, 91, 60, 99, 56, 62, 48, 93, 32, 114, 101, 109, 97, 112 };
            byte[] output = { 193, 0, 0, 0, 128, 64, 1, 8, 0, 36, 0, 0, 0, 0, 0, 0, 0, 63, 100, 39, 0, 0, 128, 62, 0, 0, 64, 63, 100, 41, 0, 0, 64, 63, 0, 0, 64, 63, 100, 38, 0, 0, 224, 63, 0, 0, 128, 62, 100, 40, 0, 0, 224, 63, 0, 0, 0, 63, 100, 41, 0, 0, 224, 63, 0, 0, 64, 63, 100, 39, 0, 0, 48, 64, 0, 0, 64, 63, 100, 37, 0, 0, 80, 64, 0, 0, 0, 63, 100 };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [<c8>0] remap -to [<c13>1]
        [TestMethod]
        public void TestRemapToClip2()
        {
            byte[] input = { 193, 0, 2, 2, 2, 7, 0, 0, 128, 64, 1, 8, 0, 60, 0, 0, 0, 0, 0, 0, 0, 63, 100, 61, 0, 0, 80, 64, 0, 0, 0, 63, 100, 64, 0, 0, 224, 63, 0, 0, 128, 62, 100, 65, 0, 0, 128, 62, 0, 0, 64, 63, 100, 65, 0, 0, 48, 64, 0, 0, 64, 63, 100, 67, 0, 0, 224, 63, 0, 0, 0, 63, 100, 69, 0, 0, 64, 63, 0, 0, 64, 63, 100, 69, 0, 0, 224, 63, 0, 0, 64, 63, 100, 2, 12, 0, 0, 128, 64, 1, 1, 0, 36, 0, 0, 0, 0, 0, 0, 128, 62, 100, 91, 60, 99, 56, 62, 48, 93, 32, 114, 101, 109, 97, 112, 32, 45, 116, 111, 32, 91, 60, 99, 49, 51, 62, 49, 93 };
            byte[] output = { 193, 0, 0, 0, 128, 64, 1, 6, 0, 36, 0, 0, 0, 0, 0, 0, 128, 62, 100, 36, 0, 0, 128, 62, 0, 0, 0, 63, 100, 36, 0, 0, 64, 63, 0, 0, 64, 63, 100, 36, 0, 0, 224, 63, 0, 0, 128, 62, 100, 36, 0, 0, 48, 64, 0, 0, 0, 63, 100, 36, 0, 0, 80, 64, 0, 0, 0, 63, 100 };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [<c8>0] setpitch 60 61 62
        [TestMethod]
        public void TestSetPitch()
        {
            byte[] input = { 193, 0, 2, 1, 2, 7, 0, 0, 128, 64, 1, 8, 0, 60, 0, 0, 0, 0, 0, 0, 0, 63, 100, 61, 0, 0, 80, 64, 0, 0, 0, 63, 100, 64, 0, 0, 224, 63, 0, 0, 128, 62, 100, 65, 0, 0, 128, 62, 0, 0, 64, 63, 100, 65, 0, 0, 48, 64, 0, 0, 64, 63, 100, 67, 0, 0, 224, 63, 0, 0, 0, 63, 100, 69, 0, 0, 64, 63, 0, 0, 64, 63, 100, 69, 0, 0, 224, 63, 0, 0, 64, 63, 100, 91, 60, 99, 56, 62, 48, 93, 32, 115, 101, 116, 112, 105, 116, 99, 104, 32, 54, 48, 32, 54, 49, 32, 54, 50 };
            byte[] output = { 193, 0, 0, 0, 128, 64, 1, 8, 0, 60, 0, 0, 0, 0, 0, 0, 0, 63, 100, 61, 0, 0, 128, 62, 0, 0, 64, 63, 100, 62, 0, 0, 64, 63, 0, 0, 64, 63, 100, 60, 0, 0, 224, 63, 0, 0, 128, 62, 100, 61, 0, 0, 224, 63, 0, 0, 0, 63, 100, 62, 0, 0, 224, 63, 0, 0, 64, 63, 100, 60, 0, 0, 48, 64, 0, 0, 64, 63, 100, 61, 0, 0, 80, 64, 0, 0, 0, 63, 100 };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [<c8>0] setpitch 60
        [TestMethod]
        public void TestSetPitchSingle()
        {
            byte[] input = { 193, 0, 2, 1, 2, 7, 0, 0, 128, 64, 1, 8, 0, 60, 0, 0, 0, 0, 0, 0, 0, 63, 100, 61, 0, 0, 80, 64, 0, 0, 0, 63, 100, 64, 0, 0, 224, 63, 0, 0, 128, 62, 100, 65, 0, 0, 128, 62, 0, 0, 64, 63, 100, 65, 0, 0, 48, 64, 0, 0, 64, 63, 100, 67, 0, 0, 224, 63, 0, 0, 0, 63, 100, 69, 0, 0, 64, 63, 0, 0, 64, 63, 100, 69, 0, 0, 224, 63, 0, 0, 64, 63, 100, 91, 60, 99, 56, 62, 48, 93, 32, 115, 101, 116, 112, 105, 116, 99, 104, 32, 54, 48 };
            byte[] output = { 193, 0, 0, 0, 128, 64, 1, 6, 0, 60, 0, 0, 0, 0, 0, 0, 128, 62, 100, 60, 0, 0, 128, 62, 0, 0, 0, 63, 100, 60, 0, 0, 64, 63, 0, 0, 64, 63, 100, 60, 0, 0, 224, 63, 0, 0, 128, 62, 100, 60, 0, 0, 48, 64, 0, 0, 0, 63, 100, 60, 0, 0, 80, 64, 0, 0, 0, 63, 100 };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }

        // Test generated by mutate4l from formula: [<c8>0] setlength 1/2
        [TestMethod]
        public void TestSetLength()
        {
            byte[] input = { 193, 0, 2, 1, 2, 7, 0, 0, 128, 64, 1, 7, 0, 60, 0, 0, 0, 0, 0, 0, 0, 63, 100, 61, 0, 0, 80, 64, 0, 0, 0, 63, 100, 64, 0, 0, 128, 62, 0, 0, 64, 63, 100, 64, 0, 0, 224, 63, 0, 0, 128, 62, 100, 65, 0, 0, 48, 64, 0, 0, 64, 63, 100, 67, 0, 0, 64, 63, 0, 0, 64, 63, 100, 67, 0, 0, 224, 63, 0, 0, 0, 63, 100, 91, 60, 99, 56, 62, 48, 93, 32, 115, 101, 116, 108, 101, 110, 103, 116, 104, 32, 49, 47, 50 };
            byte[] output = { 193, 0, 0, 0, 128, 64, 1, 7, 0, 60, 0, 0, 0, 0, 0, 0, 0, 64, 100, 64, 0, 0, 128, 62, 0, 0, 192, 63, 100, 67, 0, 0, 64, 63, 0, 0, 128, 63, 100, 64, 0, 0, 224, 63, 0, 0, 0, 64, 100, 67, 0, 0, 224, 63, 0, 0, 0, 64, 100, 65, 0, 0, 48, 64, 0, 0, 0, 64, 100, 61, 0, 0, 80, 64, 0, 0, 0, 64, 100 };

            TestUtilities.InputShouldProduceGivenOutput(input, output);
        }
    }
}