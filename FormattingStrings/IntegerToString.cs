using System.Globalization;

[assembly: CLSCompliant(true)]

namespace FormattingStrings
{
    public static class IntegerToString
    {
        public static string LiteralToString1()
        {
            // TODO #1-1. Analyze the method unit tests and implement the method.
            return 1000m.ToString(CultureInfo.InvariantCulture);
        }

        public static string LiteralToString2()
        {
            // TODO #1-2. Analyze the method unit tests and implement the method.
            return 1234m.ToString(CultureInfo.InvariantCulture);
        }

        public static string LiteralToString3()
        {
            // TODO #1-3. Analyze the method unit tests and implement the method.
            return 100_000_000m.ToString(CultureInfo.InvariantCulture);
        }

        public static string LiteralToString4()
        {
            // TODO #1-4. Analyze the method unit tests and implement the method.
            return (-123_456_789m).ToString(CultureInfo.InvariantCulture);
        }

        public static string LiteralToString5()
        {
            // TODO #1-5. Analyze the method unit tests and implement the method.
            uint hexadecimalValue = 0xABCDEFAB;
            return hexadecimalValue.ToString("X");
        }

        public static string LiteralToString6()
        {
            // TODO #1-6. Analyze the method unit tests and implement the method.
            uint hexadecimalValue = 0xAFBACEDA;
            return hexadecimalValue.ToString("x"); // Use "x" format specifier for lowercase hexadecimal
        }

        public static string LiteralToString7()
        {
            // TODO #1-7. Analyze the method unit tests and implement the method.
            int hexadecimalValue = 0x000a;
            return hexadecimalValue.ToString("x4");
        }

        public static string LiteralToString8()
        {
            // TODO #1-8. Analyze the method unit tests and implement the method.
            int hexadecimalValue = 0x00000FED;
            return hexadecimalValue.ToString("X8");
        }

        public static string LiteralToString9()
        {
            // TODO #1-9. Analyze the method unit tests and implement the method.
            int hexadecimalValue = 0x0010;
            return hexadecimalValue.ToString("X4");
        }

        public static string LiteralToString10()
        {
            // TODO #1-10. Analyze the method unit tests and implement the method.
            int hexadecimalValue = 0x00004077;
            return hexadecimalValue.ToString("X8");
        }

        public static string LiteralToString11()
        {
            // TODO #1-11. Analyze the method unit tests and implement the method.
            int decimalValue = 1394;
            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.NumberFormat.CurrencySymbol = "¤";
            return decimalValue.ToString("C", culture);
        }

        public static string LiteralToString12()
        {
            // TODO #1-12. Analyze the method unit tests and implement the method.
            int decimalValue = 28549;
            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.NumberFormat.CurrencySymbol = "¤";
            return decimalValue.ToString("C6", culture);
        }
    }
}
