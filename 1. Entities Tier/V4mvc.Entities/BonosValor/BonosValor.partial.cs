using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    public partial class BonosValor
    {
        #region [ Variables ]

        public string TIPO_BONO { get; set; }
        public string PERIODO { get; set; }
        public string PERIODOINI_FORMATO
        {
            get
            {
                return (Utils.Fec_User(PERIODOINI, Utils.Formato_Fecha.Periodo));
            }
        }
        public string PERIODOFIN_FORMATO
        {
            get
            {
                return (Utils.Fec_User(PERIODOFIN, Utils.Formato_Fecha.Periodo));
            }
        }

        #endregion

        #region [ Propiedades]

        #endregion

    }
}
