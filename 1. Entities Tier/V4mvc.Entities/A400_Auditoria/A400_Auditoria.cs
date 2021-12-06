
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class A400_Auditoria
    {
        #region [ Variables ]
        
    	private Nullable<Int32> m_porc_calc_aud;
	
    	private String m_polnatural_doc;
	
    	private String m_f_29;
	
    	private Nullable<Int32> m_finiquitos;
	
    	private String m_valida_jefe;
	
    	private String m_polnatural;
	
    	private String m_remprevired;
	
    	private String m_liquidacion;
	
    	private String m_imposicion;
	
    	private String m_pais;
	
    	private String m_bonoip;
	
    	private String m_bonois;
	
    	private Nullable<Int32> m_bonoitc_cuenta;
	
    	private String m_tgr;
	
    	private String m_empresa;
	
    	private String m_polsalud;
	
    	private Nullable<Int32> m_bonois_cuenta;
	
    	private Nullable<Int32> m_porc_calc_remu;
	
    	private Nullable<Int32> m_bonoitc_suma;
	
    	private String m_hora_autorizacion;
	
    	private String m_pago_banco_doc;
	
    	private String m_ost;
	
    	private String m_cert_mutual_doc;
	
    	private String m_polmuerte;
	
    	private String m_tgr_doc;
	
    	private String m_poldental;
	
    	private Nullable<Int32> m_dotacion;
	
    	private String m_fecha_autorizacion;
	
    	private String m_f_29_doc;
	
    	private Nullable<DateTime> m_proc_ejec;
	
    	private String m_valida_auditor;
	
    	private String m_autorizacion;
	
    	private String m_division;
	
    	private String m_f_30_1_doc;
	
    	private String m_f_30_1;
	
    	private String m_f_30;
	
    	private String m_dicom;
	
    	private String m_cert_mutual;
	
    	private String m_valida_coordinador;
	
    	private Nullable<Int32> m_porc_docs;
	
    	private Nullable<Int32> m_bonois_suma;
	
    	private String m_foliado;
	
    	private Nullable<Int32> m_porc_auditoria;
	
    	private String m_bonoitc;
	
    	private String m_imposicion_doc;
	
    	private String m_polsalud_doc;
	
    	private String m_polmuerte_doc;
	
    	private String m_foliado_doc;
	
    	private Nullable<Int32> m_bonoip_cuenta;
	
    	private Nullable<Int64> m_iva;
	
    	private String m_periodo;
	
    	private Nullable<Int32> m_bonoip_suma;
	
    	private String m_usuario_autorizacion;
	
    	private String m_pago_banco;
	
    	private String m_dicom_doc;
	
    	private String m_f_30_doc;
	
    	private String m_poldental_doc;
	
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase A400_Auditoria.
        /// </summary>
        public A400_Auditoria()
        { }
		#endregion

		#region [ Propiedades ]

		
		/// <summary>
		/// Gets or sets el valor de: PORC_CALC_AUD.
		/// </summary>
		public Nullable<Int32> PORC_CALC_AUD
		{
			get { return m_porc_calc_aud; }
			set
			{
				if (m_porc_calc_aud != value)
				{
					m_porc_calc_aud = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: POLNATURAL_DOC.
		/// </summary>
		public String POLNATURAL_DOC
		{
			get { return m_polnatural_doc; }
			set
			{
				if (m_polnatural_doc != value)
				{
					m_polnatural_doc = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: F_29.
		/// </summary>
		public String F_29
		{
			get { return m_f_29; }
			set
			{
				if (m_f_29 != value)
				{
					m_f_29 = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: FINIQUITOS.
		/// </summary>
		public Nullable<Int32> FINIQUITOS
		{
			get { return m_finiquitos; }
			set
			{
				if (m_finiquitos != value)
				{
					m_finiquitos = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: VALIDA_JEFE.
		/// </summary>
		public String VALIDA_JEFE
		{
			get { return m_valida_jefe; }
			set
			{
				if (m_valida_jefe != value)
				{
					m_valida_jefe = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: POLNATURAL.
		/// </summary>
		public String POLNATURAL
		{
			get { return m_polnatural; }
			set
			{
				if (m_polnatural != value)
				{
					m_polnatural = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: REMPREVIRED.
		/// </summary>
		public String REMPREVIRED
		{
			get { return m_remprevired; }
			set
			{
				if (m_remprevired != value)
				{
					m_remprevired = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: LIQUIDACION.
		/// </summary>
		public String LIQUIDACION
		{
			get { return m_liquidacion; }
			set
			{
				if (m_liquidacion != value)
				{
					m_liquidacion = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: IMPOSICION.
		/// </summary>
		public String IMPOSICION
		{
			get { return m_imposicion; }
			set
			{
				if (m_imposicion != value)
				{
					m_imposicion = value;
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
		/// Gets or sets el valor de: BONOIP.
		/// </summary>
		public String BONOIP
		{
			get { return m_bonoip; }
			set
			{
				if (m_bonoip != value)
				{
					m_bonoip = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: BONOIS.
		/// </summary>
		public String BONOIS
		{
			get { return m_bonois; }
			set
			{
				if (m_bonois != value)
				{
					m_bonois = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: BONOITC_CUENTA.
		/// </summary>
		public Nullable<Int32> BONOITC_CUENTA
		{
			get { return m_bonoitc_cuenta; }
			set
			{
				if (m_bonoitc_cuenta != value)
				{
					m_bonoitc_cuenta = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: TGR.
		/// </summary>
		public String TGR
		{
			get { return m_tgr; }
			set
			{
				if (m_tgr != value)
				{
					m_tgr = value;
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
		/// Gets or sets el valor de: POLSALUD.
		/// </summary>
		public String POLSALUD
		{
			get { return m_polsalud; }
			set
			{
				if (m_polsalud != value)
				{
					m_polsalud = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: BONOIS_CUENTA.
		/// </summary>
		public Nullable<Int32> BONOIS_CUENTA
		{
			get { return m_bonois_cuenta; }
			set
			{
				if (m_bonois_cuenta != value)
				{
					m_bonois_cuenta = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: PORC_CALC_REMU.
		/// </summary>
		public Nullable<Int32> PORC_CALC_REMU
		{
			get { return m_porc_calc_remu; }
			set
			{
				if (m_porc_calc_remu != value)
				{
					m_porc_calc_remu = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: BONOITC_SUMA.
		/// </summary>
		public Nullable<Int32> BONOITC_SUMA
		{
			get { return m_bonoitc_suma; }
			set
			{
				if (m_bonoitc_suma != value)
				{
					m_bonoitc_suma = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: HORA_AUTORIZACION.
		/// </summary>
		public String HORA_AUTORIZACION
		{
			get { return m_hora_autorizacion; }
			set
			{
				if (m_hora_autorizacion != value)
				{
					m_hora_autorizacion = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: PAGO_BANCO_DOC.
		/// </summary>
		public String PAGO_BANCO_DOC
		{
			get { return m_pago_banco_doc; }
			set
			{
				if (m_pago_banco_doc != value)
				{
					m_pago_banco_doc = value;
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
		/// Gets or sets el valor de: CERT_MUTUAL_DOC.
		/// </summary>
		public String CERT_MUTUAL_DOC
		{
			get { return m_cert_mutual_doc; }
			set
			{
				if (m_cert_mutual_doc != value)
				{
					m_cert_mutual_doc = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: POLMUERTE.
		/// </summary>
		public String POLMUERTE
		{
			get { return m_polmuerte; }
			set
			{
				if (m_polmuerte != value)
				{
					m_polmuerte = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: TGR_DOC.
		/// </summary>
		public String TGR_DOC
		{
			get { return m_tgr_doc; }
			set
			{
				if (m_tgr_doc != value)
				{
					m_tgr_doc = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: POLDENTAL.
		/// </summary>
		public String POLDENTAL
		{
			get { return m_poldental; }
			set
			{
				if (m_poldental != value)
				{
					m_poldental = value;
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
		/// Gets or sets el valor de: FECHA_AUTORIZACION.
		/// </summary>
		public String FECHA_AUTORIZACION
		{
			get { return m_fecha_autorizacion; }
			set
			{
				if (m_fecha_autorizacion != value)
				{
					m_fecha_autorizacion = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: F_29_DOC.
		/// </summary>
		public String F_29_DOC
		{
			get { return m_f_29_doc; }
			set
			{
				if (m_f_29_doc != value)
				{
					m_f_29_doc = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: PROC_EJEC.
		/// </summary>
		public Nullable<DateTime> PROC_EJEC
		{
			get { return m_proc_ejec; }
			set
			{
				if (m_proc_ejec != value)
				{
					m_proc_ejec = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: VALIDA_AUDITOR.
		/// </summary>
		public String VALIDA_AUDITOR
		{
			get { return m_valida_auditor; }
			set
			{
				if (m_valida_auditor != value)
				{
					m_valida_auditor = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: AUTORIZACION.
		/// </summary>
		public String AUTORIZACION
		{
			get { return m_autorizacion; }
			set
			{
				if (m_autorizacion != value)
				{
					m_autorizacion = value;
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
		/// Gets or sets el valor de: F_30_1_DOC.
		/// </summary>
		public String F_30_1_DOC
		{
			get { return m_f_30_1_doc; }
			set
			{
				if (m_f_30_1_doc != value)
				{
					m_f_30_1_doc = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: F_30_1.
		/// </summary>
		public String F_30_1
		{
			get { return m_f_30_1; }
			set
			{
				if (m_f_30_1 != value)
				{
					m_f_30_1 = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: F_30.
		/// </summary>
		public String F_30
		{
			get { return m_f_30; }
			set
			{
				if (m_f_30 != value)
				{
					m_f_30 = value;
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
		/// Gets or sets el valor de: CERT_MUTUAL.
		/// </summary>
		public String CERT_MUTUAL
		{
			get { return m_cert_mutual; }
			set
			{
				if (m_cert_mutual != value)
				{
					m_cert_mutual = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: VALIDA_COORDINADOR.
		/// </summary>
		public String VALIDA_COORDINADOR
		{
			get { return m_valida_coordinador; }
			set
			{
				if (m_valida_coordinador != value)
				{
					m_valida_coordinador = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: PORC_DOCS.
		/// </summary>
		public Nullable<Int32> PORC_DOCS
		{
			get { return m_porc_docs; }
			set
			{
				if (m_porc_docs != value)
				{
					m_porc_docs = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: BONOIS_SUMA.
		/// </summary>
		public Nullable<Int32> BONOIS_SUMA
		{
			get { return m_bonois_suma; }
			set
			{
				if (m_bonois_suma != value)
				{
					m_bonois_suma = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: FOLIADO.
		/// </summary>
		public String FOLIADO
		{
			get { return m_foliado; }
			set
			{
				if (m_foliado != value)
				{
					m_foliado = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: PORC_AUDITORIA.
		/// </summary>
		public Nullable<Int32> PORC_AUDITORIA
		{
			get { return m_porc_auditoria; }
			set
			{
				if (m_porc_auditoria != value)
				{
					m_porc_auditoria = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: BONOITC.
		/// </summary>
		public String BONOITC
		{
			get { return m_bonoitc; }
			set
			{
				if (m_bonoitc != value)
				{
					m_bonoitc = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: IMPOSICION_DOC.
		/// </summary>
		public String IMPOSICION_DOC
		{
			get { return m_imposicion_doc; }
			set
			{
				if (m_imposicion_doc != value)
				{
					m_imposicion_doc = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: POLSALUD_DOC.
		/// </summary>
		public String POLSALUD_DOC
		{
			get { return m_polsalud_doc; }
			set
			{
				if (m_polsalud_doc != value)
				{
					m_polsalud_doc = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: POLMUERTE_DOC.
		/// </summary>
		public String POLMUERTE_DOC
		{
			get { return m_polmuerte_doc; }
			set
			{
				if (m_polmuerte_doc != value)
				{
					m_polmuerte_doc = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: FOLIADO_DOC.
		/// </summary>
		public String FOLIADO_DOC
		{
			get { return m_foliado_doc; }
			set
			{
				if (m_foliado_doc != value)
				{
					m_foliado_doc = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: BONOIP_CUENTA.
		/// </summary>
		public Nullable<Int32> BONOIP_CUENTA
		{
			get { return m_bonoip_cuenta; }
			set
			{
				if (m_bonoip_cuenta != value)
				{
					m_bonoip_cuenta = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: IVA.
		/// </summary>
		public Nullable<Int64> IVA
		{
			get { return m_iva; }
			set
			{
				if (m_iva != value)
				{
					m_iva = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: PERIODO.
		/// </summary>
		public String PERIODO
		{
			get { return m_periodo; }
			set
			{
				if (m_periodo != value)
				{
					m_periodo = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: BONOIP_SUMA.
		/// </summary>
		public Nullable<Int32> BONOIP_SUMA
		{
			get { return m_bonoip_suma; }
			set
			{
				if (m_bonoip_suma != value)
				{
					m_bonoip_suma = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: USUARIO_AUTORIZACION.
		/// </summary>
		public String USUARIO_AUTORIZACION
		{
			get { return m_usuario_autorizacion; }
			set
			{
				if (m_usuario_autorizacion != value)
				{
					m_usuario_autorizacion = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: PAGO_BANCO.
		/// </summary>
		public String PAGO_BANCO
		{
			get { return m_pago_banco; }
			set
			{
				if (m_pago_banco != value)
				{
					m_pago_banco = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: DICOM_DOC.
		/// </summary>
		public String DICOM_DOC
		{
			get { return m_dicom_doc; }
			set
			{
				if (m_dicom_doc != value)
				{
					m_dicom_doc = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: F_30_DOC.
		/// </summary>
		public String F_30_DOC
		{
			get { return m_f_30_doc; }
			set
			{
				if (m_f_30_doc != value)
				{
					m_f_30_doc = value;
				}
			}
		}
	
		/// <summary>
		/// Gets or sets el valor de: POLDENTAL_DOC.
		/// </summary>
		public String POLDENTAL_DOC
		{
			get { return m_poldental_doc; }
			set
			{
				if (m_poldental_doc != value)
				{
					m_poldental_doc = value;
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
	