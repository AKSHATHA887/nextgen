using Serilog.Events;
using Serilog;
using Microsoft.Extensions.Configuration;
using Serilog.Core;
using System.Configuration;
using Microsoft.Data.SqlClient;
using Npgsql;

namespace ConsoleApp1
{
    public class Program
    {
        public static Serilog.ILogger BuildLogger()
        {
            Log.Logger = new LoggerConfiguration().MinimumLevel.Information()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
        .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
        .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Warning)
        .MinimumLevel.Override("System.Net.Http.HttpClient", LogEventLevel.Warning)
        .MinimumLevel.Override("System", LogEventLevel.Warning)
        .Enrich.FromLogContext()
        .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}").CreateLogger();
            return Log.Logger;


}

        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World! for testing permission");
            var logger = BuildLogger();
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINCostRate;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();
                logger.Information("rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com 1033_DataPatrol_FINCostRate connection success");
                connection.Close();
            }
            catch (SqlException e)
            {
                logger.Information("rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com 1033_DataPatrol_FINCostRate connection fail");
                Console.WriteLine(e.ToString());
            }
            logger.Information("Hello, World! for testing permission");


            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINCostRate;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINCostRate connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINCostRate connection fail");
            //    Console.WriteLine(e.ToString());
            //}

            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINHierarchy;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINHierarchy connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINHierarchy connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINProfitCenter;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINProfitCenter connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINProfitCenter connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINCostElement;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINCostElement connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINCostElement connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINGeographicUnit;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINGeographicUnit connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINGeographicUnit connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINGeographicRegion;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINGeographicRegion connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINGeographicRegion connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINBusinessActivities;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINBusinessActivities connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINBusinessActivities connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINMarketLocation;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINMarketLocation connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINMarketLocation connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINWorkForceFinance;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINWorkForceFinance connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINWorkForceFinance connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINEnterpriseFunction;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINEnterpriseFunction connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINEnterpriseFunction connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINLoadRate;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINLoadRate connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINLoadRate connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINTypeOfWork;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINTypeOfWork connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINTypeOfWork connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINCareerTrackFinance;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINCareerTrackFinance connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINCareerTrackFinance connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0055.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINEmployeeRates;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINEmployeeRates connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0055 1033_DataPatrol_FINEmployeeRates connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0059.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINAccountFieldStatus;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0059 1033_DataPatrol_FINAccountFieldStatus connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0059 1033_DataPatrol_FINAccountFieldStatus connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0059.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINSupplier;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0059 1033_DataPatrol_FINSupplier connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0059 1033_DataPatrol_FINSupplier connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0059.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINBillToShipAddress;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0059 1033_DataPatrol_FINBillToShipAddress connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0059 1033_DataPatrol_FINBillToShipAddress connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0059.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINPurchaseOrg;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0059 1033_DataPatrol_FINPurchaseOrg connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0059 1033_DataPatrol_FINPurchaseOrg connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0059.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINVendor;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0059 1033_DataPatrol_FINVendor connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0059 1033_DataPatrol_FINVendor connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0059.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINVendorContact;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0059 1033_DataPatrol_FINVendorContact connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0059 1033_DataPatrol_FINVendorContact connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0057.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINWBS;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINWBS connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINWBS connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0057.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINWBSNetwork;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINWBSNetwork connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINWBSNetwork connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0057.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINCustomer;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINCustomer connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINCustomer connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0057.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINContracts;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINContracts connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINContracts connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0057.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINCustomerResp;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINCustomerResp connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINCustomerResp connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0057.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINBillRate;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINBillRate connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINBillRate connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0057.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINIndustry;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINIndustry connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINIndustry connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0057.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINProject;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINProject connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINProject connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0057.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINWBSAttribute;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINWBSAttribute connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINWBSAttribute connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0057.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINContractLineItem;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINContractLineItem connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINContractLineItem connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0057.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINContractWBS;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINContractWBS connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINContractWBS connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0057.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINStateProvince;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINStateProvince connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0057 1033_DataPatrol_FINStateProvince connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0059.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINWBSRevenue;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0059 1033_DataPatrol_FINWBSRevenue connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0059 1033_DataPatrol_FINWBSRevenue connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0056.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINCountry;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0056 1033_DataPatrol_FINCountry connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0056 1033_DataPatrol_FINCountry connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0056.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINCurrency;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0056 1033_DataPatrol_FINCurrency connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0056 1033_DataPatrol_FINCurrency connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0056.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINCompany;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0056 1033_DataPatrol_FINCompany connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0056 1033_DataPatrol_FINCompany connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0056.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINAccount;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0056 1033_DataPatrol_FINAccount connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0056 1033_DataPatrol_FINAccount connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0056.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINExchangeRates;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0056 1033_DataPatrol_FINExchangeRates connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0056 1033_DataPatrol_FINExchangeRates connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0056.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINMonthlyExchangeRates;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0056 1033_DataPatrol_FINMonthlyExchangeRates connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0056 1033_DataPatrol_FINMonthlyExchangeRates connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=rds2sqs0054.c1rqiq13m2ud.us-east-1.rds.amazonaws.com;Initial Catalog=1033_DataPatrol_FINOutputCompare;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("rds2sqs0054 1033_DataPatrol_FINOutputCompare connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("rds2sqs0054 1033_DataPatrol_FINOutputCompare connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=VD133646.dir.svc.accenture.com;Initial Catalog=1033_MRDR_ServiceBus;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("VD133646 1033_MRDR_ServiceBus connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("VD133646 1033_MRDR_ServiceBus connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=VD127279.dir.svc.accenture.com;Initial Catalog=1033_MRDR_MFPLanding;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("VD127279 1033_MRDR_MFPLanding connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("VD127279 1033_MRDR_MFPLanding connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=VD127599.dir.svc.accenture.com;Initial Catalog=1033_MRDR_MFP;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("VD127599 1033_MRDR_MFP connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("VD127599 1033_MRDR_MFP connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=VD127580.dir.svc.accenture.com;Initial Catalog=1033_PeopleLanding;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("VD127580 1033_PeopleLanding connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("VD127580 1033_PeopleLanding connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=VD127580.dir.svc.accenture.com;Initial Catalog=1033_PeopleDataStore;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("VD127580 1033_PeopleDataStore connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("VD127580 1033_PeopleDataStore connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=VD128838.dir.svc.accenture.com;Initial Catalog=1033_ChargecodeLanding;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("VD128838 1033_ChargecodeLanding connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("VD128838 1033_ChargecodeLanding connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            //try
            //{
            //    SqlConnection connection = new SqlConnection("Data Source=VD128580.dir.svc.accenture.com;Initial Catalog=1033_Chargecode;Integrated Security=True; TrustServerCertificate = True");
            //    connection.Open();
            //    logger.Information("VD128580 1033_Chargecode connection success");
            //    connection.Close();
            //}
            //catch (SqlException e)
            //{
            //    logger.Information("VD128580 1033_Chargecode connection fail");
            //    Console.WriteLine(e.ToString());
            //}
            logger.Information("\nDone.");
            logger.Information("\nPress Enter.");
        }
    }
}