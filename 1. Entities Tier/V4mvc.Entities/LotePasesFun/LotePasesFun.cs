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
	public partial class LotePasesFun 
	{
		#region [ Variables ]
		private Int32 m_nloteproc;
		private String m_rutlote;
		private String m_empresalt;
		private String m_tiporut;
		private String m_apellidoslt;
		private String m_nombreslt;
		private String m_tipolt;
		private String m_fnacimlt;
		private String m_telefonolt;
		private String m_fecexpexlt;
		private String m_licondlt;
		private String m_fecexpliclt;
		private String m_clase;
		private String m_rol;
		private String m_ostlt;
		private String m_sinolt;
		private String m_alojamientolt;
		private String m_local;
		private String m_alojacampam;
		private String m_alojafecha;
		private String m_casinolt;
		private String m_qpaga;
		private String m_zona;
		private String m_ccostolt;
		private String m_futuro;
		private String m_fechamod;
		private String m_horamod;
		private String m_grabo;
		private String m_utilizolt;
		private String m_sexolt;
		private Nullable<Int32> m_codcategoria;
		private Nullable<Int32> m_codsubcategoria;
		private Nullable<Int32> m_tipovehi;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase LotePasesFun.
		/// </summary>
		public LotePasesFun()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: NLOTEPROC.
		/// </summary>
		public Int32 NLOTEPROC
		{
			get { return m_nloteproc; }
			set
			{
				if (m_nloteproc != value)
				{
					m_nloteproc = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RUTLOTE.
		/// </summary>
		public String RUTLOTE
		{
			get { return m_rutlote; }
			set
			{
				if (m_rutlote != value)
				{
					m_rutlote = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EMPRESALT.
		/// </summary>
		public String EMPRESALT
		{
			get { return m_empresalt; }
			set
			{
				if (m_empresalt != value)
				{
					m_empresalt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPORUT.
		/// </summary>
		public String TIPORUT
		{
			get { return m_tiporut; }
			set
			{
				if (m_tiporut != value)
				{
					m_tiporut = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: APELLIDOSLT.
		/// </summary>
		public String APELLIDOSLT
		{
			get { return m_apellidoslt; }
			set
			{
				if (m_apellidoslt != value)
				{
					m_apellidoslt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NOMBRESLT.
		/// </summary>
		public String NOMBRESLT
		{
			get { return m_nombreslt; }
			set
			{
				if (m_nombreslt != value)
				{
					m_nombreslt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPOLT.
		/// </summary>
		public String TIPOLT
		{
			get { return m_tipolt; }
			set
			{
				if (m_tipolt != value)
				{
					m_tipolt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FNACIMLT.
		/// </summary>
		public String FNACIMLT
		{
			get { return m_fnacimlt; }
			set
			{
				if (m_fnacimlt != value)
				{
					m_fnacimlt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TELEFONOLT.
		/// </summary>
		public String TELEFONOLT
		{
			get { return m_telefonolt; }
			set
			{
				if (m_telefonolt != value)
				{
					m_telefonolt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECEXPEXLT.
		/// </summary>
		public String FECEXPEXLT
		{
			get { return m_fecexpexlt; }
			set
			{
				if (m_fecexpexlt != value)
				{
					m_fecexpexlt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LICONDLT.
		/// </summary>
		public String LICONDLT
		{
			get { return m_licondlt; }
			set
			{
				if (m_licondlt != value)
				{
					m_licondlt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECEXPLICLT.
		/// </summary>
		public String FECEXPLICLT
		{
			get { return m_fecexpliclt; }
			set
			{
				if (m_fecexpliclt != value)
				{
					m_fecexpliclt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CLASE.
		/// </summary>
		public String CLASE
		{
			get { return m_clase; }
			set
			{
				if (m_clase != value)
				{
					m_clase = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ROL.
		/// </summary>
		public String ROL
		{
			get { return m_rol; }
			set
			{
				if (m_rol != value)
				{
					m_rol = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OSTLT.
		/// </summary>
		public String OSTLT
		{
			get { return m_ostlt; }
			set
			{
				if (m_ostlt != value)
				{
					m_ostlt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SINOLT.
		/// </summary>
		public String SINOLT
		{
			get { return m_sinolt; }
			set
			{
				if (m_sinolt != value)
				{
					m_sinolt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ALOJAMIENTOLT.
		/// </summary>
		public String ALOJAMIENTOLT
		{
			get { return m_alojamientolt; }
			set
			{
				if (m_alojamientolt != value)
				{
					m_alojamientolt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOCAL.
		/// </summary>
		public String LOCAL
		{
			get { return m_local; }
			set
			{
				if (m_local != value)
				{
					m_local = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ALOJACAMPAM.
		/// </summary>
		public String ALOJACAMPAM
		{
			get { return m_alojacampam; }
			set
			{
				if (m_alojacampam != value)
				{
					m_alojacampam = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ALOJAFECHA.
		/// </summary>
		public String ALOJAFECHA
		{
			get { return m_alojafecha; }
			set
			{
				if (m_alojafecha != value)
				{
					m_alojafecha = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CASINOLT.
		/// </summary>
		public String CASINOLT
		{
			get { return m_casinolt; }
			set
			{
				if (m_casinolt != value)
				{
					m_casinolt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: QPAGA.
		/// </summary>
		public String QPAGA
		{
			get { return m_qpaga; }
			set
			{
				if (m_qpaga != value)
				{
					m_qpaga = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ZONA.
		/// </summary>
		public String ZONA
		{
			get { return m_zona; }
			set
			{
				if (m_zona != value)
				{
					m_zona = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOSTOLT.
		/// </summary>
		public String CCOSTOLT
		{
			get { return m_ccostolt; }
			set
			{
				if (m_ccostolt != value)
				{
					m_ccostolt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FUTURO.
		/// </summary>
		public String FUTURO
		{
			get { return m_futuro; }
			set
			{
				if (m_futuro != value)
				{
					m_futuro = value;
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
		/// Gets or sets el valor de: UTILIZOLT.
		/// </summary>
		public String UTILIZOLT
		{
			get { return m_utilizolt; }
			set
			{
				if (m_utilizolt != value)
				{
					m_utilizolt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SEXOLT.
		/// </summary>
		public String SEXOLT
		{
			get { return m_sexolt; }
			set
			{
				if (m_sexolt != value)
				{
					m_sexolt = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CODCATEGORIA.
		/// </summary>
		public Nullable<Int32> CODCATEGORIA
		{
			get { return m_codcategoria; }
			set
			{
				if (m_codcategoria != value)
				{
					m_codcategoria = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CODSUBCATEGORIA.
		/// </summary>
		public Nullable<Int32> CODSUBCATEGORIA
		{
			get { return m_codsubcategoria; }
			set
			{
				if (m_codsubcategoria != value)
				{
					m_codsubcategoria = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPOVEHI.
		/// </summary>
		public Nullable<Int32> TIPOVEHI
		{
			get { return m_tipovehi; }
			set
			{
				if (m_tipovehi != value)
				{
					m_tipovehi = value;
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
