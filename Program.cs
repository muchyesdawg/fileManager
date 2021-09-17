using System;
using System.IO;

namespace fileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            saveFile saveFile = new saveFile();
            while(true){
                Console.WriteLine("what do you want to do?");
                string action = Console.ReadLine();
                if (action.ToLower() == "exit")
                {
                    Environment.Exit(0);
                }
                else if (method1.ifContainsOutIndex(saveFile.listOfActions, action, out int index))
                {
                    actionDistributer.manageActions(index);
                }
                else if (action.ToLower() == "help")
                {
                    Console.WriteLine("you can do 3 things\nproject\nthis manages projects that are saved here\nconsole/terminal\nbasically the appearance of the terminal\ntodos\nmanages todos for your project");
                }
            }
        }
    }
}
