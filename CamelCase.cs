using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    public static string camelCase(string input)
    {
        string sample = input;
        string result = "";
        string UpperCase;


        string ifCorS = sample.Substring(0, 1); //C or s
        string ifMCV = sample.Substring(2, 1);  //M or C or V


        if (ifCorS == "C")
        {
            List<string> splitedSample = sample.Remove(0, 4).Split(' ').ToList().Select(arrTemp => Convert.ToString(arrTemp)).ToList();
            if (ifMCV == "V")
            {
                for (int i = 0; i < splitedSample.Count; i++)
                {
                    if (i < 1)
                    {
                        result = result + splitedSample[i];
                    }
                    else
                    {
                        UpperCase = splitedSample[i];
                        UpperCase = char.ToUpper(UpperCase[0]) + UpperCase.Substring(1);
                        result = result + UpperCase;
                    }
                }

            }
            else
                if (ifMCV == "M")
            {
                for (int i = 0; i < splitedSample.Count; i++)
                {
                    if (i < 1)
                    {
                        result = result + splitedSample[i];
                    }
                    else
                    {
                        UpperCase = splitedSample[i];
                        UpperCase = char.ToUpper(UpperCase[0]) + UpperCase.Substring(1);
                        result = result + UpperCase;
                    }
                }
                result = result + "()";
            }
            else
                if (ifMCV == "C")
            {
                for (int i = 0; i < splitedSample.Count; i++)
                {
                    UpperCase = splitedSample[i];
                    UpperCase = char.ToUpper(UpperCase[0]) + UpperCase.Substring(1);
                    result = result + UpperCase;

                }
            }
        }
        else
        if (ifCorS == "S")
        {
            string combinedStr = sample.Substring(4);
            List<string> splitedStr = new List<string>();
            bool isUpper;
            int from = 0, to = 0;
            bool whileFlag = true;
            if (ifMCV == "V")
            {
                while (whileFlag)
                {
                    for (int i = to; i < combinedStr.Length; i++)
                    {
                        isUpper = Char.IsUpper(combinedStr[i]);
                        if (isUpper)
                        {
                            to = i;
                            break;
                        }
                        if (i == combinedStr.Length - 1)
                        {
                            to = i + 1;
                            whileFlag = false;
                        }
                    }
                    string strToAdd = combinedStr.Substring(from, to - from);
                    splitedStr.Add(char.ToLower(strToAdd[0]) + strToAdd.Substring(1));
                    from = to;
                    to++;
                }
                foreach (var x in splitedStr)
                {
                    result = result + " " + x;
                }
                result = result.TrimStart();

            }
            else
                if (ifMCV == "M")
            {
                combinedStr = combinedStr.Substring(0, combinedStr.Length - 2);
                while (whileFlag)
                {
                    for (int i = to; i < combinedStr.Length; i++)
                    {
                        isUpper = Char.IsUpper(combinedStr[i]);
                        if (isUpper)
                        {
                            to = i;
                            break;
                        }
                        if (i == combinedStr.Length - 1)
                        {
                            to = i + 1;
                            whileFlag = false;
                        }
                    }
                    string strToAdd = combinedStr.Substring(from, to - from);
                    splitedStr.Add(char.ToLower(strToAdd[0]) + strToAdd.Substring(1));
                    from = to;
                    to++;
                }
                foreach (var x in splitedStr)
                {
                    result = result + " " + x;
                }
                result = result.TrimStart();

            }
            else
                if (ifMCV == "C")
            {
                while (whileFlag)
                {
                    for (int i = to + 1; i < combinedStr.Length; i++)
                    {
                        isUpper = Char.IsUpper(combinedStr[i]);
                        if (isUpper)
                        {
                            to = i;
                            break;
                        }
                        if (i == combinedStr.Length - 1)
                        {
                            to = i + 1;
                            whileFlag = false;
                        }
                    }
                    string strToAdd = combinedStr.Substring(from, to - from);
                    splitedStr.Add(char.ToLower(strToAdd[0]) + strToAdd.Substring(1));
                    from = to;
                    to++;
                }
                foreach (var x in splitedStr)
                {
                    result = result + " " + x;
                }
                result = result.TrimStart();
            }
        }
        return result;
    }
}
