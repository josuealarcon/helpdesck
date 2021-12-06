
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class A024_Divisiones
    {
        #region [ Variables ]

        #endregion

        #region [ Propiedades ]
        public string PATENTE { get; set; }
        public int CERT { get; set; }
        public int FUNCIONARIOS_NOMINA { get; set; }
        public int FUNCIONARIOS_AUTORIZADOS { get; set; }
        public int VEHICULOS { get; set; }
        public int CONTRATOS_ACTIVOS { get; set; }
        public String FECHA { get; set; }

        public string BLOQUEA { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<Guid> ID { get; set; }
        public string USRBLOQUEA { get; set; }
        public string FECBLOQUEA { get; set; }
        public string HORABLOQUEA { get; set; }
        public string NOMBRE { get; set; }
        public string PATENTE_FORMATO
        {
            get
            {
                return (Utils.FormatoPatente(PATENTE));
            }
        }
        public string USRBLOQUEA_FORMATO
        {
            get
            {
                return (Utils.strRut(USRBLOQUEA));
            }
        }
        public string EMPRESA_FORMATO
        {
            get
            {
                return (Utils.strRut(EMPRESA));
            }
        }
        #endregion
    }
}
	