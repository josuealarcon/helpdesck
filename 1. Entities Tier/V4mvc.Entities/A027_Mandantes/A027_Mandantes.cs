using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class A027_Mandantes
	{

		#region [ Variables ]

		private String m_mandante;
		private String m_ost;
		private String m_activo;

		#endregion

		#region [ Constructores ]

		/// <summary>
		/// Inicializar una nueva instancia de la clase A027_Mandantes.
		/// </summary>
		public A027_Mandantes()
		{ }

		#endregion

		#region [ Propiedades ]

		/// <summary>
		/// Gets or sets el valor de: MANDANTE.
		/// </summary>
		public String MANDANTE
		{
			get { return m_mandante; }
			set
			{
				if (m_mandante != value)
				{
					m_mandante = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OST.
		/// </summary>
		public String OST
		{
			get { return m_ost; }
			set
			{
				if (m_ost != value)
				{
					m_ost = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ACTIVO.
		/// </summary>
		public String ACTIVO
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