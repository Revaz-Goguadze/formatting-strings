using System.Globalization;

namespace FormattingStrings
{
    public static class NumbersToString
    {
        public static string NumberToString1(float number)
        {
            // TODO #2-1. Analyze the method unit tests and implement the method.
            return number.ToString("F4", CultureInfo.InvariantCulture);
        }

        public static string NumberToString2(double number)
        {
            // TODO #2-2. Analyze the method unit tests and implement the method.
            return number.ToString("F2", CultureInfo.InvariantCulture);
        }

        public static string NumberToString3(double number)
        {
            // TODO #2-3. Analyze the method unit tests and implement the method.
            return number.ToString("N4", CultureInfo.InvariantCulture);
        }

        public static string NumberToString4(decimal number)
        {
            // TODO #2-4. Analyze the method unit tests and implement the method.
            return number.ToString("N8", CultureInfo.InvariantCulture);
        }

        public static string NumberToString5(float number)
        {
            // TODO #2-5. Analyze the method unit tests and implement the method.
            return number.ToString("C1", CultureInfo.InvariantCulture);
        }

        public static string NumberToString6(decimal number)
        {
            // TODO #2-6. Analyze the method unit tests and implement the method.
            return number.ToString("C3", CultureInfo.InvariantCulture);
        }

        public static string NumberToString7(double number)
        {
            // TODO #2-7. Analyze the method unit tests and implement the method.
            return number.ToString("P", CultureInfo.InvariantCulture);

        }

        public static string NumberToString8(float number)
        {
            // TODO #2-8. Analyze the method unit tests and implement the method.
            return number.ToString("P5", CultureInfo.InvariantCulture);
        }

        public static string NumberToString9(float number)
        {
            // TODO #2-9. Analyze the method unit tests and implement the method.
            string result = number.ToString("G7", CultureInfo.InvariantCulture);
            return float.Parse(result, NumberStyles.Float, CultureInfo.InvariantCulture).ToString("G", CultureInfo.InvariantCulture);
        }


        public static string NumberToString10(double number)
        {
            // TODO #2-10. Analyze the method unit tests and implement the method.
            return number.ToString("G5", CultureInfo.InvariantCulture);
        }
    }
}
