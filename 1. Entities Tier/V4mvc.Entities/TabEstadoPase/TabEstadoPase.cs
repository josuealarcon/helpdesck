using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class TabEstadoPase
	{
		#region [ Variables ]

		private string m_estado_pase;
		private string m_desc_estado;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase TabEstadoPase.
		/// </summary>
		public TabEstadoPase()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: ESTADO_PASE.
		/// </summary>
		public string ESTADO_PASE
		{
			get { return m_estado_pase; }
			set
			{
				if (m_estado_pase != value)
				{
					m_estado_pase = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DESC_ESTADO.
		/// </summary>
		public string DESC_ESTADO
		{
			get { return m_desc_estado; }
			set
			{
				if (m_desc_estado != value)
				{
					m_desc_estado = value;
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
