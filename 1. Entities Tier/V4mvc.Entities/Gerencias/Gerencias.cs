using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Gerencias
	{
		#region [ Variables ]

		private Int32 m_idgerencia;
		private string m_gerencia;
		private string m_descripcion;
		private string m_activo;
		private decimal? m_idgeneral;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Gerencias.
		/// </summary>
		public Gerencias()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: IDGERENCIA.
		/// </summary>
		public Int32 IDGERENCIA
		{
			get { return m_idgerencia; }
			set
			{
				if (m_idgerencia != value)
				{
					m_idgerencia = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GERENCIA.
		/// </summary>
		public string GERENCIA
		{
			get { return m_gerencia; }
			set
			{
				if (m_gerencia != value)
				{
					m_gerencia = value;
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
		/// Gets or sets el valor de: IDGENERAL.
		/// </summary>
		public decimal? IDGENERAL
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
