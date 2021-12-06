using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class OSTCombust
	{
		#region [ Variables ]

		private string m_nroost;
		private string m_idempresa;
		private string m_combust;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase OSTCombust.
		/// </summary>
		public OSTCombust()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: NROOST.
		/// </summary>
		public string NROOST
		{
			get { return m_nroost; }
			set
			{
				if (m_nroost != value)
				{
					m_nroost = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDEMPRESA.
		/// </summary>
		public string IDEMPRESA
		{
			get { return m_idempresa; }
			set
			{
				if (m_idempresa != value)
				{
					m_idempresa = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COMBUST.
		/// </summary>
		public string COMBUST
		{
			get { return m_combust; }
			set
			{
				if (m_combust != value)
				{
					m_combust = value;
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
