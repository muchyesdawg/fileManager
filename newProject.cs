//ya thats right i write really messy code but as long as it makes sense to me then thats fine but hopefully this makes sense to yall
using System;
using System.IO;
namespace fileManager
{
    public class newProject
    {
        public static void createProject(){
            //variables and objects
            storage saveFile = new storage();
            string projPath = saveFile.projSaves;
            string name;
            string path;
            bool yesOrNo = true;
            bool isWorkingTogether = false;
            StreamWriter saveWriter = new StreamWriter("saves/action.txt");

            //asking for details about the project
            Console.WriteLine("What is the name? type help for help\nplease make sure the name doesn't have any spaces, or else it will crash\nthe reason is so that it can be more organized, one of the many skills i dont posses :D i guide others to a treasure i cannot posses\ntip\nyou can useThis instead of using_this to seperate spaces ;))))hard wink\nwow i dum hahahahhhehehehhehhehhhughhhhhomigoshplssendhelp\n\nwhy am i embarrasing myself in public");
            name = Console.ReadLine();
            if (name == "help")
            {
                //helping people wow but i still dont have friends thats sad :((((( at least this doesnt turn into emojs unlike some other software(looking at you, the programs and other operating information used by a computer about disagreement between people that recently got purchased by the people that made this code *hint hint my dearest reader;)*)
                Console.WriteLine("this a thing that asks for a name. It names the project. honestly there isnt much to talk about the name thing\n though you can look at the code and see what it does if you understand csharp\nalright anyways what is the name then?");
                name = Console.ReadLine();
            }
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
                    isWorkingTogether = true;
                    //still gotta work on google sheets api and website on how to work on it cuz boi is this gonna be hard
                }
                else if(keyPress == "n")
                {
                    yesOrNo = !yesOrNo;
                    isWorkingTogether = false;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("what do you mean?");
                }
            }
            
            

            string.Concat(projPath, name);
            Directory.CreateDirectory(projPath);//projectpath/name

            //variables pt.2
            string[] wowDummyStringList1 = new string[]{
                projPath,
                "/",
                name,
                "Properties.txt"
            };
            string nameTxt = method.moreThanOneConcat(wowDummyStringList1);
            StreamWriter streamingLezGoButAmITheOnlyOneWonderingHowStreamingAndScreamingAreSimilarInSoManyWaysItsNotEvenFunny = new StreamWriter(nameTxt);
            string.Concat(projPath,"/");//projectpath/name/
            string todoFile = method.moreVersitileConcat(projPath, "todo.txt");

            //this was after i finished with the method so dont question it also feel free to use the methods in method file, such as, putting it in ur library just saying ;))
            nameTxt = method.moreVersitileConcat(projPath, nameTxt);

            File.Create(nameTxt);
            streamingLezGoButAmITheOnlyOneWonderingHowStreamingAndScreamingAreSimilarInSoManyWaysItsNotEvenFunny.WriteLine(path);
            streamingLezGoButAmITheOnlyOneWonderingHowStreamingAndScreamingAreSimilarInSoManyWaysItsNotEvenFunny.WriteLine(isWorkingTogether);
            streamingLezGoButAmITheOnlyOneWonderingHowStreamingAndScreamingAreSimilarInSoManyWaysItsNotEvenFunny.Close();//always gotta close or else crash wow sad
            
            File.Create(todoFile);//if i forget to give the argument to this variable the error is so long the screen can't even show it wow but thats just encouraging me to make it as long as that
            /*also you might be wondering 
                heyy KID, why u makin variables so long
                because for the most part i know i wont use it much so i try to make it as ridiculous as possible bcuz H U M O R
            */
        }
    }
}
//a written or verbal request inviting someone to go somewhere or to do something.
//v8d9tccumf o wait
