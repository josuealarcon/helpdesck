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
    public partial class Check_Checkinginghead
    {
        #region [ Variables ]

        #endregion
        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Check_Checkinginghead.
        /// </summary>
        public Check_Checkinginghead()
		{ }
        #endregion
        #region [ Propiedades ]
        public string ID_TIPO { get; set; }
        public int ID_CHECK { get; set; }
        public int ID_CHECKING { get; set; }
        public int ID_CHECKINGHEAD { get; set; }
        public string IDENTIFICADOR { get; set; }
        public string FECHA { get; set; }
        public string CORRECTO { get; set; }
        public string VALIDADO { get; set; }
        public int? IDSYNC { get; set; }
        public string USRCREA { get; set; }
        public DateTime FECCREA { get; set; }
        public string USRMOD { get; set; }
        public DateTime? FECMOD { get; set; }
        public int? CHECKLIST_TIPO { get; set; }
        public int? TIEMPOVAL { get; set; }
        public string DIVISION { get; set; }
        public string LOCAL { get; set; }
        public string OST { get; set; }
        public string EMPRESA { get; set; }
        public string ENVIO { get; set; }
        public string FECENVIO { get; set; }
        public string HORAENVIO { get; set; }
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
