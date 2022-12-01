using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoExtensionMethods.Extensao
{
    static class CronometroTempo
    {
        public static string teste(this DateTime thisObj)
        {
            TimeSpan total = DateTime.Now.Subtract(thisObj);

            if (total.TotalHours < 24)
            {
                return total.TotalHours.ToString("F1", CultureInfo.InvariantCulture);
            }
            else
            {
                return total.TotalDays.ToString("F1", CultureInfo.InvariantCulture);
            }
        }
    }
}
