using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

	public partial class A036Cursoprog
	{
        #region [ Variables ]

        #endregion

        #region [ Propiedades ]
        public int ID_DOC_CHARLA { get; set; }
        public string ID_ARCHIVO { get; set; }
        public string NOMBRE { get; set; }
        public int BYTES { get; set; }
        public int CAPACIDAD { get; set; }
        public string UBICACION { get; set; }
        public string CHARLA { get; set; }
        public string DESCRIP { get; set; }
        public int HORAS { get; set; }
        public int VENCIMIENTO { get; set; }
        public int CANTIDAD { get; set; }
        public DateTime HORATERMINO { get; set; }
        public string OBLIGATORIO { get; set; }
        public string DIVISION { get; set; }
        public string HORARANGO { get; set; }
        public int PORCENTAJE { get; set; }
        public string RUT { get; set; }
        public string ORADOR_NOMBRES { get; set; }
        public string ORADOR_APELLIDOS { get; set; }
        public string ORADOR_IDEMPRESA { get; set; }
        public string ORADOR_ACRONIMO { get; set; }
        public string FECHA_GML
        {
            get
            {
                return Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras);
            }
        }
        public string WHOMAKE { get; set; }
        public Guid ID_DOC { get; set; }
        #endregion
    }
}