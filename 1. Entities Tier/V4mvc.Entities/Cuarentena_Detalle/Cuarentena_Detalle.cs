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
	public partial class Cuarentena_Detalle 
	{
		#region [ Variables ]
		private Int32 m_codcuarentena;
		private String m_fecha;
		private String m_f300;
		private String m_hora;
		private String m_usuariovalida;
        private String m_fechavalida;
        private String m_validado;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Cuarentena_Detalle.
		/// </summary>
		public Cuarentena_Detalle()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CODCUARENTENA.
		/// </summary>
		public Int32 CODCUARENTENA
		{
			get { return m_codcuarentena; }
			set
			{
				if (m_codcuarentena != value)
				{
					m_codcuarentena = value;
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
		/// Gets or sets el valor de: FORMATO300.
		/// </summary>
		public String F300
		{
			get { return m_f300; }
			set
			{
				if (m_f300 != value)
				{
                    m_f300 = value;
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
        /// Gets or sets el valor de: USUARIOVALIDA.
        /// </summary>
        public String USUARIOVALIDA
		{
			get { return m_usuariovalida; }
			set
			{
				if (m_usuariovalida != value)
				{
                    m_usuariovalida = value;
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: FECHAVALIDA.
        /// </summary>
        public String FECHAVALIDA
        {
            get { return m_fechavalida; }
            set
            {
                if (m_fechavalida != value)
                {
                    m_fechavalida = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: VALIDADO.
        /// </summary>
        public String VALF300
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
