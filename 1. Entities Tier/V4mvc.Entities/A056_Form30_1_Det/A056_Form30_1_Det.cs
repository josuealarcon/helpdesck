
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class A056_Form30_1_Det
    {
        #region [ Variables ]
        
    	private String m_empresa;
	
    	private String m_periodo;
	
    	private Nullable<Int32> m_nro_trab_pag;
	
    	private Nullable<Int64> m_monto_pagado;
	
    	private Nullable<Int32> m_nro_trab_nopag;
	
    	private String m_id_certificado;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase A056_Form30_1_Det.
        /// </summary>
        public A056_Form30_1_Det()
        { }
		#endregion

		#region [ Propiedades ]

		
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
		/// Gets or sets el valor de: PERIODO.
		/// </summary>
		public String PERIODO
		{
			get { return m_periodo; }
			set
			{
				if (m_periodo != value)
				{
					m_periodo = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: NRO_TRAB_PAG.
		/// </summary>
		public Nullable<Int32> NRO_TRAB_PAG
		{
			get { return m_nro_trab_pag; }
			set
			{
				if (m_nro_trab_pag != value)
				{
					m_nro_trab_pag = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: MONTO_PAGADO.
		/// </summary>
		public Nullable<Int64> MONTO_PAGADO
		{
			get { return m_monto_pagado; }
			set
			{
				if (m_monto_pagado != value)
				{
					m_monto_pagado = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: NRO_TRAB_NOPAG.
		/// </summary>
		public Nullable<Int32> NRO_TRAB_NOPAG
		{
			get { return m_nro_trab_nopag; }
			set
			{
				if (m_nro_trab_nopag != value)
				{
					m_nro_trab_nopag = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ID_CERTIFICADO.
		/// </summary>
		public String ID_CERTIFICADO
		{
			get { return m_id_certificado; }
			set
			{
				if (m_id_certificado != value)
				{
					m_id_certificado = value;
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
	