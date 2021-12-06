using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.CommandsForm.Classes
{
    class Utils
    {
        public static string GetNearestUnitTime(long ms)
        {
            string ret = string.Empty;
            if (ms >= 60000)
            {
                ret = string.Format("{0:0.0} minutos", ((float)ms) / 60000.0f);
            }
            else if (ms >= 1000 && ms < 60000)
            {
                ret = string.Format("{0:0.0} segundos", ((float)ms) / 1000.0f);
            }
            else
            {
                ret = string.Format("{0} milisegundos", ms);
            }
            return ret;
        }
    }
}
