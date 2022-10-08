using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchForDataChall
{
    public class SearchForDataProcessor
    {
        public List<string> SearchForPhoneNumbers(string path)
        {
            List<string> output = new();
            List<string> textFileLines = ReadTextFromFile(path);

            Regex rx = new Regex(@" \(([0-9]{3})\) ([0-9]{3})-([0-9]{4}) ");
            MatchCollection matches;

            foreach (string line in textFileLines)
            {
                matches = rx.Matches(line);
                foreach (Match match in matches)
                {
                    if (string.IsNullOrWhiteSpace(match.Groups[0].Value) == false)
                    {
                        output.Add(match.Groups[0].Value.Trim());
                    }
                }

            }

            return output;


        }
        public List<string> SearchForText(string key, string path)
        {
            List<string> output = new();
            List<string> textFileLines = ReadTextFromFile(path);

            foreach (string line in textFileLines)
            {
                if (line.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    output.Add(line);
                }
            }

            return output;

        }

        private List<string> ReadTextFromFile(string textPath)
        {
            List<string> output = new();

            output = File.ReadAllLines(textPath).ToList();

            return output;
        }
    }
}
