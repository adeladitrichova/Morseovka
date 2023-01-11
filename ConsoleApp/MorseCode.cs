using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class MorseCode
    {


        private readonly Dictionary<string, string> _encodeDictionary = new Dictionary<string, string>
        {
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            { "CH", "----" }
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            { "=", "-...-" },
            { "+", ".-.-." },
            { "-", "-....-" },
            { ".", ".-.-.-" },
            { ",", "--..--" },
            { "?", "..--.." },
            { "!", "-.-.--" },
            { "/", "-..-." },
            { "(", "-.--." },
            { ")", "-.--.-" },
            { "&", ".-..." },
            { ":", "---..." },
            { ";", "-.-.-." },
            { "_", "..--.-" },
            { @"\", ".-..-." },
            { "$", "...-..-" },
            { "@", ".--.-." },
            { " ", " " },
        };

        public string Decode(string code)
        {
            string[] words = code.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            foreach (string word in words)
            {
                if (_encodeDictionary.ContainsValue(word))
                {
                    sb.Append(_encodeDictionary.FirstOrDefault(x => x.Value == word).Key);
                }
            }
            return sb.ToString();
        }

        public string Encode(string text)
        {
            text = text.ToUpper();
            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                if (_encodeDictionary.ContainsKey(c.ToString()))
                {
                    sb.Append(_encodeDictionary[c.ToString()] + "/");
                }
            }
            return sb.ToString().Trim();
        }
    }
}