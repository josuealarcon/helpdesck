//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contratista.Pases {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class CrearPase {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CrearPase() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("V4mvc.Presentation.Resources.Contratista.Pases.CrearPase", typeof(CrearPase).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Guardar y Siguiente.
        /// </summary>
        public static string Btn_Siguiente {
            get {
                return ResourceManager.GetString("Btn_Siguiente", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Contrato.
        /// </summary>
        public static string Lbl_Contrato {
            get {
                return ResourceManager.GetString("Lbl_Contrato", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Descripcion.
        /// </summary>
        public static string Lbl_Descripcion {
            get {
                return ResourceManager.GetString("Lbl_Descripcion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Operacion.
        /// </summary>
        public static string Lbl_Division {
            get {
                return ResourceManager.GetString("Lbl_Division", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Empresa.
        /// </summary>
        public static string Lbl_Empresa {
            get {
                return ResourceManager.GetString("Lbl_Empresa", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Fecha Fin.
        /// </summary>
        public static string Lbl_FechaFin {
            get {
                return ResourceManager.GetString("Lbl_FechaFin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Fecha Inicio.
        /// </summary>
        public static string Lbl_FechaInicio {
            get {
                return ResourceManager.GetString("Lbl_FechaInicio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Crear Pase.
        /// </summary>
        public static string Lbl_NombreVista {
            get {
                return ResourceManager.GetString("Lbl_NombreVista", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Tipo de Pase.
        /// </summary>
        public static string Lbl_TipoPase {
            get {
                return ResourceManager.GetString("Lbl_TipoPase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Los campos marcados con (*) son requeridos.
        /// </summary>
        public static string Msg_CamposMarcados {
            get {
                return ResourceManager.GetString("Msg_CamposMarcados", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a No puede solicitar pase ya que el contrato no completo los items de informacion de seguridad.
        /// </summary>
        public static string Msg_ErrorValidacion {
            get {
                return ResourceManager.GetString("Msg_ErrorValidacion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El pase no cumple con las fechas de los periodos, asegurese que las fechas esten dentro del rango de algun periodo.
        /// </summary>
        public static string Msg_Fecha_Fuera_Periodo {
            get {
                return ResourceManager.GetString("Msg_Fecha_Fuera_Periodo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Fecha de termino es mayor a la fecha final del contrato.
        /// </summary>
        public static string Msg_FechaFin_Mayor_FFinalContrato {
            get {
                return ResourceManager.GetString("Msg_FechaFin_Mayor_FFinalContrato", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a La fecha fin debe ser mayor o igual a la de inicio.
        /// </summary>
        public static string Msg_FechaFin_MayorIgual_FechaInicio {
            get {
                return ResourceManager.GetString("Msg_FechaFin_MayorIgual_FechaInicio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Fecha de termino es menor a la fecha de hoy, no tendra ninguna funcionalidad la creacion del pase.
        /// </summary>
        public static string Msg_FechaFin_Menor_Hoy {
            get {
                return ResourceManager.GetString("Msg_FechaFin_Menor_Hoy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Fecha inicio debe ser menor o igual a fecha fin.
        /// </summary>
        public static string Msg_FechaInicio_Mayor_FechaFin {
            get {
                return ResourceManager.GetString("Msg_FechaInicio_Mayor_FechaFin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Fecha de inicio es mayor a la fecha final del contrato.
        /// </summary>
        public static string Msg_FechaInicio_Mayor_FFinalContrato {
            get {
                return ResourceManager.GetString("Msg_FechaInicio_Mayor_FFinalContrato", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Fecha de inicio es menor a la de inicio del contrato.
        /// </summary>
        public static string Msg_FechaInicio_Mayor_FInicioContrato {
            get {
                return ResourceManager.GetString("Msg_FechaInicio_Mayor_FInicioContrato", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Fecha inicio debe ser mayor o igual a hoy.
        /// </summary>
        public static string Msg_FechaInicio_Mayor_Hoy {
            get {
                return ResourceManager.GetString("Msg_FechaInicio_Mayor_Hoy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Informacion.
        /// </summary>
        public static string Msg_Informacion {
            get {
                return ResourceManager.GetString("Msg_Informacion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Ocurrio un error, intentelo mas tarde.
        /// </summary>
        public static string Msg_OcurrioError {
            get {
                return ResourceManager.GetString("Msg_OcurrioError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se requiere un Contrato OST seleccionado.
        /// </summary>
        public static string Msg_OST_Requerido {
            get {
                return ResourceManager.GetString("Msg_OST_Requerido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Pase guardado exitosamente.
        /// </summary>
        public static string Msg_Pase_Guardado {
            get {
                return ResourceManager.GetString("Msg_Pase_Guardado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Ingresar Descripcion.
        /// </summary>
        public static string Phl_Descripcion {
            get {
                return ResourceManager.GetString("Phl_Descripcion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECCIONE OPERACION.
        /// </summary>
        public static string Phl_Division {
            get {
                return ResourceManager.GetString("Phl_Division", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECCIONE EMPRESA.
        /// </summary>
        public static string Phl_Empresa {
            get {
                return ResourceManager.GetString("Phl_Empresa", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Seleccione Fecha Fin.
        /// </summary>
        public static string Phl_FechaFin {
            get {
                return ResourceManager.GetString("Phl_FechaFin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Seleccione Fecha Inicio.
        /// </summary>
        public static string Phl_FechaInicio {
            get {
                return ResourceManager.GetString("Phl_FechaInicio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECCIONE TIPO PASE.
        /// </summary>
        public static string Phl_TipoPase {
            get {
                return ResourceManager.GetString("Phl_TipoPase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Descripcion.
        /// </summary>
        public static string Tblh_Contratos_Descripcion {
            get {
                return ResourceManager.GetString("Tblh_Contratos_Descripcion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Fecha Final.
        /// </summary>
        public static string Tblh_Contratos_FechaFinal {
            get {
                return ResourceManager.GetString("Tblh_Contratos_FechaFinal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Fecha Inicio.
        /// </summary>
        public static string Tblh_Contratos_FechaInicio {
            get {
                return ResourceManager.GetString("Tblh_Contratos_FechaInicio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Nro Contrato.
        /// </summary>
        public static string Tblh_Contratos_NroContrato {
            get {
                return ResourceManager.GetString("Tblh_Contratos_NroContrato", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Seleccionar.
        /// </summary>
        public static string Tblh_Contratos_Seleccionar {
            get {
                return ResourceManager.GetString("Tblh_Contratos_Seleccionar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Descripcion es requerido.
        /// </summary>
        public static string Val_Required_Descripcion {
            get {
                return ResourceManager.GetString("Val_Required_Descripcion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Seleccione operación.
        /// </summary>
        public static string Val_Required_Division {
            get {
                return ResourceManager.GetString("Val_Required_Division", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Seleccione Empresa.
        /// </summary>
        public static string Val_Required_Empresa {
            get {
                return ResourceManager.GetString("Val_Required_Empresa", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Fecha Fin es requerido.
        /// </summary>
        public static string Val_Required_FechaFin {
            get {
                return ResourceManager.GetString("Val_Required_FechaFin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Fecha Inicio es requerido.
        /// </summary>
        public static string Val_Required_FechaInicio {
            get {
                return ResourceManager.GetString("Val_Required_FechaInicio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Seleccione Tipo de Pase.
        /// </summary>
        public static string Val_Required_TipoPermiso {
            get {
                return ResourceManager.GetString("Val_Required_TipoPermiso", resourceCulture);
            }
        }
    }
}
