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
    [Serializable()]
    public partial class Check
	{
		#region [ Variables ]

		#endregion
		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Control_Cuarentena.
		/// </summary>
		public Check()
		{ }
        #endregion
        #region [ Propiedades ]
        public string ID_TIPO { get; set; }
        public int ID_CHECK { get; set; }
        public string NOMBRE { get; set; }
        public int? MAXITEM { get; set; }
        public int? VENCIMIENTO { get; set; }
        public string ACTIVO { get; set; }
        public int? IDSYNC { get; set; }
        public string USRCREA { get; set; }
        public DateTime FECCREA { get; set; }
        public string USRMOD { get; set; }
        public DateTime? FECMOD { get; set; }
        public string PERIODO { get; set; }
        public string PATENTE { get; set; }
        

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
