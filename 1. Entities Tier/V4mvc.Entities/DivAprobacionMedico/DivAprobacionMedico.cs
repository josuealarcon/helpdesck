
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class DivAprobacionMedico
    {
        #region [ Variables ]
        
    	private String m_division;
	
    	private String m_aprobacionmed;
	
    	private String m_divcod;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase DivAprobacionMedico.
        /// </summary>
        public DivAprobacionMedico()
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
		/// Gets or sets el valor de: APROBACIONMED.
		/// </summary>
		public String APROBACIONMED
		{
			get { return m_aprobacionmed; }
			set
			{
				if (m_aprobacionmed != value)
				{
					m_aprobacionmed = value;
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
	