using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Commands.Classes
{
    public class TiersGenerateCommand
    {

        public TiersGenerateCommand(string db_table, string entity_name, string singular_name, string plural_name, string output_folder, Utils.TiersGenOptions options)
        {
            this.db_table = db_table;
            this.entity_name = entity_name;
            this.singular_name = singular_name;
            this.plural_name = plural_name;
            this.output_folder = output_folder;
            this.options = options;
            this.provider = new DbDataProvider();
            this.getone_sp_name = this.getall_sp_name = this.insert_sp_name = this.update_sp_name = this.delete_sp_name = "__ISS";
        }

        private DbDataProvider provider { get; set; }

        private string db_table { get; set; }
        private string entity_name { get; set; }

        private string singular_name { get; set; }

        private string plural_name { get; set; }

        private string output_folder { get; set; }

        private string getone_sp_name { get; set; }
        private string getall_sp_name { get; set; }

        private string insert_sp_name { get; set; }

        private string update_sp_name { get; set; }

        private string delete_sp_name { get; set; }

        private Utils.TiersGenOptions options { get; set; }

        private List<DbColumnInfo> columns { get; set; }

        private Dictionary<string, string> mappedSqlDotNetTypes { get; set; }

        private Dictionary<string, string> mappedNetTypeParseFuncs { get; set; }

        private Dictionary<string, int> mappedSqlTypeFieldWidths { get; set; }

        private DbColumnInfo GetIdentityOrDefColumn()
        {
            DbColumnInfo ret = null;
            var icols = this.columns.Where(x => x.is_identity).ToList();
            var pk_cols = this.columns.Where(x => x.is_pk).ToList();
            var int_cols = this.columns.Where(x => mappedSqlDotNetTypes[x.type].ToLower().StartsWith("int")).ToList();
            if (icols.Count > 0)
            {
                ret = icols.First();
            }
            else if (pk_cols.Count > 0) {
                ret = pk_cols.First();
            }
            else if(int_cols.Count > 0)
            {
                ret = int_cols.First();
            }
            else
            {
                ret = this.columns.FirstOrDefault();
            }
            return ret;
        }

        private string asSpParameter(DbColumnInfo column, string var_name_mask = "{0}", short param_type = 0)
        {
            var def_null_types = new HashSet<string>(new string[] { "string", "byte[]" });
            string dotNetType = mappedSqlDotNetTypes[column.type];
            var mapping_result = Utils.GetMappingsNetGenericDb[dotNetType];
            string sp_pname = column.name;
            string var_name = string.Format(var_name_mask, column.name);
            string isql_type = mapping_result;
            var line = new StringBuilder();
            if (column.nullable)
            {
                if (!def_null_types.Contains(dotNetType.ToLower())) {
                     var_name += ".Value";
                }
            }
            line.Append(string.Format("Instance.DAAgregarParametro(\"@{0}\", {1}, {2}", sp_pname, var_name, isql_type));
            if (column.max_len > 0)
            {
                if (param_type == 0) //input
                {
                    line.Append(String.Format(", {0}, ParameterDirection.Input", column.max_len.ToString()));
                }
                else if (param_type == 1) //output
                {
                    line.Append(String.Format(", {0}, ParameterDirection.Output", column.max_len.ToString()));
                }

            }
            else if (column.precision > 0 && column.scale > 0)
            {
                if (param_type == 0) //input
                {
                    line.Append(String.Format(", {0}, {1}, ParameterDirection.Input", column.precision.ToString(), column.scale.ToString()));
                }
                else if (param_type == 1) //output
                {
                    line.Append(String.Format(", {0}, {1}, ParameterDirection.Output", column.precision.ToString(), column.scale.ToString()));
                }
            }
            else if (column.max_len < 1 && column.precision < 1 && column.scale < 1)
            {
                if (param_type == 0) //input
                {
                    line.Append(", ParameterDirection.Input");
                }
                else if (param_type == 1) //output
                {
                    line.Append(", ParameterDirection.Output");
                }
            }
            line.Append(");");
            return line.ToString();
        }

        private bool GenerateEntityTier()
        {
            bool result = false;
            var def_null_types = new HashSet<string>(new string[] { "string", "byte[]" });
            try
            {
                var members_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.EntityFragmentsFolder, @"PrivateMember.txt")));
                var gsetter_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.EntityFragmentsFolder, @"GetSetter.txt")));
                var public_part = new StringBuilder();
                var private_part = new StringBuilder();
                string mapped_type = string.Empty;
                string priv_mname = string.Empty;

                string shared_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.EntityFolder, @"Entity.txt")));
                string shared_content = string.Empty;
                string shared_fname = string.Format("{0}.cs", entity_name);

                string partial_ctta_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.EntityFolder, @"Entity.partial.ctta.txt")));
                string partial_ctta_content = string.Empty;
                string partial_ctta_fname = string.Format("{0}.partial.ctta.cs", entity_name);

                string partial_mdte_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.EntityFolder, @"Entity.partial.mdte.txt")));
                string partial_mdte_content = string.Empty;
                string partial_mdte_fname = string.Format("{0}.partial.mdte.cs", entity_name);

                foreach (var db_col in columns)
                {
                    mapped_type = mappedSqlDotNetTypes[db_col.type];
                    priv_mname = "m_" + db_col.name.ToLower();
                    if (!def_null_types.Contains(mapped_type) && db_col.nullable)
                    {
                        mapped_type = mapped_type + "?";
                    }
                    private_part.Append(string.Format(members_mask, mapped_type, priv_mname));
                    public_part.Append(string.Format(gsetter_mask, db_col.name, mapped_type, db_col.name, priv_mname, priv_mname, priv_mname));

                }
                shared_content = string.Format(shared_mask, entity_name, private_part.ToString(), entity_name, entity_name, public_part.ToString());
                partial_ctta_content = string.Format(partial_ctta_mask, entity_name);
                partial_mdte_content = string.Format(partial_mdte_mask, entity_name);

                if (Utils.CreateFileAt(output_folder, "ENTITY", entity_name, shared_fname, shared_content))
                {
                    if (Utils.CreateFileAt(output_folder, "ENTITY", entity_name, partial_ctta_fname, partial_ctta_content))
                    {
                        result = Utils.CreateFileAt(output_folder, "ENTITY", entity_name, partial_mdte_fname, partial_mdte_content);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("exc@GenerateEntityTier:" + exc.Message);
                result = false;
            }
            return result;
        }

        private bool GenerateDataAccessTier()
        {
            bool result = false;

            try
            {
                string output_param_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.DataAccessFragmentsFolder, @"IfOutputParam.txt"))); ;
                var icol = GetIdentityOrDefColumn();

                string identity_fun_arg = mappedSqlDotNetTypes[icol.type] + " " + icol.name;
                string identity_vadd_arg = asSpParameter(icol);
                string identity_iadd_arg = asSpParameter(icol, "item.{0}");
                string non_identity_args = string.Join("\n\t\t\t\t\t\t", this.columns.Where(x => !x.is_identity).Select(x => asSpParameter(x, "item.{0}")).ToArray());
                string identity_out_iadd_arg = asSpParameter(icol, "item.{0}", 1);
                string if_identity_outparam = string.Format(output_param_mask, icol.name, string.Format("item.{0}", icol.name), mappedNetTypeParseFuncs[mappedSqlDotNetTypes[icol.type]], icol.name);

                string base_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.DataAccessFolder, @"DAEntity.txt")));
                string base_content = string.Format(
                            base_mask,
                            entity_name, //{0}
                            entity_name, //{1}
                            entity_name, //{2}
                            entity_name, //{3}
                            entity_name, //{4}
                            entity_name, //{5}
                            entity_name, //{6}
                            entity_name, //{7}
                            this.getall_sp_name, //{8}
                            entity_name, //{9}
                            entity_name, //{10}
                            identity_fun_arg, //{11}
                            entity_name, //{12}
                            this.getone_sp_name, //{13}
                            identity_vadd_arg, //{14}
                            entity_name, //{15}
                            this.insert_sp_name, //{16}
                            this.update_sp_name, //{17}
                            non_identity_args, //{18}
                            identity_out_iadd_arg, //{19}
                            if_identity_outparam, //{20}
                            entity_name, //{21}
                            this.delete_sp_name, //{22}
                            identity_iadd_arg //{23}
                );

                string base_fname = string.Format("DA{0}.cs", entity_name);

                string base_partial_ctta_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.DataAccessFolder, @"DAEntity.partial.ctta.txt")));
                string base_partial_ctta_content = string.Format(base_partial_ctta_mask, entity_name);
                string base_partial_ctta_fname = string.Format("DA{0}.partial.ctta.cs", entity_name);

                string base_partial_mdte_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.DataAccessFolder, @"DAEntity.partial.mdte.txt")));
                string base_partial_mdte_content = string.Format(base_partial_mdte_mask, entity_name);
                string base_partial_mdte_fname = string.Format("DA{0}.partial.mdte.cs", entity_name);


                string iface_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.DataAccessFolder, @"IDAEntity.txt")));
                string iface_content = string.Format(
                    iface_mask,
                    entity_name, //{0}
                    entity_name, //{1}
                    entity_name, //{2}
                    identity_fun_arg, //{3}
                    entity_name, //{4}
                    entity_name  //{5}
                );

                string iface_fname = string.Format("IDA{0}.cs", entity_name);

                string iface_partial_ctta_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.DataAccessFolder, @"IDAEntity.partial.ctta.txt")));
                string iface_partial_ctta_content = string.Format(iface_partial_ctta_mask, entity_name);
                string iface_partial_ctta_fname = string.Format("IDA{0}.partial.ctta.cs", entity_name);

                string iface_partial_mdte_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.DataAccessFolder, @"IDAEntity.partial.mdte.txt")));
                string iface_partial_mdte_content = string.Format(iface_partial_mdte_mask, entity_name);
                string iface_partial_mdte_fname = string.Format("IDA{0}.partial.mdte.cs", entity_name);


                if (Utils.CreateFileAt(output_folder, "DATA_ACCESS", entity_name, base_fname, base_content))
                {
                    if (Utils.CreateFileAt(output_folder, "DATA_ACCESS", entity_name, base_partial_ctta_fname, base_partial_ctta_content))
                    {

                        if (Utils.CreateFileAt(output_folder, "DATA_ACCESS", entity_name, base_partial_mdte_fname, base_partial_mdte_content))
                        {
                            if (Utils.CreateFileAt(output_folder, "DATA_ACCESS", entity_name, iface_fname, iface_content))
                            {
                                if (Utils.CreateFileAt(output_folder, "DATA_ACCESS", entity_name, iface_partial_ctta_fname, iface_partial_ctta_content))
                                {
                                    result = Utils.CreateFileAt(output_folder, "DATA_ACCESS", entity_name, iface_partial_mdte_fname, iface_partial_mdte_content);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("exc@GenerateDataAccessTier:" + exc.Message);
                result = false;
            }
            return result;
        }

        private bool GenerateBusinessLogicTier()
        {
            bool result = false;
            try
            {
                var icol = GetIdentityOrDefColumn();

                string identity_fun_arg = mappedSqlDotNetTypes[icol.type] + " " + icol.name;
                string identity_var = icol.name;

                string base_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.BusinessLogicFolder, @"BLEntity.txt")));
                string base_content = string.Format(
                    base_mask,
                    entity_name, //{0}
                    entity_name, //{1}
                    entity_name, //{2}
                    entity_name, //{3}
                    entity_name, //{4}
                    entity_name, //{5}
                    entity_name, //{6}
                    identity_fun_arg, //{7}
                    identity_var, //{8}
                    entity_name, //{9}
                    entity_name, //{10}
                    entity_name //{11}
                );
                string base_fname = string.Format("BL{0}.cs", entity_name);

                string base_partial_ctta_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.BusinessLogicFolder, @"BLEntity.partial.ctta.txt")));
                string base_partial_ctta_content = string.Format(base_partial_ctta_mask, entity_name);
                string base_partial_ctta_fname = string.Format("BL{0}.partial.ctta.cs", entity_name);

                string base_partial_mdte_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.BusinessLogicFolder, @"BLEntity.partial.mdte.txt")));
                string base_partial_mdte_content = string.Format(base_partial_mdte_mask, entity_name);
                string base_partial_mdte_fname = string.Format("BL{0}.partial.mdte.cs", entity_name);


                string iface_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.BusinessLogicFolder, @"IBLEntity.txt")));
                string iface_content = string.Format(
                    iface_mask,
                    entity_name, //{0}
                    entity_name, //{1}
                    entity_name, //{2}
                    identity_fun_arg, //{3}
                    entity_name, //{4}
                    entity_name, //{5}
                    entity_name //{6}
                );

                string iface_fname = string.Format("IBL{0}.cs", entity_name);

                string iface_partial_ctta_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.BusinessLogicFolder, @"IBLEntity.partial.ctta.txt")));
                string iface_partial_ctta_content = string.Format(iface_partial_ctta_mask, entity_name);
                string iface_partial_ctta_fname = string.Format("IBL{0}.partial.ctta.cs", entity_name);

                string iface_partial_mdte_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.BusinessLogicFolder, @"IBLEntity.partial.mdte.txt")));
                string iface_partial_mdte_content = string.Format(iface_partial_mdte_mask, entity_name);
                string iface_partial_mdte_fname = string.Format("IBL{0}.partial.mdte.cs", entity_name);


                if (Utils.CreateFileAt(output_folder, "BUSINESS_LOGIC", entity_name, base_fname, base_content))
                {
                    if (Utils.CreateFileAt(output_folder, "BUSINESS_LOGIC", entity_name, base_partial_ctta_fname, base_partial_ctta_content))
                    {

                        if (Utils.CreateFileAt(output_folder, "BUSINESS_LOGIC", entity_name, base_partial_mdte_fname, base_partial_mdte_content))
                        {
                            if (Utils.CreateFileAt(output_folder, "BUSINESS_LOGIC", entity_name, iface_fname, iface_content))
                            {
                                if (Utils.CreateFileAt(output_folder, "BUSINESS_LOGIC", entity_name, iface_partial_ctta_fname, iface_partial_ctta_content))
                                {
                                    result = Utils.CreateFileAt(output_folder, "BUSINESS_LOGIC", entity_name, iface_partial_mdte_fname, iface_partial_mdte_content);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("exc@GenerateBusinessLogicTier:" + exc.Message);
                result = false;
            }
            return result;
        }

        private bool GenerateServiceTier()
        {
            bool result = false;
            try
            {
                var icol = GetIdentityOrDefColumn();

                string identity_fun_arg = mappedSqlDotNetTypes[icol.type] + " " + icol.name;
                string identity_var = icol.name;

                string base_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.ServiceFolder, @"ServiceProxyClient.Entity.txt")));
                string base_content = string.Format(
                    base_mask,
                    entity_name, //{0}
                    entity_name, //{1}
                    entity_name, //{2}
                    entity_name, //{3}
                    entity_name, //{4}
                    entity_name, //{5}
                    entity_name, //{6}
                    this.plural_name, //{7}
                    entity_name, //{8}
                    entity_name, //{9}
                    this.singular_name, //{10}
                    identity_fun_arg, //{11}
                    entity_name, //{12}
                    identity_var, //{13}
                    this.singular_name, //{14}
                    entity_name, //{15}
                    entity_name, //{16}
                    this.singular_name, //{17}
                    entity_name, //{18}
                    entity_name, //{19}
                    this.plural_name, //{20}
                    entity_name, //{21}
                    entity_name //{22}
                );

                string base_fname = string.Format("ServiceProxyClient.{0}.cs", entity_name);

                string base_partial_ctta_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.ServiceFolder, @"ServiceProxyClient.Entity.partial.ctta.txt")));
                string base_partial_ctta_content = string.Format(base_partial_ctta_mask);
                string base_partial_ctta_fname = string.Format("ServiceProxyClient.{0}.partial.ctta.cs", entity_name);

                string base_partial_mdte_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.ServiceFolder, @"ServiceProxyClient.Entity.partial.mdte.txt")));
                string base_partial_mdte_content = string.Format(base_partial_mdte_mask);
                string base_partial_mdte_fname = string.Format("ServiceProxyClient.{0}.partial.mdte.cs", entity_name);


                string iface_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.ServiceFolder, @"IServiceProxyClient.Entity.txt")));
                string iface_content = string.Format(
                    iface_mask,
                    entity_name,        //{0}
                    this.plural_name,   //{1}
                    entity_name,        //{2}
                    this.singular_name, //{3}
                    identity_fun_arg,   //{4}
                    this.singular_name, //{5}
                    entity_name,        //{6}
                    this.singular_name, //{7}
                    entity_name,        //{8}
                    this.plural_name,   //{9}
                    entity_name         //{10}
                );

                string iface_fname = string.Format("IServiceProxyClient.{0}.cs", entity_name);

                string iface_partial_ctta_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.ServiceFolder, @"IServiceProxyClient.Entity.partial.ctta.txt")));
                string iface_partial_ctta_content = string.Format(iface_partial_ctta_mask);
                string iface_partial_ctta_fname = string.Format("IServiceProxyClient.{0}.partial.ctta.cs", entity_name);

                string iface_partial_mdte_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.ServiceFolder, @"IServiceProxyClient.Entity.partial.mdte.txt")));
                string iface_partial_mdte_content = string.Format(iface_partial_mdte_mask);
                string iface_partial_mdte_fname = string.Format("IServiceProxyClient.{0}.partial.mdte.cs", entity_name);


                if (Utils.CreateFileAt(output_folder, "SERVICE", entity_name, base_fname, base_content))
                {
                    if (Utils.CreateFileAt(output_folder, "SERVICE", entity_name, base_partial_ctta_fname, base_partial_ctta_content))
                    {

                        if (Utils.CreateFileAt(output_folder, "SERVICE", entity_name, base_partial_mdte_fname, base_partial_mdte_content))
                        {
                            if (Utils.CreateFileAt(output_folder, "SERVICE", entity_name, iface_fname, iface_content))
                            {
                                if (Utils.CreateFileAt(output_folder, "SERVICE", entity_name, iface_partial_ctta_fname, iface_partial_ctta_content))
                                {
                                    result = Utils.CreateFileAt(output_folder, "SERVICE", entity_name, iface_partial_mdte_fname, iface_partial_mdte_content);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("exc@GenerateServiceTier:" + exc.Message);
                result = false;
            }
            return result;
        }

        private bool GenerateUpdatedConfig()
        {
            bool result = false;
            try
            {

                result = true;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                result = false;
            }
            return result;
        }

        private string GetFormatedTypeLen(DbColumnInfo column)
        {
            string result = string.Empty;
            int type_len = this.mappedSqlTypeFieldWidths[column.type];

            if (type_len == 1 && column.max_len > 0)
            {
                result = string.Format("({0})", column.max_len.ToString());
            }
            else if (type_len == 2 && column.precision > 0 && column.scale > 0)
            {
                result = string.Format("({0}, {1})", column.precision.ToString(), column.scale.ToString());
            }
            return result;
        }

        private bool GenerateStoredProcedures()
        {
            bool result = false;
            try
            {
                var icol = GetIdentityOrDefColumn();

                string today = DateTime.Now.ToString("dd/MM/yyyy");
                string str_clen = GetFormatedTypeLen(icol);
                string identity_sp_arg = string.Format("@{0}\t\t{1}{2}", icol.name, icol.type.ToUpper(), str_clen);
                string mixed_sp_args = string.Join("\n\t,", this.columns.Select(x => string.Format("@{0}\t\t{1}{2} = NULL {3}", x.name, x.type.ToUpper(), GetFormatedTypeLen(x), x.is_identity ? "OUTPUT" : string.Empty)).ToList());
                var non_identity_names = this.columns.Where(x => !x.is_identity).Select(x => x.name).ToArray();
                var all_field_names = this.columns.Select(x => x.name).ToArray();
                var non_identity_fields = new StringBuilder();
                var non_identity_vars = new StringBuilder();
                var updt_non_identity_fields = new StringBuilder();
                var all_fields = new StringBuilder();

                for (int i = 0; i < non_identity_names.Length; ++i)
                {
                    non_identity_vars.Append("@");
                    non_identity_vars.Append(non_identity_names[i]);

                    non_identity_fields.Append(non_identity_names[i]);

                    updt_non_identity_fields.Append(string.Format("{0}[{1}] = @{2}", (i < 1 ? " " : ","), non_identity_names[i], non_identity_names[i]));

                    if (i != (non_identity_names.Length - 1))
                    {
                        non_identity_vars.Append(" , ");
                        non_identity_fields.Append(" , ");
                        updt_non_identity_fields.Append("\n\t\t");
                        if ((i + 1) % 4 == 0)
                        {
                            non_identity_vars.Append("\n\t\t\t");
                            non_identity_fields.Append("\n\t\t\t");
                        }
                    }
                }
                for (int i = 0; i < all_field_names.Length; ++i)
                {
                    all_fields.Append(all_field_names[i]);
                    if (i != (all_field_names.Length - 1))
                    {
                        all_fields.Append(" , ");
                        if ((i + 1) % 4 == 0)
                        {
                            all_fields.Append("\n\t\t");
                        }
                    }
                }

                string delete_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.StoredProceduresFolder, @"Delete.txt")));
                string delete_content = string.Format(
                    delete_mask,
                    provider.DataBaseName, //{0}
                    this.delete_sp_name, //{1}
                    this.delete_sp_name, //{2}
                    today, //{3}
                    db_table, //{4}
                    this.delete_sp_name, //{5}
                    identity_sp_arg, //{6}
                    db_table, //{7}
                    icol.name, //{8}
                    icol.name //{9}
                );

                string delete_fname = string.Format("{0}.sql", this.delete_sp_name);

                string insert_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.StoredProceduresFolder, @"Insert.txt")));
                string insert_content = string.Format(
                    insert_mask,
                    provider.DataBaseName, //{0}
                    this.insert_sp_name, //{1}
                    this.insert_sp_name, //{2}
                    today, //{3}
                    db_table, //{4}
                    this.insert_sp_name, //{5}
                    mixed_sp_args, //{6}
                    db_table, //{7}
                    non_identity_fields.ToString(), //{8}
                    non_identity_vars.ToString(), //{9}
                    icol.name //{10}
                );
                string insert_fname = string.Format("{0}.sql", this.insert_sp_name);

                string selectall_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.StoredProceduresFolder, @"SelectAll.txt")));
                string selectall_content = string.Format(
                    selectall_mask,
                    provider.DataBaseName, //{0}
                    this.getall_sp_name, //{1}
                    this.getall_sp_name, //{2}
                    today, //{3}
                    db_table, //{4}
                    this.getall_sp_name, //{5}
                    all_fields.ToString(), //{6}
                    db_table //{7}
                );
                string selectall_fname = string.Format("{0}.sql", this.getall_sp_name);


                string selectone_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.StoredProceduresFolder, @"SelectOne.txt")));
                string selectone_content = string.Format(
                    selectone_mask,
                    provider.DataBaseName, //{0}
                    this.getone_sp_name, //{1}
                    this.getone_sp_name, //{2}
                    today, //{3}
                    db_table, //{4}
                    this.getone_sp_name, //{5}
                    identity_sp_arg, //{6}
                    all_fields.ToString(), //{7}
                    db_table,  //8
                    icol.name, //9
                    icol.name  //10
                );

                string selectone_fname = string.Format("{0}.sql", this.getone_sp_name);

                string update_mask = Utils.PreProcessStr(File.ReadAllText(Path.Combine(Utils.StoredProceduresFolder, @"Update.txt")));
                string update_content = string.Format(
                    update_mask,
                    provider.DataBaseName, //{0}
                    this.update_sp_name, //{1}
                    this.update_sp_name, //{2}
                    today, //{3}
                    db_table, //{4}
                    this.update_sp_name, //{5}
                    mixed_sp_args, //{6}
                    db_table, //{7}
                    updt_non_identity_fields.ToString(), //{8}
                    icol.name, //{9}
                    icol.name //{10}
                );
                string update_fname = string.Format("{0}.sql", this.update_sp_name);

                if (Utils.CreateFileAt(output_folder, "STORED_PROCEDURES", entity_name, delete_fname, delete_content))
                {
                    if (Utils.CreateFileAt(output_folder, "STORED_PROCEDURES", entity_name, insert_fname, insert_content))
                    {

                        if (Utils.CreateFileAt(output_folder, "STORED_PROCEDURES", entity_name, selectall_fname, selectall_content))
                        {
                            if (Utils.CreateFileAt(output_folder, "STORED_PROCEDURES", entity_name, selectone_fname, selectone_content))
                            {
                                result = Utils.CreateFileAt(output_folder, "STORED_PROCEDURES", entity_name, update_fname, update_content);
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("exc@GenerateStoredProcedures:" + exc.Message);
                result = false;
            }
            return result;
        }

        public bool Run()
        {
            bool result = true;
            bool op_result = false;
            if (!string.IsNullOrEmpty(db_table) && !string.IsNullOrEmpty(entity_name) && !string.IsNullOrEmpty(output_folder) && options.atLeastOne())
            {
                try
                {
                    this.columns = provider.GetTableColumnsInfo(db_table);
                    this.mappedSqlDotNetTypes = Utils.GetMappedTypes();
                    this.mappedNetTypeParseFuncs = Utils.GetMappingsNetParsingFuncs;
                    this.mappedSqlTypeFieldWidths = Utils.GetMappedSqlTypeFieldWidths();

                    if (options.GenerateStoredProcedures)
                    {
                        this.getone_sp_name = "V4MVC_" + db_table + "_SELECT_ONE";
                        this.getall_sp_name = "V4MVC_" + db_table + "_SELECT";
                        this.insert_sp_name = "V4MVC_" + db_table + "_INSERT";
                        this.update_sp_name = "V4MVC_" + db_table + "_UPDATE";
                        this.delete_sp_name = "V4MVC_" + db_table + "_DELETE";
                    }

                    if (options.GenerateEntityTier)
                    {
                        op_result = GenerateEntityTier();
                        result = result && op_result;
                    }
                    if (options.GenerateDataAccessTier)
                    {
                        op_result = GenerateDataAccessTier();
                        result = result && op_result;
                    }
                    if (options.GenerateBusinessLogicTier)
                    {
                        op_result = GenerateBusinessLogicTier();
                        result = result && op_result;
                    }
                    if (options.GenerateServiceTier)
                    {
                        op_result = GenerateServiceTier();
                        result = result && op_result;
                    }
                    if (options.GenerateUpdatedConfig)
                    {
                        op_result = GenerateUpdatedConfig();
                        result = result && op_result;
                    }
                    if (options.GenerateStoredProcedures)
                    {
                        op_result = GenerateStoredProcedures();
                        result = result && op_result;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    result = false;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
