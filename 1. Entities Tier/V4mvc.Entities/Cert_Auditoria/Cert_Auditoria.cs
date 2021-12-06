using System;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Cert_Auditoria
    {

		#region [ Variables ]

		private Int32 m_id_cert_auditoria;
		private String m_idempresa;
		private String m_periodo;
		private String m_fecha;
		private Guid m_id;
		private String m_tipo_auditoria;
		private Nullable<Int32> m_porcentaje_aprobacion;
		private Nullable<Int32> m_cant_personas;
		private String m_validado;
		private String m_observacion;
		private String m_usuario;
		private String m_fechasube;
		private String m_horasube;
		private String m_certusuario;
		private String m_certfecha;
		private String m_certhora;
		private String m_usuariomod;
		private String m_fechamod;
		private String m_horamod;
		private String m_ncontrato;
		private String m_division;
		private String m_cod_interno_cert;
		private Nullable<Int32> m_id_folio;

		#endregion

		#region[ Constructores ]

		/// <summary>
		/// Inicializar una nueva instancia de la clase Cert_Auditoria.
		/// </summary>
		public Cert_Auditoria()
		{ }

		#endregion

		#region [ Propiedades ]

		/// <summary>
		/// Gets or sets el valor de: ID_CERT_AUDITORIA.
		/// </summary>
		public Int32 ID_CERT_AUDITORIA
		{
			get { return m_id_cert_auditoria; }
			set
			{
				if (m_id_cert_auditoria != value)
				{
					m_id_cert_auditoria = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDEMPRESA.
		/// </summary>
		public String IDEMPRESA
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
		/// Gets or sets el valor de: PERIODO.
		/// </summary>
		public String PERIODO
		{
			get { return m_periodo; }
			set
			{
				if (m_periodo != value)
				{
					m_periodo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHA.
		/// </summary>
		public String FECHA
		{
			get { return m_fecha; }
			set
			{
				if (m_fecha != value)
				{
					m_fecha = value;
				}
			}
		}
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
		/// Gets or sets el valor de: TIPO_AUDITORIA.
		/// </summary>
		public String TIPO_AUDITORIA
		{
			get { return m_tipo_auditoria; }
			set
			{
				if (m_tipo_auditoria != value)
				{
					m_tipo_auditoria = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PORCENTAJE_APROBACION.
		/// </summary>
		public Nullable<Int32> PORCENTAJE_APROBACION
		{
			get { return m_porcentaje_aprobacion; }
			set
			{
				if (m_porcentaje_aprobacion != value)
				{
					m_porcentaje_aprobacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CANT_PERSONAS.
		/// </summary>
		public Nullable<Int32> CANT_PERSONAS
		{
			get { return m_cant_personas; }
			set
			{
				if (m_cant_personas != value)
				{
					m_cant_personas = value;
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
		/// Gets or sets el valor de: USUARIOMOD.
		/// </summary>
		public String USUARIOMOD
		{
			get { return m_usuariomod; }
			set
			{
				if (m_usuariomod != value)
				{
					m_usuariomod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHAMOD.
		/// </summary>
		public String FECHAMOD
		{
			get { return m_fechamod; }
			set
			{
				if (m_fechamod != value)
				{
					m_fechamod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORAMOD.
		/// </summary>
		public String HORAMOD
		{
			get { return m_horamod; }
			set
			{
				if (m_horamod != value)
				{
					m_horamod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NCONTRATO.
		/// </summary>
		public String NCONTRATO
		{
			get { return m_ncontrato; }
			set
			{
				if (m_ncontrato != value)
				{
					m_ncontrato = value;
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
		/// Gets or sets el valor de: COD_INTERNO_CERT.
		/// </summary>
		public String COD_INTERNO_CERT
		{
			get { return m_cod_interno_cert; }
			set
			{
				if (m_cod_interno_cert != value)
				{
					m_cod_interno_cert = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_FOLIO.
		/// </summary>
		public Nullable<Int32> ID_FOLIO
		{
			get { return m_id_folio; }
			set
			{
				if (m_id_folio != value)
				{
					m_id_folio = value;
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
