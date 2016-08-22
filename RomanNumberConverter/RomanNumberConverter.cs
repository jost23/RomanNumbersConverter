using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberConverter {

    public class RomanNumberConverter {

        private static string[] RomanChars = new string[] { "I", "V", "X", "L", "C", "D", "M" };

        public static string ConvertToRoman(string number) {
            try {
                int intNo = int.Parse(number);

                if(intNo < 1) {
                    throw new Exception("Negative integer.");
                }
            } catch (Exception) {
                throw new ArithmeticException("Number: " + number + " is not valid number. Valid numbers are only positive integers.");
            }

            string enice = "", desetice = "", stotice = "", tisocice = "", tmpInteger;
            int numberLength = number.Length;

            // pos:0 = 0-9
            tmpInteger = number.Substring(numberLength - 1);
            enice = ConvertIntToRoman(int.Parse(tmpInteger), 0);

            // pos:1 = 10-99
            if (numberLength > 1) {
                tmpInteger = number.Substring(numberLength - 2, 1);
                desetice = ConvertIntToRoman(int.Parse(tmpInteger), 1);
            }

            // pos:2 = 100-999
            if (numberLength > 2) {
                tmpInteger = number.Substring(numberLength - 3, 1);
                stotice = ConvertIntToRoman(int.Parse(tmpInteger), 2);
            }

            // pos:3 = > 1000
            if (numberLength > 3) {
                tmpInteger = number.Substring(numberLength - 4, 1);
                tisocice = ConvertIntToRoman(int.Parse(tmpInteger), 3);
            }

            return tisocice + stotice + desetice + enice;
        }

        private static string ConvertIntToRoman(int number, int indexPosition) {
            StringBuilder sb = new StringBuilder();

            // tisocice
            if (indexPosition > 2) {
                for (int i = 0; i < number; i++) {
                    sb.Append(RomanChars[6]);
                }
            } else {
                int k = 0;  // offset in RomanChars. k => 1, k+1 => 5, k+2 => 10
                if (indexPosition == 0) {   // enice
                    k = 0;
                } else if (indexPosition == 1) {    // desetice
                    k = 2;
                } else {
                    k = 4;  // stotice
                }

                if (number == 4) {
                    sb.Append(RomanChars[k]);
                    sb.Append(RomanChars[k + 1]);
                } else if (number == 5) {
                    sb.Append(RomanChars[k + 1]);
                } else if (number == 9) {
                    sb.Append(RomanChars[k]);
                    sb.Append(RomanChars[k + 2]);
                } else if (number < 4) {
                    for (int i = 0; i < number; i++) {
                        sb.Append(RomanChars[k]);
                    }
                } else {
                    sb.Append(RomanChars[k + 1]);
                    for (int i = 0; i < number; i++) {
                        sb.Append(RomanChars[k]);
                    }
                }

            }
            return sb.ToString();
        }
    }
}
