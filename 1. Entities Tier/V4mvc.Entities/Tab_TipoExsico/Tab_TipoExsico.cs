using System;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Tab_TipoExsico
	{

		#region [ Variables ]

		private Decimal m_id;
		private String m_descripcion;
		private String m_activo;
		private String m_fechamod;
		private String m_horamod;
		private String m_usuariomod;
		private Nullable<Int32> m_duracion;

		#endregion

		#region [ Constructores ]

		/// <summary>
		/// Inicializar una nueva instancia de la clase Tab_TipoPase.
		/// </summary>
		public Tab_TipoExsico()
		{ }

		#endregion

		#region [ Propiedades ]

		/// <summary>
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Decimal ID
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
		/// <summary>
		/// Gets or sets el valor de: DESCRIPCION.
		/// </summary>
		public String DESCRIPCION
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
		/// Gets or sets el valor de: FECHAMOD.
		/// </summary>
		public String FECHAMOD
		{
			get { return m_fechamod; }
			set
			{
				if (m_fechamod != value)
				{
					m_fechamod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORAMOD.
		/// </summary>
		public String HORAMOD
		{
			get { return m_horamod; }
			set
			{
				if (m_horamod != value)
				{
					m_horamod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USUARIOMOD.
		/// </summary>
		public String USUARIOMOD
		{
			get { return m_usuariomod; }
			set
			{
				if (m_usuariomod != value)
				{
					m_usuariomod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DURACION.
		/// </summary>
		public Nullable<Int32> DURACION
		{
			get { return m_duracion; }
			set
			{
				if (m_duracion != value)
				{
					m_duracion = value;
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
