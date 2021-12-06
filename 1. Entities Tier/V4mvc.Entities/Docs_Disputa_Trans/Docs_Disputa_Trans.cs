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
	public partial class Docs_Disputa_Trans 
	{
		#region [ Variables ]
		private Guid m_id;
		private Int32 m_id_doc;
		private String m_division;
		private String m_empresa;
		private String m_patente;
		private String m_observacion;
		private String m_usuario;
		private String m_fecha;
		private String m_hora;
		private String m_certusuario;
		private String m_certfecha;
		private String m_certhora;
		private String m_estado;
		private String m_observacion_reval;
		private String m_revalusuario;
		private String m_revalfecha;
		private String m_revalhora;
		private Int32 m_id_disputa;
		private String m_validado;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Docs_Disputa_Trans.
		/// </summary>
		public Docs_Disputa_Trans()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Guid ID
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
		/// Gets or sets el valor de: ID_DOC.
		/// </summary>
		public Int32 ID_DOC
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
		/// Gets or sets el valor de: PATENTE.
		/// </summary>
		public String PATENTE
		{
			get { return m_patente; }
			set
			{
				if (m_patente != value)
				{
					m_patente = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OBSERVACION.
		/// </summary>
		public String OBSERVACION
		{
			get { return m_observacion; }
			set
			{
				if (m_observacion != value)
				{
					m_observacion = value;
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
		/// Gets or sets el valor de: FECHA.
		/// </summary>
		public String FECHA
		{
			get { return m_fecha; }
			set
			{
				if (m_fecha != value)
				{
					m_fecha = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORA.
		/// </summary>
		public String HORA
		{
			get { return m_hora; }
			set
			{
				if (m_hora != value)
				{
					m_hora = value;
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
		/// Gets or sets el valor de: ESTADO.
		/// </summary>
		public String ESTADO
		{
			get { return m_estado; }
			set
			{
				if (m_estado != value)
				{
					m_estado = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OBSERVACION_REVAL.
		/// </summary>
		public String OBSERVACION_REVAL
		{
			get { return m_observacion_reval; }
			set
			{
				if (m_observacion_reval != value)
				{
					m_observacion_reval = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REVALUSUARIO.
		/// </summary>
		public String REVALUSUARIO
		{
			get { return m_revalusuario; }
			set
			{
				if (m_revalusuario != value)
				{
					m_revalusuario = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REVALFECHA.
		/// </summary>
		public String REVALFECHA
		{
			get { return m_revalfecha; }
			set
			{
				if (m_revalfecha != value)
				{
					m_revalfecha = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REVALHORA.
		/// </summary>
		public String REVALHORA
		{
			get { return m_revalhora; }
			set
			{
				if (m_revalhora != value)
				{
					m_revalhora = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_DISPUTA.
		/// </summary>
		public Int32 ID_DISPUTA
		{
			get { return m_id_disputa; }
			set
			{
				if (m_id_disputa != value)
				{
					m_id_disputa = value;
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
