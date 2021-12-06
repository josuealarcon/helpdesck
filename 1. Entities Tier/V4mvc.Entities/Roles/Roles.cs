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
	public partial class Roles
	{
		#region [ Variables ]
		private String m_rol;
		private String m_area;
		private String m_proceso;
		private String m_subproceso;
		private String m_activo;
		private Int32 m_codigorol;
		private Guid m_msrepl_tran_version;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Roles.
		/// </summary>
		public Roles()
		{  }
		#endregion

		#region [ Propiedades ]
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
		/// <summary>
		/// Gets or sets el valor de: AREA.
		/// </summary>
		public String AREA
		{
			get { return m_area; }
			set
			{
				if (m_area != value)
				{
					m_area = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PROCESO.
		/// </summary>
		public String PROCESO
		{
			get { return m_proceso; }
			set
			{
				if (m_proceso != value)
				{
					m_proceso = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SUBPROCESO.
		/// </summary>
		public String SUBPROCESO
		{
			get { return m_subproceso; }
			set
			{
				if (m_subproceso != value)
				{
					m_subproceso = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ACTIVO.
		/// </summary>
		public String ACTIVO
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
		/// <summary>
		/// Gets or sets el valor de: CODIGOROL.
		/// </summary>
		public Int32 CODIGOROL
		{
			get { return m_codigorol; }
			set
			{
				if (m_codigorol != value)
				{
					m_codigorol = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: msrepl_tran_version.
		/// </summary>
		public Guid msrepl_tran_version
		{
			get { return m_msrepl_tran_version; }
			set
			{
				if (m_msrepl_tran_version != value)
				{
					m_msrepl_tran_version = value;
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
