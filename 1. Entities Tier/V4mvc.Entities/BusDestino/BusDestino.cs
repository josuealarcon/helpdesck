using System;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class BusDestino 
	{
		#region [ Variables ]
		private String m_busdestino;
		private String m_busdirdes;
		private String m_division;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase BusDestino.
		/// </summary>
		public BusDestino()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: BUSDESTINO.
		/// </summary>
		public String BUSDESTINO
		{
			get { return m_busdestino; }
			set
			{
				if (m_busdestino != value)
				{
					m_busdestino = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: BUSDIRDES.
		/// </summary>
		public String BUSDIRDES
		{
			get { return m_busdirdes; }
			set
			{
				if (m_busdirdes != value)
				{
					m_busdirdes = value;
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
