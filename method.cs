using System;

namespace fileManager
{
    public class method
    {
        public static bool ifContainsOutIndex(string[] arraySrc, string matching, out int index){
            bool yesOrNo = false;
            int check = 0;
            for(int i = 0; i < arraySrc.Length; i++){
                if (arraySrc[i] == matching)
                {
                    check++;
                    yesOrNo = true;
                }
            }
            if (check == 0)
            {
                yesOrNo = false;
                index = arraySrc.Length + 1;
            return yesOrNo;
            }
            else
            {
                index = Array.IndexOf(arraySrc, matching);
                return yesOrNo;
            }
        }
        public static bool doesStringContainChar(string text, char exclude){
            bool yesOrNo = false;
            char[] characters = text.ToCharArray();
            foreach (char character in characters)
            {
                if (character == exclude)
                {
                    yesOrNo = true;
                }
            }
            return yesOrNo;
        }
        public static string moreVersitileConcat(string firstText, string secondText){
            string.Concat(firstText, secondText);
            return firstText;
        }
        public static string moreThanOneConcat(string[] WhatToConcatNoteThatItWillConcatInOrderOfList){
            String value = "";
            for (int i = 0; i < WhatToConcatNoteThatItWillConcatInOrderOfList.Length; i++)
            {
                String.Concat(value, WhatToConcatNoteThatItWillConcatInOrderOfList[i]);
            }
            return value;
        }
    }
}