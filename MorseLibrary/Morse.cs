using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace MorseLibrary
{
    public class Morse
    {
        public static Dictionary<char, string> MorseAlphabeth;
        
        public static string Converter(string parameter)
        {
            AlphabethToMorse();
            return Translate(parameter);
        }
        public static string Translate(string parameter)
        {
            if (inputValidation(parameter)) {return parameter;}
            StringBuilder translate = new StringBuilder();
            foreach (char character in parameter.ToLower())
            {
                if (MorseAlphabeth.ContainsKey(character))
                { translate.Append(MorseAlphabeth[character] + "|"); }
                else if (character == ' ')
                { translate.Append("#"); }
                else
                { translate.Append(character + ""); }
            }
            return translate.ToString();
        }
        public static bool inputValidation(string parameter)
        {
            if (parameter is null)
            { 
                 throw new ArgumentNullException();
            }
            else if (parameter.Length == 0) return true;
            else return false;
        }
        private static void AlphabethToMorse()
        {
            MorseAlphabeth = new Dictionary<char, string>()
            {
                {'a', ".-"}, {'b', "-..."},
                {'c', "-.-."}, {'d', "-.."},
                {'e', "."}, {'f', "..-."},
                {'g', "--."}, {'h', "...."},
                {'i', ".."}, {'j', ".---"},
                {'k', "-.-"}, {'l', ".-.."},
                {'m', "--"}, {'n', "-."},
                {'o', "---"}, {'p', ".--."},
                {'q', "--.-"}, {'r', ".-."},
                {'s', "..."}, {'t', "-"},
                {'u', "..-"}, {'v', "...-"},
                {'w', ".--"}, {'x', "-..-"},
                {'y', "-.--"}, {'z', "--.."},
                {'0', "-----"}, {'1', ".----"},
                {'2', "..---"}, {'3', "...--"},
                {'4', "....-"}, {'5', "....."},
                {'6', "-...."}, {'7', "--..."},
                {'8', "---.."}, {'9', "----."}
            };
            
           

        }
    }
}