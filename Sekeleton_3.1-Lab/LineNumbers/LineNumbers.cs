﻿namespace LineNumbers
{
    using System;
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using(StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string line = reader.ReadLine();
                    int row = 0;

                    while (line != null)
                    {
                        writer.WriteLine($"{++row}.{line}");
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
