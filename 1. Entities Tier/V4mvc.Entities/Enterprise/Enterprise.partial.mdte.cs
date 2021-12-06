using System;

namespace V4mvc.Entities
{
    public partial class Enterprise
    {
        public string DIVISION { get; set; }

        public int COUNT { get; set; }
        public int START { get; set; }
        public int LENGTH { get; set; }
        public string COLUMN { get; set; }
        public string DIRECTION { get; set; }

        public string IDEMPRESA_F {
            get { return Utils.strRut(IDEMPRESA); }
        }
        public int? COMUN { get; set; }

    }
}
