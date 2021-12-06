
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class A024_Divisiones
    {
        #region [ Variables ]
        
    	private String m_division;
	
    	private String m_empresa;
	
    	private String m_pais;
	
    	private String m_divcod;
	
    	private String m_ctrl_carranque;
	
    	private String m_ctrl_adas;
	
    	private String m_ost;
	
    	private String m_localinout;
	
    	private String m_ctrl_blausentes;
	
    	private String m_control_seguridad;
	
    	private String m_activo;
	
    	private String m_pases_vehiculares;
	
    	private String m_ctrl_conducc;
	
    	private String m_tarjeta;
	
    	private String m_glosa;
	
    	private String m_ctrl_lic_conduc;
	
    	private String m_visita;
	
    	private String m_periodovisita;
	
    	private String m_ctrl_licint;
	
    	private Nullable<Int32> m_cantvisita;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase A024_Divisiones.
        /// </summary>
        public A024_Divisiones()
        { }
		#endregion

		#region [ Propiedades ]

		
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
		/// Gets or sets el valor de: PAIS.
		/// </summary>
		public String PAIS
		{
			get { return m_pais; }
			set
			{
				if (m_pais != value)
				{
					m_pais = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: DIVCOD.
		/// </summary>
		public String DIVCOD
		{
			get { return m_divcod; }
			set
			{
				if (m_divcod != value)
				{
					m_divcod = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: CTRL_CARRANQUE.
		/// </summary>
		public String CTRL_CARRANQUE
		{
			get { return m_ctrl_carranque; }
			set
			{
				if (m_ctrl_carranque != value)
				{
					m_ctrl_carranque = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: CTRL_ADAS.
		/// </summary>
		public String CTRL_ADAS
		{
			get { return m_ctrl_adas; }
			set
			{
				if (m_ctrl_adas != value)
				{
					m_ctrl_adas = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: OST.
		/// </summary>
		public String OST
		{
			get { return m_ost; }
			set
			{
				if (m_ost != value)
				{
					m_ost = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: LOCALINOUT.
		/// </summary>
		public String LOCALINOUT
		{
			get { return m_localinout; }
			set
			{
				if (m_localinout != value)
				{
					m_localinout = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: CTRL_BLAUSENTES.
		/// </summary>
		public String CTRL_BLAUSENTES
		{
			get { return m_ctrl_blausentes; }
			set
			{
				if (m_ctrl_blausentes != value)
				{
					m_ctrl_blausentes = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: CONTROL_SEGURIDAD.
		/// </summary>
		public String CONTROL_SEGURIDAD
		{
			get { return m_control_seguridad; }
			set
			{
				if (m_control_seguridad != value)
				{
					m_control_seguridad = value;
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
		/// Gets or sets el valor de: PASES_VEHICULARES.
		/// </summary>
		public String PASES_VEHICULARES
		{
			get { return m_pases_vehiculares; }
			set
			{
				if (m_pases_vehiculares != value)
				{
					m_pases_vehiculares = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: CTRL_CONDUCC.
		/// </summary>
		public String CTRL_CONDUCC
		{
			get { return m_ctrl_conducc; }
			set
			{
				if (m_ctrl_conducc != value)
				{
					m_ctrl_conducc = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: TARJETA.
		/// </summary>
		public String TARJETA
		{
			get { return m_tarjeta; }
			set
			{
				if (m_tarjeta != value)
				{
					m_tarjeta = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: GLOSA.
		/// </summary>
		public String GLOSA
		{
			get { return m_glosa; }
			set
			{
				if (m_glosa != value)
				{
					m_glosa = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: CTRL_LIC_CONDUC.
		/// </summary>
		public String CTRL_LIC_CONDUC
		{
			get { return m_ctrl_lic_conduc; }
			set
			{
				if (m_ctrl_lic_conduc != value)
				{
					m_ctrl_lic_conduc = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: VISITA.
		/// </summary>
		public String VISITA
		{
			get { return m_visita; }
			set
			{
				if (m_visita != value)
				{
					m_visita = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: PERIODOVISITA.
		/// </summary>
		public String PERIODOVISITA
		{
			get { return m_periodovisita; }
			set
			{
				if (m_periodovisita != value)
				{
					m_periodovisita = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: CTRL_LICINT.
		/// </summary>
		public String CTRL_LICINT
		{
			get { return m_ctrl_licint; }
			set
			{
				if (m_ctrl_licint != value)
				{
					m_ctrl_licint = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: CANTVISITA.
		/// </summary>
		public Nullable<Int32> CANTVISITA
		{
			get { return m_cantvisita; }
			set
			{
				if (m_cantvisita != value)
				{
					m_cantvisita = value;
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
	