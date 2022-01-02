using System.Text;

namespace LeetcodeIntegerToEnglishWords
{
    public class Solution
    {
        private readonly string[] _units = {
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

            return sb.ToString().Trim();
        }


        private void Create1(StringBuilder sb, int num, string unitName)
        {
            if (num > 999) throw new ArgumentException(nameof(num));

            if (num >= 900)
                sb.Append("Nine Hundred ");
            else if (num >= 800)
                sb.Append("Eight Hundred ");
            else if (num >= 700)
                sb.Append("Seven Hundred ");
            else if (num >= 600)
                sb.Append("Six Hundred ");
            else if (num >= 500)
                sb.Append("Five Hundred ");
            else if (num >= 400)
                sb.Append("Four Hundred ");
            else if (num >= 300)
                sb.Append("Three Hundred ");
            else if (num >= 200)
                sb.Append("Two Hundred ");
            else if (num >= 100)
                sb.Append("One Hundred ");

            var tens = num % 100;
            if (tens >= 90)
            {
                sb.Append("Ninety ");
            }
            else if (tens >= 80)
            {
                sb.Append("Eighty ");
            }
            else if (tens >= 70)
            {
                sb.Append("Seventy ");
            }
            else if (tens >= 60)
            {
                sb.Append("Sixty ");
            }
            else if (tens >= 50)
            {
                sb.Append("Fifty ");
            }
            else if (tens >= 40)
            {
                sb.Append("Forty ");
            }
            else if (tens >= 30)
            {
                sb.Append("Thirty ");
            }
            else if (tens >= 20)
            {
                sb.Append("Twenty ");
            }
            else if (tens !=0)
                sb.Append(_units[tens] + " ");

            if (tens >= 20 && tens %10 !=0)
                sb.Append(_units[tens % 10] + " ");

            sb.Append(unitName);
        }

    }
}
