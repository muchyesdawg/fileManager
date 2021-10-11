using System;
using System.IO;

namespace fileManager
{
    public class deleteclass
    {
        public static void DeletingClass(){
            //projectsaves/ has 13 characters
            storage storage = new storage();
            //TODO: make deleting thing wow
            Console.Clear();
            Console.WriteLine("what is the project you want to delete?\n(you can either press the number corrisponding to the project you want to delete,\n press n or p for the next or previous page, \nand s for searchin. pls note that the search engine is really bad.:/)");
            var projectNoPth = new string[storage.projectNames.Length];
            //variables
            bool yesOrNo = true;
            String[] selections = new String[10];
            int howManySelections = storage.projectNames.Length;
            int currentPage = 0;
            int maxPages;
            string keyStroke;
            int tempInt;
            int howManyExtras = howManySelections%10;
            tempInt = howManySelections-howManyExtras;
            maxPages = tempInt/10;
            for(int i = 0; i<storage.projectNames.Length;i++){
                selections[i] = storage
            }

            while (yesOrNo)
            {

                Console.WriteLine("you have these projects:");
                for (int i = 0; i < 10; i++)
                {
                    selections[i] = storage.projectNames[i + currentPage * 10];
                    Console.WriteLine("{0})  " + selections[1], i);
                }
                Console.WriteLine("<=p         n=>");
                keyStroke = Console.ReadKey().ToString();
                if (int.TryParse(keyStroke, out int yes))
                {
                    //TODO:delete and ask if they want to do another one.

                }
                else if(keyStroke == "p"&& currentPage > 0){
                    currentPage--;
                }
                else if (keyStroke == "n"&& currentPage < maxPages)
                {
                    currentPage++;
                }
                else if(keyStroke == "s")
                {
                    string[] suggestions = method.findSimilar(Console.ReadLine(), );
                    Console.WriteLine("is it");
                    for(int i = 1; i < suggestions.Length; i++){
                        Console.WriteLine("{0})  {1}", i, suggestions[i-1]);
                    }
                    Console.WriteLine("press the corrisponding number to select it. Or you can press ")
                }
                else{

                }
            }
        }
    }
}
