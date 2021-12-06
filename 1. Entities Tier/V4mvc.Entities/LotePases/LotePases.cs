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
	public partial class LotePases 
	{
		#region [ Variables ]
		private Int32 m_lotenum;
		private String m_lotefecha;
		private String m_loteestado;
		private String m_lotefecproceso;
		private String m_loterutproceso;
		private String m_lotefinicio;
		private String m_loteffinal;
		private String m_loteempresa;
		private String m_loteemail;
		private String m_loteglosa;
		private String m_lotever;
		private String m_loteempmadre;
		private String m_fechamod;
		private String m_horamod;
		private String m_grabo;
		private String m_lotehorproceso;
		private String m_division;
		private String m_loteusuario;
		private String m_motivorechazo;
		private String m_medfecproceso;
		private String m_medhorproceso;
		private String m_medrutproceso;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase LotePases.
		/// </summary>
		public LotePases()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: LOTENUM.
		/// </summary>
		public Int32 LOTENUM
		{
			get { return m_lotenum; }
			set
			{
				if (m_lotenum != value)
				{
					m_lotenum = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOTEFECHA.
		/// </summary>
		public String LOTEFECHA
		{
			get { return m_lotefecha; }
			set
			{
				if (m_lotefecha != value)
				{
					m_lotefecha = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOTEESTADO.
		/// </summary>
		public String LOTEESTADO
		{
			get { return m_loteestado; }
			set
			{
				if (m_loteestado != value)
				{
					m_loteestado = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOTEFECPROCESO.
		/// </summary>
		public String LOTEFECPROCESO
		{
			get { return m_lotefecproceso; }
			set
			{
				if (m_lotefecproceso != value)
				{
					m_lotefecproceso = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOTERUTPROCESO.
		/// </summary>
		public String LOTERUTPROCESO
		{
			get { return m_loterutproceso; }
			set
			{
				if (m_loterutproceso != value)
				{
					m_loterutproceso = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOTEFINICIO.
		/// </summary>
		public String LOTEFINICIO
		{
			get { return m_lotefinicio; }
			set
			{
				if (m_lotefinicio != value)
				{
					m_lotefinicio = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOTEFFINAL.
		/// </summary>
		public String LOTEFFINAL
		{
			get { return m_loteffinal; }
			set
			{
				if (m_loteffinal != value)
				{
					m_loteffinal = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOTEEMPRESA.
		/// </summary>
		public String LOTEEMPRESA
		{
			get { return m_loteempresa; }
			set
			{
				if (m_loteempresa != value)
				{
					m_loteempresa = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOTEEMAIL.
		/// </summary>
		public String LOTEEMAIL
		{
			get { return m_loteemail; }
			set
			{
				if (m_loteemail != value)
				{
					m_loteemail = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOTEGLOSA.
		/// </summary>
		public String LOTEGLOSA
		{
			get { return m_loteglosa; }
			set
			{
				if (m_loteglosa != value)
				{
					m_loteglosa = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOTEVER.
		/// </summary>
		public String LOTEVER
		{
			get { return m_lotever; }
			set
			{
				if (m_lotever != value)
				{
					m_lotever = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOTEEMPMADRE.
		/// </summary>
		public String LOTEEMPMADRE
		{
			get { return m_loteempmadre; }
			set
			{
				if (m_loteempmadre != value)
				{
					m_loteempmadre = value;
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
		/// Gets or sets el valor de: GRABO.
		/// </summary>
		public String GRABO
		{
			get { return m_grabo; }
			set
			{
				if (m_grabo != value)
				{
					m_grabo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOTEHORPROCESO.
		/// </summary>
		public String LOTEHORPROCESO
		{
			get { return m_lotehorproceso; }
			set
			{
				if (m_lotehorproceso != value)
				{
					m_lotehorproceso = value;
				}
			}
		}
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
		/// Gets or sets el valor de: LOTEUSUARIO.
		/// </summary>
		public String LOTEUSUARIO
		{
			get { return m_loteusuario; }
			set
			{
				if (m_loteusuario != value)
				{
					m_loteusuario = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOTIVORECHAZO.
		/// </summary>
		public String MOTIVORECHAZO
		{
			get { return m_motivorechazo; }
			set
			{
				if (m_motivorechazo != value)
				{
					m_motivorechazo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MEDFECPROCESO.
		/// </summary>
		public String MEDFECPROCESO
		{
			get { return m_medfecproceso; }
			set
			{
				if (m_medfecproceso != value)
				{
					m_medfecproceso = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MEDHORPROCESO.
		/// </summary>
		public String MEDHORPROCESO
		{
			get { return m_medhorproceso; }
			set
			{
				if (m_medhorproceso != value)
				{
					m_medhorproceso = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MEDRUTPROCESO.
		/// </summary>
		public String MEDRUTPROCESO
		{
			get { return m_medrutproceso; }
			set
			{
				if (m_medrutproceso != value)
				{
					m_medrutproceso = value;
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
