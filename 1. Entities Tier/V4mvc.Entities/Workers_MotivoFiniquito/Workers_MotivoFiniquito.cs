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
	public partial class Workers_MotivoFiniquito
	{
		#region [ Variables ]
		private String m_rut;
		private String m_empresa;
		private Nullable<Int32> m_id_doc;
		private Nullable<Guid> m_idarchivo;
		private String m_motivo;
		private String m_usrregistra;
		private String m_fecharegistra;
		private String m_horaregistra;
		private String m_usrmod;
		private String m_fechamod;
		private String m_horamod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Workers_MotivoFiniquito.
		/// </summary>
		public Workers_MotivoFiniquito()
		{  }
		#endregion

		#region [ Propiedades ]
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
		/// Gets or sets el valor de: ID_DOC.
		/// </summary>
		public Nullable<Int32> ID_DOC
		{
			get { return m_id_doc; }
			set
			{
				if (m_id_doc != value)
				{
					m_id_doc = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDARCHIVO.
		/// </summary>
		public Nullable<Guid> IDARCHIVO
		{
			get { return m_idarchivo; }
			set
			{
				if (m_idarchivo != value)
				{
					m_idarchivo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOTIVO.
		/// </summary>
		public String MOTIVO
		{
			get { return m_motivo; }
			set
			{
				if (m_motivo != value)
				{
					m_motivo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USRREGISTRA.
		/// </summary>
		public String USRREGISTRA
		{
			get { return m_usrregistra; }
			set
			{
				if (m_usrregistra != value)
				{
					m_usrregistra = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHAREGISTRA.
		/// </summary>
		public String FECHAREGISTRA
		{
			get { return m_fecharegistra; }
			set
			{
				if (m_fecharegistra != value)
				{
					m_fecharegistra = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORAREGISTRA.
		/// </summary>
		public String HORAREGISTRA
		{
			get { return m_horaregistra; }
			set
			{
				if (m_horaregistra != value)
				{
					m_horaregistra = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USRMOD.
		/// </summary>
		public String USRMOD
		{
			get { return m_usrmod; }
			set
			{
				if (m_usrmod != value)
				{
					m_usrmod = value;
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
