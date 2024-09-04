using System;
using System.IO;

namespace Invoicing_System.Data
{
    public class AppData
    {
        public static string AppDbCon = File.ReadAllText(Environment.CurrentDirectory + @"\config.mgt");
    }
}
