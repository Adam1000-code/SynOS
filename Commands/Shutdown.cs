﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynOS.Commands
{
    public class Shutdown : Command
    {
        public Shutdown (string name) : base(name) { }

        public override string execute(string[] args)
        {
            Console.WriteLine("Shutting down...");
            Thread.Sleep(1);
            Cosmos.System.Power.Shutdown();
            return "";
        }
    }
}
