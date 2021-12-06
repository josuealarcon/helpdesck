using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Tab_TipoPase 
	{
		#region [ Variables ]
		private Int16 m_id_tipopase;
		private String m_tipopase;
		private String m_desc_tipopase;
		private String m_activo;
		private String m_req_ost;
		private String m_aprueba_medico;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Tab_TipoPase.
		/// </summary>
		public Tab_TipoPase()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ID_TIPOPASE.
		/// </summary>
		public Int16 ID_TIPOPASE
		{
			get { return m_id_tipopase; }
			set
			{
				if (m_id_tipopase != value)
				{
					m_id_tipopase = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPOPASE.
		/// </summary>
		public String TIPOPASE
		{
			get { return m_tipopase; }
			set
			{
				if (m_tipopase != value)
				{
					m_tipopase = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DESC_TIPOPASE.
		/// </summary>
		public String DESC_TIPOPASE
		{
			get { return m_desc_tipopase; }
			set
			{
				if (m_desc_tipopase != value)
				{
					m_desc_tipopase = value;
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
		/// Gets or sets el valor de: REQ_OST.
		/// </summary>
		public String REQ_OST
		{
			get { return m_req_ost; }
			set
			{
				if (m_req_ost != value)
				{
					m_req_ost = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: APRUEBA_MEDICO.
		/// </summary>
		public String APRUEBA_MEDICO
		{
			get { return m_aprueba_medico; }
			set
			{
				if (m_aprueba_medico != value)
				{
					m_aprueba_medico = value;
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
