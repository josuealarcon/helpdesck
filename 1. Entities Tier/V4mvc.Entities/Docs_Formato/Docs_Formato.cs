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
	public partial class Docs_Formato 
	{
		#region [ Variables ]
		private Int32 m_id_doc;
		private Int32 m_id_doc_ext;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Docs_Formato.
		/// </summary>
		public Docs_Formato()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ID_DOC.
		/// </summary>
		public Int32 ID_DOC
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
		/// Gets or sets el valor de: ID_DOC_EXT.
		/// </summary>
		public Int32 ID_DOC_EXT
		{
			get { return m_id_doc_ext; }
			set
			{
				if (m_id_doc_ext != value)
				{
					m_id_doc_ext = value;
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
