
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Parametros_V2
    {
        #region [ Variables ]
        
    	private String m_valor1;
	
    	private String m_valor2;
	
    	private String m_valor3;
	
    	private String m_horamod;
	
    	private String m_fechamod;
	
    	private String m_titulo2;
	
    	private String m_titulo3;
	
    	private String m_titulo1;
	
    	private String m_descripcion;
	
    	private String m_activatask;
	
    	private Int32 m_id_parametro;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Parametros_V2.
        /// </summary>
        public Parametros_V2()
        { }
		#endregion

		#region [ Propiedades ]

		
		/// <summary>
		/// Gets or sets el valor de: Valor1.
		/// </summary>
		public String Valor1
		{
			get { return m_valor1; }
			set
			{
				if (m_valor1 != value)
				{
					m_valor1 = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: Valor2.
		/// </summary>
		public String Valor2
		{
			get { return m_valor2; }
			set
			{
				if (m_valor2 != value)
				{
					m_valor2 = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: Valor3.
		/// </summary>
		public String Valor3
		{
			get { return m_valor3; }
			set
			{
				if (m_valor3 != value)
				{
					m_valor3 = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: HoraMod.
		/// </summary>
		public String HoraMod
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
		/// Gets or sets el valor de: FechaMod.
		/// </summary>
		public String FechaMod
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
		/// Gets or sets el valor de: Titulo2.
		/// </summary>
		public String Titulo2
		{
			get { return m_titulo2; }
			set
			{
				if (m_titulo2 != value)
				{
					m_titulo2 = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: Titulo3.
		/// </summary>
		public String Titulo3
		{
			get { return m_titulo3; }
			set
			{
				if (m_titulo3 != value)
				{
					m_titulo3 = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: Titulo1.
		/// </summary>
		public String Titulo1
		{
			get { return m_titulo1; }
			set
			{
				if (m_titulo1 != value)
				{
					m_titulo1 = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: Descripcion.
		/// </summary>
		public String Descripcion
		{
			get { return m_descripcion; }
			set
			{
				if (m_descripcion != value)
				{
					m_descripcion = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ACTIVATASK.
		/// </summary>
		public String ACTIVATASK
		{
			get { return m_activatask; }
			set
			{
				if (m_activatask != value)
				{
					m_activatask = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: Id_Parametro.
		/// </summary>
		public Int32 Id_Parametro
		{
			get { return m_id_parametro; }
			set
			{
				if (m_id_parametro != value)
				{
					m_id_parametro = value;
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
	