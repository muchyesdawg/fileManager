using System;
using System.IO;

namespace fileManager{
    public class saveFile {
        public string[] listOfActions = File.ReadAllLines("/actions.txt");
    }
}