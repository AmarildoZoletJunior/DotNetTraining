using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Chain
{
    public abstract class MiddleWare
    {
        private MiddleWare next;
        public MiddleWare LinkWith(MiddleWare next)
        {
            this.next = next;

            return next;
        }

        public abstract Boolean Check(string email, string passoword);

        protected Boolean CheckNext(string email, string password)
        {
            if(next == null)
            {
                return true;
            }
            return next.Check(email, password);
        }

    }
}
