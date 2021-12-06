
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Colab_WC_SubMenu
    {
        #region [ Variables ]
        
    	private String m_linkv4;
	
    	private String m_permiso;
	
    	private Int32 m_codmenu;
	
    	private String m_activo;
	
    	private String m_link;
	
    	private Int32 m_codsubmenu;
	
    	private String m_descripcion;
	
    	private String m_icono;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Colab_WC_SubMenu.
        /// </summary>
        public Colab_WC_SubMenu()
        { }
		#endregion

		#region [ Propiedades ]

		
		/// <summary>
		/// Gets or sets el valor de: LinkV4.
		/// </summary>
		public String LinkV4
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
		/// Gets or sets el valor de: Permiso.
		/// </summary>
		public String Permiso
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
	
		/// <summary>
		/// Gets or sets el valor de: CodMenu.
		/// </summary>
		public Int32 CodMenu
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
	
		/// <summary>
		/// Gets or sets el valor de: Link.
		/// </summary>
		public String Link
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
		/// Gets or sets el valor de: CodSubMenu.
		/// </summary>
		public Int32 CodSubMenu
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
		/// Gets or sets el valor de: Icono.
		/// </summary>
		public String Icono
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
	