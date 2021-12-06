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
	public partial class TypeTrans 
	{
		#region [ Variables ]
		private Int32 m_idtipo;
		private String m_dsctipov;
		private Nullable<Int32> m_duracion;
		private String m_tipov;
		private String m_licencias;
		private String m_fechamod;
		private String m_horamod;
		private Nullable<Int64> m_idsync;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase TypeTrans.
		/// </summary>
		public TypeTrans()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: IDTIPO.
		/// </summary>
		public Int32 IDTIPO
		{
			get { return m_idtipo; }
			set
			{
				if (m_idtipo != value)
				{
					m_idtipo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DSCTIPOV.
		/// </summary>
		public String DSCTIPOV
		{
			get { return m_dsctipov; }
			set
			{
				if (m_dsctipov != value)
				{
					m_dsctipov = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DURACION.
		/// </summary>
		public Nullable<Int32> DURACION
		{
			get { return m_duracion; }
			set
			{
				if (m_duracion != value)
				{
					m_duracion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPOV.
		/// </summary>
		public String TIPOV
		{
			get { return m_tipov; }
			set
			{
				if (m_tipov != value)
				{
					m_tipov = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LICENCIAS.
		/// </summary>
		public String LICENCIAS
		{
			get { return m_licencias; }
			set
			{
				if (m_licencias != value)
				{
					m_licencias = value;
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
		/// <summary>
		/// Gets or sets el valor de: IDSYNC.
		/// </summary>
		public Nullable<Int64> IDSYNC
		{
			get { return m_idsync; }
			set
			{
				if (m_idsync != value)
				{
					m_idsync = value;
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
