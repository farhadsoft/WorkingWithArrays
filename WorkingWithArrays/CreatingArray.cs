using System;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        public static int[] CreateEmptyArrayOfIntegers()
        {
            return Array.Empty<int>();
        }

        public static bool[] CreateEmptyArrayOfBooleans()
        {
            return Array.Empty<bool>();
        }

        public static string[] CreateEmptyArrayOfStrings()
        {
            return Array.Empty<string>();
        }

        public static char[] CreateEmptyArrayOfCharacters()
        {
            return Array.Empty<char>();
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            return Array.Empty<double>();
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            return Array.Empty<float>();
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            return Array.Empty<decimal>();
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            int[] result = new int[10];
            return result;
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            bool[] result = new bool[20];
            return result;
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            string[] result = new string[5];
            return result;
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            char[] result = new char[15];
            return result;
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            double[] result = new double[18];
            return result;
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            float[] result = new float[100];
            return result;
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            decimal[] result = new decimal[1000];
            return result;
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            int[] result = { 123456 };
            return result;
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            int[] result = { 1_111_111, 9_999_999 };
            return result;
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            int[] result = { 0, 4_234, 3_845, 2_942, 1_104, 9_794, 0_923_943, 7_537, 4_162, 10134 };
            return result;
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            bool[] result = { true };
            return result;
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            bool[] result = { true, false, true, false, true };
            return result;
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            bool[] result = { false, true, true, false, true, true, false };
            return result;
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            string[] result = { "one" };
            return result;
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            string[] result = { "one", "two", "three" };
            return result;
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            string[] result = { "one", "two", "three", "four", "five", "six" };
            return result;
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            char[] result = { 'a' };
            return result;
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            char[] result = { 'a', 'b', 'c' };
            return result;
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            char[] result = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };
            return result;
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            var result = new[] { 1.12 };
            return result;
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            var result = new[] { 1.12, 2.23, 3.34, 4.45, 5.56 };
            return result;
        }

        public static double[] CreateDoubleWithNineElements()
        {
            var result = new[] { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };
            return result;
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            var result = new[] { 123_456_789.123_456f };
            return result;
        }

        public static float[] CreateFloatWithThreeElements()
        {
            var result = new[] { 1_000_000.123_456f, 222_333_4444.123_456f, 9_999.999_999f };
            return result;
        }

        public static float[] CreateFloatWithFiveElements()
        {
            var result = new[] { 1.0123f, 20.012345f, 300.01234567f, 4_000.01234567f, 500_000.01234567f };
            return result;
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            var result = new[] { 10_000.123456m };
            return result;
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            var result = new[] { 1_000.1234m, 100_000.2345m, 100_000.3456m, 1_000_000.456789m, 10_000_000.5678901m };
            return result;
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
            var result = new[]
            {
                10.122112m, 200.233223m, 3_000.344334m, 40_000.455445m, 500_000.566556m,
                6_000_000.677667m, 70_000_000.788778m, 800_000_000.899889m, 9_000_000_000.911991m,
            };
            return result;
        }
    }
}
