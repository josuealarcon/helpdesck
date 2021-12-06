using System;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class WC_Menu 
	{
		#region [ Variables ]
		private Decimal m_codmenu;
		private String m_descmenu;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase WC_Menu.
		/// </summary>
		public WC_Menu()
		{  }
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
		/// Gets or sets el valor de: DESCMENU.
		/// </summary>
		public String DESCMENU
		{
			get { return m_descmenu; }
			set
			{
				if (m_descmenu != value)
				{
					m_descmenu = value;
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
