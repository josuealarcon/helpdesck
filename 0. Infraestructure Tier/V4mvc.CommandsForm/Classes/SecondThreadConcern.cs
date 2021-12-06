using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.CommandsForm.Classes
{
    class SecondThreadConcern
    {
        public static bool SaveStoredProcedureFiles(string output_folder, V4mvc.Commands.Classes.Utils.FilterSpObject filter)
        {
            try
            {
                var saver = new V4mvc.Commands.Classes.SpSaveCommand(output_folder, filter);
                return saver.Run();
            }
            catch(Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }
            return false;
        }

        public static bool ValidateTableNameFunc(string table_name, out int err_type)
        {
            err_type = -1;
            try
            {
                var db_provider = new V4mvc.Commands.Classes.DbDataProvider();
                return db_provider.DataTableExists(table_name, out err_type);
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }
            return false;
        }

        public static bool GenerateTiers(
            string db_table,
            string entity_name,
            string plural_name,
            string singular_name,
            string output_folder,
            bool gen_entity_tier,
            bool gen_dataccess_tier,
            bool gen_blogic_tier,
            bool gen_service_tier,
            bool gen_uconfig_file,
            bool gen_stored_procs
        )
        {
            var options = new V4mvc.Commands.Classes.Utils.TiersGenOptions
            {
                GenerateEntityTier = gen_entity_tier,
                GenerateDataAccessTier = gen_dataccess_tier,
                GenerateBusinessLogicTier = gen_blogic_tier,
                GenerateServiceTier = gen_service_tier,
                GenerateUpdatedConfig = gen_uconfig_file,
                GenerateStoredProcedures = gen_stored_procs
            };
            try
            {
                var generador = new V4mvc.Commands.Classes.TiersGenerateCommand(db_table, entity_name, singular_name, plural_name, output_folder, options);
                return generador.Run();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }
            return false;
        }

        public static string GetSuggestedEntityName(string table_name)
        {
            return V4mvc.Commands.Classes.Utils.GetSuggestedEntityName(table_name);
        }
        public static string GetSuggestedSingularName(string entity_name)
        {
            return V4mvc.Commands.Classes.Utils.GetSuggestedSingularName(entity_name);
        }
        public static string GetSuggestedPluralName(string entity_name)
        {
            return V4mvc.Commands.Classes.Utils.GetSuggestedPluralName(entity_name);
        }

    }
}
