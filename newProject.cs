using System;
using System.IO;
namespace fileManager
{
    public class newProject
    {
        public static void createProject(){
            //variables and objects
            saveFile saveFile = new saveFile();
            string projPath = saveFile.projSaves;
            string name;
            string path;
            bool yesOrNo = true;
            string dummyString;
            StreamWriter saveWriter = new StreamWriter("saves/action.txt");

            //asking for details about the project
            Console.WriteLine("What is the name? type help for help\nlease make sure the name doesn't have any spaces, or else it will crash\nthe reason is so that it can be more organized, one of the many skills i dont posses :D i guide others to a treasure i cannot posses\ntip\nyou can useThis instead of using_this to seperate spaces ;))))hard wink\nwow i dum hahahahhhehehehhehhehhhughhhhhomigoshplssendhelp\n\nwhy am i embarrasing myself in public");
            dummyString = Console.ReadLine();
            while (yesOrNo)
            {
                
                if (dummyString == "help")
                {
                    //helping people wow but i still dont have friends thats sad :((((( at least this doesnt turn into emojs unlike some other software(looking at you, disagreement between people*hint hint my dearest reader;)*)
                }
                else if (method.doesStringContainChar(dummyString, ' '))
                {
                    name = dummyString;
                }
                else
                {
                    Console.WriteLine("im sorry, but this has spaces, so no");
                }
            }
            yesOrNo = false;
            Console.Clear();
            Console.WriteLine("what is the path? also make sure there aren't any spaces");
            path = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("will you be working with sombody?");
            while(!yesOrNo){
                string keyPress = Console.ReadKey().ToString();
                if(keyPress == "y"){
                    Console.WriteLine("then, you would need to follow something cuz wow.");
                    yesOrNo = !yesOrNo;
                }
                else if(keyPress == "n")
                {
                    yesOrNo = !yesOrNo;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("what do you mean?");
                }
            }
            //variables pt.2
            string nameTxt = name;
            string.Concat(nameTxt, ".txt");


            string.Concat(projPath, name);
            Directory.CreateDirectory(projPath);
            string.Concat(projPath, );
            File.Create();
        }
    }
}
//a written or verbal request inviting someone to go somewhere or to do something.
//v8d9tccumf o wait
