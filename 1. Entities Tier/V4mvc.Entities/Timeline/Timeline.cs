
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Timeline
    {
        #region [ Variables ]
        
    	private Nullable<Int32> m_diames;
	
    	private String m_author;
	
    	private Nullable<Int32> m_espaciodelante;
	
    	private Nullable<Int32> m_espacioatras;
	
    	private String m_descripcion;
	
    	private Int32 m_id;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Timeline.
        /// </summary>
        public Timeline()
        { }
		#endregion

		#region [ Propiedades ]

		
		/// <summary>
		/// Gets or sets el valor de: DIAMES.
		/// </summary>
		public Nullable<Int32> DIAMES
		{
			get { return m_diames; }
			set
			{
				if (m_diames != value)
				{
					m_diames = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: AUTHOR.
		/// </summary>
		public String AUTHOR
		{
			get { return m_author; }
			set
			{
				if (m_author != value)
				{
					m_author = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ESPACIODELANTE.
		/// </summary>
		public Nullable<Int32> ESPACIODELANTE
		{
			get { return m_espaciodelante; }
			set
			{
				if (m_espaciodelante != value)
				{
					m_espaciodelante = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: ESPACIOATRAS.
		/// </summary>
		public Nullable<Int32> ESPACIOATRAS
		{
			get { return m_espacioatras; }
			set
			{
				if (m_espacioatras != value)
				{
					m_espacioatras = value;
				}
			}
		}
	
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
	