using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeIntegerToEnglishWords
{
    public class Solution
    {
        public string NumberToWords(int num)
        {
            var sb = new StringBuilder();

            int billions = num / 1000000000;
            if (billions > 0)
                sb.Append(Create1(billions, "Billion "));

            int millions = (num % 1000000000) / 1000000;
            if (millions > 0)
                sb.Append(Create1(millions, "Million "));
            
            int thousands = (num % 1000000) / 1000;
            if (thousands > 0)
                sb.Append(Create1(thousands, "Thousand "));

            int n4 = (num % 1000);

            sb.Append(Create1(n4, string.Empty));

            return sb.ToString().Trim();
        }


        private string Create1(int num, string units)
        {
            if (num > 999) throw new ArgumentException(nameof(num));

            StringBuilder sb = new();

            if (num >= 900)
                sb.Append("Nine Hundred ");
            else if (num >= 800)
                sb.Append("Eight Hundred ");
            else if (num >= 700)
                sb.Append($"Seven Hundred ");
            else if (num >= 600)
                sb.Append($"Six Hundred ");
            else if (num >= 500)
                sb.Append($"Five Hundred ");
            else if (num >= 400)
                sb.Append($"Four Hundred ");
            else if (num >= 300)
                sb.Append($"Three Hundred ");
            else if (num >= 200)
                sb.Append($"Two Hundred ");
            else if (num >= 100)
                sb.Append($"One Hundred ");

            var tens = num % 100;
            if (tens >= 90)
            {
                sb.Append("Ninety ");
                sb.Append(CreateForUnits(tens % 10));
            }
            else if (tens >= 80)
            {
                sb.Append("Eighty ");
                sb.Append(CreateForUnits(tens % 10));
            }
            else if (tens >= 70)
            {
                sb.Append("Seventy ");
                sb.Append(CreateForUnits(tens % 10));
            }
            else if (tens >= 60)
            {
                sb.Append("Sixty ");
                sb.Append(CreateForUnits(tens % 10));
            }
            else if (tens >= 50)
            {
                sb.Append("Fifty ");
                sb.Append(CreateForUnits(tens % 10));
            }
            else if (tens >= 40)
            {
                sb.Append("Forty ");
                sb.Append(CreateForUnits(tens % 10));
            }
            else if (tens >= 30)
            {
                sb.Append("Thirty ");
                sb.Append(CreateForUnits(tens % 10));
            }
            else if (tens >= 20)
            {
                sb.Append("Twenty ");
                sb.Append(CreateForUnits(tens % 10));
            }
            else if (tens == 19)
                sb.Append("Nineteen ");
            else if (tens == 18)
                sb.Append("Eighteen ");
            else if (tens == 17)
                sb.Append("Seventeen ");
            else if (tens == 16)
                sb.Append("Sixteen ");
            else if (tens == 15)
                sb.Append("Fifteen ");
            else if (tens == 14)
                sb.Append("Fourteen ");
            else if (tens == 13)
                sb.Append("Thirteen ");
            else if (tens == 12)
                sb.Append("Twelve ");
            else if (tens == 11)
                sb.Append("Eleven ");
            else if (tens == 10)
                sb.Append("Ten ");
            else
                sb.Append(CreateForUnits(tens));

            sb.Append(units);
            
            return sb.ToString();
        }


        private string CreateForUnits(int num)
        {
            StringBuilder sb = new();
            if (num == 9)
                sb.Append("Nine ");
            else if (num == 8)
                sb.Append("Eight ");
            else if (num == 7)
                sb.Append("Seven ");
            else if (num == 6)
                sb.Append("Six ");
            else if (num == 5)
                sb.Append("Five ");
            else if (num == 4)
                sb.Append("Four ");
            else if (num == 3)
                sb.Append("Three ");
            else if (num == 2)
                sb.Append("Two ");
            else if (num == 1)
                sb.Append("One ");

            return sb.ToString();
        }




    }
}
