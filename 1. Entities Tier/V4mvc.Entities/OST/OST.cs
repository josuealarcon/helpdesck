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
	public partial class OST 
	{
		#region [ Variables ]
		private String m_nroost;
		private String m_idempresa;
		private String m_fecinicio;
		private String m_fecterm;
		private String m_adminost;
		private String m_aloja;
		private String m_transp;
		private String m_aliment;
		private String m_combust;
		private String m_descripost;
		private String m_feccierre;
		private Nullable<Int32> m_dotacion;
		private Nullable<Int32> m_flotante;
		private Nullable<Int32> m_dotaloja;
		private Nullable<Int32> m_dotalim;
		private String m_madre;
		private Nullable<Int16> m_nivel;
		private Nullable<Int32> m_dotransp;
		private String m_fechamod;
		private String m_horamod;
		private String m_autor;
		private String m_grabo;
		private Nullable<Int32> m_valor;
		private String m_moneda;
		private String m_admincontr;
		private String m_descext;
		private String m_ccosto;
		private String m_usuario;
		private String m_division;
		private String m_gerencia;
		private String m_fanterior;
		private Nullable<Int32> m_id_departamento;
		private Nullable<Int32> m_id_tipo_sector;
		private Nullable<Int32> m_id_sector;
		private Nullable<DateTime> m_fecha_avisoese;
		private Nullable<Int32> m_dottrans;
		private String m_esporadico;
		private Nullable<Int32> m_dotmaxfaena;
		private Nullable<Int32> m_holgdotacre;
		private String m_horacreacion;
		private String m_usrcreacion;
		private Nullable<Int32> m_validador;
		private String m_finicert;
		private String m_ffincert;
		private String m_fentdocs;
		private String m_ffinvalida;
		private String m_ffinvalida_admin;
		private String m_preven_riesgos;
		private String m_status;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase OST.
		/// </summary>
		public OST()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: NROOST.
		/// </summary>
		public String NROOST
		{
			get { return m_nroost; }
			set
			{
				if (m_nroost != value)
				{
					m_nroost = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDEMPRESA.
		/// </summary>
		public String IDEMPRESA
		{
			get { return m_idempresa; }
			set
			{
				if (m_idempresa != value)
				{
					m_idempresa = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECINICIO.
		/// </summary>
		public String FECINICIO
		{
			get { return m_fecinicio; }
			set
			{
				if (m_fecinicio != value)
				{
					m_fecinicio = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECTERM.
		/// </summary>
		public String FECTERM
		{
			get { return m_fecterm; }
			set
			{
				if (m_fecterm != value)
				{
					m_fecterm = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ADMINOST.
		/// </summary>
		public String ADMINOST
		{
			get { return m_adminost; }
			set
			{
				if (m_adminost != value)
				{
					m_adminost = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ALOJA.
		/// </summary>
		public String ALOJA
		{
			get { return m_aloja; }
			set
			{
				if (m_aloja != value)
				{
					m_aloja = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TRANSP.
		/// </summary>
		public String TRANSP
		{
			get { return m_transp; }
			set
			{
				if (m_transp != value)
				{
					m_transp = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ALIMENT.
		/// </summary>
		public String ALIMENT
		{
			get { return m_aliment; }
			set
			{
				if (m_aliment != value)
				{
					m_aliment = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COMBUST.
		/// </summary>
		public String COMBUST
		{
			get { return m_combust; }
			set
			{
				if (m_combust != value)
				{
					m_combust = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DESCRIPOST.
		/// </summary>
		public String DESCRIPOST
		{
			get { return m_descripost; }
			set
			{
				if (m_descripost != value)
				{
					m_descripost = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECCIERRE.
		/// </summary>
		public String FECCIERRE
		{
			get { return m_feccierre; }
			set
			{
				if (m_feccierre != value)
				{
					m_feccierre = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOTACION.
		/// </summary>
		public Nullable<Int32> DOTACION
		{
			get { return m_dotacion; }
			set
			{
				if (m_dotacion != value)
				{
					m_dotacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FLOTANTE.
		/// </summary>
		public Nullable<Int32> FLOTANTE
		{
			get { return m_flotante; }
			set
			{
				if (m_flotante != value)
				{
					m_flotante = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOTALOJA.
		/// </summary>
		public Nullable<Int32> DOTALOJA
		{
			get { return m_dotaloja; }
			set
			{
				if (m_dotaloja != value)
				{
					m_dotaloja = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOTALIM.
		/// </summary>
		public Nullable<Int32> DOTALIM
		{
			get { return m_dotalim; }
			set
			{
				if (m_dotalim != value)
				{
					m_dotalim = value;
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
		/// Gets or sets el valor de: DOTRANSP.
		/// </summary>
		public Nullable<Int32> DOTRANSP
		{
			get { return m_dotransp; }
			set
			{
				if (m_dotransp != value)
				{
					m_dotransp = value;
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
		/// Gets or sets el valor de: VALOR.
		/// </summary>
		public Nullable<Int32> VALOR
		{
			get { return m_valor; }
			set
			{
				if (m_valor != value)
				{
					m_valor = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MONEDA.
		/// </summary>
		public String MONEDA
		{
			get { return m_moneda; }
			set
			{
				if (m_moneda != value)
				{
					m_moneda = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ADMINCONTR.
		/// </summary>
		public String ADMINCONTR
		{
			get { return m_admincontr; }
			set
			{
				if (m_admincontr != value)
				{
					m_admincontr = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DESCEXT.
		/// </summary>
		public String DESCEXT
		{
			get { return m_descext; }
			set
			{
				if (m_descext != value)
				{
					m_descext = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOSTO.
		/// </summary>
		public String CCOSTO
		{
			get { return m_ccosto; }
			set
			{
				if (m_ccosto != value)
				{
					m_ccosto = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USUARIO.
		/// </summary>
		public String USUARIO
		{
			get { return m_usuario; }
			set
			{
				if (m_usuario != value)
				{
					m_usuario = value;
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
		/// Gets or sets el valor de: GERENCIA.
		/// </summary>
		public String GERENCIA
		{
			get { return m_gerencia; }
			set
			{
				if (m_gerencia != value)
				{
					m_gerencia = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FANTERIOR.
		/// </summary>
		public String FANTERIOR
		{
			get { return m_fanterior; }
			set
			{
				if (m_fanterior != value)
				{
					m_fanterior = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_DEPARTAMENTO.
		/// </summary>
		public Nullable<Int32> ID_DEPARTAMENTO
		{
			get { return m_id_departamento; }
			set
			{
				if (m_id_departamento != value)
				{
					m_id_departamento = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_TIPO_SECTOR.
		/// </summary>
		public Nullable<Int32> ID_TIPO_SECTOR
		{
			get { return m_id_tipo_sector; }
			set
			{
				if (m_id_tipo_sector != value)
				{
					m_id_tipo_sector = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_SECTOR.
		/// </summary>
		public Nullable<Int32> ID_SECTOR
		{
			get { return m_id_sector; }
			set
			{
				if (m_id_sector != value)
				{
					m_id_sector = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHA_AVISOESE.
		/// </summary>
		public Nullable<DateTime> FECHA_AVISOESE
		{
			get { return m_fecha_avisoese; }
			set
			{
				if (m_fecha_avisoese != value)
				{
					m_fecha_avisoese = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOTTRANS.
		/// </summary>
		public Nullable<Int32> DOTTRANS
		{
			get { return m_dottrans; }
			set
			{
				if (m_dottrans != value)
				{
					m_dottrans = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ESPORADICO.
		/// </summary>
		public String ESPORADICO
		{
			get { return m_esporadico; }
			set
			{
				if (m_esporadico != value)
				{
					m_esporadico = value;
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
		/// Gets or sets el valor de: HORACREACION.
		/// </summary>
		public String HORACREACION
		{
			get { return m_horacreacion; }
			set
			{
				if (m_horacreacion != value)
				{
					m_horacreacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USRCREACION.
		/// </summary>
		public String USRCREACION
		{
			get { return m_usrcreacion; }
			set
			{
				if (m_usrcreacion != value)
				{
					m_usrcreacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: VALIDADOR.
		/// </summary>
		public Nullable<Int32> VALIDADOR
		{
			get { return m_validador; }
			set
			{
				if (m_validador != value)
				{
					m_validador = value;
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
		/// Gets or sets el valor de: PREVEN_RIESGOS.
		/// </summary>
		public String PREVEN_RIESGOS
		{
			get { return m_preven_riesgos; }
			set
			{
				if (m_preven_riesgos != value)
				{
					m_preven_riesgos = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: STATUS.
		/// </summary>
		public String STATUS
		{
			get { return m_status; }
			set
			{
				if (m_status != value)
				{
					m_status = value;
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
