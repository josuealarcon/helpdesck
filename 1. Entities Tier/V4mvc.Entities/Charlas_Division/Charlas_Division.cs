using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Charlas_Division
	{
		#region [ Variables ]

		private Int32 m_id_charla_division;
		private Int32? m_idcharla;
		private string m_division;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Charlas_Division.
		/// </summary>
		public Charlas_Division()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: ID_CHARLA_DIVISION.
		/// </summary>
		public Int32 ID_CHARLA_DIVISION
		{
			get { return m_id_charla_division; }
			set
			{
				if (m_id_charla_division != value)
				{
					m_id_charla_division = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDCHARLA.
		/// </summary>
		public Int32? IDCHARLA
		{
			get { return m_idcharla; }
			set
			{
				if (m_idcharla != value)
				{
					m_idcharla = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DIVISION.
		/// </summary>
		public string DIVISION
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
