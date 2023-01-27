using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynOS.Commands
{
    public class Echo : Command
    {
        public Echo (String name) : base(name) { }

        public override String execute(String[] args)
        {
            String response = "";

            int ctr = 0;
            StringBuilder sb = new StringBuilder();
            foreach (String s in args)
            {
                if (ctr > 1)
                    sb.Append(s + ' ');
                ++ctr;
            }
            String txt = sb.ToString();

            Byte[] data = Encoding.ASCII.GetBytes(txt.Substring(0, txt.Length - 1));

            Console.WriteLine(data.Length);

            response = "";

            return response;
        }
    }
}
