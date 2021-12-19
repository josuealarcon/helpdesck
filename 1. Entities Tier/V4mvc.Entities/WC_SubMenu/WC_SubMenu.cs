using System;
using System.ComponentModel;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class WC_SubMenu
	{
		#region [ Variables ]
		private Decimal m_codmenu;
		private Decimal m_codsubmenu;
		private String m_link;
		private String m_icono;
		private String m_descripcion;
		private String m_activo;
		private String m_permiso;
		private String m_linkv4;
		private String m_iconov4;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase WC_SubMenu.
		/// </summary>
		public WC_SubMenu()
		{ }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CODMENU.
		/// </summary>
		public Decimal CODMENU
		{
			get { return m_codmenu; }
			set
			{
				if (m_codmenu != value)
				{
					m_codmenu = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CODSUBMENU.
		/// </summary>
		public Decimal CODSUBMENU
		{
			get { return m_codsubmenu; }
			set
			{
				if (m_codsubmenu != value)
				{
					m_codsubmenu = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LINK.
		/// </summary>
		public String LINK
		{
			get { return m_link; }
			set
			{
				if (m_link != value)
				{
					m_link = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LINKV4.
		/// </summary>
		public String LINKV4
		{
			get { return m_linkv4; }
			set
			{
				if (m_linkv4 != value)
				{
					m_linkv4 = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ICONOV4.
		/// </summary>
		public String ICONOV4
		{
			get { return m_iconov4; }
			set
			{
				if (m_iconov4 != value)
				{
					m_iconov4 = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ICONO.
		/// </summary>
		public String ICONO
		{
			get { return m_icono; }
			set
			{
				if (m_icono != value)
				{
					m_icono = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DESCRIPCION.
		/// </summary>
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
		/// Gets or sets el valor de: PERMISO.
		/// </summary>
		public String PERMISO
		{
			get { return m_permiso; }
			set
			{
				if (m_permiso != value)
				{
					m_permiso = value;
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
