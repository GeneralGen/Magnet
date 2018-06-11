using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Magnet
{
    public class MyRegex
    {
        public static string Span(string input)
        {
            string[] Lines = input.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> list = new List<string>();

            foreach (var item in Lines)
            {
                Regex reg = new Regex(@"(?<=\<span\>).*?(?=\<\/span\>)");

                var result = reg.Match(item).ToString();

                if (result != string.Empty)
                {
                    list.Add(result);
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (var item in list)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }
    }
}
