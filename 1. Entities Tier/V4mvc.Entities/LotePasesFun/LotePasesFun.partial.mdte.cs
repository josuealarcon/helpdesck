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

    public class FuncionarioComparer : IEqualityComparer<LotePasesFun>
    {
        public bool Equals(LotePasesFun x, LotePasesFun y)
        {

            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            return x.RUTLOTE == y.RUTLOTE;
        }

        public int GetHashCode(LotePasesFun obj)
        {
            if (Object.ReferenceEquals(obj, null)) return 0;

            int RUTLOTE_HASH = obj.RUTLOTE == null ? 0 : obj.RUTLOTE.GetHashCode();

            return RUTLOTE_HASH;
        }
    }

    public class VehiculoComparer : IEqualityComparer<LotePasesFun>
    {
        public bool Equals(LotePasesFun x, LotePasesFun y)
        {

            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            return x.PATENTE == y.PATENTE;
        }

        public int GetHashCode(LotePasesFun obj)
        {
            if (Object.ReferenceEquals(obj, null)) return 0;

            int PATENTE_HASH = obj.PATENTE == null ? 0 : obj.PATENTE.GetHashCode();

            return PATENTE_HASH;
        }
    }

    public partial class LotePasesFun
	{

		#region [ Variables ]


		#endregion



		#region [ Propiedades ]


		public string FECNACIM_GM
		{
			get
			{
				return (Utils.Fec_User(FECNACIM, Utils.Formato_Fecha.GuionMesLetras));
			}
		}

		public string CATEGORIA_LETRAS { get; set; }

		public string SUBCATEGORIA_LETRAS { get; set; }

		public string CONDUCE_LETRAS { get; set; }

		public string HOTEL_LETRAS { get; set; }

		public string AUTORIZADO_LETRAS { get; set; }

		public string TIPOVEHI_LETRAS { get; set; }

        public int CERTIFICADO { get; set; }

        public string FECHNACIM { get; set; }

        public string EMPRESA { get; set; }

        public string FECEXPIREX { get; set; }

        public string LICCONDUC { get; set; }

        public string FECEXPIRALIC { get; set; }

        public string CLASELICW { get; set; }

        public string OST { get; set; }

        public string FINIPASE { get; set; }

        public string FFINPASE { get; set; }

        public string AUTOREMPRESA { get; set; }

        public int RESULTADO_CERTIFICACION { get; set; }

        #endregion

    }
}
