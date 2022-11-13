using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using SynOS.Commands;

namespace SynOS
{
    public class Kernel : Sys.Kernel
    {
        private CommandManager commandManager;
        protected override void BeforeRun()
        {
            Console.WriteLine("Welcome to SynOS.");
            Console.WriteLine("Please enter a command.");
            this.commandManager = new CommandManager();
        }

        protected override void Run()
        {
            Console.Write("/S:");
            String response;
            String input = Console.ReadLine();
            response = this.commandManager.processInput(input);
            Console.WriteLine(response);
        }
    }
}
