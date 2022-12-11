using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using SynOS.Commands;
using Cosmos.System.FileSystem;

namespace SynOS
{
    public class Kernel : Sys.Kernel
    {

        private CommandManager commandManager;
        private CosmosVFS vfs;
        protected override void BeforeRun()
        {
            this.vfs = new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.vfs);
            this.commandManager = new CommandManager();
            Console.Clear();

            Console.WriteLine(" _______  __   __  __    _  _______  _______");
            Console.WriteLine("|       ||  | |  ||  |  | ||       ||       |");
            Console.WriteLine("|  _____||  |_|  ||   |_| ||   _   ||  _____|");
            Console.WriteLine("| |_____ |       ||       ||  | |  || |_____ ");
            Console.WriteLine("|_____  ||_     _||  _    ||  |_|  ||_____  |");
            Console.WriteLine(" _____| |  |   |  | | |   ||       | _____| |");
            Console.WriteLine("|_______|  |___|  |_|  |__||_______||_______|");
            Console.WriteLine("Welcome to SynOS. Please enter a command.");
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
