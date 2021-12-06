using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class DocumentosContratistas
	{
		#region [ Variables ]

		private Int32 m_idctta_doc;
		private Int32 m_iddoc;
		private string m_tipoprop;
		private string m_obliga;
		private string m_activo;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase DocumentosContratistas.
		/// </summary>
		public DocumentosContratistas()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: IDCTTA_DOC.
		/// </summary>
		public Int32 IDCTTA_DOC
		{
			get { return m_idctta_doc; }
			set
			{
				if (m_idctta_doc != value)
				{
					m_idctta_doc = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDDOC.
		/// </summary>
		public Int32 IDDOC
		{
			get { return m_iddoc; }
			set
			{
				if (m_iddoc != value)
				{
					m_iddoc = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPOPROP.
		/// </summary>
		public string TIPOPROP
		{
			get { return m_tipoprop; }
			set
			{
				if (m_tipoprop != value)
				{
					m_tipoprop = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OBLIGA.
		/// </summary>
		public string OBLIGA
		{
			get { return m_obliga; }
			set
			{
				if (m_obliga != value)
				{
					m_obliga = value;
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
