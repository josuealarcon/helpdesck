using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Gerencias_General
	{
		#region [ Variables ]

		private decimal m_idgeneral;
		private string m_descripcion;
		private string m_activo;
		private string m_idsitio;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Gerencias_General.
		/// </summary>
		public Gerencias_General()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: IDGENERAL.
		/// </summary>
		public decimal IDGENERAL
		{
			get { return m_idgeneral; }
			set
			{
				if (m_idgeneral != value)
				{
					m_idgeneral = value;
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
		/// <summary>
		/// Gets or sets el valor de: IDSITIO.
		/// </summary>
		public string IDSITIO
		{
			get { return m_idsitio; }
			set
			{
				if (m_idsitio != value)
				{
					m_idsitio = value;
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
