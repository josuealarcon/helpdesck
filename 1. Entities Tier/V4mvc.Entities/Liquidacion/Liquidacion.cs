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
	public partial class Liquidacion 
	{
		#region [ Variables ]
		private String m_rut;
		private String m_fecha;
		private String m_nombre_archivo;
		private String m_tipo_contenido;
		private byte[] m_archivo;
		private String m_fechasube;
		private String m_horasube;
		private String m_usuario;
		private String m_validado;
		private String m_certusuario;
		private String m_certfecha;
		private String m_certhora;
		private Nullable<Int32> m_idrechazo;
		private Nullable<Guid> m_id;
		private Nullable<Int32> m_imponible;
		private Nullable<Int32> m_liquido;
		private Nullable<Int32> m_transferido;
		private String m_empresa;
		private Nullable<Int32> m_bonoip;
		private Nullable<Int32> m_bonois;
		private Nullable<Int32> m_sueldobase;
		private Nullable<Int32> m_gratificacion;
		private String m_fechacsv;
		private String m_horacsv;
		private String m_usuariocsv;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Liquidacion.
		/// </summary>
		public Liquidacion()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: RUT.
		/// </summary>
		public String RUT
		{
			get { return m_rut; }
			set
			{
				if (m_rut != value)
				{
					m_rut = value;
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
		/// Gets or sets el valor de: IDRECHAZO.
		/// </summary>
		public Nullable<Int32> IDRECHAZO
		{
			get { return m_idrechazo; }
			set
			{
				if (m_idrechazo != value)
				{
					m_idrechazo = value;
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
		/// Gets or sets el valor de: IMPONIBLE.
		/// </summary>
		public Nullable<Int32> IMPONIBLE
		{
			get { return m_imponible; }
			set
			{
				if (m_imponible != value)
				{
					m_imponible = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LIQUIDO.
		/// </summary>
		public Nullable<Int32> LIQUIDO
		{
			get { return m_liquido; }
			set
			{
				if (m_liquido != value)
				{
					m_liquido = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TRANSFERIDO.
		/// </summary>
		public Nullable<Int32> TRANSFERIDO
		{
			get { return m_transferido; }
			set
			{
				if (m_transferido != value)
				{
					m_transferido = value;
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
		/// Gets or sets el valor de: BONOIP.
		/// </summary>
		public Nullable<Int32> BONOIP
		{
			get { return m_bonoip; }
			set
			{
				if (m_bonoip != value)
				{
					m_bonoip = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: BONOIS.
		/// </summary>
		public Nullable<Int32> BONOIS
		{
			get { return m_bonois; }
			set
			{
				if (m_bonois != value)
				{
					m_bonois = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHACSV.
		/// </summary>
		public Nullable<Int32> SUELDOBASE
		{
			get { return m_sueldobase; }
			set
			{
				if (m_sueldobase != value)
				{
					m_sueldobase = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: BONOIS.
		/// </summary>
		public Nullable<Int32> GRATIFICACION
		{
			get { return m_gratificacion; }
			set
			{
				if (m_gratificacion != value)
				{
					m_gratificacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHACSV.
		/// </summary>
		public String FECHACSV
		{
			get { return m_fechacsv; }
			set
			{
				if (m_fechacsv != value)
				{
					m_fechacsv = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORACSV.
		/// </summary>
		public String HORACSV
		{
			get { return m_horacsv; }
			set
			{
				if (m_horacsv != value)
				{
					m_horacsv = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USUARIOCSV.
		/// </summary>
		public String USUARIOCSV
		{
			get { return m_usuariocsv; }
			set
			{
				if (m_usuariocsv != value)
				{
					m_usuariocsv = value;
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
