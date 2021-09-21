using System;
using System.IO;
namespace fileManager
{
    public class saveFile {
        public string projSaves = "projectSaves/";

        public string[] saveInfo = File.ReadAllLines("saves/saves.txt");
        public string[] actionInfo = File.ReadAllLines("saves/action.txt");
        public string[] help = File.ReadAllLines("saves/action.txt");
    }
}