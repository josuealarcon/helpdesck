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
    public partial class Workers
    {

        #region [ Variables ]






        #endregion

        #region [ Propiedades ]
        public string FECHNACIM_G
        {
            get
            {
                return (Utils.Fec_User(FECHNACIM, Utils.Formato_Fecha.Guion));
            }
        }

        public string FECHAHOY_G
        {
            get
            {
                return (Utils.Fec_User(FECHAHOY, Utils.Formato_Fecha.Guion));
            }
        }
        public String HORAHOY { get; set; }
        public string IDEMPRESA { get; set; }
        public string DIVISION_NOMBRE { get; set; }

        public int CONDUCE_DIVISION { get; set; }
        public string NOMBRE_CONTRATO { get; set; }
        
        public string DIVCOD { get; set; }

        public int CERTIFICADO { get; set; }

        public string TIPO_PASE { get; set; }
        public string ORADOR_NOMBRES { get { return NOMBRES; } }
        public string ORADOR_APELLIDOS { get { return APELLIDOS; } }
        public string ORADOR_IDEMPRESA { get { return EMPRESA; } }
        public string ORADOR_ACRONIMO { get { return ACRONIMO; } }
        public string ORADOR { get { return RUT; } }

        public int TIENE_DIVISION_EMPRESA { get; set; }

        public ObservableCollection<A024_Divisiones> LISTA_DIVISIONES { get; set; }

        public string DIVISIONES_ENTRE_COMAS { get; set; }

        public int IDPASE { get; set; }
		
        public string Funcionario_ID { get { return RUT; } set { Funcionario_ID = value; } }
        public string Funcionario_NOMBRES { get { return NOMBRES; } set { Funcionario_NOMBRES = value; } }
        public string Funcionario_APELLIDOS { get { return APELLIDOS; } set { Funcionario_APELLIDOS = value; } }
        public string Funcionario_IDEMPRESA { get { return IDEMPRESA; } set { Funcionario_IDEMPRESA = value; } }
        public string Funcionario_ACRONIMO { get { return ACRONIMO; } set { Funcionario_ACRONIMO = value; } }

        #endregion


    }
}
