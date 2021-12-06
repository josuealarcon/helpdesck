using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    public static class Utils
    {
        public enum Formato_Fecha
        {
            GuionMesLetras,
            Guion,
            Slash,
            BaseDatos,
            Periodo,
            Mes

        }

        public enum Apellido
        {
            Paterno,
            Materno
        }

        public class AlertaDispEliminadaArgs
        {
            public string ID { get; set; }
            public string PATENTE { get; set; }

            public int? TIPO_DOCUMENTO_ID { get; set; }
            public string EMPRESA { get; set; }
            public string PERIODO { get; set; }

            public string ID_ELIM { get; set; }

        }
        public static string ObtieneEdad(string fecha)
        {
            if (!string.IsNullOrEmpty(fecha))
            {
                if (fecha.Length == 8)
                {
                    return (DateTime.Now.Year - Int32.Parse(fecha.Substring(0, 4))) + " años al "
                        + Fec_User((DateTime.Now.Year + string.Empty) +
                                   (DateTime.Now.Month.ToString().Length < 2 ? "0" + DateTime.Now.Month : DateTime.Now.Month + string.Empty) +
                                   (DateTime.Now.Day.ToString().Length < 2 ? "0" + DateTime.Now.Day : DateTime.Now.Day + string.Empty), Formato_Fecha.GuionMesLetras);
                }
            }
            return string.Empty;
        }

        public static string FormatoPatente(string placa)
        {
            try
            {
                if (!string.IsNullOrEmpty(placa))
                {
                    bool guion = false;
                    string resultado = string.Empty;
                    for (int i = placa.Length - 1; i >= 1; i--)
                    {
                        if (!guion && char.IsDigit(placa[i]) != char.IsDigit(placa[i - 1]))
                        {
                            resultado += placa[i] + "-";
                            guion = true;
                        }
                        else
                            resultado += placa[i];
                    }

                    if (placa.Length > 0) resultado += placa[0];

                    return new string(resultado.Reverse().ToArray());
                }
                return string.Empty;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public static string EmailOculto(string email)
        {
            try
            {
                if (!string.IsNullOrEmpty(email))
                {
                    string[] user = email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] domain = (user.Length > 1 ? user[1].Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries) : new string[] { });
                    return (user.Length > 0 ? (user[0].Substring(0, 1) + string.Empty.PadLeft(user[0].Length - 1, '*')) : "") + "@"
                           + (domain.Length > 0 ? (string.Empty.PadLeft(domain[0].Length - 2, '*') + domain[0].Substring(domain[0].Length - 2)) : "") + "." + (domain.Length > 1 ? domain[1] : "");
                }
                else return string.Empty;
            }
            catch (Exception ex)
            { throw ex; }
        }


        public static string Fec_User(string fecha, Formato_Fecha formato)
        {
            try
            {
                string _fecha = string.Empty;
                Dictionary<string, KeyValuePair<string, string>> meses = new Dictionary<string, KeyValuePair<string, string>>();
                meses.Add("01", new KeyValuePair<string, string>("-Ene-", "ENERO"));
                meses.Add("02", new KeyValuePair<string, string>("-Feb-", "FEBRERO"));
                meses.Add("03", new KeyValuePair<string, string>("-Mar-", "MARZO"));
                meses.Add("04", new KeyValuePair<string, string>("-Abr-", "ABRIL"));
                meses.Add("05", new KeyValuePair<string, string>("-May-", "MAYO"));
                meses.Add("06", new KeyValuePair<string, string>("-Jun-", "JUNIO"));
                meses.Add("07", new KeyValuePair<string, string>("-Jul-", "JULIO"));
                meses.Add("08", new KeyValuePair<string, string>("-Ago-", "AGOSTO"));
                meses.Add("09", new KeyValuePair<string, string>("-Sep-", "SEPTIEMBRE"));
                meses.Add("10", new KeyValuePair<string, string>("-Oct-", "OCTUBRE"));
                meses.Add("11", new KeyValuePair<string, string>("-Nov-", "NOVIEMBRE"));
                meses.Add("12", new KeyValuePair<string, string>("-Dic-", "DICIEMBRE"));


                if (string.IsNullOrEmpty(fecha))
                    return Fec_User("19000101", formato);
                else
                {
                    switch (formato)
                    {
                        case Formato_Fecha.Guion:
                            if (fecha.Length == 8)
                            {
                                _fecha = fecha.Substring(0, 4) + "-" + fecha.Substring(4, 2) + "-" + fecha.Substring(6, 2);
                            }
                            if (fecha.Length == 6)
                            {
                                _fecha = fecha.Substring(0, 4) + "-" + fecha.Substring(4, 2);
                            }
                            break;
                        case Formato_Fecha.GuionMesLetras:
                            if (fecha.Length == 8)
                            {
                                _fecha = fecha.Substring(6, 2) + (meses.ContainsKey(fecha.Substring(4, 2)) ? meses[fecha.Substring(4, 2)].Key : "- -") + fecha.Substring(0, 4);
                            }
                            if (fecha.Length == 6)
                            {
                                _fecha = (meses.ContainsKey(fecha.Substring(4, 2)) ? meses[fecha.Substring(4, 2)].Key.Substring(1, 4) : "- -") + fecha.Substring(0, 4);
                            }
                            break;
                        case Formato_Fecha.Slash:
                            if (fecha.Length == 8)
                            {
                                _fecha = fecha.Substring(6, 2) + "/" + fecha.Substring(4, 2) + "/" + fecha.Substring(0, 4);
                            }
                            break;
                        case Formato_Fecha.BaseDatos:
                            if (fecha.Length == 10)
                            {
                                _fecha = fecha.Substring(0, 4) + fecha.Substring(5, 2) + fecha.Substring(8, 2);
                            }
                            if (fecha.Length == 7)
                            {
                                _fecha = fecha.Substring(0, 4) + fecha.Substring(5, 2);
                            }
                            break;
                        case Formato_Fecha.Periodo:
                            if (fecha.Length == 6)
                            {
                                _fecha = (fecha.Substring(0, 4) + meses[fecha.Substring(4, 2)]).Substring(0, 8);
                            }
                            if (fecha.Length == 8)
                            {
                                _fecha = (fecha.Substring(0, 4) + meses[fecha.Substring(4, 2)]).Substring(0, 8);
                            }
                            break;
                        case Formato_Fecha.Mes:
                            if (fecha.Length == 8 || fecha.Length == 6)
                            {
                                _fecha = meses[fecha.Substring(4, 2)].Value;
                            }
                            break;
                    }
                }
                return _fecha;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public static string SplitApellidos(string apellidos, Apellido tipo)
        {
            try
            {
                string retorno = string.Empty;
                if (!string.IsNullOrEmpty(apellidos))
                {
                    string[] _apellidos = apellidos.Split(new char[] { ' ', ',', '.', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
                    switch (tipo)
                    {
                        case Apellido.Paterno:
                            switch (_apellidos.Length)
                            {
                                case 1:
                                    retorno = apellidos;
                                    break;
                                case 2:
                                    retorno = _apellidos[0];
                                    break;
                                default:
                                    retorno = apellidos;
                                    break;
                            }
                            break;
                        case Apellido.Materno:
                            switch (_apellidos.Length)
                            {
                                case 1:
                                    retorno = apellidos;
                                    break;
                                case 2:
                                    retorno = _apellidos[1];
                                    break;
                                default:
                                    retorno = apellidos;
                                    break;
                            }
                            break;
                        default: break;
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public static string ConvertDatetimeToDB(object fecha)
        {
            DateTime fec_user;
            string fec_usuario = "19000101";
            if (fecha != null)
            {
                if (fecha.ToString() != "")
                {
                    if (DateTime.TryParseExact(fecha.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fec_user))
                    {
                        fec_usuario = fec_user.ToString("yyyyMMdd");
                    }
                    else if (DateTime.TryParseExact(fecha.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fec_user))
                    {
                        fec_usuario = fec_user.ToString("yyyyMMdd");
                    }
                    else
                    {
                        fec_usuario = ConvertToDateTime(fecha).ToString("yyyyMMdd");
                    }
                }
            }
            return fec_usuario;
        }
        public static DateTime ConvertToDateTime(object fecha)
        {
            DateTime fecreturn = new DateTime();
            DateTime fec_user;
            try
            {
                if (fecha != null)
                {
                    if (fecha.ToString() != "")
                    {
                        if (DateTime.TryParseExact(fecha.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fec_user))
                        {
                            fecreturn = fec_user;
                        }
                        else if (DateTime.TryParseExact(fecha.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fec_user))
                        {
                            fecreturn = fec_user;
                        }
                        else if (DateTime.TryParse(fecha.ToString(), CultureInfo.InvariantCulture, DateTimeStyles.None, out fec_user))
                        {
                            fecreturn = fec_user;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return fecreturn;
            }
            return fecreturn;
        }

        public static ExpandoObject ToExpando(this object anonymousObject)
        {
            IDictionary<string, object> expando = new ExpandoObject();
            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(anonymousObject))
            {
                var obj = propertyDescriptor.GetValue(anonymousObject);
                expando.Add(propertyDescriptor.Name, obj);
            }

            return (ExpandoObject)expando;
        }

        public static string getClosestCulture(string target)
        {
            string culture = null;
            List<string> cultures = new List<string>();
            bool done = false;
            if (!string.IsNullOrEmpty(target))
            {
                var tokens = target.Split(new char[] { '-' });
                string base_lan = null;
                if (tokens.Length > 0)
                    base_lan = tokens[0];
                else
                    done = true;

                CultureInfo[] cinfo = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);
                foreach (CultureInfo cul in cinfo)
                {
                    if (done)
                    {
                        break;
                    }
                    if (cul.Name.StartsWith(base_lan))
                    {
                        cultures.Add(cul.Name);
                        if (cul.Name == target)
                        {
                            culture = cul.Name;
                            done = true;
                        }
                    }
                }
                if (!done)
                {
                    if (cultures.Count > 0)
                    {
                        culture = cultures.OrderByDescending(x => x.Length).First();
                    }
                }
            }
            return culture;
        }

        //--------------------[strRut]---------------------------------------

        public static void custom_debug_msg(string msg)
        {
            System.Diagnostics.Debug.WriteLine("===============>>>>" + msg);
        }

        public static void custom_debug_obj(object obj)
        {
            System.Diagnostics.Debug.WriteLine("===============>>>>" + Newtonsoft.Json.JsonConvert.SerializeObject(obj));
        }
        public static void nowIntoDbFrmtedTokens(ref string dt, ref string tm)
        {
            DateTime today = DateTime.Now;
            dt = today.ToString("yyyyMMdd");
            tm = today.ToString("HH:mm:ss");
        }

        public static string generateAllExtensions(string base_extensions)
        {
            HashSet<string> all_extensions = new HashSet<string>();
            if (!string.IsNullOrEmpty(base_extensions))
            {
                foreach (var extension in base_extensions.Split(','))
                {
                    all_extensions.Add(extension.ToLower());
                    all_extensions.Add(extension.ToUpper());
                }
            }
            return all_extensions.Count() > 0 ? string.Join(",", all_extensions) : "";
        }

        public static string reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ExtlessFilename(string filename)
        {
            return string.IsNullOrEmpty(filename) ? filename : System.IO.Path.GetFileNameWithoutExtension(filename);
        }

        public static string getExtension(string filename)
        {
            return string.IsNullOrEmpty(filename) ? filename : System.IO.Path.GetExtension(filename);
        }

        public static string agregar_puntos_miles(string str_num)
        {
            string ret = "";
            try
            {
                string num_nuevo = "";
                int largo = str_num.Length - 1;
                for (int i = 0; i < str_num.Length; ++i)
                {
                    if (i % 3 == 0 && i > 0)
                    {
                        num_nuevo = num_nuevo + ".";
                    }
                    num_nuevo = num_nuevo + str_num[largo];
                    --largo;
                }
                ret = reverse(num_nuevo);
            }
            catch
            {
                ret = "";
            }
            return ret;
        }

        public static string strRut(string rut)
        {
            if (string.IsNullOrEmpty(rut))
            {
                return rut;
            }
            string str = rut;
            try
            {
                string cabeza = str.Substring(0, str.Length - 1).Trim('-');
                int outnum;
                if (int.TryParse(cabeza, out outnum))
                {
                    cabeza = agregar_puntos_miles(cabeza);
                }
                char cola = str[str.Length - 1];
                str = cabeza + "-" + cola;
            }
            catch
            {
                str = "";
            }
            return str;
        }

        public static bool ValidarRUT(string RUT)
        {
            try
            {
                string ultimo_digito = RUT.Substring(RUT.Length - 1, 1);
                string numRut = RUT.Substring(0, RUT.Length - 1);
                char[] serie = "23456723".ToArray();
                char[] arr = reverse(numRut).ToArray();
                int suma = 0;
                for (int i = 0; i <= numRut.Length - 1; i++)
                    suma = suma + (Convert.ToInt32(arr[i].ToString()) * Convert.ToInt32(serie[i].ToString()));

                int suma_resta = suma - (11 * (suma / 11));
                int resultado = 11 - suma_resta;
                string digito_verificador = string.Empty;
                switch (11 - suma_resta)
                {
                    case 11:
                        digito_verificador = "0";
                        break;
                    case 10:
                        digito_verificador = "K";
                        break;
                    default:
                        digito_verificador = (11 - suma_resta).ToString();
                        break;
                }
                return string.Equals(ultimo_digito, digito_verificador, StringComparison.OrdinalIgnoreCase);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static string GenerarClave()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[10];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
                stringChars[i] = chars[random.Next(chars.Length)];

            return new string(stringChars);
        }

        public static string toBase64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string fromBase64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        //--------------------[Begin: lightweight Encr/Decr]---------------------------------------
        public static string ROT13(string input)
        {
            return !string.IsNullOrEmpty(input) ? new string(input.ToCharArray().Select(s => { return (char)((s >= 97 && s <= 122) ? ((s + 13 > 122) ? s - 13 : s + 13) : (s >= 65 && s <= 90 ? (s + 13 > 90 ? s - 13 : s + 13) : s)); }).ToArray()) : input;
        }

        public static string random_ascii_str(int n)
        {
            int asciiCharacterStart = 32; // from which ascii character code the generation should start
            int asciiCharacterEnd = 126; // to which ascii character code the generation should end

            Random random = new Random(DateTime.Now.Millisecond);
            System.Text.StringBuilder builder = new System.Text.StringBuilder();

            for (int i = 0; i < n; ++i)
                builder.Append((char)(random.Next(asciiCharacterStart, asciiCharacterEnd + 1) % 255));

            return builder.ToString();
        }

        public static string xorEach(string s, int key)
        {
            System.Text.StringBuilder out_sb = new System.Text.StringBuilder(s.Length);
            char ch;
            for (int i = 0; i < s.Length; ++i)
            {
                ch = s[i];
                ch = (char)(ch ^ key);
                out_sb.Append(ch);
            }
            return out_sb.ToString();
        }

        public static string lightweightEncrypt(string input)
        {
            return !string.IsNullOrEmpty(input) ? toBase64Encode(ROT13(input.ToString())) : input;
        }

        public static string lightweightDecrypt(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            string output = ROT13(fromBase64Decode(input));
            return output;
        }
        //--------------------[End: lightweight Encr/Decr]---------------------------------------
        //--------------------[Begin: simpleEncr/simpleDecr]---------------------------------------

        private static string Encrypt(string plainText, string passPhrase, int Keysize, int DerivationIterations)
        {
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            using (var password = new System.Security.Cryptography.Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new System.Security.Cryptography.RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new System.IO.MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        private static string Decrypt(string cipherText, string passPhrase, int Keysize, int DerivationIterations)
        {
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new System.Security.Cryptography.RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new System.IO.MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new System.Security.Cryptography.CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return System.Text.Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32];
            using (var rngCsp = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }


        public static string simpleEncr(string text)
        {
            return lightweightEncrypt(text);
        }

        public static string simpleDecr(string enc_text)
        {
            return lightweightDecrypt(enc_text);
        }

        private static string ToHexString(string str)
        {
            var sb = new System.Text.StringBuilder();

            var bytes = System.Text.Encoding.Unicode.GetBytes(str);
            foreach (var t in bytes)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }

        private static string FromHexString(string hexString)
        {
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return System.Text.Encoding.Unicode.GetString(bytes);
        }
        //--------------------[End: simpleEncr/simpleDecr]---------------------------------------

        public static bool isValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
