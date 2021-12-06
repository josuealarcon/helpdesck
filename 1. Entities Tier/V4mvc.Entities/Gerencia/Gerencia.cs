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
	public partial class Gerencia
	{
		#region [ Variables ]
		public Int32 m_gerencia;
		public String m_descripcion;
		#endregion

		#region [ Constructores ]
		public Gerencia()
		{ }
		#endregion

		#region [ Propiedades ]
		public Int32 IDGERENCIA
		{
			get { return m_gerencia; }
			set
			{
				if (m_gerencia != value)
				{
					m_gerencia = value;
				}
			}
		}
        public string GERENCIA { get; set; }
        public String DESCRIPCION
		{
			get { return m_descripcion; }
			set
			{
				if (m_descripcion != value)
				{
					m_descripcion = value;
				}
			}
		}
        public string ACTIVO { get; set; }
        public double IDGENERAL { get; set; }
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