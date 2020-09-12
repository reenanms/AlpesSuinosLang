using System;
using System.IO;

namespace ASLang.Executor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var startFilePath = args[0];
            var fileContent = File.ReadAllText(startFilePath);
            new CodeExecutor()
                .Execute(fileContent);
        }
    }
}
