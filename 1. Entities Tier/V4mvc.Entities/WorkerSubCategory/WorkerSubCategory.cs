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
	public partial class WorkerSubCategory 
	{
		#region [ Variables ]
		private Int32 m_id;
        private String m_codigo;
        private String m_categoria;
        private String m_descripcion;
		private String m_activo;
		private String m_fec_reg;
		private String m_hora_reg;
		private String m_usr_reg;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase WorkerSubCategory.
		/// </summary>
		public WorkerSubCategory()
		{  }
		#endregion

		#region [ Propiedades ]
        /// <summary>
		/// Gets or sets el valor de: Id.
		/// </summary>
		public Int32 Id
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
        /// Gets or sets el valor de: CODIGO.
        /// </summary>
        public String CODIGO
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
		/// Gets or sets el valor de: CATEGORIA.
		/// </summary>
		public String CATEGORIA
        {
			get { return m_categoria; }
			set
			{
				if (m_categoria != value)
				{
                    m_categoria = value;
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
        /// Gets or sets el valor de: ACTIVO.
        /// </summary>
        public String ACTIVO
		{
			get { return m_activo; }
			set
			{
				if (m_activo != value)
				{
					m_activo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORAREGISTRO.
		/// </summary>
		public String HORAREGISTRO
		{
			get { return m_hora_reg; }
			set
			{
				if (m_hora_reg != value)
				{
					m_hora_reg = value;
				}
			}
		}

		/// <summary>
		/// Gets or sets el valor de: FECREGISTRO.
		/// </summary>
		public String FECREGISTRO
		{
			get { return m_fec_reg; }
			set
			{
				if (m_fec_reg != value)
				{
					m_fec_reg = value;
				}
			}
		}

		/// <summary>
		/// Gets or sets el valor de: USRREGISTRO.
		/// </summary>
		public String USRREGISTRO
        {
			get { return m_usr_reg; }
			set
			{
				if (m_usr_reg != value)
				{
                    m_usr_reg = value;
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
