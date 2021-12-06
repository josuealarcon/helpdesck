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
	public partial class Tab_Combustible 
	{
		#region [ Variables ]
		private Int32 m_idcombustible;
		private String m_combustible;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Tab_Combustible.
		/// </summary>
		public Tab_Combustible()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: IDCOMBUSTIBLE.
		/// </summary>
		public Int32 IDCOMBUSTIBLE
		{
			get { return m_idcombustible; }
			set
			{
				if (m_idcombustible != value)
				{
					m_idcombustible = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COMBUSTIBLE.
		/// </summary>
		public String COMBUSTIBLE
		{
			get { return m_combustible; }
			set
			{
				if (m_combustible != value)
				{
					m_combustible = value;
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
		
		protected void RefreshInstanceEntity()
		{
			if (Instance != InstanceEntity.New && Instance != InstanceEntity.Delete)
			{ Instance = InstanceEntity.Modify; }
		}
		#endregion

	}
}
