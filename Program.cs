using System;

namespace fileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true){
                saveFile saveFile = new saveFile();
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
                        
                    }
                }
            }
        }
    }
}
