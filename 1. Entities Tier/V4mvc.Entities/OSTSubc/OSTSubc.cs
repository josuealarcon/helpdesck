
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class OSTSubc
    {
        #region [ Variables ]
        
    	private Nullable<Int16> m_nivel;
	
    	private String m_empresa;
	
    	private Nullable<Int32> m_validador;
	
    	private String m_ftermino;
	
    	private String m_acronimomadre;
	
    	private String m_ost;
	
    	private String m_madre;
	
    	private String m_esporadico;
	
    	private String m_finicio;
	
    	private String m_adminnomb;
	
    	private String m_acronimo;
	
    	private String m_autor;
	
    	private String m_adminost;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase OSTSubc.
        /// </summary>
        public OSTSubc()
        { }
		#endregion

		#region [ Propiedades ]

		
		/// <summary>
		/// Gets or sets el valor de: NIVEL.
		/// </summary>
		public Nullable<Int16> NIVEL
		{
			get { return m_nivel; }
			set
			{
				if (m_nivel != value)
				{
					m_nivel = value;
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
		/// Gets or sets el valor de: VALIDADOR.
		/// </summary>
		public Nullable<Int32> VALIDADOR
		{
			get { return m_validador; }
			set
			{
				if (m_validador != value)
				{
					m_validador = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: FTERMINO.
		/// </summary>
		public String FTERMINO
		{
			get { return m_ftermino; }
			set
			{
				if (m_ftermino != value)
				{
					m_ftermino = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ACRONIMOMADRE.
		/// </summary>
		public String ACRONIMOMADRE
		{
			get { return m_acronimomadre; }
			set
			{
				if (m_acronimomadre != value)
				{
					m_acronimomadre = value;
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
		/// Gets or sets el valor de: MADRE.
		/// </summary>
		public String MADRE
		{
			get { return m_madre; }
			set
			{
				if (m_madre != value)
				{
					m_madre = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ESPORADICO.
		/// </summary>
		public String ESPORADICO
		{
			get { return m_esporadico; }
			set
			{
				if (m_esporadico != value)
				{
					m_esporadico = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: FINICIO.
		/// </summary>
		public String FINICIO
		{
			get { return m_finicio; }
			set
			{
				if (m_finicio != value)
				{
					m_finicio = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ADMINNOMB.
		/// </summary>
		public String ADMINNOMB
		{
			get { return m_adminnomb; }
			set
			{
				if (m_adminnomb != value)
				{
					m_adminnomb = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ACRONIMO.
		/// </summary>
		public String ACRONIMO
		{
			get { return m_acronimo; }
			set
			{
				if (m_acronimo != value)
				{
					m_acronimo = value;
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
	