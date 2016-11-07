
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using dhprWebApi.Models;
using Npgsql;
namespace dhprWebApi
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

        public Company GetCompanyById(int id)
        {
            var company = new Company();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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

                                    company = item;
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
            return company;
        }

        public List<AerIngredient> GetAllAerIngredient()
        {
            var items = new List<AerIngredient>();
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
                                    var item = new AerIngredient();
                                    item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();
                                    //item.first_licence_status_dt = dr["FIRST_LICENCE_STATUS_DT"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["FIRST_LICENCE_STATUS_DT"]);

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
            var aerIngredient = new AerIngredient();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    aerIngredient = item;
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
            return aerIngredient;
        }

        public List<AerReactionTerms> GetAllAerReactionTerms()
        {
            var items = new List<AerReactionTerms>();
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
                                    var item = new AerReactionTerms();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var aerReactionTerms = new AerReactionTerms();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    aerReactionTerms = item;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMessages = string.Format("DbConnection.cs - GetAerReactionTermsById()");
                        ExceptionHelper.LogException(ex, errorMessages);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
            }
            return aerReactionTerms;
        }
        public List<AerProductInformation> GetAllAerProductInformation()
        {
            var items = new List<AerProductInformation>();
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
                                    var item = new AerProductInformation();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var aerProductInformation = new AerProductInformation();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    aerProductInformation = item;
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
            return aerProductInformation;
        }
        public List<Ci> GetAllCi()
        {
            var items = new List<Ci>();
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
                                    var item = new Ci();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var ci = new Ci();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    ci = item;
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
            return ci;
        }

        public List<AerReportType> GetAllAerReportType()
        {
            var items = new List<AerReportType>();
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
                                    var item = new AerReportType();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var aerReportType = new AerReportType();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    aerReportType = item;
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
            return aerReportType;
        }
        public List<AerLink> GetAllAerLink()
        {
            var items = new List<AerLink>();
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
                                    var item = new AerLink();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var aerLink = new AerLink();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    aerLink = item;
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
            return aerLink;
        }
        public List<DrugProduct> GetAllDrugProduct()
        {
            var items = new List<DrugProduct>();
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
                                    var item = new DrugProduct();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var drugProduct = new DrugProduct();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    drugProduct = item;
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
            return drugProduct;
        }

        public List<AerSource> GetAllAerSource()
        {
            var items = new List<AerSource>();
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
                                    var item = new AerSource();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var aerSource = new AerSource();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    aerSource = item;
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
            return aerSource;
        }

        public List<AerSerious> GetAllAerSerious()
        {
            var items = new List<AerSerious>();
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
                                    var item = new AerSerious();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var aerSerious = new AerSerious();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    aerSerious = item;
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
            return aerSerious;
        }

        public List<ActiveIngredient> GetAllActiveIngredient()
        {
            var items = new List<ActiveIngredient>();
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
                                    var item = new ActiveIngredient();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var activeingredient = new ActiveIngredient();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    activeingredient = item;
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
            return activeingredient;
        }

        public List<Route> GetAllRoute()
        {
            var items = new List<Route>();
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
                                    var item = new Route();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var route = new Route();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    route = item;
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
            return route;
        }

        public List<Aer> GetAllAer()
        {
            var items = new List<Aer>();
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
                                    var item = new Aer();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var aer = new Aer();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    aer = item;
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
            return aer;
        }


        public List<AerOutcome> GetAllAerOutcome()
        {
            var items = new List<AerOutcome>();
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
                                    var item = new AerOutcome();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var aeroutcome = new AerOutcome();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    aeroutcome = item;
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
            return aeroutcome;
        }

        public List<AerIndication> GetAllAerIndication()
        {
            var items = new List<AerIndication>();
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
                                    var item = new AerIndication();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var aerindication = new AerIndication();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    aerindication = item;
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
            return aerindication;
        }

        public List<ProductMonograph> GetAllProductMonograph()
        {
            var items = new List<ProductMonograph>();
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
                                    var item = new ProductMonograph();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var productMonograph = new ProductMonograph();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    productMonograph = item;
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
            return productMonograph;
        }

        public List<PharmForm> GetAllPharmForm()
        {
            var items = new List<PharmForm>();
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
                                    var item = new PharmForm();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var pharmForm = new PharmForm();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    pharmForm = item;
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
            return pharmForm;
        }

        public List<BrandName> GetAllBrandName()
        {
            var items = new List<BrandName>();
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
                                    var item = new BrandName();
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

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
            var brandName = new BrandName();
            string commandText = "SELECT * FROM COMPANY WHERE ID = " + id;

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
                                    //item.id = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
                                    //item.company_name = dr["COMPANY_NAME"] == DBNull.Value ? string.Empty : dr["COMPANY_NAME"].ToString().Trim();

                                    brandName = item;
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
            return brandName;
        }

    }
}

