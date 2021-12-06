using System;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class WC_Informes_Certificacion
	{
		#region [ Variables ]
		private Decimal m_cod_infcer;
		private String m_desc_infcer;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase WC_Menu.
		/// </summary>
		public WC_Informes_Certificacion()
		{ }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: COD_INFCER.
		/// </summary>
		public Decimal COD_INFCER
		{
			get { return m_cod_infcer; }
			set
			{
				if (m_cod_infcer != value)
				{
					m_cod_infcer = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DESCMENU.
		/// </summary>
		public String DESC_INFCER
		{
			get { return m_desc_infcer; }
			set
			{
				if (m_desc_infcer != value)
				{
					m_desc_infcer = value;
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
