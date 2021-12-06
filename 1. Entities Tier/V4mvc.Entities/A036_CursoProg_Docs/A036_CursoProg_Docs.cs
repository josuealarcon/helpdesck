using System;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class A036_CursoProg_Docs
	{
		#region [ Variables ]

		private Int32 m_id_doc_charla;
		private Int32 m_codigo;
		private Guid m_id;
		private Int32 m_bytes;
		private String m_nombre;

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase A036_CursoProg_Docs.
		/// </summary>
		public A036_CursoProg_Docs()
		{ }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ID_DOC_CHARLA.
		/// </summary>
		public Int32 ID_DOC_CHARLA
		{
			get { return m_id_doc_charla; }
			set
			{
				if (m_id_doc_charla != value)
				{
					m_id_doc_charla = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CODIGO.
		/// </summary>
		public Int32 CODIGO
		{
			get { return m_codigo; }
			set
			{
				if (m_codigo != value)
				{
					m_codigo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Guid ID
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
		/// Gets or sets el valor de: BYTES.
		/// </summary>
		public Int32 BYTES
		{
			get { return m_bytes; }
			set
			{
				if (m_bytes != value)
				{
					m_bytes = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NOMBRE.
		/// </summary>
		public String NOMBRE
		{
			get { return m_nombre; }
			set
			{
				if (m_nombre != value)
				{
					m_nombre = value;
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