using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynOS.Commands
{
    public class Syn : Command
    {
        public Syn (String name) : base (name) { }

        public override String execute(String[] args)
        {
            String response = "";

            switch(args[0])
            {
                case "info":
                    try
                    {
                        Console.WriteLine("Syn command is unfinished");
                        break;
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }
                    break;

                default:
                    response = "Unexpected argument: " + args[0];
                    break;
            }

            return response;
        }
    }
}
