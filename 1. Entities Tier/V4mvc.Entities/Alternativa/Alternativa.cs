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
	public partial class Alternativa 
	{
		#region [ Variables ]
		private Int32 m_codigo;
		private Int32 m_codcuestionario;
        private String m_tipo;
        private String m_descripcion;
		private Boolean m_comenta;
		private Int32 m_orden;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Alternativa.
		/// </summary>
		public Alternativa()
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
		/// Gets or sets el valor de: CODCUESTIONARIO.
		/// </summary>
		public Int32 CODCUESTIONARIO
		{
			get { return m_codcuestionario; }
			set
			{
				if (m_codcuestionario != value)
				{
					m_codcuestionario = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DESCRIPCION.
		/// </summary>
		public String DESCRIPCION
		{
			get { return m_descripcion; }
			set
			{
				if (m_descripcion != value)
				{
					m_descripcion = value;
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
        /// Gets or sets el valor de: COMENTA.
        /// </summary>
        public Boolean COMENTA
		{
			get { return m_comenta; }
			set
			{
				if (m_comenta != value)
				{
					m_comenta = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ORDEN.
		/// </summary>
		public Int32 ORDEN
		{
			get { return m_orden; }
			set
			{
				if (m_orden != value)
				{
					m_orden = value;
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
