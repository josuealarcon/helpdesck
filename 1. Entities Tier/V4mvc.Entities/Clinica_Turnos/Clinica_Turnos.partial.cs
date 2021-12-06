using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
namespace V4mvc.Entities
{
	public partial class Clinica_Turnos
	{
        #region [ Variables Validación ]

        public String CI_FECHA { get; set; }
        public String CONSENTIMIENTO { get; set; }
        public String POSITIVO { get; set; }
        public String ALERTA_APRUEBA_EM { get; set; }
        public String NOMBRE { get; set; }
        public String DIRECCION { get; set; }
        public String NOMBRES { get; set; }
        public String APELLIDOS { get; set; }
        public String EMAIL { get; set; }
        public String CIUDAD { get; set; }
        public String FECHA_CITA
        {
            get
            {
                return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.Guion));
            }
        }
    #endregion

    #region [ Propiedades Validación ]

    #endregion

}
}
