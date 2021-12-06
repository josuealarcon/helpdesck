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
	public partial class Docs_Tipo_Rechazo
	{
		#region [ Variables ]
		private Int32 m_id_tipo_rechazo;
		private String m_tipo_rechazo;
		private Nullable<Int32> m_id_doc;
		private String m_explicacion;
		private String m_link_explicacion;
		private String m_ver_check;
		private String m_titulo_check;
		private String m_explicacion_check;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Docs_Tipo_Rechazo.
		/// </summary>
		public Docs_Tipo_Rechazo()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ID_TIPO_RECHAZO.
		/// </summary>
		public Int32 ID_TIPO_RECHAZO
		{
			get { return m_id_tipo_rechazo; }
			set
			{
				if (m_id_tipo_rechazo != value)
				{
					m_id_tipo_rechazo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_RECHAZO.
		/// </summary>
		public String TIPO_RECHAZO
		{
			get { return m_tipo_rechazo; }
			set
			{
				if (m_tipo_rechazo != value)
				{
					m_tipo_rechazo = value;
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
		/// <summary>
		/// Gets or sets el valor de: EXPLICACION.
		/// </summary>
		public String EXPLICACION
		{
			get { return m_explicacion; }
			set
			{
				if (m_explicacion != value)
				{
					m_explicacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LINK_EXPLICACION.
		/// </summary>
		public String LINK_EXPLICACION
		{
			get { return m_link_explicacion; }
			set
			{
				if (m_link_explicacion != value)
				{
					m_link_explicacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: VER_CHECK.
		/// </summary>
		public String VER_CHECK
		{
			get { return m_ver_check; }
			set
			{
				if (m_ver_check != value)
				{
					m_ver_check = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TITULO_CHECK.
		/// </summary>
		public String TITULO_CHECK
		{
			get { return m_titulo_check; }
			set
			{
				if (m_titulo_check != value)
				{
					m_titulo_check = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EXPLICACION_CHECK.
		/// </summary>
		public String EXPLICACION_CHECK
		{
			get { return m_explicacion_check; }
			set
			{
				if (m_explicacion_check != value)
				{
					m_explicacion_check = value;
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
