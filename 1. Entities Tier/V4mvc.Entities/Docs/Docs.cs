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
	public partial class Docs 
	{
		#region [ Variables ]
		private Int32 m_id_doc;
		private String m_nombre;
		private String m_ruta;
		private String m_campo;
		private String m_activo;
		private Nullable<Int32> m_id_doc_opcion;
		private Nullable<Int32> m_id_tipo_propietario;
		private String m_confidencial;
		private Nullable<Int32> m_identificador_foto;
		private String m_subedoc;
		private String m_whoupdate;
		private String m_short;
		private Nullable<Int32> m_orden;
		private Nullable<Int32> m_comun;
		private String m_especifico;
		private String m_url_especifico;
		private String m_url_ctrllaboral;
		private String m_url_ctrllaboral_v4;
		private String m_comun_div;
		private String m_urldonde;
		private String m_urlcomo;
		private Nullable<Int32> m_porcentaje_audit;
		private String m_validamandante;
		private String m_especifico_ver_ost;
		private String m_especifico_ver_resolucion;
		private Nullable<Int32> m_id_tipo_especifico;
		private String m_validasubcontratista;
		private String m_tipodoc_audit;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Docs.
		/// </summary>
		public Docs()
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
		/// Gets or sets el valor de: RUTA.
		/// </summary>
		public String RUTA
		{
			get { return m_ruta; }
			set
			{
				if (m_ruta != value)
				{
					m_ruta = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CAMPO.
		/// </summary>
		public String CAMPO
		{
			get { return m_campo; }
			set
			{
				if (m_campo != value)
				{
					m_campo = value;
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
		/// Gets or sets el valor de: ID_DOC_OPCION.
		/// </summary>
		public Nullable<Int32> ID_DOC_OPCION
		{
			get { return m_id_doc_opcion; }
			set
			{
				if (m_id_doc_opcion != value)
				{
					m_id_doc_opcion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_TIPO_PROPIETARIO.
		/// </summary>
		public Nullable<Int32> ID_TIPO_PROPIETARIO
		{
			get { return m_id_tipo_propietario; }
			set
			{
				if (m_id_tipo_propietario != value)
				{
					m_id_tipo_propietario = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONFIDENCIAL.
		/// </summary>
		public String CONFIDENCIAL
		{
			get { return m_confidencial; }
			set
			{
				if (m_confidencial != value)
				{
					m_confidencial = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDENTIFICADOR_FOTO.
		/// </summary>
		public Nullable<Int32> IDENTIFICADOR_FOTO
		{
			get { return m_identificador_foto; }
			set
			{
				if (m_identificador_foto != value)
				{
					m_identificador_foto = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SUBEDOC.
		/// </summary>
		public String SUBEDOC
		{
			get { return m_subedoc; }
			set
			{
				if (m_subedoc != value)
				{
					m_subedoc = value;
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
		/// Gets or sets el valor de: SHORT.
		/// </summary>
		public String SHORT
		{
			get { return m_short; }
			set
			{
				if (m_short != value)
				{
					m_short = value;
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
		/// <summary>
		/// Gets or sets el valor de: ESPECIFICO.
		/// </summary>
		public String ESPECIFICO
		{
			get { return m_especifico; }
			set
			{
				if (m_especifico != value)
				{
					m_especifico = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: URL_ESPECIFICO.
		/// </summary>
		public String URL_ESPECIFICO
		{
			get { return m_url_especifico; }
			set
			{
				if (m_url_especifico != value)
				{
					m_url_especifico = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: URL_CTRLLABORAL.
		/// </summary>
		public String URL_CTRLLABORAL
		{
			get { return m_url_ctrllaboral; }
			set
			{
				if (m_url_ctrllaboral != value)
				{
					m_url_ctrllaboral = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: URL_CTRLLABORAL_V4.
		/// </summary>
		public String URL_CTRLLABORAL_V4
		{
			get { return m_url_ctrllaboral_v4; }
			set
			{
				if (m_url_ctrllaboral_v4 != value)
				{
					m_url_ctrllaboral_v4 = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COMUN_DIV.
		/// </summary>
		public String COMUN_DIV
		{
			get { return m_comun_div; }
			set
			{
				if (m_comun_div != value)
				{
					m_comun_div = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: URLDONDE.
		/// </summary>
		public String URLDONDE
		{
			get { return m_urldonde; }
			set
			{
				if (m_urldonde != value)
				{
					m_urldonde = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: URLCOMO.
		/// </summary>
		public String URLCOMO
		{
			get { return m_urlcomo; }
			set
			{
				if (m_urlcomo != value)
				{
					m_urlcomo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PORCENTAJE_AUDIT.
		/// </summary>
		public Nullable<Int32> PORCENTAJE_AUDIT
		{
			get { return m_porcentaje_audit; }
			set
			{
				if (m_porcentaje_audit != value)
				{
					m_porcentaje_audit = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: VALIDAMANDANTE.
		/// </summary>
		public String VALIDAMANDANTE
		{
			get { return m_validamandante; }
			set
			{
				if (m_validamandante != value)
				{
					m_validamandante = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ESPECIFICO_VER_OST.
		/// </summary>
		public String ESPECIFICO_VER_OST
		{
			get { return m_especifico_ver_ost; }
			set
			{
				if (m_especifico_ver_ost != value)
				{
					m_especifico_ver_ost = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ESPECIFICO_VER_RESOLUCION.
		/// </summary>
		public String ESPECIFICO_VER_RESOLUCION
		{
			get { return m_especifico_ver_resolucion; }
			set
			{
				if (m_especifico_ver_resolucion != value)
				{
					m_especifico_ver_resolucion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_TIPO_ESPECIFICO.
		/// </summary>
		public Nullable<Int32> ID_TIPO_ESPECIFICO
		{
			get { return m_id_tipo_especifico; }
			set
			{
				if (m_id_tipo_especifico != value)
				{
					m_id_tipo_especifico = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: VALIDASUBCONTRATISTA.
		/// </summary>
		public String VALIDASUBCONTRATISTA
		{
			get { return m_validasubcontratista; }
			set
			{
				if (m_validasubcontratista != value)
				{
					m_validasubcontratista = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPODOC_AUDIT.
		/// </summary>
		public String TIPODOC_AUDIT
		{
			get { return m_tipodoc_audit; }
			set
			{
				if (m_tipodoc_audit != value)
				{
					m_tipodoc_audit = value;
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
