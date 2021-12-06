using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;

using System.Data.Common;
using System.Xml;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace V4mvc.DataAccess
{
    public class LoaderEntity<TEntity>
    {
        public LoaderEntity()
        { }

        #region [ Propiedades ]

        public Type EntityType { get; set; }

        #endregion

        #region [ Metodos ]

        public void LoadEntity(IDataReader reader, object x_esquema)
        {
            try
            {
                int _campos = reader.FieldCount - 1;
                for (int _index = 0; _index <= _campos; _index++)
                {
                    if (!reader.IsDBNull(_index))
                    {
                        object _valor = reader.GetValue(_index);
                        string _campo = reader.GetName(_index);
                        PropertyInfo _propertInfo = null;
                        _propertInfo = EntityType.GetProperty(_campo);
                        if (!((_propertInfo == null)))
                        {
                            Type _tipoCampo = _propertInfo.PropertyType;
                            this.SetValueEntity(ref _propertInfo, _tipoCampo.ToString(), _valor, ref x_esquema);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LoadEntity(DataRow fila, object x_esquema)
        {
            try
            {
                int _campos = fila.Table.Columns.Count - 1;
                for (int _index = 0; _index <= _campos; _index++)
                {
                    if ((fila[_index] != DBNull.Value))
                    {
                        object _valor = fila[_index];
                        string _campo = fila.Table.Columns[_index].ColumnName;
                        PropertyInfo _propertInfo = null;
                        _propertInfo = EntityType.GetProperty(_campo);
                        if (!((_propertInfo == null)))
                        {
                            Type _tipoCampo = _propertInfo.PropertyType;

                            SetValueEntity(ref _propertInfo, _tipoCampo.ToString(), _valor, ref x_esquema);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SetValueEntity(ref PropertyInfo x_propertInfo, string x_tipoCampo, object x_valor, ref object x_esquema)
        {
            if (x_valor != null)
            {
                switch (x_tipoCampo)
                {
                    case "System.String":
                        x_propertInfo.SetValue(x_esquema, x_valor.ToString(), null);
                        break;
                    case "System.Int16":
                        Int16 _value1;
                        if (Int16.TryParse(x_valor.ToString(), out _value1))
                        { x_propertInfo.SetValue(x_esquema, _value1, null); }
                        break;
                    case "System.Nullable`1[System.Int16]":
                        Int16 _value2;
                        if (Int16.TryParse(x_valor.ToString(), out _value2))
                        { x_propertInfo.SetValue(x_esquema, _value2, null); }
                        break;
                    case "System.Int32":
                        Int32 _value3;
                        if (Int32.TryParse(x_valor.ToString(), out _value3))
                        { x_propertInfo.SetValue(x_esquema, _value3, null); }
                        break;
                    case "System.Nullable`1[System.Int32]":
                        Int32 _value4;
                        if (Int32.TryParse(x_valor.ToString(), out _value4))
                        { x_propertInfo.SetValue(x_esquema, _value4, null); }
                        break;
                    case "System.Int64":
                        Int64 _value3_1;
                        if (Int64.TryParse(x_valor.ToString(), out _value3_1))
                        { x_propertInfo.SetValue(x_esquema, _value3_1, null); }
                        break;
                    case "System.Nullable`1[System.Int64]":
                        Int64 _value4_1;
                        if (Int64.TryParse(x_valor.ToString(), out _value4_1))
                        { x_propertInfo.SetValue(x_esquema, _value4_1, null); }
                        break;
                    case "System.Double":
                        Double _value5;
                        if (Double.TryParse(x_valor.ToString(), out _value5))
                        { x_propertInfo.SetValue(x_esquema, _value5, null); }
                        break;
                    case "System.Nullable`1[System.Double]":
                        Double _value6;
                        if (Double.TryParse(x_valor.ToString(), out _value6))
                        { x_propertInfo.SetValue(x_esquema, _value6, null); }
                        break;
                    case "System.Decimal":
                        Decimal _value7;
                        if (Decimal.TryParse(x_valor.ToString(), out _value7))
                        { x_propertInfo.SetValue(x_esquema, _value7, null); }
                        break;
                    case "System.Nullable`1[System.Decimal]":
                        Decimal _value8;
                        if (Decimal.TryParse(x_valor.ToString(), out _value8))
                        { x_propertInfo.SetValue(x_esquema, _value8, null); }
                        break;
                    case "System.DateTime":
                        DateTime _value9;
                        if (DateTime.TryParse(x_valor.ToString(), out _value9))
                        { x_propertInfo.SetValue(x_esquema, _value9, null); }
                        break;
                    case "System.Nullable`1[System.DateTime]":
                        DateTime _value10;
                        if (DateTime.TryParse(x_valor.ToString(), out _value10))
                        { x_propertInfo.SetValue(x_esquema, _value10, null); }
                        break;
                    case "System.Boolean":
                        Boolean _value11;
                        if (Boolean.TryParse(x_valor.ToString(), out _value11))
                        { x_propertInfo.SetValue(x_esquema, _value11, null); }
                        break;
                    case "System.Nullable`1[System.Boolean]":
                        Boolean _value12;
                        if (Boolean.TryParse(x_valor.ToString(), out _value12))
                        { x_propertInfo.SetValue(x_esquema, _value12, null); }
                        break;
                    case "System.Byte[]":
                        x_propertInfo.SetValue(x_esquema, x_valor, null);
                        break;
                    case "System.Nullable`1[System.Guid]":
                        Guid _value13;
                        if (Guid.TryParse(x_valor.ToString(), out _value13))
                        { x_propertInfo.SetValue(x_esquema, _value13, null); }
                        break;
                    case "System.Guid":
                        Guid _value14;
                        if (Guid.TryParse(x_valor.ToString(), out _value14))
                        { x_propertInfo.SetValue(x_esquema, _value14, null); }
                        break;
                    case "System.Xml.XmlDocument":
                        try
                        {
                            XmlDocument _value15 = new XmlDocument();
                            _value15.LoadXml(x_valor.ToString());
                            x_propertInfo.SetValue(x_esquema, _value15, null);
                        }
                        catch (Exception)
                        { }
                        break;

                }
            }
        }

        #endregion

    }
}

