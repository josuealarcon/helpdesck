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
	public partial class OSTArbol 
	{
		#region [ Variables ]
		private String m_ost;
		private String m_madre;
		private String m_empresa;
		private String m_adminsubc;
		private String m_descsubc;
		private Nullable<Int16> m_nivel;
		private String m_finicio;
		private String m_ftermino;
		private String m_fechamod;
		private String m_horamod;
		private String m_autor;
		private String m_grabo;
		private Nullable<Int32> m_dotmaxfaena;
		private Nullable<Int32> m_holgdotacre;
		private String m_ffincert;
		private String m_fentdocs;
		private String m_ffinvalida;
		private String m_ffinvalida_admin;
		private String m_finicert;
		private String m_valida_carranque;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase OSTArbol.
		/// </summary>
		public OSTArbol()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: OST.
		/// </summary>
		public String OST
		{
			get { return m_ost; }
			set
			{
				if (m_ost != value)
				{
					m_ost = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MADRE.
		/// </summary>
		public String MADRE
		{
			get { return m_madre; }
			set
			{
				if (m_madre != value)
				{
					m_madre = value;
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
		/// Gets or sets el valor de: ADMINSUBC.
		/// </summary>
		public String ADMINSUBC
		{
			get { return m_adminsubc; }
			set
			{
				if (m_adminsubc != value)
				{
					m_adminsubc = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DESCSUBC.
		/// </summary>
		public String DESCSUBC
		{
			get { return m_descsubc; }
			set
			{
				if (m_descsubc != value)
				{
					m_descsubc = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NIVEL.
		/// </summary>
		public Nullable<Int16> NIVEL
		{
			get { return m_nivel; }
			set
			{
				if (m_nivel != value)
				{
					m_nivel = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FINICIO.
		/// </summary>
		public String FINICIO
		{
			get { return m_finicio; }
			set
			{
				if (m_finicio != value)
				{
					m_finicio = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FTERMINO.
		/// </summary>
		public String FTERMINO
		{
			get { return m_ftermino; }
			set
			{
				if (m_ftermino != value)
				{
					m_ftermino = value;
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
		/// Gets or sets el valor de: AUTOR.
		/// </summary>
		public String AUTOR
		{
			get { return m_autor; }
			set
			{
				if (m_autor != value)
				{
					m_autor = value;
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
		/// Gets or sets el valor de: DOTMAXFAENA.
		/// </summary>
		public Nullable<Int32> DOTMAXFAENA
		{
			get { return m_dotmaxfaena; }
			set
			{
				if (m_dotmaxfaena != value)
				{
					m_dotmaxfaena = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HOLGDOTACRE.
		/// </summary>
		public Nullable<Int32> HOLGDOTACRE
		{
			get { return m_holgdotacre; }
			set
			{
				if (m_holgdotacre != value)
				{
					m_holgdotacre = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FFINCERT.
		/// </summary>
		public String FFINCERT
		{
			get { return m_ffincert; }
			set
			{
				if (m_ffincert != value)
				{
					m_ffincert = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FENTDOCS.
		/// </summary>
		public String FENTDOCS
		{
			get { return m_fentdocs; }
			set
			{
				if (m_fentdocs != value)
				{
					m_fentdocs = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FFINVALIDA.
		/// </summary>
		public String FFINVALIDA
		{
			get { return m_ffinvalida; }
			set
			{
				if (m_ffinvalida != value)
				{
					m_ffinvalida = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FFINVALIDA_ADMIN.
		/// </summary>
		public String FFINVALIDA_ADMIN
		{
			get { return m_ffinvalida_admin; }
			set
			{
				if (m_ffinvalida_admin != value)
				{
					m_ffinvalida_admin = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FINICERT.
		/// </summary>
		public String FINICERT
		{
			get { return m_finicert; }
			set
			{
				if (m_finicert != value)
				{
					m_finicert = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: VALIDA_CARRANQUE.
		/// </summary>
		public String VALIDA_CARRANQUE
		{
			get { return m_valida_carranque; }
			set
			{
				if (m_valida_carranque != value)
				{
					m_valida_carranque = value;
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
