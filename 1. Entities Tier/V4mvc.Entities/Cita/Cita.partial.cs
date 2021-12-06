using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    public partial class Cita
    {
        public string FECHA_CITA
        {
            get
            {
                return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.Guion));
            }
        }
    }
}
