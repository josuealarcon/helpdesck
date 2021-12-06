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
    public partial class Turnos
    {
        #region [ Variables ]
        private String m_empresa;
        private String m_turno;
        private String m_local;
        private Nullable<Int32> m_diatrabajo;
        private Nullable<Int32> m_diadescanso;
        private String m_ddiurno;
        private String m_dnoche;
        private String m_ddiurno2;
        private String m_dnoche2;
        private String m_fecinicio;
        private String m_turdescr;
        private Nullable<Int32> m_dotturno;
        private String m_clasetur;
        private String m_estadotur;
        private String m_observtur;
        private String m_tienehe;
        private Nullable<Double> m_hmaxdianor;
        private Nullable<Double> m_hmaxdiahe;
        private Nullable<Double> m_hsemana;
        private Nullable<Double> m_hextras;
        private String m_hingreso;
        private String m_hindesde;
        private String m_hinhasta;
        private String m_houtdesde;
        private String m_houthasta;
        private String m_halimi;
        private String m_halims;
        private String m_fechamod;
        private String m_horamod;
        private String m_grabo;
        private String m_tieneferiado;
        private String m_hsalida;
        private Int32 m_idturno;
        private String m_usuariomod;
        private String m_visible;
        private String m_tipo;
        private String m_hingreson;
        private String m_hindesden;
        private String m_hinhastan;
        private String m_hsalidan;
        private String m_houtdesden;
        private String m_houthastan;
        private String m_halimin;
        private String m_halimsn;
        private String m_hsal_ulimodia;
        private String m_fvigencia;
        private String m_empiezanochea;
        private String m_empiezanocheb;
        private String m_empieza;
        private String m_ost;
        private Nullable<Guid> m_id;
        private String m_validado;
        private String m_usrsube;
        private String m_fecsube;
        private String m_horasube;
        private String m_certusuario;
        private String m_certfecha;
        private String m_certhora;
        private String m_obs_rechazo;
        private String m_hsal_ulimonoche;
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Turnos.
        /// </summary>
        public Turnos()
        { }
        #endregion

        #region [ Propiedades ]
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
        /// Gets or sets el valor de: DIATRABAJO.
        /// </summary>
        public Nullable<Int32> DIATRABAJO
        {
            get { return m_diatrabajo; }
            set
            {
                if (m_diatrabajo != value)
                {
                    m_diatrabajo = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: DIADESCANSO.
        /// </summary>
        public Nullable<Int32> DIADESCANSO
        {
            get { return m_diadescanso; }
            set
            {
                if (m_diadescanso != value)
                {
                    m_diadescanso = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: DDIURNO.
        /// </summary>
        public String DDIURNO
        {
            get { return m_ddiurno; }
            set
            {
                if (m_ddiurno != value)
                {
                    m_ddiurno = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: DNOCHE.
        /// </summary>
        public String DNOCHE
        {
            get { return m_dnoche; }
            set
            {
                if (m_dnoche != value)
                {
                    m_dnoche = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: DDIURNO2.
        /// </summary>
        public String DDIURNO2
        {
            get { return m_ddiurno2; }
            set
            {
                if (m_ddiurno2 != value)
                {
                    m_ddiurno2 = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: DNOCHE2.
        /// </summary>
        public String DNOCHE2
        {
            get { return m_dnoche2; }
            set
            {
                if (m_dnoche2 != value)
                {
                    m_dnoche2 = value;
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
        /// Gets or sets el valor de: TURDESCR.
        /// </summary>
        public String TURDESCR
        {
            get { return m_turdescr; }
            set
            {
                if (m_turdescr != value)
                {
                    m_turdescr = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: DOTTURNO.
        /// </summary>
        public Nullable<Int32> DOTTURNO
        {
            get { return m_dotturno; }
            set
            {
                if (m_dotturno != value)
                {
                    m_dotturno = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CLASETUR.
        /// </summary>
        public String CLASETUR
        {
            get { return m_clasetur; }
            set
            {
                if (m_clasetur != value)
                {
                    m_clasetur = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ESTADOTUR.
        /// </summary>
        public String ESTADOTUR
        {
            get { return m_estadotur; }
            set
            {
                if (m_estadotur != value)
                {
                    m_estadotur = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: OBSERVTUR.
        /// </summary>
        public String OBSERVTUR
        {
            get { return m_observtur; }
            set
            {
                if (m_observtur != value)
                {
                    m_observtur = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: TIENEHE.
        /// </summary>
        public String TIENEHE
        {
            get { return m_tienehe; }
            set
            {
                if (m_tienehe != value)
                {
                    m_tienehe = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HMAXDIANOR.
        /// </summary>
        public Nullable<Double> HMAXDIANOR
        {
            get { return m_hmaxdianor; }
            set
            {
                if (m_hmaxdianor != value)
                {
                    m_hmaxdianor = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HMAXDIAHE.
        /// </summary>
        public Nullable<Double> HMAXDIAHE
        {
            get { return m_hmaxdiahe; }
            set
            {
                if (m_hmaxdiahe != value)
                {
                    m_hmaxdiahe = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HSEMANA.
        /// </summary>
        public Nullable<Double> HSEMANA
        {
            get { return m_hsemana; }
            set
            {
                if (m_hsemana != value)
                {
                    m_hsemana = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HEXTRAS.
        /// </summary>
        public Nullable<Double> HEXTRAS
        {
            get { return m_hextras; }
            set
            {
                if (m_hextras != value)
                {
                    m_hextras = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HINGRESO.
        /// </summary>
        public String HINGRESO
        {
            get { return m_hingreso; }
            set
            {
                if (m_hingreso != value)
                {
                    m_hingreso = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HINDESDE.
        /// </summary>
        public String HINDESDE
        {
            get { return m_hindesde; }
            set
            {
                if (m_hindesde != value)
                {
                    m_hindesde = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HINHASTA.
        /// </summary>
        public String HINHASTA
        {
            get { return m_hinhasta; }
            set
            {
                if (m_hinhasta != value)
                {
                    m_hinhasta = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HOUTDESDE.
        /// </summary>
        public String HOUTDESDE
        {
            get { return m_houtdesde; }
            set
            {
                if (m_houtdesde != value)
                {
                    m_houtdesde = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HOUTHASTA.
        /// </summary>
        public String HOUTHASTA
        {
            get { return m_houthasta; }
            set
            {
                if (m_houthasta != value)
                {
                    m_houthasta = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HALIMI.
        /// </summary>
        public String HALIMI
        {
            get { return m_halimi; }
            set
            {
                if (m_halimi != value)
                {
                    m_halimi = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HALIMS.
        /// </summary>
        public String HALIMS
        {
            get { return m_halims; }
            set
            {
                if (m_halims != value)
                {
                    m_halims = value;
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
        /// Gets or sets el valor de: TIENEFERIADO.
        /// </summary>
        public String TIENEFERIADO
        {
            get { return m_tieneferiado; }
            set
            {
                if (m_tieneferiado != value)
                {
                    m_tieneferiado = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HSALIDA.
        /// </summary>
        public String HSALIDA
        {
            get { return m_hsalida; }
            set
            {
                if (m_hsalida != value)
                {
                    m_hsalida = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: IDTURNO.
        /// </summary>
        public Int32 IDTURNO
        {
            get { return m_idturno; }
            set
            {
                if (m_idturno != value)
                {
                    m_idturno = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: USUARIOMOD.
        /// </summary>
        public String USUARIOMOD
        {
            get { return m_usuariomod; }
            set
            {
                if (m_usuariomod != value)
                {
                    m_usuariomod = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: VISIBLE.
        /// </summary>
        public String VISIBLE
        {
            get { return m_visible; }
            set
            {
                if (m_visible != value)
                {
                    m_visible = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: TIPO.
        /// </summary>
        public String TIPO
        {
            get { return m_tipo; }
            set
            {
                if (m_tipo != value)
                {
                    m_tipo = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HINGRESON.
        /// </summary>
        public String HINGRESON
        {
            get { return m_hingreson; }
            set
            {
                if (m_hingreson != value)
                {
                    m_hingreson = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HINDESDEN.
        /// </summary>
        public String HINDESDEN
        {
            get { return m_hindesden; }
            set
            {
                if (m_hindesden != value)
                {
                    m_hindesden = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HINHASTAN.
        /// </summary>
        public String HINHASTAN
        {
            get { return m_hinhastan; }
            set
            {
                if (m_hinhastan != value)
                {
                    m_hinhastan = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HSALIDAN.
        /// </summary>
        public String HSALIDAN
        {
            get { return m_hsalidan; }
            set
            {
                if (m_hsalidan != value)
                {
                    m_hsalidan = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HOUTDESDEN.
        /// </summary>
        public String HOUTDESDEN
        {
            get { return m_houtdesden; }
            set
            {
                if (m_houtdesden != value)
                {
                    m_houtdesden = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HOUTHASTAN.
        /// </summary>
        public String HOUTHASTAN
        {
            get { return m_houthastan; }
            set
            {
                if (m_houthastan != value)
                {
                    m_houthastan = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HALIMIN.
        /// </summary>
        public String HALIMIN
        {
            get { return m_halimin; }
            set
            {
                if (m_halimin != value)
                {
                    m_halimin = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HALIMSN.
        /// </summary>
        public String HALIMSN
        {
            get { return m_halimsn; }
            set
            {
                if (m_halimsn != value)
                {
                    m_halimsn = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HSAL_ULIMODIA.
        /// </summary>
        public String HSAL_ULIMODIA
        {
            get { return m_hsal_ulimodia; }
            set
            {
                if (m_hsal_ulimodia != value)
                {
                    m_hsal_ulimodia = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: FVIGENCIA.
        /// </summary>
        public String FVIGENCIA
        {
            get { return m_fvigencia; }
            set
            {
                if (m_fvigencia != value)
                {
                    m_fvigencia = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: EMPIEZANOCHEA.
        /// </summary>
        public String EMPIEZANOCHEA
        {
            get { return m_empiezanochea; }
            set
            {
                if (m_empiezanochea != value)
                {
                    m_empiezanochea = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: EMPIEZANOCHEB.
        /// </summary>
        public String EMPIEZANOCHEB
        {
            get { return m_empiezanocheb; }
            set
            {
                if (m_empiezanocheb != value)
                {
                    m_empiezanocheb = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: EMPIEZA.
        /// </summary>
        public String EMPIEZA
        {
            get { return m_empieza; }
            set
            {
                if (m_empieza != value)
                {
                    m_empieza = value;
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
        /// Gets or sets el valor de: ID.
        /// </summary>
        public Nullable<Guid> ID
        {
            get { return m_id; }
            set
            {
                if (m_id != value)
                {
                    m_id = value;
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
        /// Gets or sets el valor de: USRSUBE.
        /// </summary>
        public String USRSUBE
        {
            get { return m_usrsube; }
            set
            {
                if (m_usrsube != value)
                {
                    m_usrsube = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: FECSUBE.
        /// </summary>
        public String FECSUBE
        {
            get { return m_fecsube; }
            set
            {
                if (m_fecsube != value)
                {
                    m_fecsube = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HORASUBE.
        /// </summary>
        public String HORASUBE
        {
            get { return m_horasube; }
            set
            {
                if (m_horasube != value)
                {
                    m_horasube = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CERTUSUARIO.
        /// </summary>
        public String CERTUSUARIO
        {
            get { return m_certusuario; }
            set
            {
                if (m_certusuario != value)
                {
                    m_certusuario = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CERTFECHA.
        /// </summary>
        public String CERTFECHA
        {
            get { return m_certfecha; }
            set
            {
                if (m_certfecha != value)
                {
                    m_certfecha = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CERTHORA.
        /// </summary>
        public String CERTHORA
        {
            get { return m_certhora; }
            set
            {
                if (m_certhora != value)
                {
                    m_certhora = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: OBS_RECHAZO.
        /// </summary>
        public String OBS_RECHAZO
        {
            get { return m_obs_rechazo; }
            set
            {
                if (m_obs_rechazo != value)
                {
                    m_obs_rechazo = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: HSAL_ULIMONOCHE.
        /// </summary>
        public String HSAL_ULIMONOCHE
        {
            get { return m_hsal_ulimonoche; }
            set
            {
                if (m_hsal_ulimonoche != value)
                {
                    m_hsal_ulimonoche = value;
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
