using System;
using System.Text;

namespace Tokenzi.Logic
{
    /// <summary>
    /// String Tokenzi Logic Class Implemtation
    /// </summary>
    public class StringTokenziLogic
    {
        #region Public Method For App
        /// <summary>
        /// Implementation Logic to String Tokenzi
        /// </summary>
        /// <param name="inputString">inputString as String Value</param>
        public void StrTokenzi(string inputString)
        {
            string[] splitString = inputString.Split(' ');
            string margeString = string.Empty;
            int IsPrint = 0;
            bool IsSecond = false;
            for (int i = 0; i < splitString.Length; i++)
            {
                if (splitString[i].Contains("'") || IsPrint > 0)
                {
                    margeString = margeString + splitString[i] + " ";
                    IsPrint++;
                    if (IsPrint > 1 && splitString[i].Contains("'"))
                        IsSecond = true;
                }
                if (IsPrint > 0 && IsSecond == true)
                {
                    Console.WriteLine(margeString.Trim());
                    margeString = "";
                    IsPrint = 0;
                    IsSecond = false;
                }
                else if (IsPrint == 0)
                    Console.WriteLine(splitString[i]);

            }
            Console.ReadLine();
        }
        #endregion Public Method For TestCase

        #region Public Method For App
        /// <summary>
        /// Implementation Logic to String Tokenzi
        /// </summary>
        /// <param name="inputString">inputString as String Value</param>
        public StringBuilder TestCaseStrTokenzi(string inputString)
        {
            var outPutString = new StringBuilder();
            string[] splitString = inputString.Split(' ');
            string margeString = string.Empty;
            int IsPrint = 0;
            bool IsSecond = false;
            for (int i = 0; i < splitString.Length; i++)
            {
                if (splitString[i].Contains("'") || IsPrint > 0)
                {
                    margeString = margeString + splitString[i] + " ";
                    IsPrint++;
                    if (IsPrint > 1 && splitString[i].Contains("'"))
                        IsSecond = true;
                }
                if (IsPrint > 0 && IsSecond == true)
                {
                    outPutString.Append(margeString.Trim());
                    margeString = "";
                    IsPrint = 0;
                    IsSecond = false;
                }
                else if (IsPrint == 0)
                    outPutString.Append(splitString[i]);

            }
            return outPutString;
        }
        #endregion Public Method For TestCase
    }
}
