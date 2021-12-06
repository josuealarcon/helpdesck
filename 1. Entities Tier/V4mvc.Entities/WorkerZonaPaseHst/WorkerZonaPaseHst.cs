
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class WorkerZonaPaseHst
    {
        #region [ Variables ]
        
    	private String m_fechacreacion;
	
    	private String m_fechamod;
	
    	private String m_empresa;
	
    	private String m_horacreacion;
	
    	private String m_horamod;
	
    	private String m_usuariocreacion;
	
    	private Nullable<Int32> m_lotenum;
	
    	private String m_usuariomod;
	
    	private String m_local;
	
    	private String m_rut;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase WorkerZonaPaseHst.
        /// </summary>
        public WorkerZonaPaseHst()
        { }
		#endregion

		#region [ Propiedades ]

		
		/// <summary>
		/// Gets or sets el valor de: FECHACREACION.
		/// </summary>
		public String FECHACREACION
		{
			get { return m_fechacreacion; }
			set
			{
				if (m_fechacreacion != value)
				{
					m_fechacreacion = value;
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
		/// Gets or sets el valor de: HORACREACION.
		/// </summary>
		public String HORACREACION
		{
			get { return m_horacreacion; }
			set
			{
				if (m_horacreacion != value)
				{
					m_horacreacion = value;
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
		/// Gets or sets el valor de: USUARIOCREACION.
		/// </summary>
		public String USUARIOCREACION
		{
			get { return m_usuariocreacion; }
			set
			{
				if (m_usuariocreacion != value)
				{
					m_usuariocreacion = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: LOTENUM.
		/// </summary>
		public Nullable<Int32> LOTENUM
		{
			get { return m_lotenum; }
			set
			{
				if (m_lotenum != value)
				{
					m_lotenum = value;
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
	