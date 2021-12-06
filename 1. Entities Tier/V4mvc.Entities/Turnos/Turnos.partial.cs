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
	public partial class Turnos
	{
        #region [ Variables Validación ]

        public int CALENDARIO { get; set; }
        public string FECHA { get; set; }
        public Nullable<Int32> DISP_IDDISPUTA { get; set; }
        public string DISP_ESTADO { get; set; }
        public string ACCION { get; set; }
        public Archivos CERTIFICADO { get; set; }
        public string COLOR { get; set; }
        public string NOMBRE { get; set; }
        public string FECHA_FORMATO
        {
            get { return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.Guion)); }
        }
        #endregion

        #region [ Propiedades Validación ]
        public string NOMBRE_ARCHIVO { get; set; }
        public string ACTIVO { get; set; }
        public string OBSACREDITA { get; set; }
        public string CARGO { get; set; }
        public string ROTATIVOS { get; set; }
        public string FECRESOLUCION { get; set; }

        #endregion

    }
}
