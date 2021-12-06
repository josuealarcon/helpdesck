
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Region
    {
        #region [ Variables ]
        
    	private String m_descripcion;
	
    	private String m_pais;
	
    	private String m_region;
	
    	private Int32 m_cregion;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Region.
        /// </summary>
        public Region()
        { }
		#endregion

		#region [ Propiedades ]

		
		/// <summary>
		/// Gets or sets el valor de: DESCRIPCION.
		/// </summary>
		public String DESCRIPCION
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
		/// Gets or sets el valor de: REGION.
		/// </summary>
		public String REGION
		{
			get { return m_region; }
			set
			{
				if (m_region != value)
				{
					m_region = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: CREGION.
		/// </summary>
		public Int32 CREGION
		{
			get { return m_cregion; }
			set
			{
				if (m_cregion != value)
				{
					m_cregion = value;
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
	