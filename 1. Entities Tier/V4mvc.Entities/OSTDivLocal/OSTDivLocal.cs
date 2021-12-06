
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class OSTDivLocal
    {
        #region [ Variables ]
        
    	private String m_glosa2;
	
    	private String m_division;
	
    	private String m_empresa;
	
    	private String m_mandante;
	
    	private String m_idgerencia;
	
    	private String m_ost;
	
    	private String m_activo;
	
    	private String m_ccosto;
	
    	private String m_admincontr;
	
    	private String m_local;
	
    	private String m_adminost;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase OSTDivLocal.
        /// </summary>
        public OSTDivLocal()
        { }
		#endregion

		#region [ Propiedades ]

		
		/// <summary>
		/// Gets or sets el valor de: GLOSA2.
		/// </summary>
		public String GLOSA2
		{
			get { return m_glosa2; }
			set
			{
				if (m_glosa2 != value)
				{
					m_glosa2 = value;
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
		/// Gets or sets el valor de: MANDANTE.
		/// </summary>
		public String MANDANTE
		{
			get { return m_mandante; }
			set
			{
				if (m_mandante != value)
				{
					m_mandante = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: IDGERENCIA.
		/// </summary>
		public String IDGERENCIA
		{
			get { return m_idgerencia; }
			set
			{
				if (m_idgerencia != value)
				{
					m_idgerencia = value;
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
		/// Gets or sets el valor de: CCOSTO.
		/// </summary>
		public String CCOSTO
		{
			get { return m_ccosto; }
			set
			{
				if (m_ccosto != value)
				{
					m_ccosto = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ADMINCONTR.
		/// </summary>
		public String ADMINCONTR
		{
			get { return m_admincontr; }
			set
			{
				if (m_admincontr != value)
				{
					m_admincontr = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: LOCAL.
		/// </summary>
		public String LOCAL
		{
			get { return m_local; }
			set
			{
				if (m_local != value)
				{
					m_local = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ADMINOST.
		/// </summary>
		public String ADMINOST
		{
			get { return m_adminost; }
			set
			{
				if (m_adminost != value)
				{
					m_adminost = value;
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
	