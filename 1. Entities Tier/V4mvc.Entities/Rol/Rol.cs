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
	public partial class Rol 
	{
		#region [ Variables ]
		private Int32 m_id_rol;
		private String m_rol;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Rol.
		/// </summary>
		public Rol()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ID_ROL.
		/// </summary>
		public Int32 ID_ROL
		{
			get { return m_id_rol; }
			set
			{
				if (m_id_rol != value)
				{
					m_id_rol = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ROL.
		/// </summary>
		public String ROL
		{
			get { return m_rol; }
			set
			{
				if (m_rol != value)
				{
					m_rol = value;
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
