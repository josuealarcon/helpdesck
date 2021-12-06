using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    public partial class OSTArbol
    {
        public int DOTACION { get; set; }
        public string SUBC { get; set; }
        public string SUBC2 { get; set; }
        public string FINICIO_FORMATOG { get { return Utils.Fec_User(FINICIO, Utils.Formato_Fecha.Guion); } }
        public string FTERMINO_FORMATOG { get { return Utils.Fec_User(FTERMINO, Utils.Formato_Fecha.Guion); } }
        public string ESTADO { get; set; }
        public OST OSTMADRE { get; set; }
        public OSTSubc OSTSUBC { get; set; }
        public Docs_Ost DOCS_OST { get; set; }
        public OSTArbol OSTARBOL { get; set; }
        public string NOMBRE_ARCHIVO { get; set; }
        public string NOMBRES_ADMINSUBC { get; set; }
        public string APELLIDOS_ADMINSUBC { get; set; }
    }
}
