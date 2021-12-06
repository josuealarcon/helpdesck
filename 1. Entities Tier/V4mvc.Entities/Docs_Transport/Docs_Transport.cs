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
	public partial class Docs_Transport
	{
		#region [ Variables ]
		private Int32 m_id_docs_veh;
		private String m_patente;
		private Nullable<Int32> m_id_doc;
		private String m_nombre_archivo;
		private String m_fecha_mod;
		private String m_hora_mod;
		private String m_tipo_contenido;
		private byte[] m_archivo;
		private String m_usuario;
		private Nullable<Int16> m_cantidad;
		private String m_grabo;
		private Nullable<Guid> m_id;
		private String m_validado;
		private String m_certusuario;
		private String m_certfecha;
		private String m_certhora;
		private String m_division;
		private String m_empresa;
		private String m_certusuario2;
		private String m_certfecha2;
		private String m_certhora2;
		private String m_validado2;
		private String m_fechasube;
		private String m_horasube;
		private String m_observacion;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Docs_Transport.
		/// </summary>
		public Docs_Transport()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ID_DOCS_VEH.
		/// </summary>
		public Int32 ID_DOCS_VEH
		{
			get { return m_id_docs_veh; }
			set
			{
				if (m_id_docs_veh != value)
				{
					m_id_docs_veh = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PATENTE.
		/// </summary>
		public String PATENTE
		{
			get { return m_patente; }
			set
			{
				if (m_patente != value)
				{
					m_patente = value;
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
		/// Gets or sets el valor de: NOMBRE_ARCHIVO.
		/// </summary>
		public String NOMBRE_ARCHIVO
		{
			get { return m_nombre_archivo; }
			set
			{
				if (m_nombre_archivo != value)
				{
					m_nombre_archivo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHA_MOD.
		/// </summary>
		public String FECHA_MOD
		{
			get { return m_fecha_mod; }
			set
			{
				if (m_fecha_mod != value)
				{
					m_fecha_mod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORA_MOD.
		/// </summary>
		public String HORA_MOD
		{
			get { return m_hora_mod; }
			set
			{
				if (m_hora_mod != value)
				{
					m_hora_mod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CONTENIDO.
		/// </summary>
		public String TIPO_CONTENIDO
		{
			get { return m_tipo_contenido; }
			set
			{
				if (m_tipo_contenido != value)
				{
					m_tipo_contenido = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ARCHIVO.
		/// </summary>
		public byte[] ARCHIVO
		{
			get { return m_archivo; }
			set
			{
				if (m_archivo != value)
				{
					m_archivo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USUARIO.
		/// </summary>
		public String USUARIO
		{
			get { return m_usuario; }
			set
			{
				if (m_usuario != value)
				{
					m_usuario = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CANTIDAD.
		/// </summary>
		public Nullable<Int16> CANTIDAD
		{
			get { return m_cantidad; }
			set
			{
				if (m_cantidad != value)
				{
					m_cantidad = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GRABO.
		/// </summary>
		public String GRABO
		{
			get { return m_grabo; }
			set
			{
				if (m_grabo != value)
				{
					m_grabo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Nullable<Guid> ID
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
		/// Gets or sets el valor de: VALIDADO.
		/// </summary>
		public String VALIDADO
		{
			get { return m_validado; }
			set
			{
				if (m_validado != value)
				{
					m_validado = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CERTUSUARIO.
		/// </summary>
		public String CERTUSUARIO
		{
			get { return m_certusuario; }
			set
			{
				if (m_certusuario != value)
				{
					m_certusuario = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CERTFECHA.
		/// </summary>
		public String CERTFECHA
		{
			get { return m_certfecha; }
			set
			{
				if (m_certfecha != value)
				{
					m_certfecha = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CERTHORA.
		/// </summary>
		public String CERTHORA
		{
			get { return m_certhora; }
			set
			{
				if (m_certhora != value)
				{
					m_certhora = value;
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
		/// <summary>
		/// Gets or sets el valor de: EMPRESA.
		/// </summary>
		public String EMPRESA
		{
			get { return m_empresa; }
			set
			{
				if (m_empresa != value)
				{
					m_empresa = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CERTUSUARIO2.
		/// </summary>
		public String CERTUSUARIO2
		{
			get { return m_certusuario2; }
			set
			{
				if (m_certusuario2 != value)
				{
					m_certusuario2 = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CERTFECHA2.
		/// </summary>
		public String CERTFECHA2
		{
			get { return m_certfecha2; }
			set
			{
				if (m_certfecha2 != value)
				{
					m_certfecha2 = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CERTHORA2.
		/// </summary>
		public String CERTHORA2
		{
			get { return m_certhora2; }
			set
			{
				if (m_certhora2 != value)
				{
					m_certhora2 = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: VALIDADO2.
		/// </summary>
		public String VALIDADO2
		{
			get { return m_validado2; }
			set
			{
				if (m_validado2 != value)
				{
					m_validado2 = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHASUBE.
		/// </summary>
		public String FECHASUBE
		{
			get { return m_fechasube; }
			set
			{
				if (m_fechasube != value)
				{
					m_fechasube = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORASUBE.
		/// </summary>
		public String HORASUBE
		{
			get { return m_horasube; }
			set
			{
				if (m_horasube != value)
				{
					m_horasube = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OBSERVACION.
		/// </summary>
		public String OBSERVACION
		{
			get { return m_observacion; }
			set
			{
				if (m_observacion != value)
				{
					m_observacion = value;
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
		
		protected void RefreshInstanceEntity()
		{
			if (Instance != InstanceEntity.New && Instance != InstanceEntity.Delete)
			{ Instance = InstanceEntity.Modify; }
		}
		#endregion

	}
}
