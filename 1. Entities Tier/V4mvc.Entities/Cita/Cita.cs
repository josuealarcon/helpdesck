using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Cita
    {
        #region [ Variables ]
        private Int32 m_codigo;
        private String m_codctrl_inicial;
        private String m_rut;
        private String m_hora;
        private String m_fecha;
        private String m_nombre;
        private String m_ruc;
        private String m_ciudad;
        private String m_direccion;
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Mutualidad.
        /// </summary>
        public Cita()
        { }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CODIGO.
		/// </summary>
		public Int32 CODIGO
		{
			get { return m_codigo; }
			set
			{
				if (m_codigo != value)
				{
					m_codigo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CODCTRL_INICIAL.
		/// </summary>
		public String CODCTRL_INICIAL
		{
			get { return m_codctrl_inicial; }
			set
			{
				if (m_codctrl_inicial != value)
				{
					m_codctrl_inicial = value;
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
		/// Gets or sets el valor de: RUC.
		/// </summary>
		public String RUC
		{
			get { return m_ruc; }
			set
			{
				if (m_ruc != value)
				{
					m_ruc = value;
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
		/// Gets or sets el valor de: DIRECCION.
		/// </summary>
		public String DIRECCION
		{
			get { return m_direccion; }
			set
			{
				if (m_direccion != value)
				{
					m_direccion = value;
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
