using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string keyFile = @"C:\Users\morya\Downloads\Batfile_Tool\key_value.txt";
        string inputFile = @"C:\Users\morya\Downloads\Batfile_Tool\input.txt";
        string outputFile = @"C:\Users\morya\Downloads\Batfile_Tool\output.txt";

        var map = new Dictionary<string, string>();
        foreach (var line in File.ReadAllLines(keyFile))
        {
            if (line.Contains(":"))
            {
                var parts = line.Split(new[] { ':' }, 2);
                string key = parts[0].Trim();
                string value = parts[1].Trim();
                map[key] = value;
            }
        }

        string text = File.ReadAllText(inputFile);

        text = Regex.Replace(text, @"<([^>]+)>", match =>
        {
            string key = match.Groups[1].Value;
            if (map.ContainsKey(key))
                return map[key];
            else
                return match.Value;
        });

        File.WriteAllText(outputFile, text);

        Console.WriteLine("Done! Output saved at: " + outputFile);
    }
}
