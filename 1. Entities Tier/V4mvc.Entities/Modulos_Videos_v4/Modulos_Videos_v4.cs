
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Modulos_Videos_v4
	{
		#region [ Variables ]

		private String m_glosa;

		private String m_activo;

		private String m_modulo;

		private Int32 m_id;

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Modulos_Videos_v4.
		/// </summary>
		public Modulos_Videos_v4()
		{ }
		#endregion

		#region [ Propiedades ]


		/// <summary>
		/// Gets or sets el valor de: GLOSA.
		/// </summary>
		public String GLOSA
		{
			get { return m_glosa; }
			set
			{
				if (m_glosa != value)
				{
					m_glosa = value;
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

		/// <summary>
		/// Gets or sets el valor de: MODULO.
		/// </summary>
		public String MODULO
		{
			get { return m_modulo; }
			set
			{
				if (m_modulo != value)
				{
					m_modulo = value;
				}
			}
		}

		/// <summary>
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Int32 ID
		{
			get { return m_id; }
			set
			{
				if (m_id != value)
				{
					m_id = value;
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
