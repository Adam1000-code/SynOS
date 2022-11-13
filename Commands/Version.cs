using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynOS.Commands
{
    public class Version : Command
    {
        public Version(String name) : base(name) { }

        public override String execute(String[] args)
        {
            return "SynOS beta 0.0.2, Created by Adam Zeiser";
        }
    }
}
