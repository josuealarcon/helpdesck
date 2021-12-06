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
	public partial class Mutualidad 
	{
		#region [ Variables ]
		private Int32 m_idmutual;
		private String m_mutual;
		private Nullable<Int32> m_id_doc;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Mutualidad.
		/// </summary>
		public Mutualidad()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: IDMUTUAL.
		/// </summary>
		public Int32 IDMUTUAL
		{
			get { return m_idmutual; }
			set
			{
				if (m_idmutual != value)
				{
					m_idmutual = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MUTUAL.
		/// </summary>
		public String MUTUAL
		{
			get { return m_mutual; }
			set
			{
				if (m_mutual != value)
				{
					m_mutual = value;
				}
			}
		}
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
