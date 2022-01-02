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

            int millions = num / 1000000;
            if (millions > 0)
                sb.Append(Create(millions, "million "));
            
            int thousands = (num % 1000000) / 1000;
            if (thousands > 0)
                sb.Append(Create(thousands, "thousand "));

            int n4 = (num % 1000);

            sb.Append(Create(n4, string.Empty));

            return sb.ToString();
        }


        private string Create(int num, string units)
        {
            if (num > 999) throw new ArgumentException(nameof(num));

            StringBuilder sb = new();

            if (num >= 900)
                sb.Append("Nine hundred ");
            else if (num >= 800)
                sb.Append("Eight hundred ");
            else if (num >= 700)
                sb.Append($"Seven hundred ");
            else if (num >= 600)
                sb.Append($"Six hundred ");
            else if (num >= 500)
                sb.Append($"Five hundred ");
            else if (num >= 400)
                sb.Append($"Four hundred ");
            else if (num >= 300)
                sb.Append($"Three hundred ");
            else if (num >= 200)
                sb.Append($"Two hundred ");
            else if (num >= 100)
                sb.Append($"One hundred ");

            var tens = num % 100;
            if (tens>= 90)
                sb.Append("Ninety ");
            else if (tens >= 80)
                sb.Append("Eighty ");
            else if (tens >= 70)
                sb.Append("Seventy ");
            else if (tens >= 60)
                sb.Append("Sixty ");
            else if (tens >= 50)
                sb.Append("Fifty ");
            else if (tens >= 40)
                sb.Append("Forty ");
            else if (tens >= 30)
                sb.Append("Thirty ");
            else if (tens >= 20)
                sb.Append("Twenty ");


            var lessThan20 = num % 20;

            if (lessThan20 == 19)
                sb.Append("Nineteen ");
            else if (lessThan20 == 18)
                sb.Append("Eighteen ");
            else if (lessThan20 == 17)
                sb.Append("Seventeen ");
            else if (lessThan20 == 16)
                sb.Append("Sixteen ");
            else if (lessThan20 == 15)
                sb.Append("Fifteen ");
            else if (lessThan20 == 14)
                sb.Append("Fourteen ");
            else if (lessThan20 == 13)
                sb.Append("Thirteen ");
            else if (lessThan20 == 12)
                sb.Append("Twelve ");
            else if (lessThan20 == 11)
                sb.Append("Twelve ");
            else if (lessThan20 == 10)
                sb.Append("Ten ");
            else if (lessThan20 == 9)
                sb.Append("Nine ");
            else if (lessThan20 == 8)
                sb.Append("Eight ");
            else if (lessThan20 == 7)
                sb.Append("Seven ");
            else if (lessThan20 == 6)
                sb.Append("Six ");
            else if (lessThan20 == 5)
                sb.Append("Five ");
            else if (lessThan20 == 4)
                sb.Append("Four ");
            else if (lessThan20 == 3)
                sb.Append("Three ");
            else if (lessThan20 == 2)
                sb.Append("Two ");
            else if (lessThan20 == 1)
                sb.Append("One ");

            sb.Append(units);
            
            return sb.ToString();
        }




    }
}
