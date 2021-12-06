
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Tab_ModuloEc
    {
        #region [ Variables ]
        
    	private String m_descripcion;
	
    	private String m_tipousuario;
	
    	private String m_activo;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Tab_ModuloEc.
        /// </summary>
        public Tab_ModuloEc()
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
		/// Gets or sets el valor de: TIPOUSUARIO.
		/// </summary>
		public String TIPOUSUARIO
		{
			get { return m_tipousuario; }
			set
			{
				if (m_tipousuario != value)
				{
					m_tipousuario = value;
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
	