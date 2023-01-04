using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforma
{
    public interface IPlataform
    {
        public void ConfigureRMTP();
        public void AuthToken();
    }
}
