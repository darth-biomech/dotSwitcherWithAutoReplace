using System;
using System.Text.RegularExpressions;

namespace dotSwitcher.Data
{
    public struct ReplacementEntry
    {
        public string source;
        public string target;
        public bool ignoreCase;

        public ReplacementEntry(string source="", string target="", bool ignoreCase=false)
        {
            this.source = source;
            this.target = target;
            this.ignoreCase = ignoreCase;
        }

        public string Replace(string text)
        {
            if (String.IsNullOrEmpty(text) || text.Length < source.Length)
            { return text; }

            int length = text.Length - source.Length+2;
            string splitStart = text.Substring(0,length);
            string replacedPart = text.Substring(length);
            if (ignoreCase)
            {
                return splitStart+(replacedPart.ToLower().Replace(source.ToLower(), target));
            }
            return splitStart+ (replacedPart.Replace(source, target));
        }
        public string Serialize()
        {
            return "\""+source + "\"\t\"" + target + "\"\t" + (ignoreCase ? "true" : "false");
        }
        public static ReplacementEntry Deserialize(string src)
        {
            string[] parts = src.Split('\t');
            if (parts.Length < 3)
            {
                return new ReplacementEntry();
            }
            
            string source = "";
            string replace = "";
            
            if(parts[0].Length > 2)
                source = parts[0].Substring(1, parts[0].Length - 2);
            if(parts[1].Length > 2)
                replace = parts[1].Substring(1, parts[1].Length - 2);
            
            return new ReplacementEntry(source, replace, parts[2].Trim() == "true");
        }

        public bool IsIncomplete()
        {
            bool sourceIsEmpty = String.IsNullOrEmpty(source) || source == " ";
            bool targetIsEmpty = String.IsNullOrEmpty(target)|| target == " ";
            return sourceIsEmpty || targetIsEmpty;
        }

        public bool Matches(string lastWord)
        {
            if(ignoreCase) 
                return lastWord.ToLower().Contains(source.ToLower());
            return lastWord.Contains(source);
        }
    }
}