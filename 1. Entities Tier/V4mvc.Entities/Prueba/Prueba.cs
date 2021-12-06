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
	public partial class Prueba 
	{
		#region [ Variables ]
		private Int32 m_codigo;
        private Int32 m_codctrl_inicial;
        private String m_rut;
        private String m_tipo;
        private String m_resultado;
		private String m_fecha;
		private String m_hora;
		private String m_usuario;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Prueba.
		/// </summary>
		public Prueba()
		{  }
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
		public Int32 CODCTRL_INICIAL
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
		/// Gets or sets el valor de: EMPRESA.
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
		/// Gets or sets el valor de: RESULTADO.
		/// </summary>
        public String RESULTADO
        {
            get { return m_resultado; }
            set
            {
                if (m_resultado != value)
                {
                    m_resultado = value;
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
		/// Gets or sets el valor de: FECHAMOD.
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
