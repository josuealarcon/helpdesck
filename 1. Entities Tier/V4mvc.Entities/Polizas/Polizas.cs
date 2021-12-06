using System;
using System.Collections.ObjectModel;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Polizas
	{
		#region [ Variables ]

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Polizas.
		/// </summary>
		public Polizas()
		{  }
        #endregion

        #region [ Propiedades ]
        public string NROPOLIZA { get; set; }

        public int IDDOC { get; set; }

        public string FECINI { get; set; }

        public string FECFIN { get; set; }

        public string EMPRESA { get; set; }

        public string DIVISION { get; set; }

        public Guid? ID { get; set; }

        public string VALIDADO { get; set; }

        public string CERTFECHA { get; set; }

        public string CERTHORA { get; set; }

        public string CERTUSUARIO { get; set; }

        public string OBSERVACION { get; set; }

        public string FECHAMOD { get; set; }

        public string HORAMOD { get; set; }

        public string USUARIOMOD { get; set; }

        public string OST { get; set; }
		public string EMPRESA_FORMATO
		{
			get
			{
				return (Utils.strRut(EMPRESA));
			}
		}
		public string EXTENSIONES { get; set; }
		#endregion

		#region [ Instance Entity ]
		public InstanceEntity m_instance;
		
		/// <summary>
		/// Gets or sets el valor de: InstanceEntity.
		/// </summary>
		public InstanceEntity Instance
		{
			get { return m_instance; }
			set { m_instance = value; }
		}

		#endregion

	}
}
