using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using SynOS.Commands;
using Cosmos.System.FileSystem;
using SynOS.Graphics;
using Cosmos.Core.Memory;

namespace SynOS
{
    public class Kernel : Sys.Kernel
    {
        private CommandManager commandManager;
        private CosmosVFS vfs;
        public static GUI gui;
        public static NewDisplay newDis;

        protected override void BeforeRun()
        {
            Kernel.newDis = null;
            this.vfs = new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.vfs);
            this.commandManager = new CommandManager();
            Console.Clear();

            Console.WriteLine(@"  _____              ____   _____ ");
            Console.WriteLine(@" / ____|            / __ \ / ____|");
            Console.WriteLine(@"| (___  _   _ _ __ | |  | | (___  ");
            Console.WriteLine(@" \___ \| | | | '_ \| |  | |\___ \ ");
            Console.WriteLine(@" ____) | |_| | | | | |__| |____) |");
            Console.WriteLine(@"|_____/ \__, |_| |_|\____/|_____/ ");
            Console.WriteLine(@"         __/ |                    ");
            Console.WriteLine(@"        |___/                     ");
            Console.WriteLine("Welcome to SynOS. Please enter a command.");
            Console.WriteLine("Benvenuto tu SynOS. Per favore accedere un comando.");
        }

        protected override void Run()
        {
            if(Kernel.newDis != null)
            {
                newDis.Display();
                return;
            }

            Console.Write(@"S:\>");
            string response;
            Heap.Collect();
            string input = Console.ReadLine();
            response = this.commandManager.processInput(input);
            Console.WriteLine(response);
        }
    }
}
