using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class ReqVal_Docs
	{
		#region [ Variables ]
		private Nullable<Int32> m_id_doc;
		private String m_requisito;
		private Int32 m_idrequisito;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase ReqVal_Docs.
		/// </summary>
		public ReqVal_Docs()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ID_DOC.
		/// </summary>
		public Nullable<Int32> ID_DOC
		{
			get { return m_id_doc; }
			set
			{
				if (m_id_doc != value)
				{
					m_id_doc = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REQUISITO.
		/// </summary>
		public String REQUISITO
		{
			get { return m_requisito; }
			set
			{
				if (m_requisito != value)
				{
					m_requisito = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDREQUISITO.
		/// </summary>
		public Int32 IDREQUISITO
		{
			get { return m_idrequisito; }
			set
			{
				if (m_idrequisito != value)
				{
					m_idrequisito = value;
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
