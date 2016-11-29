using dhprWebApi.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Npgsql;

namespace dhprWebApi.AppCode
{
    public class DBConnection
    {

        private string _lang;
        public string Lang
        {
            get { return this._lang; }
            set { this._lang = value; }
        }

        public DBConnection(string lang)
        {
            this._lang = lang;
        }

        private string DhprDBConnection
        {
            get { return ConfigurationManager.ConnectionStrings["dhpr"].ToString(); }
        }



        public List<Company> GetAllCompany()
        {
            var items = new List<Company>();
            string commandText = "SELECT DISTINCT C.* FROM COMPANY C";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new Company();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllCompany()");
                        ExceptionHelper.LogException(exc, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public Company GetCompanyById(int id)
        {
            var item = new Company();
            string commandText = "SELECT * FROM COMPANY AS C WHERE C.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetCompanyById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }

        public List<AerIngredient> GetAllAerIngredient()
        {
            var items = new List<AerIngredient>();
            string commandText = "SELECT DISTINCT A.* FROM AERINGREDIENT A";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new AerIngredient();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.drug_product_id = dr["DRUG_PRODUCT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUG_PRODUCT_ID"]);
                                    item.drug_name = dr["DRUG_NAME"] == DBNull.Value ? string.Empty : dr["DRUG_NAME"].ToString().Trim();
                                    item.ingredient_id = dr["INGREDIENT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["INGREDIENT_ID"]);
                                    item.ingredient_name = dr["INGREDIENT_NAME"] == DBNull.Value ? string.Empty : dr["INGREDIENT_NAME"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllAerIngredient()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public AerIngredient GetAerIngredientById(int id)
        {
            var item = new AerIngredient();
            string commandText = "SELECT * FROM AERINGREDIENT AS A WHERE A.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.drug_product_id = dr["DRUG_PRODUCT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUG_PRODUCT_ID"]);
                                    item.drug_name = dr["DRUG_NAME"] == DBNull.Value ? string.Empty : dr["DRUG_NAME"].ToString().Trim();
                                    item.ingredient_id = dr["INGREDIENT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["INGREDIENT_ID"]);
                                    item.ingredient_name = dr["INGREDIENT_NAME"] == DBNull.Value ? string.Empty : dr["INGREDIENT_NAME"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAerIngredientById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }

        public List<AerReactionTerms> GetAllAerReactionTerms()
        {
            var items = new List<AerReactionTerms>();
            string commandText = "SELECT DISTINCT A.* FROM AERREACTIONTERMS A";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new AerReactionTerms();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.report_id = dr["REPORT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORT_ID"]);
                                    item.adverse_reaction_terms = dr["ADVERSE_REACTION_TERMS"] == DBNull.Value ? string.Empty : dr["ADVERSE_REACTION_TERMS"].ToString().Trim();
                                    item.meddra_system_organ_class_soc = dr["MEDDRA_SYSTEM_ORGAN_CLASS_SOC"] == DBNull.Value ? string.Empty : dr["MEDDRA_SYSTEM_ORGAN_CLASS_SOC"].ToString().Trim();
                                    item.reaction_duration = dr["REACTION_DURATION"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REACTION_DURATION"]);
                                    item.reaction_duration_unit = dr["REACTION_DURATION_UNIT"] == DBNull.Value ? string.Empty : dr["REACTION_DURATION_UNIT"].ToString().Trim();
                                    item.meddra_version = dr["MEDDRA_VERSION"] == DBNull.Value ? string.Empty : dr["MEDDRA_VERSION"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllAerReactionTerms()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public AerReactionTerms GetAerReactionTermsById(int id)
        {
            var item = new AerReactionTerms();
            string commandText = "SELECT * FROM AERREACTIONTERMS AS A WHERE A.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.report_id = dr["REPORT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORT_ID"]);
                                    item.adverse_reaction_terms = dr["ADVERSE_REACTION_TERMS"] == DBNull.Value ? string.Empty : dr["ADVERSE_REACTION_TERMS"].ToString().Trim();
                                    item.meddra_system_organ_class_soc = dr["MEDDRA_SYSTEM_ORGAN_CLASS_SOC"] == DBNull.Value ? string.Empty : dr["MEDDRA_SYSTEM_ORGAN_CLASS_SOC"].ToString().Trim();
                                    item.reaction_duration = dr["REACTION_DURATION"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REACTION_DURATION"].ToString().Trim());
                                    item.reaction_duration_unit = dr["REACTION_DURATION_UNIT"] == DBNull.Value ? string.Empty : dr["REACTION_DURATION_UNIT"].ToString().Trim();
                                    item.meddra_version = dr["MEDDRA_VERSION"] == DBNull.Value ? string.Empty : dr["MEDDRA_VERSION"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllCompany()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }
        public List<AerProductInformation> GetAllAerProductInformation()
        {
            var items = new List<AerProductInformation>();
            string commandText = "SELECT DISTINCT A.* FROM AERPRODUCTINFORMATION";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new AerProductInformation();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.report_drug_id = dr["REPORT_DRUG_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORT_DRUG_ID"]);
                                    item.report_id = dr["REPORT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORT_ID"]);
                                    item.drug_product_id = dr["DRUG_PRODUCT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUG_PRODUCT_ID"]);
                                    item.drug_name = dr["DRUG_NAME"] == DBNull.Value ? string.Empty : dr["DRUG_NAME"].ToString().Trim();
                                    item.cvp_name = dr["CVP_NAME"] == DBNull.Value ? string.Empty : dr["CVP_NAME"].ToString().Trim();
                                    item.dosage_form = dr["DOSAGE_FORM"] == DBNull.Value ? string.Empty : dr["DOSAGE_FORM"].ToString().Trim();
                                    item.health_product_role = dr["HEALTH_PRODUCT_ROLE"] == DBNull.Value ? string.Empty : dr["HEALTH_PRODUCT_ROLE"].ToString().Trim();
                                    item.route_of_administration = dr["ROUTE_OF_ADMINISTRATION"] == DBNull.Value ? string.Empty : dr["ROUTE_OF_ADMINISTRATION"].ToString().Trim();
                                    item.amount = dr["AMOUNT"] == DBNull.Value ? 0 : Convert.ToInt64(dr["AMOUNT"]);
                                    item.amount_unit = dr["AMOUNT_UNIT"] == DBNull.Value ? string.Empty : dr["AMOUNT_UNIT"].ToString().Trim();
                                    item.frequency = dr["FREQUENCY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["FREQUENCY"]);
                                    item.frequency_time = dr["FREQUENCY_TIME"] == DBNull.Value ? 0 : Convert.ToInt32(dr["FREQUENCY_TIME"]);
                                    item.frequency_time_unit = dr["FREQUENCY_TIME_UNIT"] == DBNull.Value ? string.Empty : dr["FREQUENCY_TIME_UNIT"].ToString().Trim();
                                    item.frequency_unit = dr["FREQUENCY_UNIT"] == DBNull.Value ? string.Empty : dr["FREQUENCY_UNIT"].ToString().Trim();
                                    item.therapy_duration = dr["THERAPY_DURATION"] == DBNull.Value ? 0 : Convert.ToInt32(dr["THERAPY_DURATION"]);
                                    item.therapy_duration_unit = dr["THERAPY_DURATION_UNIT"] == DBNull.Value ? string.Empty : dr["THERAPY_DURATION_UNIT"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllAerProductInformation()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public AerProductInformation GetAerProductInformationById(int id)
        {
            var item = new AerProductInformation();
            string commandText = "SELECT * FROM AERPRODUCTINFORMATION AS A WHERE A.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.report_drug_id = dr["REPORT_DRUG_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORT_DRUG_ID"]);
                                    item.report_id = dr["REPORT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORT_ID"]);
                                    item.drug_product_id = dr["DRUG_PRODUCT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUG_PRODUCT_ID"]);
                                    item.drug_name = dr["DRUG_NAME"] == DBNull.Value ? string.Empty : dr["DRUG_NAME"].ToString().Trim();
                                    item.cvp_name = dr["CVP_NAME"] == DBNull.Value ? string.Empty : dr["CVP_NAME"].ToString().Trim();
                                    item.dosage_form = dr["DOSAGE_FORM"] == DBNull.Value ? string.Empty : dr["DOSAGE_FORM"].ToString().Trim();
                                    item.health_product_role = dr["HEALTH_PRODUCT_ROLE"] == DBNull.Value ? string.Empty : dr["HEALTH_PRODUCT_ROLE"].ToString().Trim();
                                    item.route_of_administration = dr["ROUTE_OF_ADMINISTRATION"] == DBNull.Value ? string.Empty : dr["ROUTE_OF_ADMINISTRATION"].ToString().Trim();
                                    item.amount = dr["AMOUNT"] == DBNull.Value ? 0 : Convert.ToInt64(dr["AMOUNT"]);
                                    item.amount_unit = dr["AMOUNT_UNIT"] == DBNull.Value ? string.Empty : dr["AMOUNT_UNIT"].ToString().Trim();
                                    item.frequency = dr["FREQUENCY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["FREQUENCY"]);
                                    item.frequency_time = dr["FREQUENCY_TIME"] == DBNull.Value ? 0 : Convert.ToInt32(dr["FREQUENCY_TIME"]);
                                    item.frequency_time_unit = dr["FREQUENCY_TIME_UNIT"] == DBNull.Value ? string.Empty : dr["FREQUENCY_TIME_UNIT"].ToString().Trim();
                                    item.frequency_unit = dr["FREQUENCY_UNIT"] == DBNull.Value ? string.Empty : dr["FREQUENCY_UNIT"].ToString().Trim();
                                    item.therapy_duration = dr["THERAPY_DURATION"] == DBNull.Value ? 0 : Convert.ToInt32(dr["THERAPY_DURATION"]);
                                    item.therapy_duration_unit = dr["THERAPY_DURATION_UNIT"] == DBNull.Value ? string.Empty : dr["THERAPY_DURATION_UNIT"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAerProductInformationById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }
        public List<Ci> GetAllCi()
        {
            var items = new List<Ci>();
            string commandText = "SELECT DISTINCT C.* FROM CI C";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new Ci();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.ci_used_for = dr["CI_USED_FOR"] == DBNull.Value ? string.Empty : dr["CI_USED_FOR"].ToString().Trim();
                                    item.ci_what_it_does = dr["CI_WHAT_IT_DOES"] == DBNull.Value ? string.Empty : dr["CI_WHAT_IT_DOES"].ToString().Trim();
                                    item.ci_whennotused = dr["CI_WHEN_NOT_USED"] == DBNull.Value ? string.Empty : dr["CI_WHEN_NOT_USED"].ToString().Trim();
                                    item.ci_medicinal_ingredients = dr["CI_MEDICINAL_INGREDIENTS"] == DBNull.Value ? string.Empty : dr["CI_MEDICINAL_INGREDIENTS"].ToString().Trim();
                                    item.ci_nonmedicinal_ingredients = dr["CI_NONMEDICINAL_INGREDIENTS"] == DBNull.Value ? string.Empty : dr["CI_NONMEDICINAL_INGREDIENTS"].ToString().Trim();
                                    item.ci_dosage = dr["CI_DOSAGE"] == DBNull.Value ? string.Empty : dr["CI_DOSAGE"].ToString().Trim();
                                    item.ci_warnings = dr["CI_WARNINGS"] == DBNull.Value ? string.Empty : dr["CI_WARNINGS"].ToString().Trim();
                                    item.ci_interactions = dr["CI_INTERACTIONS"] == DBNull.Value ? string.Empty : dr["CI_INTERACTIONS"].ToString().Trim();
                                    item.ci_proper_use = dr["CI_PROPER_USE"] == DBNull.Value ? string.Empty : dr["CI_PROPER_USE"].ToString().Trim();
                                    item.ci_side_effects = dr["CI_SIDE_EFFECTS"] == DBNull.Value ? string.Empty : dr["CI_SIDE_EFFECTS"].ToString().Trim();
                                    item.ci_storage = dr["CI_STORAGE"] == DBNull.Value ? string.Empty : dr["CI_STORAGE"].ToString().Trim();
                                    item.ci_reporting_side_effects = dr["CI_REPORTING_SIDE_EFFECTS"] == DBNull.Value ? string.Empty : dr["CI_REPORTING_SIDE_EFFECTS"].ToString().Trim();
                                    item.ci_more_info = dr["CI_MORE_INFO"] == DBNull.Value ? string.Empty : dr["CI_MORE_INFO"].ToString().Trim();
                                    item.ci_language = dr["CI_LANGUAGE"] == DBNull.Value ? string.Empty : dr["CI_LANGUAGE"].ToString().Trim();
                                    item.ci_id = dr["CI_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CI_ID"]);
                                    item.product_monograph_id = dr["PRODUCT_MONOGRAPH_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["PRODUCT_MONOGRAPH_ID"]);

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllCi()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public Ci GetCiById(int id)
        {
            var item = new Ci();
            string commandText = "SELECT * FROM CI WHERE AS C WHERE C.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.ci_used_for = dr["CI_USED_FOR"] == DBNull.Value ? string.Empty : dr["CI_USED_FOR"].ToString().Trim();
                                    item.ci_what_it_does = dr["CI_WHAT_IT_DOES"] == DBNull.Value ? string.Empty : dr["CI_WHAT_IT_DOES"].ToString().Trim();
                                    item.ci_whennotused = dr["CI_WHEN_NOT_USED"] == DBNull.Value ? string.Empty : dr["CI_WHEN_NOT_USED"].ToString().Trim();
                                    item.ci_medicinal_ingredients = dr["CI_MEDICINAL_INGREDIENTS"] == DBNull.Value ? string.Empty : dr["CI_MEDICINAL_INGREDIENTS"].ToString().Trim();
                                    item.ci_nonmedicinal_ingredients = dr["CI_NONMEDICINAL_INGREDIENTS"] == DBNull.Value ? string.Empty : dr["CI_NONMEDICINAL_INGREDIENTS"].ToString().Trim();
                                    item.ci_dosage = dr["CI_DOSAGE"] == DBNull.Value ? string.Empty : dr["CI_DOSAGE"].ToString().Trim();
                                    item.ci_warnings = dr["CI_WARNINGS"] == DBNull.Value ? string.Empty : dr["CI_WARNINGS"].ToString().Trim();
                                    item.ci_interactions = dr["CI_INTERACTIONS"] == DBNull.Value ? string.Empty : dr["CI_INTERACTIONS"].ToString().Trim();
                                    item.ci_proper_use = dr["CI_PROPER_USE"] == DBNull.Value ? string.Empty : dr["CI_PROPER_USE"].ToString().Trim();
                                    item.ci_side_effects = dr["CI_SIDE_EFFECTS"] == DBNull.Value ? string.Empty : dr["CI_SIDE_EFFECTS"].ToString().Trim();
                                    item.ci_storage = dr["CI_STORAGE"] == DBNull.Value ? string.Empty : dr["CI_STORAGE"].ToString().Trim();
                                    item.ci_reporting_side_effects = dr["CI_REPORTING_SIDE_EFFECTS"] == DBNull.Value ? string.Empty : dr["CI_REPORTING_SIDE_EFFECTS"].ToString().Trim();
                                    item.ci_more_info = dr["CI_MORE_INFO"] == DBNull.Value ? string.Empty : dr["CI_MORE_INFO"].ToString().Trim();
                                    item.ci_language = dr["CI_LANGUAGE"] == DBNull.Value ? string.Empty : dr["CI_LANGUAGE"].ToString().Trim();
                                    item.ci_id = dr["CI_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CI_ID"]);
                                    item.product_monograph_id = dr["PRODUCT_MONOGRAPH_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["PRODUCT_MONOGRAPH_ID"]);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetCiById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }

        public List<AerReportType> GetAllAerReportType()
        {
            var items = new List<AerReportType>();
            string commandText = "SELECT DISTINCT A.* FROM AERREPORTTYPE A";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new AerReportType();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.code = dr["CODE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CODE"]);
                                    item.type = dr["TYPE"] == DBNull.Value ? string.Empty : dr["TYPE"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllAerReportType()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public AerReportType GetAerReportTypeById(int id)
        {
            var item = new AerReportType();
            string commandText = "SELECT * FROM AERREPORTTYPE AS A WHERE A.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.code = dr["CODE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CODE"]);
                                    item.type = dr["TYPE"] == DBNull.Value ? string.Empty : dr["TYPE"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAerReportTypeById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }
        public List<AerLink> GetAllAerLink()
        {
            var items = new List<AerLink>();
            string commandText = "SELECT DISTINCT A.* FROM AERLINK A";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new AerLink();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.report_id = dr["REPORT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORT_ID"]);
                                    item.type = dr["TYPE"] == DBNull.Value ? string.Empty : dr["TYPE"].ToString().Trim();
                                    item.linked_aer_number = dr["LINKED_AER_NUMBER"] == DBNull.Value ? 0 : Convert.ToInt32(dr["LINKED_AER_NUMBER"]);
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllAerLink()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public AerLink GetAerLinkById(int id)
        {
            var item = new AerLink();
            string commandText = "SELECT * FROM AERLINK WHERE AS A WHERE A.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.report_id = dr["REPORT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORT_ID"]);
                                    item.type = dr["TYPE"] == DBNull.Value ? string.Empty : dr["TYPE"].ToString().Trim();
                                    item.linked_aer_number = dr["LINKED_AER_NUMBER"] == DBNull.Value ? 0 : Convert.ToInt32(dr["LINKED_AER_NUMBER"]);
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAerLinkById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }
        public List<DrugProduct> GetAllDrugProduct()
        {
            var items = new List<DrugProduct>();
            string commandText = "SELECT DISTINCT D.* FROM DRUGPRODUCT D";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new DrugProduct();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.product_monograph_id = dr["PRODUCT_MONOGRAPH_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["PRODUCT_MONOGRAPH_ID"]);
                                    item.drug_code = dr["DRUG_CODE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUG_CODE"]);
                                    item.brand_name_id = dr["BRAND_NAME_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["BRAND_NAME_ID"]);
                                    item.sbd_link = dr["SBD_LINK"] == DBNull.Value ? string.Empty : dr["SBD_LINK"].ToString().Trim();
                                    item.rds_link = dr["RDS_LINK"] == DBNull.Value ? string.Empty : dr["RDS_LINK"].ToString().Trim();
                                    item.ssr_link = dr["SSR_LINK"] == DBNull.Value ? string.Empty : dr["SSR_LINK"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllDrugProduct()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public DrugProduct GetDrugProductById(int id)
        {
            var item = new DrugProduct();
            string commandText = "SELECT * FROM DRUGPRODUCT WHERE AS D WHERE D.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.product_monograph_id = dr["PRODUCT_MONOGRAPH_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["PRODUCT_MONOGRAPH_ID"]);
                                    item.drug_code = dr["DRUG_CODE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUG_CODE"]);
                                    item.brand_name_id = dr["BRAND_NAME_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["BRAND_NAME_ID"]);
                                    item.sbd_link = dr["SBD_LINK"] == DBNull.Value ? string.Empty : dr["SBD_LINK"].ToString().Trim();
                                    item.rds_link = dr["RDS_LINK"] == DBNull.Value ? string.Empty : dr["RDS_LINK"].ToString().Trim();
                                    item.ssr_link = dr["SSR_LINK"] == DBNull.Value ? string.Empty : dr["SSR_LINK"].ToString().Trim();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetDrugProductById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }

        public List<AerSource> GetAllAerSource()
        {
            var items = new List<AerSource>();
            string commandText = "SELECT DISTINCT A.* FROM AERSOURCE A";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new AerSource();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.code = dr["CODE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CODE"]);
                                    item.source = dr["SOURCE"] == DBNull.Value ? string.Empty : dr["SOURCE"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllAerSource()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public AerSource GetAerSourceById(int id)
        {
            var item = new AerSource();
            string commandText = "SELECT * FROM AERSOURCE WHERE AS A WHERE A.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.code = dr["CODE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CODE"]);
                                    item.source = dr["SOURCE"] == DBNull.Value ? string.Empty : dr["SOURCE"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAerSourceById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }

        public List<AerSerious> GetAllAerSerious()
        {
            var items = new List<AerSerious>();
            string commandText = "SELECT DISTINCT A.* FROM AERSERIOUS A";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new AerSerious();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.code = dr["CODE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CODE"]);
                                    item.serious = dr["SERIOUS"] == DBNull.Value ? string.Empty : dr["SERIOUS"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllAerSerious()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public AerSerious GetAerSeriousById(int id)
        {
            var item = new AerSerious();
            string commandText = "SELECT * FROM AERSRIOUS WHERE AS A WHERE A.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.code = dr["CODE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CODE"]);
                                    item.serious = dr["SERIOUS"] == DBNull.Value ? string.Empty : dr["SERIOUS"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAerSeriousById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }

        public List<ActiveIngredient> GetAllActiveIngredient()
        {
            var items = new List<ActiveIngredient>();
            string commandText = "SELECT DISTINCT A.* FROM ACTIVEINGREDIENT A";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new ActiveIngredient();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.pharm_form_id = dr["PHARM_FORM_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["PHARM_FORM_ID"]);
                                    item.ingredient_prefix = dr["INGREDIENT_PREFIX"] == DBNull.Value ? string.Empty : dr["INGREDIENT_PREFIX"].ToString().Trim();
                                    item.ingredient = dr["INGREDIENT"] == DBNull.Value ? string.Empty : dr["INGREDIENT"].ToString().Trim();
                                    item.ingredient_supplied_ind = dr["INGREDIENT_SUPPLIED_IND"] == DBNull.Value ? string.Empty : dr["INGREDIENT_SUPPLIED_IND"].ToString().Trim();
                                    item.strength = dr["STRENGTH"] == DBNull.Value ? string.Empty : dr["STRENGTH"].ToString().Trim();
                                    item.strength_unit = dr["STRENGTH_UNIT"] == DBNull.Value ? string.Empty : dr["STRENGTH_UNIT"].ToString().Trim();
                                    item.strength_type = dr["STRENGTH_TYPE"] == DBNull.Value ? string.Empty : dr["STRENGTH_TYPE"].ToString().Trim();
                                    item.dosage_value = dr["DOSAGE_VALUE"] == DBNull.Value ? string.Empty : dr["DOSAGE_VALUE"].ToString().Trim();
                                    item.dosage_unit = dr["DOSAGE_UNIT"] == DBNull.Value ? string.Empty : dr["DOSAGE_UNIT"].ToString().Trim();
                                    item.notes = dr["NOTES"] == DBNull.Value ? string.Empty : dr["NOTES"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllCompany()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public ActiveIngredient GetActiveIngredientById(int id)
        {
            var item = new ActiveIngredient();
            string commandText = "SELECT * FROM ACTIVEINGREDIENT AS A WHERE A.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.pharm_form_id = dr["PHARM_FORM_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["PHARM_FORM_ID"]);
                                    item.ingredient_prefix = dr["INGREDIENT_PREFIX"] == DBNull.Value ? string.Empty : dr["INGREDIENT_PREFIX"].ToString().Trim();
                                    item.ingredient = dr["INGREDIENT"] == DBNull.Value ? string.Empty : dr["INGREDIENT"].ToString().Trim();
                                    item.ingredient_supplied_ind = dr["INGREDIENT_SUPPLIED_IND"] == DBNull.Value ? string.Empty : dr["INGREDIENT_SUPPLIED_IND"].ToString().Trim();
                                    item.strength = dr["STRENGTH"] == DBNull.Value ? string.Empty : dr["STRENGTH"].ToString().Trim();
                                    item.strength_unit = dr["STRENGTH_UNIT"] == DBNull.Value ? string.Empty : dr["STRENGTH_UNIT"].ToString().Trim();
                                    item.strength_type = dr["STRENGTH_TYPE"] == DBNull.Value ? string.Empty : dr["STRENGTH_TYPE"].ToString().Trim();
                                    item.dosage_value = dr["DOSAGE_VALUE"] == DBNull.Value ? string.Empty : dr["DOSAGE_VALUE"].ToString().Trim();
                                    item.dosage_unit = dr["DOSAGE_UNIT"] == DBNull.Value ? string.Empty : dr["DOSAGE_UNIT"].ToString().Trim();
                                    item.notes = dr["NOTES"] == DBNull.Value ? string.Empty : dr["NOTES"].ToString().Trim();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetCompanyById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }
        public List<AerGender> GetAllAerGender()
        {
            var items = new List<AerGender>();
            string commandText = "SELECT DISTINCT A.* FROM AERGENDER A";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new AerGender();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.code = dr["CODE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CODE"]);
                                    item.gender = dr["GENDER"] == DBNull.Value ? string.Empty : dr["GENDER"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllAerGender()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public AerGender GetAerGenderById(int id)
        {
            var aerGender = new AerGender();
            string commandText = "SELECT * FROM AERGENDER AS A WHERE A.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new AerGender();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.code = dr["CODE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CODE"]);
                                    item.gender = dr["GENDER"] == DBNull.Value ? string.Empty : dr["GENDER"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                    aerGender = item;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAerGenderById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return aerGender;
        }

        public List<Route> GetAllRoute()
        {
            var items = new List<Route>();
            string commandText = "SELECT DISTINCT R.* FROM ROUTE R";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new Route();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.pharm_form_id = dr["PHARM_FORM_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["PHARM_FORM_ID"]);
                                    item.route_of_admin = dr["ROUTE_OF_ADMIN"] == DBNull.Value ? string.Empty : dr["ROUTE_OF_ADMIN"].ToString().Trim();
                                    item.route_inactive_date = dr["ROUTE_INACTIVE_DATE"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["ROUTE_INACTIVE_DATE"]);

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllRoute()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public Route GetRouteById(int id)
        {
            var item = new Route();
            string commandText = "SELECT * FROM ROUTE AS RWHERE R.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.pharm_form_id = dr["PHARM_FORM_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["PHARM_FORM_ID"]);
                                    item.route_of_admin = dr["ROUTE_OF_ADMIN"] == DBNull.Value ? string.Empty : dr["ROUTE_OF_ADMIN"].ToString().Trim();
                                    item.route_inactive_date = dr["ROUTE_INACTIVE_DATE"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["ROUTE_INACTIVE_DATE"]);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetCompanyById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }

        public List<Aer> GetAllAer()
        {
            var items = new List<Aer>();
            string commandText = "SELECT DISTINCT A.* FROM AER A";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new Aer();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.report_id = dr["REPORT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORT_ID"]);
                                    item.latest_aer_version_number = dr["LATEST_AER_VERSION_NUMBER"] == DBNull.Value ? 0 : Convert.ToInt32(dr["LATEST_AER_VERSION_NUMBER"]);
                                    item.market_authorization_holder_aer_number = dr["MARKET_AUTHORIZATION_HOLDER_AER_NUMBER"] == DBNull.Value ? string.Empty : dr["MARKET_AUTHORIZATION_HOLDER_AER_NUMBER"].ToString().Trim();
                                    item.initial_received_date = dr["INITIAL_RECEIVED_DATE"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["INITIAL_RECEIVED_DATE"]);
                                    item.latest_received_date = dr["LATEST_RECEIVED_DATE"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["LATEST_RECEIVED_DATE"]);
                                    item.type_of_report = dr["TYPE_OF_REPORT"] == DBNull.Value ? string.Empty : dr["TYPE_OF_REPORT"].ToString().Trim();
                                    item.serious_report = dr["SERIOUS_REPORT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["SERIOUS_REPORT"]);
                                    item.age_group = dr["AGE_GROUP"] == DBNull.Value ? string.Empty : dr["AGE_GROUP"].ToString().Trim();
                                    item.age = dr["AGE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["AGE"]);
                                    item.age_unit = dr["AGE_UNIT"] == DBNull.Value ? string.Empty : dr["AGE_UNIT"].ToString().Trim();
                                    item.age_years = dr["AGE_YEARS"] == DBNull.Value ? 0 : Convert.ToInt64(dr["AGE_YEARS"]);
                                    item.gender = dr["GENDER"] == DBNull.Value ? 0 : Convert.ToInt32(dr["GENDER"]);
                                    item.weight = dr["WEIGHT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["WEIGHT"]);
                                    item.weight_unit = dr["WEIGHT_UNIT"] == DBNull.Value ? string.Empty : dr["WEIGHT_UNIT"].ToString().Trim();
                                    item.height = dr["HEIGHT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["HEIGHT"]);
                                    item.height_unit = dr["HEIGHT_UNIT"] == DBNull.Value ? string.Empty : dr["HEIGHT_UNIT"].ToString().Trim();
                                    item.report_outcome = dr["REPORT_OUTCOME"] == DBNull.Value ? string.Empty : dr["REPORT_OUTCOME"].ToString().Trim();
                                    item.reporter_type = dr["REPORTER_TYPE"] == DBNull.Value ? string.Empty : dr["REPORTER_TYPE"].ToString().Trim();
                                    item.source_of_report = dr["SOURCE_OF_REPORT"] == DBNull.Value ? string.Empty : dr["SOURCE_OF_REPORT"].ToString().Trim();
                                    item.death = dr["DEATH"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DEATH"]);
                                    item.disability = dr["DISABILITY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DISABILITY"]);
                                    item.congenital_anomaly = dr["CONGENITAL_ANOMALY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CONGENITAL_ANOMALY"]);
                                    item.life_threatening = dr["LIFE_THREATENING"] == DBNull.Value ? 0 : Convert.ToInt32(dr["LIFE_THREATENING"]);
                                    item.hospitalization = dr["HOSPITALIZATION"] == DBNull.Value ? 0 : Convert.ToInt32(dr["HOSPITALIZATION"]);
                                    item.other_medically_important_conditions = dr["OTHER_MEDICALLY_IMPORTANT_CONDITIONS"] == DBNull.Value ? string.Empty : dr["OTHER_MEDICALLY_IMPORTANT_CONDITIONS"].ToString().Trim();
                                    item.record_type = dr["RECORD_TYPE"] == DBNull.Value ? string.Empty : dr["RECORD_TYPE"].ToString().Trim();
                                    item.link_aer_number = dr["LINK_AER_NUMBER"] == DBNull.Value ? string.Empty : dr["LINK_AER_NUMBER"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllAer()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public Aer GetAerById(int id)
        {
            var item = new Aer();
            string commandText = "SELECT * FROM AER AS A WHERE A.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.report_id = dr["REPORT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORT_ID"]);
                                    item.latest_aer_version_number = dr["LATEST_AER_VERSION_NUMBER"] == DBNull.Value ? 0 : Convert.ToInt32(dr["LATEST_AER_VERSION_NUMBER"]);
                                    item.market_authorization_holder_aer_number = dr["MARKET_AUTHORIZATION_HOLDER_AER_NUMBER"] == DBNull.Value ? string.Empty : dr["MARKET_AUTHORIZATION_HOLDER_AER_NUMBER"].ToString().Trim();
                                    item.initial_received_date = dr["INITIAL_RECEIVED_DATE"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["INITIAL_RECEIVED_DATE"]);
                                    item.latest_received_date = dr["LATEST_RECEIVED_DATE"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["LATEST_RECEIVED_DATE"]);
                                    item.type_of_report = dr["TYPE_OF_REPORT"] == DBNull.Value ? string.Empty : dr["TYPE_OF_REPORT"].ToString().Trim();
                                    item.serious_report = dr["SERIOUS_REPORT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["SERIOUS_REPORT"]);
                                    item.age_group = dr["AGE_GROUP"] == DBNull.Value ? string.Empty : dr["AGE_GROUP"].ToString().Trim();
                                    item.age = dr["AGE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["AGE"]);
                                    item.age_unit = dr["AGE_UNIT"] == DBNull.Value ? string.Empty : dr["AGE_UNIT"].ToString().Trim();
                                    item.age_years = dr["AGE_YEARS"] == DBNull.Value ? 0 : Convert.ToInt64(dr["AGE_YEARS"]);
                                    item.gender = dr["GENDER"] == DBNull.Value ? 0 : Convert.ToInt32(dr["GENDER"]);
                                    item.weight = dr["WEIGHT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["WEIGHT"]);
                                    item.weight_unit = dr["WEIGHT_UNIT"] == DBNull.Value ? string.Empty : dr["WEIGHT_UNIT"].ToString().Trim();
                                    item.height = dr["HEIGHT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["HEIGHT"]);
                                    item.height_unit = dr["HEIGHT_UNIT"] == DBNull.Value ? string.Empty : dr["HEIGHT_UNIT"].ToString().Trim();
                                    item.report_outcome = dr["REPORT_OUTCOME"] == DBNull.Value ? string.Empty : dr["REPORT_OUTCOME"].ToString().Trim();
                                    item.reporter_type = dr["REPORTER_TYPE"] == DBNull.Value ? string.Empty : dr["REPORTER_TYPE"].ToString().Trim();
                                    item.source_of_report = dr["SOURCE_OF_REPORT"] == DBNull.Value ? string.Empty : dr["SOURCE_OF_REPORT"].ToString().Trim();
                                    item.death = dr["DEATH"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DEATH"]);
                                    item.disability = dr["DISABILITY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DISABILITY"]);
                                    item.congenital_anomaly = dr["CONGENITAL_ANOMALY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CONGENITAL_ANOMALY"]);
                                    item.life_threatening = dr["LIFE_THREATENING"] == DBNull.Value ? 0 : Convert.ToInt32(dr["LIFE_THREATENING"]);
                                    item.hospitalization = dr["HOSPITALIZATION"] == DBNull.Value ? 0 : Convert.ToInt32(dr["HOSPITALIZATION"]);
                                    item.other_medically_important_conditions = dr["OTHER_MEDICALLY_IMPORTANT_CONDITIONS"] == DBNull.Value ? string.Empty : dr["OTHER_MEDICALLY_IMPORTANT_CONDITIONS"].ToString().Trim();
                                    item.record_type = dr["RECORD_TYPE"] == DBNull.Value ? string.Empty : dr["RECORD_TYPE"].ToString().Trim();
                                    item.link_aer_number = dr["LINK_AER_NUMBER"] == DBNull.Value ? string.Empty : dr["LINK_AER_NUMBER"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAerById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }


        public List<AerOutcome> GetAllAerOutcome()
        {
            var items = new List<AerOutcome>();
            string commandText = "SELECT DISTINCT A.* FROM AEROUTCOME A";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new AerOutcome();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.code = dr["CODE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CODE"]);
                                    item.outcome = dr["OUTCOME"] == DBNull.Value ? string.Empty : dr["OUTCOME"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllAerOutcome()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public AerOutcome GetAerOutcomeById(int id)
        {
            var item = new AerOutcome();
            string commandText = "SELECT * FROM AEROUTCOME AS A WHERE A.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.code = dr["CODE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["CODE"]);
                                    item.outcome = dr["OUTCOME"] == DBNull.Value ? string.Empty : dr["OUTCOME"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAerOutcomeById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }

        public List<AerIndication> GetAllAerIndication()
        {
            var items = new List<AerIndication>();
            string commandText = "SELECT DISTINCT A.* FROM AERINDICATION A";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new AerIndication();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.report_id = dr["REPORT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORT_ID"]);
                                    item.drug_product_id = dr["DRUG_PRODUCT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUG_PRODUCT_ID"]);
                                    item.drug_name = dr["DRUG_NAME"] == DBNull.Value ? string.Empty : dr["DRUG_NAME"].ToString().Trim();
                                    item.indication = dr["INDICATION"] == DBNull.Value ? string.Empty : dr["INDICATION"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllAerIndication()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public AerIndication GetAerIndicationById(int id)
        {
            var item = new AerIndication();
            string commandText = "SELECT * FROM AERINDICATION AS A WHERE A.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.report_id = dr["REPORT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORT_ID"]);
                                    item.drug_product_id = dr["DRUG_PRODUCT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUG_PRODUCT_ID"]);
                                    item.drug_name = dr["DRUG_NAME"] == DBNull.Value ? string.Empty : dr["DRUG_NAME"].ToString().Trim();
                                    item.indication = dr["INDICATION"] == DBNull.Value ? string.Empty : dr["INDICATION"].ToString().Trim();
                                    item.language = dr["LANGUAGE"] == DBNull.Value ? string.Empty : dr["LANGUAGE"].ToString().Trim();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAerIndicationById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }

        public List<ProductMonograph> GetAllProductMonograph()
        {
            var items = new List<ProductMonograph>();
            string commandText = "SELECT DISTINCT P.* FROM PRODUCTMONOGRAPH P";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new ProductMonograph();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.ci_id = dr["CI_ID"] == DBNull.Value ? string.Empty : dr["CI_ID"].ToString().Trim();
                                    item.company_id = dr["COMPANY_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["COMPANY_ID"]);

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllProductMonograph()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public ProductMonograph GetProductMonographById(int id)
        {
            var item = new ProductMonograph();
            string commandText = "SELECT * FROM PRODUCTMONOGRAPH AS P WHERE P.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.ci_id = dr["CI_ID"] == DBNull.Value ? string.Empty : dr["CI_ID"].ToString().Trim();
                                    item.company_id = dr["COMPANY_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["COMPANY_ID"]);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetProductMonographById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }

        public List<PharmForm> GetAllPharmForm()
        {
            var items = new List<PharmForm>();
            string commandText = "SELECT DISTINCT P.* FROM PHARMFORM P";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new PharmForm();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.drug_product_id = dr["DRUG_PRODUCT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUG_PRODUCT_ID"]);
                                    item.pharm_form = dr["PHARM_FORM"] == DBNull.Value ? string.Empty : dr["PHARM_FORM"].ToString().Trim();
                                    item.form_inactive_date = dr["FORM_INACTIVE_DATE"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["FORM_INACTIVE_DATE"]);
                                    item.drug_identification_number = dr["DRUG_IDENTIFICATION_NUMBER"] == DBNull.Value ? string.Empty : dr["DRUG_IDENTIFICATION_NUMBER"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllPharmForm()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public PharmForm GetPharmFormById(int id)
        {
            var item = new PharmForm();
            string commandText = "SELECT * FROM PHARMFORM AS P WHERE P.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.drug_product_id = dr["DRUG_PRODUCT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUG_PRODUCT_ID"]);
                                    item.pharm_form = dr["PHARM_FORM"] == DBNull.Value ? string.Empty : dr["PHARM_FORM"].ToString().Trim();
                                    item.form_inactive_date = dr["FORM_INACTIVE_DATE"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["FORM_INACTIVE_DATE"]);
                                    item.drug_identification_number = dr["DRUG_IDENTIFICATION_NUMBER"] == DBNull.Value ? string.Empty : dr["DRUG_IDENTIFICATION_NUMBER"].ToString().Trim();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetPharmFormById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }

        public List<BrandName> GetAllBrandName()
        {
            var items = new List<BrandName>();
            string commandText = "SELECT DISTINCT B.* FROM BRANDNAME B";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var item = new BrandName();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.brand_name = dr["BRAND_NAME"] == DBNull.Value ? string.Empty : dr["BRAND_NAME"].ToString().Trim();

                                    items.Add(item);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAllBrandName()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return items;
        }

        public BrandName GetBrandNameById(int id)
        {
            var item = new BrandName();
            string commandText = "SELECT * FROM BRANDNAME AS B WHERE B.ID = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(DhprDBConnection))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, con))
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    item.brand_name = dr["BRAND_NAME"] == DBNull.Value ? string.Empty : dr["BRAND_NAME"].ToString().Trim();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetBrandNameById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return item;
        }

    }
}

