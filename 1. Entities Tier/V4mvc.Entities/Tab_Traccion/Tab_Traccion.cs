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
	public partial class Tab_Traccion 
	{
		#region [ Variables ]
		private Int32 m_idtraccion;
		private String m_traccion;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Tab_Traccion.
		/// </summary>
		public Tab_Traccion()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: IDTRACCION.
		/// </summary>
		public Int32 IDTRACCION
		{
			get { return m_idtraccion; }
			set
			{
				if (m_idtraccion != value)
				{
					m_idtraccion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TRACCION.
		/// </summary>
		public String TRACCION
		{
			get { return m_traccion; }
			set
			{
				if (m_traccion != value)
				{
					m_traccion = value;
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
