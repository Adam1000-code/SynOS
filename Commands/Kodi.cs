using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynOS.Graphics;
using Cosmos.System;
using Sys = Cosmos.System;

namespace SynOS.Commands
{
    public class Kodi : Command
    {
        public Kodi (string name) : base (name) { }

        public override string execute(string[] args)
        {
            if(Kernel.gui != null)
            {
                return "Kodi has already launched";
            }
            Kernel.gui = new GUI();
            return "The Kodi Desktop has launched";
        }
    }
}
