using Chain.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Chain
{
    public class CheckUserMiddleware : MiddleWare
    {
        private Server server;
        public CheckUserMiddleware(Server server)
        {
            this.server = server;
        }

        public override bool Check(string email, string password)
        {
            if (!server.HasEmail(email))
            {
                Console.WriteLine("Email invalido");
                return false;
            }
            if (!server.IsValidPassword(email,password))
            {
                Console.WriteLine("Email ou senha invalida");
                return false;
            }
            return CheckNext(email, password);
        }
    }
}
