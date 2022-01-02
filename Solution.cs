using System.Text;

namespace LeetcodeIntegerToEnglishWords
{
    public class Solution
    {
        private static readonly string[] _units = {
            "Zero",
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Eleven",
            "Twelve",
            "Thirteen",
            "Fourteen",
            "Fifteen",
            "Sixteen",
            "Seventeen",
            "Eighteen",
            "Nineteen"
        };


        private static readonly string[] _tens =
        {
            "Twenty",
            "Thirty",
            "Forty",
            "Fifty",
            "Sixty",
            "Seventy",
            "Eighty",
            "Ninety"
        };




        public string NumberToWords(int num)
        {
            if (num == 0)
                return "Zero";

            var sb = new StringBuilder();

            int billions = num / 1000000000;
            if (billions > 0)
                Create1(sb,billions, "Billion ");

            int millions = (num % 1000000000) / 1000000;
            if (millions > 0)
                Create1(sb, millions, "Million ");
            
            int thousands = (num % 1000000) / 1000;
            if (thousands > 0)
                Create1(sb, thousands, "Thousand ");

            int n4 = (num % 1000);

            Create1(sb, n4, string.Empty);

            return sb.ToString().TrimEnd();
        }


        private void Create1(StringBuilder sb, int num, string unitName)
        {
            if (num >= 100) 
            {
                sb.Append(_units[num / 100]);
                sb.Append(" Hundred ");
            }

            var tens = num % 100;
            if (tens >= 20)
            {
                sb.Append(_tens[(tens / 10)-2] + " ");

                if (tens %10 !=0)
                    sb.Append(_units[tens % 10] + " ");
            }
            else if (tens !=0)
                sb.Append(_units[tens] + " ");

            sb.Append(unitName);
        }

    }
}
