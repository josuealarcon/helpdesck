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
	public partial class CTRLultimo
	{
		#region [ Variables ]
		private String m_rut;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Control_Cuarentena.
		/// </summary>
		public CTRLultimo()
		{ }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: RUT.
		/// </summary>
		public String RUT
		{
			get { return m_rut; }
			set
			{
				if (m_rut != value)
				{
					m_rut = value;
				}
			}
		}
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