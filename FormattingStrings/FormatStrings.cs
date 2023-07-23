using System.Globalization;

namespace FormattingStrings
{
    public static class FormatStrings
    {
        public static string Format1(int number1, int number2, float number3, double number4)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "{0} {2} {1} {3}", number1, number2, number3, number4);
        }

        public static string Format2(string str1, double number1, string str2, float number2, int number3)
        {
            // TODO #3-2. Analyze the method unit tests and implement the method.
            return $"{str2} {number2} {number1} {number3} {str1}";
        }


        public static string Format3(string str1, float number1, double number2, int number3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "{3}, {0}, {1:P0}, {2:C2}", str1, number1, number2, number3);
        }

        public static string Format4(int number1, int number2, long number3, string str1, string str2)
        {
            // TODO #3-4. Analyze the method unit tests and implement the method.
            throw new NotImplementedException();
        }

        public static string Format5(string str1, double number1, int number2, int number3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "{{ \"id\": {3:D}, \"name\": \"{0}\", \"deposit\": {1:F}, \"days\": {2:D3} }}", str1, number1, number2, number3);
        }

        public static string Format6(int number1, double number2, string str1, string str2, string str3)
        {
            // TODO #3-6. Analyze the method unit tests and implement the method.
            throw new NotImplementedException();
        }

        public static string Format7(string str1, string str2, float number1, float number2, int number3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "|{4,6}|{0,9}|{2,8}|{1,9}|{3,6}|", str1, str2, number1, number2, number3);
        }

        public static string Format8(string str1, string str2, string str3, double number1, double number2, double number3)
        {
            // TODO #3-8. Analyze the method unit tests and implement the method.
            throw new NotImplementedException();
        }

        public static string Format9(string str1, string str2, float number1, float number2, float number3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "| {4,10:P} | {0,-12} | {1,-14} | {3,12:C2} | {2,-20:N4} |", str1, str2, number1, number2, number3);
        }

        public static string Format10(decimal number1, decimal number2, double number3, string str1, string str2, string str3)
        {
            // TODO #3-10. Analyze the method unit tests and implement the method.
            throw new NotImplementedException();
        }
    }
}
