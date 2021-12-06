
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class InstalacionFaena
    {
        #region [ Variables ]
        
    	private String m_horaregistro;
	
    	private String m_fecregistro;
	
    	private String m_activo;
	
    	private String m_nombre;
	
    	private Int32 m_id;
	
    	private String m_usrregistro;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase InstalacionFaena.
        /// </summary>
        public InstalacionFaena()
        { }
		#endregion

		#region [ Propiedades ]

		
		/// <summary>
		/// Gets or sets el valor de: HORAREGISTRO.
		/// </summary>
		public String HORAREGISTRO
		{
			get { return m_horaregistro; }
			set
			{
				if (m_horaregistro != value)
				{
					m_horaregistro = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: FECREGISTRO.
		/// </summary>
		public String FECREGISTRO
		{
			get { return m_fecregistro; }
			set
			{
				if (m_fecregistro != value)
				{
					m_fecregistro = value;
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
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Int32 ID
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
		/// Gets or sets el valor de: USRREGISTRO.
		/// </summary>
		public String USRREGISTRO
		{
			get { return m_usrregistro; }
			set
			{
				if (m_usrregistro != value)
				{
					m_usrregistro = value;
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
	