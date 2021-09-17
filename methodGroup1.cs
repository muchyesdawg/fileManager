using System;

namespace fileManager{
    public class method1{
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
        public static void open(){
            Console.WriteLine("What is the path? or is it from a folder?");
            string action = Console.ReadLine();

        }
    }
}