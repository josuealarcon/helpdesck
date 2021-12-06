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
	public partial class Transport 
	{
		#region [ Variables ]
		private String m_patente;
		private Nullable<Int32> m_tipo;
		private String m_color;
		private String m_empresa;
		private String m_anofab;
		private String m_permisocirc;
		private String m_fecseguro;
		private String m_revtec;
		private Nullable<Int16> m_capacidad;
		private String m_operinvier;
		private Nullable<Int16> m_nro;
		private String m_autor;
		private String m_marca;
		private String m_modelo;
		private String m_codmop;
		private String m_fechamod;
		private String m_horamod;
		private String m_grabo;
		private String m_feccheck;
		private String m_fecminera;
		private String m_label;
		private String m_obs;
		private String m_tienewise;
		private String m_funcacargo;
		private String m_funcnom;
		private String m_area;
		private String m_numint;
		private String m_tipo_propietario;
		private String m_rut_propietario;
		private String m_usuario;
		private Nullable<Int32> m_combustible;
		private Nullable<Int32> m_traccion;
		private String m_cilindrada;
		private String m_potencia;
		private String m_turno;
		private String m_servicio;
		private String m_monitoreado;
        private String m_equipoadas;
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Transport.
        /// </summary>
        public Transport()
		{  }
		#endregion

		#region [ Propiedades ]
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
		/// Gets or sets el valor de: TIPO.
		/// </summary>
		public Nullable<Int32> TIPO
		{
			get { return m_tipo; }
			set
			{
				if (m_tipo != value)
				{
					m_tipo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COLOR.
		/// </summary>
		public String COLOR
		{
			get { return m_color; }
			set
			{
				if (m_color != value)
				{
					m_color = value;
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
		/// Gets or sets el valor de: ANOFAB.
		/// </summary>
		public String ANOFAB
		{
			get { return m_anofab; }
			set
			{
				if (m_anofab != value)
				{
					m_anofab = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PERMISOCIRC.
		/// </summary>
		public String PERMISOCIRC
		{
			get { return m_permisocirc; }
			set
			{
				if (m_permisocirc != value)
				{
					m_permisocirc = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECSEGURO.
		/// </summary>
		public String FECSEGURO
		{
			get { return m_fecseguro; }
			set
			{
				if (m_fecseguro != value)
				{
					m_fecseguro = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REVTEC.
		/// </summary>
		public String REVTEC
		{
			get { return m_revtec; }
			set
			{
				if (m_revtec != value)
				{
					m_revtec = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CAPACIDAD.
		/// </summary>
		public Nullable<Int16> CAPACIDAD
		{
			get { return m_capacidad; }
			set
			{
				if (m_capacidad != value)
				{
					m_capacidad = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OPERINVIER.
		/// </summary>
		public String OPERINVIER
		{
			get { return m_operinvier; }
			set
			{
				if (m_operinvier != value)
				{
					m_operinvier = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NRO.
		/// </summary>
		public Nullable<Int16> NRO
		{
			get { return m_nro; }
			set
			{
				if (m_nro != value)
				{
					m_nro = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUTOR.
		/// </summary>
		public String AUTOR
		{
			get { return m_autor; }
			set
			{
				if (m_autor != value)
				{
					m_autor = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MARCA.
		/// </summary>
		public String MARCA
		{
			get { return m_marca; }
			set
			{
				if (m_marca != value)
				{
					m_marca = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MODELO.
		/// </summary>
		public String MODELO
		{
			get { return m_modelo; }
			set
			{
				if (m_modelo != value)
				{
					m_modelo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CODMOP.
		/// </summary>
		public String CODMOP
		{
			get { return m_codmop; }
			set
			{
				if (m_codmop != value)
				{
					m_codmop = value;
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
		/// Gets or sets el valor de: FECCHECK.
		/// </summary>
		public String FECCHECK
		{
			get { return m_feccheck; }
			set
			{
				if (m_feccheck != value)
				{
					m_feccheck = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECMINERA.
		/// </summary>
		public String FECMINERA
		{
			get { return m_fecminera; }
			set
			{
				if (m_fecminera != value)
				{
					m_fecminera = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LABEL.
		/// </summary>
		public String LABEL
		{
			get { return m_label; }
			set
			{
				if (m_label != value)
				{
					m_label = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OBS.
		/// </summary>
		public String OBS
		{
			get { return m_obs; }
			set
			{
				if (m_obs != value)
				{
					m_obs = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIENEWISE.
		/// </summary>
		public String TIENEWISE
		{
			get { return m_tienewise; }
			set
			{
				if (m_tienewise != value)
				{
					m_tienewise = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FUNCACARGO.
		/// </summary>
		public String FUNCACARGO
		{
			get { return m_funcacargo; }
			set
			{
				if (m_funcacargo != value)
				{
					m_funcacargo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FUNCNOM.
		/// </summary>
		public String FUNCNOM
		{
			get { return m_funcnom; }
			set
			{
				if (m_funcnom != value)
				{
					m_funcnom = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AREA.
		/// </summary>
		public String AREA
		{
			get { return m_area; }
			set
			{
				if (m_area != value)
				{
					m_area = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NUMINT.
		/// </summary>
		public String NUMINT
		{
			get { return m_numint; }
			set
			{
				if (m_numint != value)
				{
					m_numint = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_PROPIETARIO.
		/// </summary>
		public String TIPO_PROPIETARIO
		{
			get { return m_tipo_propietario; }
			set
			{
				if (m_tipo_propietario != value)
				{
					m_tipo_propietario = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RUT_PROPIETARIO.
		/// </summary>
		public String RUT_PROPIETARIO
		{
			get { return m_rut_propietario; }
			set
			{
				if (m_rut_propietario != value)
				{
					m_rut_propietario = value;
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
		/// Gets or sets el valor de: COMBUSTIBLE.
		/// </summary>
		public Nullable<Int32> COMBUSTIBLE
		{
			get { return m_combustible; }
			set
			{
				if (m_combustible != value)
				{
					m_combustible = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TRACCION.
		/// </summary>
		public Nullable<Int32> TRACCION
		{
			get { return m_traccion; }
			set
			{
				if (m_traccion != value)
				{
					m_traccion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CILINDRADA.
		/// </summary>
		public String CILINDRADA
		{
			get { return m_cilindrada; }
			set
			{
				if (m_cilindrada != value)
				{
					m_cilindrada = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: POTENCIA.
		/// </summary>
		public String POTENCIA
		{
			get { return m_potencia; }
			set
			{
				if (m_potencia != value)
				{
					m_potencia = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TURNO.
		/// </summary>
		public String TURNO
		{
			get { return m_turno; }
			set
			{
				if (m_turno != value)
				{
					m_turno = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERVICIO.
		/// </summary>
		public String SERVICIO
		{
			get { return m_servicio; }
			set
			{
				if (m_servicio != value)
				{
					m_servicio = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MONITOREADO.
		/// </summary>
		public String MONITOREADO
		{
			get { return m_monitoreado; }
			set
			{
				if (m_monitoreado != value)
				{
					m_monitoreado = value;
				}
			}
		}
        /// <summary>
		/// Gets or sets el valor de: EQUIPOADAS.
		/// </summary>
		public String EQUIPOADAS
        {
            get { return m_equipoadas; }
            set
            {
                if (m_equipoadas != value)
                {
                    m_equipoadas = value;
                }
            }
        }
        public int KILOMETRAJE { get; set; }
        public int IDTRACCION { get; set; }
        public int IDCOMBUSTIBLE { get; set; }

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
