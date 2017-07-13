using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using dhprWebApi.AppCode;

namespace dhprWebApi.Controllers
{
    public class CSVController : ApiController
    {
        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage DownloadCSV(string dataType, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            var jsonResult = string.Empty;
            var fileNameDate = string.Format("{0}{1}{2}",
                           DateTime.Now.Year.ToString(),
                           DateTime.Now.Month.ToString().PadLeft(2, '0'),
                           DateTime.Now.Day.ToString().PadLeft(2, '0'));
            var fileName = string.Format(dataType + "_{0}.csv", fileNameDate);
            byte[] outputBuffer = null;
            string resultString = string.Empty;
            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);

            var json = string.Empty;

            switch (dataType)
            {
                case "activeGender":
                    var activeGenders = dbConnection.GetAllAerGender().ToList();
                    if (activeGenders.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(activeGenders);

                    }
                    break;

                case "activeIngredient":
                    var activeIngredients = dbConnection.GetAllActiveIngredient().ToList();
                    if (activeIngredients.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(activeIngredients);

                    }
                    break;

                case "Aer":
                    var Aer = dbConnection.GetAllAer().ToList();
                    if (Aer.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(Aer);

                    }
                    break;

                case "AerIndication":
                    var AerIndication = dbConnection.GetAllAerIndication().ToList();
                    if (AerIndication.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(AerIndication);

                    }
                    break;

                case "AerIngredient":
                    var AerIngredient = dbConnection.GetAllAerIngredient().ToList();
                    if (AerIngredient.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(AerIngredient);

                    }
                    break;

                case "AerLink":
                    var AerLink = dbConnection.GetAllAerLink().ToList();
                    if (AerLink.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(AerLink);

                    }
                    break;

                case "AerOutcome":
                    var AerOutcome = dbConnection.GetAllAerOutcome().ToList();
                    if (AerOutcome.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(AerOutcome);

                    }
                    break;

                case "AerProductInfo":
                    var AerProductInfo = dbConnection.GetAllAerProductInformation().ToList();
                    if (AerProductInfo.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(AerProductInfo);

                    }
                    break;

                case "reactionTerm":
                    var reactionTerm = dbConnection.GetAllAerReactionTerm().ToList();
                    if (reactionTerm.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(reactionTerm);

                    }
                    break;

                case "reportType":
                    var reportType = dbConnection.GetAllAerReportType().ToList();
                    if (reportType.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(reportType);

                    }
                    break;

                case "serious":
                    var serious = dbConnection.GetAllAerSerious().ToList();
                    if (serious.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(serious);

                    }
                    break;

                case "source":
                    var source = dbConnection.GetAllAerSource().ToList();
                    if (source.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(source);

                    }
                    break;

                case "brandName":
                    var brandName = dbConnection.GetAllBrandName().ToList();
                    if (brandName.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(brandName);

                    }
                    break;

                case "ci":
                    var ci = dbConnection.GetAllCi().ToList();
                    if (ci.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(ci);

                    }
                    break;

                case "company":
                    var company = dbConnection.GetAllCompany().ToList();
                    if (company.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(company);

                    }
                    break;

                case "drugProduct":
                    var drugProduct = dbConnection.GetAllDrugProduct().ToList();
                    if (drugProduct.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(drugProduct);

                    }
                    break;

                case "AerGender":
                    var AerGender = dbConnection.GetAllAerGender().ToList();
                    if (AerGender.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(AerGender);

                    }
                    break;

                case "pharmForm":
                    var pharmForm = dbConnection.GetAllPharmForm().ToList();
                    if (pharmForm.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(pharmForm);

                    }
                    break;

                case "productMonograph":
                    var productMonograph = dbConnection.GetAllProductMonograph().ToList();
                    if (productMonograph.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(productMonograph);

                    }
                    break;

                case "route":
                    var route = dbConnection.GetAllRoute().ToList();
                    if (route.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(route);

                    }
                    break;

                case "xref":
                    var xref = dbConnection.GetAllXref().ToList();
                    if (xref.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(xref);

                    }
                    break;
            }

            if (!string.IsNullOrWhiteSpace(json))
            {
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(json);
                if (dt.Rows.Count > 0)
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            UtilityHelper.WriteDataTable(dt, writer, true);
                            outputBuffer = stream.ToArray();
                            resultString = Encoding.UTF8.GetString(outputBuffer, 0, outputBuffer.Length);
                        }
                    }
                    result.Content = new StringContent(resultString);
                    result.Content.Headers.ContentType = new MediaTypeHeaderValue("text/csv");
                    result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment") { FileName = fileName };
                }
            }

            return result;
        }
    }
}
