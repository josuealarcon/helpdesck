using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Area
	{
		#region [ Variables ]

		private string m_area;
		private string m_descripcion;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Area.
		/// </summary>
		public Area()
		{ }

		#endregion

		#region [ Propiedades ]

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
		/// Gets or sets el valor de: DESCRIPCION.
		/// </summary>
		public string DESCRIPCION
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
