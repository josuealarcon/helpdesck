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
	public partial class Docs_Fec_TipoPase 
	{
		#region [ Variables ]
		private String m_tipopase;
		private Int32 m_id_doc_fec;
		private String m_division;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Docs_Fec_TipoPase.
		/// </summary>
		public Docs_Fec_TipoPase()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: TIPOPASE.
		/// </summary>
		public String TIPOPASE
		{
			get { return m_tipopase; }
			set
			{
				if (m_tipopase != value)
				{
					m_tipopase = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_DOC_FEC.
		/// </summary>
		public Int32 ID_DOC_FEC
		{
			get { return m_id_doc_fec; }
			set
			{
				if (m_id_doc_fec != value)
				{
					m_id_doc_fec = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DIVISION.
		/// </summary>
		public String DIVISION
		{
			get { return m_division; }
			set
			{
				if (m_division != value)
				{
					m_division = value;
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
