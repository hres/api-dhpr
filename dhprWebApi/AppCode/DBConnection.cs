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
                                    item.drugproductid = dr["DRUGPRODUCTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUGPRODUCTID"]);
                                    item.drugname = dr["DRUGNAME"] == DBNull.Value ? string.Empty : dr["DRUGNAME"].ToString().Trim();
                                    item.ingredientid = dr["INGREDIENTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["INGREDIENTID"]);
                                    item.ingredientname = dr["INGREDIENTNAME"] == DBNull.Value ? string.Empty : dr["INGREDIENTNAME"].ToString().Trim();
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
                                    item.drugproductid = dr["DRUGPRODUCTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUGPRODUCTID"]);
                                    item.drugname = dr["DRUGNAME"] == DBNull.Value ? string.Empty : dr["DRUGNAME"].ToString().Trim();
                                    item.ingredientid = dr["INGREDIENTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["INGREDIENTID"]);
                                    item.ingredientname = dr["INGREDIENTNAME"] == DBNull.Value ? string.Empty : dr["INGREDIENTNAME"].ToString().Trim();
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
                                    item.reportid = dr["REPORTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORTID"]);
                                    item.adversereactionterms = dr["ADVERSEREACTIONTERMS"] == DBNull.Value ? string.Empty : dr["ADVERSEREACTIONTERMS"].ToString().Trim();
                                    item.meddrasystemorganclasssoc = dr["MEDDRASYSTEMORGANCLASSSOC"] == DBNull.Value ? string.Empty : dr["MEDDRASYSTEMORGANCLASSSOC"].ToString().Trim();
                                    item.reactionduration = dr["REACTIONDURATION"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REACTIONDURATION"]);
                                    item.reactiondurationunit = dr["REACTIONDURATIONUNIT"] == DBNull.Value ? string.Empty : dr["REACTIONDURATIONUNIT"].ToString().Trim();
                                    item.meddraversion = dr["MEDDRAVERSION"] == DBNull.Value ? string.Empty : dr["MEDDRAVERSION"].ToString().Trim();
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
                                    item.reportid = dr["REPORTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORTID"]);
                                    item.adversereactionterms = dr["ADVERSEREACTIONTERMS"] == DBNull.Value ? string.Empty : dr["ADVERSEREACTIONTERMS"].ToString().Trim();
                                    item.meddrasystemorganclasssoc = dr["MEDDRASYSTEMORGANCLASSSOC"] == DBNull.Value ? string.Empty : dr["MEDDRASYSTEMORGANCLASSSOC"].ToString().Trim();
                                    item.reactionduration = dr["REACTIONDURATION"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REACTIONDURATION"].ToString().Trim());
                                    item.reactiondurationunit = dr["REACTIONDURATIONUNIT"] == DBNull.Value ? string.Empty : dr["REACTIONDURATIONUNIT"].ToString().Trim();
                                    item.meddraversion = dr["MEDDRAVERSION"] == DBNull.Value ? string.Empty : dr["MEDDRAVERSION"].ToString().Trim();
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
                                    item.reportdrugid = dr["REPORTDRUGID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORTDRUGID"]);
                                    item.reportid = dr["REPORTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORTID"]);
                                    item.drugproductid = dr["DRUGPRODUCTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUGPRODUCTID"]);
                                    item.drugname = dr["DRUGNAME"] == DBNull.Value ? string.Empty : dr["DRUGNAME"].ToString().Trim();
                                    item.cvpname = dr["CVPNAME"] == DBNull.Value ? string.Empty : dr["CVPNAME"].ToString().Trim();
                                    item.dosageform = dr["DOSAGEFORM"] == DBNull.Value ? string.Empty : dr["DOSAGEFORM"].ToString().Trim();
                                    item.healthproductrole = dr["HEALTHPRODUCTROLE"] == DBNull.Value ? string.Empty : dr["HEALTHPRODUCTROLE"].ToString().Trim();
                                    item.routeofadministration = dr["ROUTEOFADMINISTRATION"] == DBNull.Value ? string.Empty : dr["ROUTEOFADMINISTRATION"].ToString().Trim();
                                    item.amount = dr["AMOUNT"] == DBNull.Value ? 0 : Convert.ToInt64(dr["AMOUNT"]);
                                    item.amountunit = dr["AMOUNTUNIT"] == DBNull.Value ? string.Empty : dr["AMOUNTUNIT"].ToString().Trim();
                                    item.frequency = dr["FREQUENCY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["FREQUENCY"]);
                                    item.frequencytime = dr["FREQUENCYTIME"] == DBNull.Value ? 0 : Convert.ToInt32(dr["FREQUENCYTIME"]);
                                    item.frequencytimeunit = dr["FREQUENCYTIMEUNIT"] == DBNull.Value ? string.Empty : dr["FREQUENCYTIMEUNIT"].ToString().Trim();
                                    item.frequencyunit = dr["FREQUENCYUNIT"] == DBNull.Value ? string.Empty : dr["FREQUENCYUNIT"].ToString().Trim();
                                    item.therapyduration = dr["THERAPYDURATION"] == DBNull.Value ? 0 : Convert.ToInt32(dr["THERAPYDURATION"]);
                                    item.therapydurationunit = dr["THERAPYDURATIONUNIT"] == DBNull.Value ? string.Empty : dr["THERAPYDURATIONUNIT"].ToString().Trim();
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
                                    item.reportdrugid = dr["REPORTDRUGID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORTDRUGID"]);
                                    item.reportid = dr["REPORTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORTID"]);
                                    item.drugproductid = dr["DRUGPRODUCTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUGPRODUCTID"]);
                                    item.drugname = dr["DRUGNAME"] == DBNull.Value ? string.Empty : dr["DRUGNAME"].ToString().Trim();
                                    item.cvpname = dr["CVPNAME"] == DBNull.Value ? string.Empty : dr["CVPNAME"].ToString().Trim();
                                    item.dosageform = dr["DOSAGEFORM"] == DBNull.Value ? string.Empty : dr["DOSAGEFORM"].ToString().Trim();
                                    item.healthproductrole = dr["HEALTHPRODUCTROLE"] == DBNull.Value ? string.Empty : dr["HEALTHPRODUCTROLE"].ToString().Trim();
                                    item.routeofadministration = dr["ROUTEOFADMINISTRATION"] == DBNull.Value ? string.Empty : dr["ROUTEOFADMINISTRATION"].ToString().Trim();
                                    item.amount = dr["AMOUNT"] == DBNull.Value ? 0 : Convert.ToInt64(dr["AMOUNT"]);
                                    item.amountunit = dr["AMOUNTUNIT"] == DBNull.Value ? string.Empty : dr["AMOUNTUNIT"].ToString().Trim();
                                    item.frequency = dr["FREQUENCY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["FREQUENCY"]);
                                    item.frequencytime = dr["FREQUENCYTIME"] == DBNull.Value ? 0 : Convert.ToInt32(dr["FREQUENCYTIME"]);
                                    item.frequencytimeunit = dr["FREQUENCYTIMEUNIT"] == DBNull.Value ? string.Empty : dr["FREQUENCYTIMEUNIT"].ToString().Trim();
                                    item.frequencyunit = dr["FREQUENCYUNIT"] == DBNull.Value ? string.Empty : dr["FREQUENCYUNIT"].ToString().Trim();
                                    item.therapyduration = dr["THERAPYDURATION"] == DBNull.Value ? 0 : Convert.ToInt32(dr["THERAPYDURATION"]);
                                    item.therapydurationunit = dr["THERAPYDURATIONUNIT"] == DBNull.Value ? string.Empty : dr["THERAPYDURATIONUNIT"].ToString().Trim();
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
                                    item.ci_usedfor = dr["CI_USEDFOR"] == DBNull.Value ? string.Empty : dr["CI_USEDFOR"].ToString().Trim();
                                    item.ci_whatitdoes = dr["CI_WHATITDOES"] == DBNull.Value ? string.Empty : dr["CI_WHATITDOES"].ToString().Trim();
                                    item.ci_whennotused = dr["CI_WHENNOTUSED"] == DBNull.Value ? string.Empty : dr["CI_WHENNOTUSED"].ToString().Trim();
                                    item.ci_medicinalingredients = dr["CI_MEDICINALINGREDIENTS"] == DBNull.Value ? string.Empty : dr["CI_MEDICINALINGREDIENTS"].ToString().Trim();
                                    item.ci_nonmedicinalingredients = dr["CI_NONMEDICINALINGREDIENTS"] == DBNull.Value ? string.Empty : dr["CI_NONMEDICINALINGREDIENTS"].ToString().Trim();
                                    item.ci_dosage = dr["CI_DOSAGE"] == DBNull.Value ? string.Empty : dr["CI_DOSAGE"].ToString().Trim();
                                    item.ci_warnings = dr["CI_WARNINGS"] == DBNull.Value ? string.Empty : dr["CI_WARNINGS"].ToString().Trim();
                                    item.ci_interactions = dr["CI_INTERACTIONS"] == DBNull.Value ? string.Empty : dr["CI_INTERACTIONS"].ToString().Trim();
                                    item.ci_properuse = dr["CI_PROPERUSE"] == DBNull.Value ? string.Empty : dr["CI_PROPERUSE"].ToString().Trim();
                                    item.ci_sideeffects = dr["CI_SIDEEFFECTS"] == DBNull.Value ? string.Empty : dr["CI_SIDEEFFECTS"].ToString().Trim();
                                    item.ci_storage = dr["CI_STORAGE"] == DBNull.Value ? string.Empty : dr["CI_STORAGE"].ToString().Trim();
                                    item.ci_reportingsideeffects = dr["CI_REPORTINGSIDEEFFECTS"] == DBNull.Value ? string.Empty : dr["CI_REPORTINGSIDEEFFECTS"].ToString().Trim();
                                    item.ci_moreinfo = dr["CI_MOREINFO"] == DBNull.Value ? string.Empty : dr["CI_MOREINFO"].ToString().Trim();
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
                                    item.ci_usedfor = dr["CI_USEDFOR"] == DBNull.Value ? string.Empty : dr["CI_USEDFOR"].ToString().Trim();
                                    item.ci_whatitdoes = dr["CI_WHATITDOES"] == DBNull.Value ? string.Empty : dr["CI_WHATITDOES"].ToString().Trim();
                                    item.ci_whennotused = dr["CI_WHENNOTUSED"] == DBNull.Value ? string.Empty : dr["CI_WHENNOTUSED"].ToString().Trim();
                                    item.ci_medicinalingredients = dr["CI_MEDICINALINGREDIENTS"] == DBNull.Value ? string.Empty : dr["CI_MEDICINALINGREDIENTS"].ToString().Trim();
                                    item.ci_nonmedicinalingredients = dr["CI_NONMEDICINALINGREDIENTS"] == DBNull.Value ? string.Empty : dr["CI_NONMEDICINALINGREDIENTS"].ToString().Trim();
                                    item.ci_dosage = dr["CI_DOSAGE"] == DBNull.Value ? string.Empty : dr["CI_DOSAGE"].ToString().Trim();
                                    item.ci_warnings = dr["CI_WARNINGS"] == DBNull.Value ? string.Empty : dr["CI_WARNINGS"].ToString().Trim();
                                    item.ci_interactions = dr["CI_INTERACTIONS"] == DBNull.Value ? string.Empty : dr["CI_INTERACTIONS"].ToString().Trim();
                                    item.ci_properuse = dr["CI_PROPERUSE"] == DBNull.Value ? string.Empty : dr["CI_PROPERUSE"].ToString().Trim();
                                    item.ci_sideeffects = dr["CI_SIDEEFFECTS"] == DBNull.Value ? string.Empty : dr["CI_SIDEEFFECTS"].ToString().Trim();
                                    item.ci_storage = dr["CI_STORAGE"] == DBNull.Value ? string.Empty : dr["CI_STORAGE"].ToString().Trim();
                                    item.ci_reportingsideeffects = dr["CI_REPORTINGSIDEEFFECTS"] == DBNull.Value ? string.Empty : dr["CI_REPORTINGSIDEEFFECTS"].ToString().Trim();
                                    item.ci_moreinfo = dr["CI_MOREINFO"] == DBNull.Value ? string.Empty : dr["CI_MOREINFO"].ToString().Trim();
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
                                    item.reportid = dr["REPORTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORTID"]);
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
                                    item.reportid = dr["REPORTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORTID"]);
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
                                    item.reportid = dr["REPORTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORTID"]);
                                    item.latestaerversionnumber = dr["LATESTAERVERSIONNUMBER"] == DBNull.Value ? 0 : Convert.ToInt32(dr["LATESTAERVERSIONNUMBER"]);
                                    item.marketauthorizationholderaernumber = dr["MARKETAUTHORIZATIONHOLDERAERNUMBER"] == DBNull.Value ? string.Empty : dr["MARKETAUTHORIZATIONHOLDERAERNUMBER"].ToString().Trim();
                                    item.initialreceiveddate = dr["INITIALRECEIVEDDATE"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["INITIALRECEIVEDDATE"]);
                                    item.latestreceiveddate = dr["LATESTRECEIVEDDATE"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["LATESTRECEIVEDDATE"]);
                                    item.typeofreport = dr["TYPEOFREPORT"] == DBNull.Value ? string.Empty : dr["TYPEOFREPORT"].ToString().Trim();
                                    item.seriousreport = dr["SERIOUSREPORT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["SERIOUSREPORT"]);
                                    item.agegroup = dr["AGEGROUP"] == DBNull.Value ? string.Empty : dr["AGEGROUP"].ToString().Trim();
                                    item.age = dr["AGE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["AGE"]);
                                    item.ageunit = dr["AGEUNIT"] == DBNull.Value ? string.Empty : dr["AGEUNIT"].ToString().Trim();
                                    item.age_years = dr["AGE_YEARS"] == DBNull.Value ? 0 : Convert.ToInt64(dr["AGE_YEARS"]);
                                    item.gender = dr["GENDER"] == DBNull.Value ? 0 : Convert.ToInt32(dr["GENDER"]);
                                    item.weight = dr["WEIGHT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["WEIGHT"]);
                                    item.weightunit = dr["WEIGHTUNIT"] == DBNull.Value ? string.Empty : dr["WEIGHTUNIT"].ToString().Trim();
                                    item.height = dr["HEIGHT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["HEIGHT"]);
                                    item.heightunit = dr["HEIGHTUNIT"] == DBNull.Value ? string.Empty : dr["HEIGHTUNIT"].ToString().Trim();
                                    item.reportoutcome = dr["REPORTOUTCOME"] == DBNull.Value ? string.Empty : dr["REPORTOUTCOME"].ToString().Trim();
                                    item.reportertype = dr["REPORTERTYPE"] == DBNull.Value ? string.Empty : dr["REPORTERTYPE"].ToString().Trim();
                                    item.sourceofreport = dr["SOURCEOFREPORT"] == DBNull.Value ? string.Empty : dr["SOURCEOFREPORT"].ToString().Trim();
                                    item.death = dr["DEATH"] == DBNull.Value ? 0 : Convert.ToInt16(dr["DEATH"]);
                                    item.disability = dr["DISABILITY"] == DBNull.Value ? 0 : Convert.ToInt16(dr["DISABILITY"]);
                                    item.congenitalanomaly = dr["CONGENITALANOMALY"] == DBNull.Value ? 0 : Convert.ToInt16(dr["CONGENITALANOMALY"]);
                                    item.lifethreatening = dr["LIFETHREATENING"] == DBNull.Value ? 0 : Convert.ToInt16(dr["LIFETHREATENING"]);
                                    item.hospitalization = dr["HOSPITALIZATION"] == DBNull.Value ? 0 : Convert.ToInt16(dr["HOSPITALIZATION"]);
                                    item.othermedicallyimportantconditions = dr["OTHERMEDICALLYIMPORTANTCONDITIONS"] == DBNull.Value ? string.Empty : dr["OTHERMEDICALLYIMPORTANTCONDITIONS"].ToString().Trim();
                                    item.recordtype = dr["RECORDTYPE"] == DBNull.Value ? string.Empty : dr["RECORDTYPE"].ToString().Trim();
                                    item.linkaernumber = dr["LINKAERNUMBER"] == DBNull.Value ? string.Empty : dr["LINKAERNUMBER"].ToString().Trim();
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
                                    item.reportid = dr["REPORTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORTID"]);
                                    item.latestaerversionnumber = dr["LATESTAERVERSIONNUMBER"] == DBNull.Value ? 0 : Convert.ToInt32(dr["LATESTAERVERSIONNUMBER"]);
                                    item.marketauthorizationholderaernumber = dr["MARKETAUTHORIZATIONHOLDERAERNUMBER"] == DBNull.Value ? string.Empty : dr["MARKETAUTHORIZATIONHOLDERAERNUMBER"].ToString().Trim();
                                    item.initialreceiveddate = dr["INITIALRECEIVEDDATE"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["INITIALRECEIVEDDATE"]);
                                    item.latestreceiveddate = dr["LATESTRECEIVEDDATE"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["LATESTRECEIVEDDATE"]);
                                    item.typeofreport = dr["TYPEOFREPORT"] == DBNull.Value ? string.Empty : dr["TYPEOFREPORT"].ToString().Trim();
                                    item.seriousreport = dr["SERIOUSREPORT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["SERIOUSREPORT"]);
                                    item.agegroup = dr["AGEGROUP"] == DBNull.Value ? string.Empty : dr["AGEGROUP"].ToString().Trim();
                                    item.age = dr["AGE"] == DBNull.Value ? 0 : Convert.ToInt32(dr["AGE"]);
                                    item.ageunit = dr["AGEUNIT"] == DBNull.Value ? string.Empty : dr["AGEUNIT"].ToString().Trim();
                                    item.age_years = dr["AGE_YEARS"] == DBNull.Value ? 0 : Convert.ToInt64(dr["AGE_YEARS"]);
                                    item.gender = dr["GENDER"] == DBNull.Value ? 0 : Convert.ToInt32(dr["GENDER"]);
                                    item.weight = dr["WEIGHT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["WEIGHT"]);
                                    item.weightunit = dr["WEIGHTUNIT"] == DBNull.Value ? string.Empty : dr["WEIGHTUNIT"].ToString().Trim();
                                    item.height = dr["HEIGHT"] == DBNull.Value ? 0 : Convert.ToInt32(dr["HEIGHT"]);
                                    item.heightunit = dr["HEIGHTUNIT"] == DBNull.Value ? string.Empty : dr["HEIGHTUNIT"].ToString().Trim();
                                    item.reportoutcome = dr["REPORTOUTCOME"] == DBNull.Value ? string.Empty : dr["REPORTOUTCOME"].ToString().Trim();
                                    item.reportertype = dr["REPORTERTYPE"] == DBNull.Value ? string.Empty : dr["REPORTERTYPE"].ToString().Trim();
                                    item.sourceofreport = dr["SOURCEOFREPORT"] == DBNull.Value ? string.Empty : dr["SOURCEOFREPORT"].ToString().Trim();
                                    item.death = dr["DEATH"] == DBNull.Value ? 0 : Convert.ToInt16(dr["DEATH"]);
                                    item.disability = dr["DISABILITY"] == DBNull.Value ? 0 : Convert.ToInt16(dr["DISABILITY"]);
                                    item.congenitalanomaly = dr["CONGENITALANOMALY"] == DBNull.Value ? 0 : Convert.ToInt16(dr["CONGENITALANOMALY"]);
                                    item.lifethreatening = dr["LIFETHREATENING"] == DBNull.Value ? 0 : Convert.ToInt16(dr["LIFETHREATENING"]);
                                    item.hospitalization = dr["HOSPITALIZATION"] == DBNull.Value ? 0 : Convert.ToInt16(dr["HOSPITALIZATION"]);
                                    item.othermedicallyimportantconditions = dr["OTHERMEDICALLYIMPORTANTCONDITIONS"] == DBNull.Value ? string.Empty : dr["OTHERMEDICALLYIMPORTANTCONDITIONS"].ToString().Trim();
                                    item.recordtype = dr["RECORDTYPE"] == DBNull.Value ? string.Empty : dr["RECORDTYPE"].ToString().Trim();
                                    item.linkaernumber = dr["LINKAERNUMBER"] == DBNull.Value ? string.Empty : dr["LINKAERNUMBER"].ToString().Trim();
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
                                    item.reportid = dr["REPORTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORTID"]);
                                    item.drugproductid = dr["DRUGPRODUCTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUGPRODUCTID"]);
                                    item.drugname = dr["DRUGNAME"] == DBNull.Value ? string.Empty : dr["DRUGNAME"].ToString().Trim();
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
                                    item.reportid = dr["REPORTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["REPORTID"]);
                                    item.drugproductid = dr["DRUGPRODUCTID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DRUGPRODUCTID"]);
                                    item.drugname = dr["DRUGNAME"] == DBNull.Value ? string.Empty : dr["DRUGNAME"].ToString().Trim();
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

