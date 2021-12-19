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
	public partial class Workers
	{
        #region [ Variables ]

        private String m_tipodoc;
        private String m_rut;
		private String m_nombres;
		private String m_apellidos;
		private String m_fechnacim;
		private String m_empresa;
		private String m_castigo;
		private String m_policlin;
		private String m_fecharla;
		private String m_contrato;
		private String m_cedula;
		private String m_expreocup;
		private String m_certantec;
		private String m_fecexpirex;
		private String m_licconduc;
		private String m_fecexpiralic;
		private String m_clase;
		private String m_partes;
		private String m_rol;
		private String m_staff;
		private Nullable<Int16> m_pieza;
		private String m_autor;
		private String m_ccosto;
		private String m_autcasino;
		private Nullable<Int16> m_grupo;
		private String m_zona;
		private String m_clave;
		private String m_autorvisita;
		private String m_casinodes;
		private String m_casinoalm;
		private String m_casinocen;
		private String m_casinocen2;
		private String m_casinootr;
		private String m_casinoperm1;
		private String m_tipopase;
		private String m_turno;
		private String m_grupoturn;
		private String m_ost;
		private String m_fechabloqueo;
		private String m_sexo;
		private String m_finipase;
		private String m_ffinpase;
		private String m_fecexplicint;
		private String m_cool;
		private String m_email;
		private String m_defecha;
		private String m_vip;
		private String m_cargo;
		private String m_doc_das;
		private String m_doc_regint;
		private String m_doc_psicotec;
		private String m_tipovehic;
		private String m_sicofecha;
		private String m_fechamod;
		private String m_horamod;
		private String m_contratofec;
		private String m_contratotip;
		private String m_doc_hvida;
		private String m_nacionalidad;
		private String m_grabo;
		private Nullable<Int32> m_lote;
		private String m_fingreso;
		private String m_finiquito;
		private String m_motivo;
		private String m_doc_finiquito;
		private String m_division;
		private String m_doc_foto;
		private String m_autor_ext;
		private String m_fecmedico;
		private String m_okmedico;
		private String m_doc_manejo;
		private String m_fec_das;
		private String m_validado;
		private String m_quien;
		private String m_finiquito2;
		private String m_doc_finiquito2;
		private String m_alturaex;
		private Nullable<Int32> m_id_area;
		private String m_gsangre;
		private String m_aut_cond_mand;
		private String m_tdoc;
		private String m_idgerencia;
		private String m_idunidad;
		private String m_funcion;
		private Nullable<Int32> m_sap;
		private String m_fiscalizado;
		private String m_ubigeo;
		private String m_codconstcivil;
		private String m_residente;
		private String m_calificado;
		private String m_manoobralocal;
		private Nullable<Int32> m_ginstruccion;
		private String m_cod_habilitacion;
		private Nullable<Int32> m_rol_aaq;
		private Nullable<Int32> m_salario;
		private String m_fecinicasino;
		private String m_fecfincasino;
		private String m_local_trabajo_aaq;
		private Nullable<Int64> m_idsync;
		private String m_restcredencial;
		private String m_obscredencial;

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Workers.
		/// </summary>
		public Workers()
		{  }
        #endregion

        #region [ Propiedades ]

        /// <summary>
        /// Gets or sets el valor de: TIPODOC.
        /// </summary>
        public String TIPODOC
        {
            get { return m_tipodoc; }
            set
            {
                if (m_tipodoc != value)
                {
                    m_tipodoc = value;
                }
            }
        }
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
		/// Gets or sets el valor de: NOMBRES.
		/// </summary>
		public String NOMBRES
		{
			get { return m_nombres; }
			set
			{
				if (m_nombres != value)
				{
					m_nombres = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: APELLIDOS.
		/// </summary>
		public String APELLIDOS
		{
			get { return m_apellidos; }
			set
			{
				if (m_apellidos != value)
				{
					m_apellidos = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHNACIM.
		/// </summary>
		public String FECHNACIM
		{
			get { return m_fechnacim; }
			set
			{
				if (m_fechnacim != value)
				{
					m_fechnacim = value;
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
		/// Gets or sets el valor de: CASTIGO.
		/// </summary>
		public String CASTIGO
		{
			get { return m_castigo; }
			set
			{
				if (m_castigo != value)
				{
					m_castigo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: POLICLIN.
		/// </summary>
		public String POLICLIN
		{
			get { return m_policlin; }
			set
			{
				if (m_policlin != value)
				{
					m_policlin = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHARLA.
		/// </summary>
		public String FECHARLA
		{
			get { return m_fecharla; }
			set
			{
				if (m_fecharla != value)
				{
					m_fecharla = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONTRATO.
		/// </summary>
		public String CONTRATO
		{
			get { return m_contrato; }
			set
			{
				if (m_contrato != value)
				{
					m_contrato = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CEDULA.
		/// </summary>
		public String CEDULA
		{
			get { return m_cedula; }
			set
			{
				if (m_cedula != value)
				{
					m_cedula = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EXPREOCUP.
		/// </summary>
		public String EXPREOCUP
		{
			get { return m_expreocup; }
			set
			{
				if (m_expreocup != value)
				{
					m_expreocup = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CERTANTEC.
		/// </summary>
		public String CERTANTEC
		{
			get { return m_certantec; }
			set
			{
				if (m_certantec != value)
				{
					m_certantec = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECEXPIREX.
		/// </summary>
		public String FECEXPIREX
		{
			get { return m_fecexpirex; }
			set
			{
				if (m_fecexpirex != value)
				{
					m_fecexpirex = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LICCONDUC.
		/// </summary>
		public String LICCONDUC
		{
			get { return m_licconduc; }
			set
			{
				if (m_licconduc != value)
				{
					m_licconduc = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECEXPIRALIC.
		/// </summary>
		public String FECEXPIRALIC
		{
			get { return m_fecexpiralic; }
			set
			{
				if (m_fecexpiralic != value)
				{
					m_fecexpiralic = value;
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
		/// Gets or sets el valor de: PARTES.
		/// </summary>
		public String PARTES
		{
			get { return m_partes; }
			set
			{
				if (m_partes != value)
				{
					m_partes = value;
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
		/// Gets or sets el valor de: STAFF.
		/// </summary>
		public String STAFF
		{
			get { return m_staff; }
			set
			{
				if (m_staff != value)
				{
					m_staff = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PIEZA.
		/// </summary>
		public Nullable<Int16> PIEZA
		{
			get { return m_pieza; }
			set
			{
				if (m_pieza != value)
				{
					m_pieza = value;
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
		/// Gets or sets el valor de: AUTCASINO.
		/// </summary>
		public String AUTCASINO
		{
			get { return m_autcasino; }
			set
			{
				if (m_autcasino != value)
				{
					m_autcasino = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GRUPO.
		/// </summary>
		public Nullable<Int16> GRUPO
		{
			get { return m_grupo; }
			set
			{
				if (m_grupo != value)
				{
					m_grupo = value;
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
		/// Gets or sets el valor de: AUTORVISITA.
		/// </summary>
		public String AUTORVISITA
		{
			get { return m_autorvisita; }
			set
			{
				if (m_autorvisita != value)
				{
					m_autorvisita = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CASINODES.
		/// </summary>
		public String CASINODES
		{
			get { return m_casinodes; }
			set
			{
				if (m_casinodes != value)
				{
					m_casinodes = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CASINOALM.
		/// </summary>
		public String CASINOALM
		{
			get { return m_casinoalm; }
			set
			{
				if (m_casinoalm != value)
				{
					m_casinoalm = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CASINOCEN.
		/// </summary>
		public String CASINOCEN
		{
			get { return m_casinocen; }
			set
			{
				if (m_casinocen != value)
				{
					m_casinocen = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CASINOCEN2.
		/// </summary>
		public String CASINOCEN2
		{
			get { return m_casinocen2; }
			set
			{
				if (m_casinocen2 != value)
				{
					m_casinocen2 = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CASINOOTR.
		/// </summary>
		public String CASINOOTR
		{
			get { return m_casinootr; }
			set
			{
				if (m_casinootr != value)
				{
					m_casinootr = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CASINOPERM1.
		/// </summary>
		public String CASINOPERM1
		{
			get { return m_casinoperm1; }
			set
			{
				if (m_casinoperm1 != value)
				{
					m_casinoperm1 = value;
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
		/// Gets or sets el valor de: TURNO.
		/// </summary>
		public String TURNO
		{
			get { return m_turno; }
			set
			{
				if (m_turno != value)
				{
					m_turno = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GRUPOTURN.
		/// </summary>
		public String GRUPOTURN
		{
			get { return m_grupoturn; }
			set
			{
				if (m_grupoturn != value)
				{
					m_grupoturn = value;
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
		/// Gets or sets el valor de: SEXO.
		/// </summary>
		public String SEXO
		{
			get { return m_sexo; }
			set
			{
				if (m_sexo != value)
				{
					m_sexo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FINIPASE.
		/// </summary>
		public String FINIPASE
		{
			get { return m_finipase; }
			set
			{
				if (m_finipase != value)
				{
					m_finipase = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FFINPASE.
		/// </summary>
		public String FFINPASE
		{
			get { return m_ffinpase; }
			set
			{
				if (m_ffinpase != value)
				{
					m_ffinpase = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECEXPLICINT.
		/// </summary>
		public String FECEXPLICINT
		{
			get { return m_fecexplicint; }
			set
			{
				if (m_fecexplicint != value)
				{
					m_fecexplicint = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COOL.
		/// </summary>
		public String COOL
		{
			get { return m_cool; }
			set
			{
				if (m_cool != value)
				{
					m_cool = value;
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
		/// Gets or sets el valor de: DEFECHA.
		/// </summary>
		public String DEFECHA
		{
			get { return m_defecha; }
			set
			{
				if (m_defecha != value)
				{
					m_defecha = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: VIP.
		/// </summary>
		public String VIP
		{
			get { return m_vip; }
			set
			{
				if (m_vip != value)
				{
					m_vip = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CARGO.
		/// </summary>
		public String CARGO
		{
			get { return m_cargo; }
			set
			{
				if (m_cargo != value)
				{
					m_cargo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOC_DAS.
		/// </summary>
		public String DOC_DAS
		{
			get { return m_doc_das; }
			set
			{
				if (m_doc_das != value)
				{
					m_doc_das = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOC_REGINT.
		/// </summary>
		public String DOC_REGINT
		{
			get { return m_doc_regint; }
			set
			{
				if (m_doc_regint != value)
				{
					m_doc_regint = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOC_PSICOTEC.
		/// </summary>
		public String DOC_PSICOTEC
		{
			get { return m_doc_psicotec; }
			set
			{
				if (m_doc_psicotec != value)
				{
					m_doc_psicotec = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPOVEHIC.
		/// </summary>
		public String TIPOVEHIC
		{
			get { return m_tipovehic; }
			set
			{
				if (m_tipovehic != value)
				{
					m_tipovehic = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SICOFECHA.
		/// </summary>
		public String SICOFECHA
		{
			get { return m_sicofecha; }
			set
			{
				if (m_sicofecha != value)
				{
					m_sicofecha = value;
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
		/// Gets or sets el valor de: CONTRATOFEC.
		/// </summary>
		public String CONTRATOFEC
		{
			get { return m_contratofec; }
			set
			{
				if (m_contratofec != value)
				{
					m_contratofec = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONTRATOTIP.
		/// </summary>
		public String CONTRATOTIP
		{
			get { return m_contratotip; }
			set
			{
				if (m_contratotip != value)
				{
					m_contratotip = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOC_HVIDA.
		/// </summary>
		public String DOC_HVIDA
		{
			get { return m_doc_hvida; }
			set
			{
				if (m_doc_hvida != value)
				{
					m_doc_hvida = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NACIONALIDAD.
		/// </summary>
		public String NACIONALIDAD
		{
			get { return m_nacionalidad; }
			set
			{
				if (m_nacionalidad != value)
				{
					m_nacionalidad = value;
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
		/// Gets or sets el valor de: LOTE.
		/// </summary>
		public Nullable<Int32> LOTE
		{
			get { return m_lote; }
			set
			{
				if (m_lote != value)
				{
					m_lote = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FINGRESO.
		/// </summary>
		public String FINGRESO
		{
			get { return m_fingreso; }
			set
			{
				if (m_fingreso != value)
				{
					m_fingreso = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FINIQUITO.
		/// </summary>
		public String FINIQUITO
		{
			get { return m_finiquito; }
			set
			{
				if (m_finiquito != value)
				{
					m_finiquito = value;
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
		/// Gets or sets el valor de: DOC_FINIQUITO.
		/// </summary>
		public String DOC_FINIQUITO
		{
			get { return m_doc_finiquito; }
			set
			{
				if (m_doc_finiquito != value)
				{
					m_doc_finiquito = value;
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
		/// Gets or sets el valor de: DOC_FOTO.
		/// </summary>
		public String DOC_FOTO
		{
			get { return m_doc_foto; }
			set
			{
				if (m_doc_foto != value)
				{
					m_doc_foto = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUTOR_EXT.
		/// </summary>
		public String AUTOR_EXT
		{
			get { return m_autor_ext; }
			set
			{
				if (m_autor_ext != value)
				{
					m_autor_ext = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECMEDICO.
		/// </summary>
		public String FECMEDICO
		{
			get { return m_fecmedico; }
			set
			{
				if (m_fecmedico != value)
				{
					m_fecmedico = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OKMEDICO.
		/// </summary>
		public String OKMEDICO
		{
			get { return m_okmedico; }
			set
			{
				if (m_okmedico != value)
				{
					m_okmedico = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOC_MANEJO.
		/// </summary>
		public String DOC_MANEJO
		{
			get { return m_doc_manejo; }
			set
			{
				if (m_doc_manejo != value)
				{
					m_doc_manejo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FEC_DAS.
		/// </summary>
		public String FEC_DAS
		{
			get { return m_fec_das; }
			set
			{
				if (m_fec_das != value)
				{
					m_fec_das = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: VALIDADO.
		/// </summary>
		public String VALIDADO
		{
			get { return m_validado; }
			set
			{
				if (m_validado != value)
				{
					m_validado = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: QUIEN.
		/// </summary>
		public String QUIEN
		{
			get { return m_quien; }
			set
			{
				if (m_quien != value)
				{
					m_quien = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FINIQUITO2.
		/// </summary>
		public String FINIQUITO2
		{
			get { return m_finiquito2; }
			set
			{
				if (m_finiquito2 != value)
				{
					m_finiquito2 = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOC_FINIQUITO2.
		/// </summary>
		public String DOC_FINIQUITO2
		{
			get { return m_doc_finiquito2; }
			set
			{
				if (m_doc_finiquito2 != value)
				{
					m_doc_finiquito2 = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ALTURAEX.
		/// </summary>
		public String ALTURAEX
		{
			get { return m_alturaex; }
			set
			{
				if (m_alturaex != value)
				{
					m_alturaex = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_AREA.
		/// </summary>
		public Nullable<Int32> ID_AREA
		{
			get { return m_id_area; }
			set
			{
				if (m_id_area != value)
				{
					m_id_area = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GSANGRE.
		/// </summary>
		public String GSANGRE
		{
			get { return m_gsangre; }
			set
			{
				if (m_gsangre != value)
				{
					m_gsangre = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUT_COND_MAND.
		/// </summary>
		public String AUT_COND_MAND
		{
			get { return m_aut_cond_mand; }
			set
			{
				if (m_aut_cond_mand != value)
				{
					m_aut_cond_mand = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TDOC.
		/// </summary>
		public String TDOC
		{
			get { return m_tdoc; }
			set
			{
				if (m_tdoc != value)
				{
					m_tdoc = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDGERENCIA.
		/// </summary>
		public String IDGERENCIA
		{
			get { return m_idgerencia; }
			set
			{
				if (m_idgerencia != value)
				{
					m_idgerencia = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDUNIDAD.
		/// </summary>
		public String IDUNIDAD
		{
			get { return m_idunidad; }
			set
			{
				if (m_idunidad != value)
				{
					m_idunidad = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FUNCION.
		/// </summary>
		public String FUNCION
		{
			get { return m_funcion; }
			set
			{
				if (m_funcion != value)
				{
					m_funcion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SAP.
		/// </summary>
		public Nullable<Int32> SAP
		{
			get { return m_sap; }
			set
			{
				if (m_sap != value)
				{
					m_sap = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FISCALIZADO.
		/// </summary>
		public String FISCALIZADO
		{
			get { return m_fiscalizado; }
			set
			{
				if (m_fiscalizado != value)
				{
					m_fiscalizado = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: UBIGEO.
		/// </summary>
		public String UBIGEO
		{
			get { return m_ubigeo; }
			set
			{
				if (m_ubigeo != value)
				{
					m_ubigeo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CODCONSTCIVIL.
		/// </summary>
		public String CODCONSTCIVIL
		{
			get { return m_codconstcivil; }
			set
			{
				if (m_codconstcivil != value)
				{
					m_codconstcivil = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RESIDENTE.
		/// </summary>
		public String RESIDENTE
		{
			get { return m_residente; }
			set
			{
				if (m_residente != value)
				{
					m_residente = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CALIFICADO.
		/// </summary>
		public String CALIFICADO
		{
			get { return m_calificado; }
			set
			{
				if (m_calificado != value)
				{
					m_calificado = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MANOOBRALOCAL.
		/// </summary>
		public String MANOOBRALOCAL
		{
			get { return m_manoobralocal; }
			set
			{
				if (m_manoobralocal != value)
				{
					m_manoobralocal = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GINSTRUCCION.
		/// </summary>
		public Nullable<Int32> GINSTRUCCION
		{
			get { return m_ginstruccion; }
			set
			{
				if (m_ginstruccion != value)
				{
					m_ginstruccion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COD_HABILITACION.
		/// </summary>
		public String COD_HABILITACION
		{
			get { return m_cod_habilitacion; }
			set
			{
				if (m_cod_habilitacion != value)
				{
					m_cod_habilitacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ROL_AAQ.
		/// </summary>
		public Nullable<Int32> ROL_AAQ
		{
			get { return m_rol_aaq; }
			set
			{
				if (m_rol_aaq != value)
				{
					m_rol_aaq = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SALARIO.
		/// </summary>
		public Nullable<Int32> SALARIO
		{
			get { return m_salario; }
			set
			{
				if (m_salario != value)
				{
					m_salario = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECINICASINO.
		/// </summary>
		public String FECINICASINO
		{
			get { return m_fecinicasino; }
			set
			{
				if (m_fecinicasino != value)
				{
					m_fecinicasino = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECFINCASINO.
		/// </summary>
		public String FECFINCASINO
		{
			get { return m_fecfincasino; }
			set
			{
				if (m_fecfincasino != value)
				{
					m_fecfincasino = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOCAL_TRABAJO_AAQ.
		/// </summary>
		public String LOCAL_TRABAJO_AAQ
		{
			get { return m_local_trabajo_aaq; }
			set
			{
				if (m_local_trabajo_aaq != value)
				{
					m_local_trabajo_aaq = value;
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
		/// <summary>
		/// Gets or sets el valor de: RESTCREDENCIAL.
		/// </summary>
		public String RESTCREDENCIAL
		{
			get { return m_restcredencial; }
			set
			{
				if (m_restcredencial != value)
				{
					m_restcredencial = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OBSCREDENCIAL.
		/// </summary>
		public String OBSCREDENCIAL
		{
			get { return m_obscredencial; }
			set
			{
				if (m_obscredencial != value)
				{
					m_obscredencial = value;
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
