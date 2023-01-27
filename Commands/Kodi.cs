using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynOS.Commands
{
    public class Kodi : Command
    {
        public Kodi (String name) : base(name) { }

        public override String execute(String[] args)
        {
            return "";
        }
    }
}
