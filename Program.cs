using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace algconsole
{
    class Program
    {

        public static string Solution(string s, long numRows)
        {
            List<StringBuilder> res = new List<StringBuilder>();
            for (int i = 0; i < numRows; i++)
            {
                res.Add(new StringBuilder());
            }

            int step = 1;
            int si = 0;
            int row = 0;
            while (si < s.Length)
            {

                res[row].Append(s[si]);
                if (row == 0)
                {
                    step = 1;
                }
                else
                {
                    if (row == numRows - 1)
                    {
                        step = -1;
                    }
                }
                row += step;
                si++;
            }
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < numRows; i++)
            {
                result.Append(res[i].ToString());
            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            string s = "EXAMPLESTRING";
            var sol = Solution(s, 3);
            System.Console.WriteLine(sol);
        }
    }
}