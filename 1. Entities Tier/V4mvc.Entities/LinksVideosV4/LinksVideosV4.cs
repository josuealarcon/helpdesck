
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class LinksVideosV4
    {
        #region [ Variables ]
        
    	private String m_link;
	
    	private Int32 m_id;
	
    	private Nullable<Int32> m_id_video;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase LinksVideosV4.
        /// </summary>
        public LinksVideosV4()
        { }
		#endregion

		#region [ Propiedades ]

		
		/// <summary>
		/// Gets or sets el valor de: LINK.
		/// </summary>
		public String LINK
		{
			get { return m_link; }
			set
			{
				if (m_link != value)
				{
					m_link = value;
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
		/// Gets or sets el valor de: ID_VIDEO.
		/// </summary>
		public Nullable<Int32> ID_VIDEO
		{
			get { return m_id_video; }
			set
			{
				if (m_id_video != value)
				{
					m_id_video = value;
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
	