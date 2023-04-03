using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KMP_3_9A
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Pat = new char[30];
            int[] LPS = new int[30];
            string ulaz = Console.ReadLine();
            int n = ulaz.Length;
            Pat = ulaz.ToCharArray();
            int len = 0;
            LPS[0] = 0;
            int i = 1;
            while (i < n)
            {
                if (Pat[i] == Pat[len])
                {
                    // LPS[i++] = ++len;
                    len++;
                    LPS[i] = len;
                    i++;
                }
                else if (len > 0) len = LPS[len - 1];
                else
                {
                    LPS[i] = 0;
                    i++;
                }
            }
            for (int j = 0; j < n; j++) Console.Write(LPS[j]);
        }
    }
}
