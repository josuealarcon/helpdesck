using System;
namespace V4mvc.Entities
{
	[Serializable()]
	public partial class BusOrigen 
	{
		#region [ Variables ]
		private String m_busorigen;
		private String m_busdirori;
		private String m_division;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase BusOrigen.
		/// </summary>
		public BusOrigen()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: BUSORIGEN.
		/// </summary>
		public String BUSORIGEN
		{
			get { return m_busorigen; }
			set
			{
				if (m_busorigen != value)
				{
					m_busorigen = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: BUSDIRORI.
		/// </summary>
		public String BUSDIRORI
		{
			get { return m_busdirori; }
			set
			{
				if (m_busdirori != value)
				{
					m_busdirori = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DIVISION.
		/// </summary>
		public String DIVISION
		{
			get { return m_division; }
			set
			{
				if (m_division != value)
				{
					m_division = value;
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
