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
	public partial class Tab_TipoContrato 
	{
		#region [ Variables ]
		private Int32 m_id_tipocontrato;
		private String m_tipocontrato;
		private String m_descripcion;
		private String m_activo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Tab_TipoContrato.
		/// </summary>
		public Tab_TipoContrato()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Id_TipoContrato.
		/// </summary>
		public Int32 Id_TipoContrato
		{
			get { return m_id_tipocontrato; }
			set
			{
				if (m_id_tipocontrato != value)
				{
					m_id_tipocontrato = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TipoContrato.
		/// </summary>
		public String TipoContrato
		{
			get { return m_tipocontrato; }
			set
			{
				if (m_tipocontrato != value)
				{
					m_tipocontrato = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: Descripcion.
		/// </summary>
		public String Descripcion
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
		/// <summary>
		/// Gets or sets el valor de: Activo.
		/// </summary>
		public String Activo
		{
			get { return m_activo; }
			set
			{
				if (m_activo != value)
				{
					m_activo = value;
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
