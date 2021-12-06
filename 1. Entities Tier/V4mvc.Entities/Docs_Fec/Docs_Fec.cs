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
	public partial class Docs_Fec 
	{
		#region [ Variables ]
		private Int32 m_id_doc_fec;
		private String m_nombre;
		private Nullable<Int32> m_id_doc_depend;
		private String m_campo_bd;
		private String m_activo;
		private String m_whoupdate;
		private Nullable<Int32> m_valido_mayor_hoy;
		private Nullable<Int32> m_orden;
		private Nullable<Int32> m_comun;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Docs_Fec.
		/// </summary>
		public Docs_Fec()
		{  }
		#endregion

		#region [ Propiedades ]
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
		/// <summary>
		/// Gets or sets el valor de: ID_DOC_DEPEND.
		/// </summary>
		public Nullable<Int32> ID_DOC_DEPEND
		{
			get { return m_id_doc_depend; }
			set
			{
				if (m_id_doc_depend != value)
				{
					m_id_doc_depend = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CAMPO_BD.
		/// </summary>
		public String CAMPO_BD
		{
			get { return m_campo_bd; }
			set
			{
				if (m_campo_bd != value)
				{
					m_campo_bd = value;
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
		/// Gets or sets el valor de: WHOUPDATE.
		/// </summary>
		public String WHOUPDATE
		{
			get { return m_whoupdate; }
			set
			{
				if (m_whoupdate != value)
				{
					m_whoupdate = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: VALIDO_MAYOR_HOY.
		/// </summary>
		public Nullable<Int32> VALIDO_MAYOR_HOY
		{
			get { return m_valido_mayor_hoy; }
			set
			{
				if (m_valido_mayor_hoy != value)
				{
					m_valido_mayor_hoy = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ORDEN.
		/// </summary>
		public Nullable<Int32> ORDEN
		{
			get { return m_orden; }
			set
			{
				if (m_orden != value)
				{
					m_orden = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COMUN.
		/// </summary>
		public Nullable<Int32> COMUN
		{
			get { return m_comun; }
			set
			{
				if (m_comun != value)
				{
					m_comun = value;
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
