using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Linq;

namespace fileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Disclaimer: this is not a hack. I will not use any of the data that you have provided(say, your google account information) for any other purpose other than accessing the google sheets you have provided\n you can check my code if you dont trust it. it is completely fine if you don't trust me, but just note that I won't \nuse your information(i dont and wont)");
            Console.WriteLine("also i dont recieve your information.");
            deleteclass.DeletingClass();
            while (true){
                var saveFile = new storage();
                Console.WriteLine("what do you want to do? also for everything except for names do not use capital spaces");
                string action = Console.ReadLine();
                if (method.ifContainsOutIndex(saveFile.actionInfo, action, out int index))
                {
                    
                    if (index == 3)
                    {
                        for (int i = 0; i < saveFile.actionInfo.Length; i++)
                        {
                            Console.WriteLine(saveFile.actionInfo[i]);
                            Console.WriteLine(saveFile.help[i]);
                        }
                    }
                    else if(index == 0){
                        newProject.createProject();
                    }
                    else if(index == 1)
                    {
                        deleteclass.DeletingClass();
                    }
                    else if(index == 6){
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
