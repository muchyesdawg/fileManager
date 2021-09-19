using System;
using System.IO;
namespace fileManager
{
    public class saveFile {
        public string[] saveInfo = File.ReadAllLines("saves/saves.txt");
    }
}