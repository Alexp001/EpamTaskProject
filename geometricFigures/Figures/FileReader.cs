using System;
using System.IO;

namespace Figures
{
    static class FileReader
    {
        public static String[] ReadingByFile()
        {
            int number = File.ReadAllLines("Point.txt").Length;
            String[] SetPoints = new String[number];
            using (StreamReader sr = new StreamReader("Point.txt", System.Text.Encoding.Default))
            {
                int i = 0;
                while (i < number)
                {
                    SetPoints[i] = sr.ReadLine();
                    i++;  
                }
                return SetPoints;
            }
        }
    }
}