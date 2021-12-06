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
	public partial class Aprobacion_SubContratos
    {

        #region [ Variables ]

        #endregion

        #region [ Propiedades ]

        public string ACRONIMO { get; set; }

        public string FINICIO_MESLETRAS
        {
            get
            {
                return (Utils.Fec_User(FINICIO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string FTERMINO_MESLETRAS
        {
            get
            {
                return (Utils.Fec_User(FTERMINO, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public string FINICIO_GUION
        {
            get
            {
                return (Utils.Fec_User(FINICIO, Utils.Formato_Fecha.Guion));
            }
        }
        public string FTERMINO_GUION
        {
            get
            {
                return (Utils.Fec_User(FTERMINO, Utils.Formato_Fecha.Guion));
            }
        }

        public string FADM_VALIDA_FORMATO
        {
            get
            {
                return (Utils.Fec_User(FEC_ADM_VALIDA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        

        public string F_SUPCHAIN_VALIDA_FORMATO
        {
            get
            {
                return (Utils.Fec_User(FEC_SUPCHAIN_VALIDA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }
        public string F_GSEGURIDAD_VALIDA_FORMATO
        {
            get
            {
                return (Utils.Fec_User(FEC_GSEGURIDAD_VALIDA, Utils.Formato_Fecha.GuionMesLetras));
            }
        }

        public ObservableCollection<OSTArbol> LISTADO_OST { get; set; }

        public Workers WORKER { get; set; }

        public String NOMBRES_ADMIN_CTTA { get; set; }

        public String APELLIDOS_ADMIN_CTTA { get; set; }

        public String NOMBRES_ADM_VALIDA { get; set; }

        public String NOMBRES_ADM_SUPCHAIN_VALIDA { get; set; }
        public String NOMBRES_ADM_GSEGURIDAD_VALIDA { get; set; }

        public string ESTADO { get; set; }

        public string  EMPRESA_SESSION { get; set; }
        public string ACRONIMO_SESSION { get; set; }
        public string NOMBRE_ARCHIVO { get; set; }
        public Docs DOCS { get; set; }
        public string FINICIO_CONTRATO { get; set; }
        public string FTERMINO_CONTRATO { get; set; }
        public string EMPRESA_NUEVA { get; set; }
        public string ACRONIMO_NUEVA { get; set; }
        public string EMPRESA_SINFORMATO { get; set; }
        #endregion

    }
}
