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
    public partial class CTRLing
    {
		#region [ Variables ]
		private Int32 m_id;
		private String m_rutingreso;
		private String m_fecha;
		private String m_hora;
		private String m_patente;
		private String m_empresa;
		private String m_error;
		private String m_local;
		private String m_inout;
		private String m_ccosto;
		private String m_ost;
		private String m_tipopase;
		private String m_division;
		private String m_vehiculo;
		private String m_cod_pda;
		private String m_usuario;
		private String m_locald;
		private Int32 m_idgerencia;
		#endregion
		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Control_Cuarentena.
		/// </summary>
		public CTRLing()
		{ }
		#endregion
		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ID.
		/// </summary>
		public Int32 ID
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
		/// Gets or sets el valor de: RUTINGRESO.
		/// </summary>
		public String RUTINGRESO
		{
			get { return m_rutingreso; }
			set
			{
				if (m_rutingreso != value)
				{
					m_rutingreso = value;
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
		/// Gets or sets el valor de: ERROR.
		/// </summary>
		public String ERROR
		{
			get { return m_error; }
			set
			{
				if (m_error != value)
				{
					m_error = value;
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
		/// Gets or sets el valor de: INOUT.
		/// </summary>
		public String INOUT
		{
			get { return m_inout; }
			set
			{
				if (m_inout != value)
				{
					m_inout = value;
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
		/// Gets or sets el valor de: VEHICULO.
		/// </summary>
		public String VEHICULO
		{
			get { return m_vehiculo; }
			set
			{
				if (m_vehiculo != value)
				{
					m_vehiculo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COD_PDA.
		/// </summary>
		public String COD_PDA
		{
			get { return m_cod_pda; }
			set
			{
				if (m_cod_pda != value)
				{
					m_cod_pda = value;
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
		/// Gets or sets el valor de: LOCALD.
		/// </summary>
		public String LOCALD
		{
			get { return m_locald; }
			set
			{
				if (m_locald != value)
				{
					m_locald = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDGERENCIA.
		/// </summary>
		public Int32 IDGERENCIA
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
