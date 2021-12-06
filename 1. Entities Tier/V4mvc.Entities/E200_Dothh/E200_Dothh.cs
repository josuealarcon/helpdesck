using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class E200_Dothh
	{
		#region [ Variables ]

		private Guid m_id;
		private string m_idempresa;
		private Int32? m_dothom;
		private Int32? m_hhhom;
		private Int32? m_dotmuj;
		private Int32? m_hhmuj;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase E200_Dothh.
		/// </summary>
		public E200_Dothh()
		{ }

		#endregion

		#region [ Propiedades ]

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
		/// Gets or sets el valor de: DOTHOM.
		/// </summary>
		public Int32? DOTHOM
		{
			get { return m_dothom; }
			set
			{
				if (m_dothom != value)
				{
					m_dothom = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HHHOM.
		/// </summary>
		public Int32? HHHOM
		{
			get { return m_hhhom; }
			set
			{
				if (m_hhhom != value)
				{
					m_hhhom = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOTMUJ.
		/// </summary>
		public Int32? DOTMUJ
		{
			get { return m_dotmuj; }
			set
			{
				if (m_dotmuj != value)
				{
					m_dotmuj = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HHMUJ.
		/// </summary>
		public Int32? HHMUJ
		{
			get { return m_hhmuj; }
			set
			{
				if (m_hhmuj != value)
				{
					m_hhmuj = value;
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
