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
        // TODO:make a custom string.remove thing
        public static string removeString(string whatToRemove, int setting, int firstRemoveInt, int secondRemoveInt,  string firstRemoveString, string secondRemoveString){
            char[] characters = whatToRemove.ToCharArray();
            string bruh = "";
            if(setting == 0){
                for (int i = 0; i < firstRemoveInt; i++)
                {
                    string.Concat()
                }
            }
            else if (setting == 1)
            {
                //starts from where, how many characters to remove
                if (true)
                {
                    
                }
            }
            else if (setting == 2)
            {
                //starts from what index ends in what index
                
            }
            else if(setting == 3){
                
            }
            else if(setting == 4){
                
            }else{
                return "no the setting is not defined wow";
            }
            return bruh;
        }
        public static string[] findSimilar(string TargetedSimilarIGuess, string[] WhereToFindFrom){
            //variable
            string target = TargetedSimilarIGuess;
            int[] similarity = new int[WhereToFindFrom.Length];
            string[] database = WhereToFindFrom;
            int[] copySimilarity = similarity;
            bool yesOrNo = false;
            int howManySim = 0;

            for (int i = 0; i < database.Length; i++) {//the list
                //character arraies
                char[] character = database[i].ToCharArray();
                char[] targetCharacter = TargetedSimilarIGuess.ToCharArray();
                similarity[i] = 0;
                //compare
                for (int di = 0; di<character.Length; di++) {//the character
                    if (character[di] == targetCharacter[di]) {
                        similarity[i]++;
                    }
                }
            }
            copySimilarity = similarity;
            Array.Sort(copySimilarity);
            Array.Reverse(copySimilarity);
            if (copySimilarity[0] > database[Array.IndexOf(similarity, copySimilarity[0])].Length/2-1) {


                for (int i = 1; yesOrNo; i++) {
                    if (copySimilarity[i] == copySimilarity[i-1]) {
                        howManySim++;
                    }
                    else
                    {
                        yesOrNo = false;
                    }
                }
                string[] value = new string[howManySim];
                for (int i = 0; i < howManySim; i++)
                {
                    value[i] = database[Array.IndexOf(similarity,copySimilarity[i])];
                }
                return value;

            }
            else {
                string[] Value = new string[]{
                    ""
                };
                return Value;
            }
        }
        public static bool ifArrayContains(String[] database, string whatToFind){
            var yesOrNo = false;
            foreach (string item in database)
            {
                if (item == whatToFind)
                {
                    yesOrNo = true;
                }
            }
            return yesOrNo;
        }
    }
}