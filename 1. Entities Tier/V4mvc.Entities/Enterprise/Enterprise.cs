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
	public partial class Enterprise
	{
		#region [ Variables ]
		private String m_idempresa;
		private String m_clave;
		private String m_acronimo;
		private String m_nombre;
		private String m_rubro;
		private String m_direcccion;
		private String m_ciudad;
		private String m_region;
		private String m_telefono;
		private String m_fax;
		private String m_nrelegal;
		private String m_relegal;
		private String m_email;
		private String m_ubifaena;
		private String m_fonofaena;
		private String m_adminnom;
		private String m_adminrut;
		private String m_adminemail;
		private String m_adminfono;
		private String m_bloqueocasino;
		private String m_fechabloqueo;
		private String m_ost;
		private String m_fecaudit;
		private String m_tipoemp;
		private String m_rinterno;
		private String m_cparitario;
		private String m_autor;
		private String m_finanzas;
		private String m_rrhh;
		private String m_sicep;
		private String m_dicom;
		private String m_propio;
		private String m_legal;
		private String m_contratos;
		private Nullable<Int16> m_taudit;
		private String m_segurito;
		private String m_emailsegurito;
		private String m_mutual;
		private String m_codigomutual;
		private String m_sernageomin;
		private String m_codigoserna;
		private String m_fechamod;
		private String m_horamod;
		private String m_grabo;
		private String m_maillicita;
		private String m_balance;
		private String m_anterior;
		private String m_elypse;
		private String m_pais;
		private String m_ruthotel;
		private String m_contactohotel;
		private String m_tlfhotel;
		private String m_emailhotel;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Enterprise.
		/// </summary>
		public Enterprise()
		{  }
		#endregion

		#region [ Propiedades ]
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
		/// Gets or sets el valor de: CLAVE.
		/// </summary>
		public String CLAVE
		{
			get { return m_clave; }
			set
			{
				if (m_clave != value)
				{
					m_clave = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ACRONIMO.
		/// </summary>
		public String ACRONIMO
		{
			get { return m_acronimo; }
			set
			{
				if (m_acronimo != value)
				{
					m_acronimo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NOMBRE.
		/// </summary>
		public String NOMBRE
		{
			get { return m_nombre; }
			set
			{
				if (m_nombre != value)
				{
					m_nombre = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RUBRO.
		/// </summary>
		public String RUBRO
		{
			get { return m_rubro; }
			set
			{
				if (m_rubro != value)
				{
					m_rubro = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DIRECCCION.
		/// </summary>
		public String DIRECCCION
		{
			get { return m_direcccion; }
			set
			{
				if (m_direcccion != value)
				{
					m_direcccion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CIUDAD.
		/// </summary>
		public String CIUDAD
		{
			get { return m_ciudad; }
			set
			{
                if (m_ciudad != value)
                {
                    m_ciudad = value;
                }
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REGION.
		/// </summary>
		public String REGION
		{
			get { return m_region; }
			set
			{
				if (m_region != value)
				{
					m_region = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TELEFONO.
		/// </summary>
		public String TELEFONO
		{
			get { return m_telefono; }
			set
			{
				if (m_telefono != value)
				{
					m_telefono = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FAX.
		/// </summary>
		public String FAX
		{
			get { return m_fax; }
			set
			{
				if (m_fax != value)
				{
					m_fax = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NRELEGAL.
		/// </summary>
		public String NRELEGAL
		{
			get { return m_nrelegal; }
			set
			{
				if (m_nrelegal != value)
				{
					m_nrelegal = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RELEGAL.
		/// </summary>
		public String RELEGAL
		{
			get { return m_relegal; }
			set
			{
				if (m_relegal != value)
				{
					m_relegal = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EMAIL.
		/// </summary>
		public String EMAIL
		{
			get { return m_email; }
			set
			{
				if (m_email != value)
				{
					m_email = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: UBIFAENA.
		/// </summary>
		public String UBIFAENA
		{
			get { return m_ubifaena; }
			set
			{
				if (m_ubifaena != value)
				{
					m_ubifaena = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FONOFAENA.
		/// </summary>
		public String FONOFAENA
		{
			get { return m_fonofaena; }
			set
			{
				if (m_fonofaena != value)
				{
					m_fonofaena = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ADMINNOM.
		/// </summary>
		public String ADMINNOM
		{
			get { return m_adminnom; }
			set
			{
				if (m_adminnom != value)
				{
					m_adminnom = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ADMINRUT.
		/// </summary>
		public String ADMINRUT
		{
			get { return m_adminrut; }
			set
			{
				if (m_adminrut != value)
				{
					m_adminrut = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ADMINEMAIL.
		/// </summary>
		public String ADMINEMAIL
		{
			get { return m_adminemail; }
			set
			{
				if (m_adminemail != value)
				{
					m_adminemail = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ADMINFONO.
		/// </summary>
		public String ADMINFONO
		{
			get { return m_adminfono; }
			set
			{
				if (m_adminfono != value)
				{
					m_adminfono = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: BLOQUEOCASINO.
		/// </summary>
		public String BLOQUEOCASINO
		{
			get { return m_bloqueocasino; }
			set
			{
				if (m_bloqueocasino != value)
				{
					m_bloqueocasino = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHABLOQUEO.
		/// </summary>
		public String FECHABLOQUEO
		{
			get { return m_fechabloqueo; }
			set
			{
				if (m_fechabloqueo != value)
				{
					m_fechabloqueo = value;
				}
			}
		}
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
		/// Gets or sets el valor de: FECAUDIT.
		/// </summary>
		public String FECAUDIT
		{
			get { return m_fecaudit; }
			set
			{
				if (m_fecaudit != value)
				{
					m_fecaudit = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPOEMP.
		/// </summary>
		public String TIPOEMP
		{
			get { return m_tipoemp; }
			set
			{
				if (m_tipoemp != value)
				{
					m_tipoemp = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RINTERNO.
		/// </summary>
		public String RINTERNO
		{
			get { return m_rinterno; }
			set
			{
				if (m_rinterno != value)
				{
					m_rinterno = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CPARITARIO.
		/// </summary>
		public String CPARITARIO
		{
			get { return m_cparitario; }
			set
			{
				if (m_cparitario != value)
				{
					m_cparitario = value;
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
		/// Gets or sets el valor de: FINANZAS.
		/// </summary>
		public String FINANZAS
		{
			get { return m_finanzas; }
			set
			{
				if (m_finanzas != value)
				{
					m_finanzas = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RRHH.
		/// </summary>
		public String RRHH
		{
			get { return m_rrhh; }
			set
			{
				if (m_rrhh != value)
				{
					m_rrhh = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SICEP.
		/// </summary>
		public String SICEP
		{
			get { return m_sicep; }
			set
			{
				if (m_sicep != value)
				{
					m_sicep = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DICOM.
		/// </summary>
		public String DICOM
		{
			get { return m_dicom; }
			set
			{
				if (m_dicom != value)
				{
					m_dicom = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PROPIO.
		/// </summary>
		public String PROPIO
		{
			get { return m_propio; }
			set
			{
				if (m_propio != value)
				{
					m_propio = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LEGAL.
		/// </summary>
		public String LEGAL
		{
			get { return m_legal; }
			set
			{
				if (m_legal != value)
				{
					m_legal = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONTRATOS.
		/// </summary>
		public String CONTRATOS
		{
			get { return m_contratos; }
			set
			{
				if (m_contratos != value)
				{
					m_contratos = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TAUDIT.
		/// </summary>
		public Nullable<Int16> TAUDIT
		{
			get { return m_taudit; }
			set
			{
				if (m_taudit != value)
				{
					m_taudit = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SEGURITO.
		/// </summary>
		public String SEGURITO
		{
			get { return m_segurito; }
			set
			{
				if (m_segurito != value)
				{
					m_segurito = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EMAILSEGURITO.
		/// </summary>
		public String EMAILSEGURITO
		{
			get { return m_emailsegurito; }
			set
			{
				if (m_emailsegurito != value)
				{
					m_emailsegurito = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MUTUAL.
		/// </summary>
		public String MUTUAL
		{
			get { return m_mutual; }
			set
			{
				if (m_mutual != value)
				{
					m_mutual = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CODIGOMUTUAL.
		/// </summary>
		public String CODIGOMUTUAL
		{
			get { return m_codigomutual; }
			set
			{
				if (m_codigomutual != value)
				{
					m_codigomutual = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERNAGEOMIN.
		/// </summary>
		public String SERNAGEOMIN
		{
			get { return m_sernageomin; }
			set
			{
				if (m_sernageomin != value)
				{
					m_sernageomin = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CODIGOSERNA.
		/// </summary>
		public String CODIGOSERNA
		{
			get { return m_codigoserna; }
			set
			{
				if (m_codigoserna != value)
				{
					m_codigoserna = value;
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
		/// Gets or sets el valor de: MAILLICITA.
		/// </summary>
		public String MAILLICITA
		{
			get { return m_maillicita; }
			set
			{
				if (m_maillicita != value)
				{
					m_maillicita = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: BALANCE.
		/// </summary>
		public String BALANCE
		{
			get { return m_balance; }
			set
			{
				if (m_balance != value)
				{
					m_balance = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ANTERIOR.
		/// </summary>
		public String ANTERIOR
		{
			get { return m_anterior; }
			set
			{
				if (m_anterior != value)
				{
					m_anterior = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ELYPSE.
		/// </summary>
		public String ELYPSE
		{
			get { return m_elypse; }
			set
			{
				if (m_elypse != value)
				{
					m_elypse = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PAIS.
		/// </summary>
		public String PAIS
		{
			get { return m_pais; }
			set
			{
				if (m_pais != value)
				{
					m_pais = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RUTHOTEL.
		/// </summary>
		public String RUTHOTEL
		{
			get { return m_ruthotel; }
			set
			{
				if (m_ruthotel != value)
				{
					m_ruthotel = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONTACTOHOTEL.
		/// </summary>
		public String CONTACTOHOTEL
		{
			get { return m_contactohotel; }
			set
			{
				if (m_contactohotel != value)
				{
					m_contactohotel = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TLFHOTEL.
		/// </summary>
		public String TLFHOTEL
		{
			get { return m_tlfhotel; }
			set
			{
				if (m_tlfhotel != value)
				{
					m_tlfhotel = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EMAILHOTEL.
		/// </summary>
		public String EMAILHOTEL
		{
			get { return m_emailhotel; }
			set
			{
				if (m_emailhotel != value)
				{
					m_emailhotel = value;
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
