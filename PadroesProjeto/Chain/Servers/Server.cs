using Chain.Chain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Servers
{
    public class Server
    {
        private Dictionary<string, string> _users = new Dictionary<string, string>();

        private MiddleWare middleware;

        public void SetMiddleware(MiddleWare middleware)
        {
            this.middleware = middleware;
        }
        public Boolean LogIn(string email, string password)
        {
           if(middleware.Check(email, password))
            {
                Console.WriteLine("Usuario autorizado com sucesso");
                Console.WriteLine("Seja bem vindo");
                return true;
            }
           return false;
        }
        public void RegisterUser(string email,string password)
        {
            _users[email] = password;
        }

        public Boolean HasEmail(string email)
        {
            return _users.ContainsKey(email);
        }
        public Boolean IsValidPassword(string email, string password)
        {
            string value = "";

            _users.TryGetValue(email, out value);

            return password == value;
        }
    }
}
