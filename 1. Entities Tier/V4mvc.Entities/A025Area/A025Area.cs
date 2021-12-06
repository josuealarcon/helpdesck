using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class A025Area
	{
		#region [ Variables ]

		private Int32 m_id_area;
		private string m_area;
		private string m_activo;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase A025Area.
		/// </summary>
		public A025Area()
		{ }

		#endregion

		#region [ Propiedades ]


		/// <summary>
		/// Gets or sets el valor de: ID_AREA.
		/// </summary>
		public Int32 ID_AREA
		{
			get { return m_id_area; }
			set
			{
				if (m_id_area != value)
				{
					m_id_area = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AREA.
		/// </summary>
		public string AREA
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
		/// Gets or sets el valor de: ACTIVO.
		/// </summary>
		public string ACTIVO
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
