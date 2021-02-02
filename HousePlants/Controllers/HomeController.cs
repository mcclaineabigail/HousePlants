using HousePlants.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HousePlants.Controllers
{
    public class HomeController : Controller
    {
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        List<Plant> plantList = new List<Plant>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            con.ConnectionString = HousePlants.Properties.Resources.ConnectionString;
        }

        public IActionResult Index()
        {
            // create new view model
            //get list of plants from database
            //iterrate list of plants be creating new plant model and adding it to the list of plants
            //
            //var pothos = new Plant("Pothos", "/sun-icons/any.png", "/plant-images/pothos.PNG", "Moderately Dry", "Poisonous");
            //var peperomia = new Plant("Peperomina", "/sun-icons/low-medium.png", "/plant-images/peperomia.PNG", "Allow soil to dry", "Poisonous");
            //var chineseEvergreen = new Plant("Chinese Evergreen", "/sun-icons/low-medium.png", "/plant-images/chinese-evergreen.PNG", "Keep Evenly Moist", "Poisonous");

            //var model = new IndexViewModel();

            //model.plantList.Add(pothos);
            //model.plantList.Add(peperomia);
            //model.plantList.Add(chineseEvergreen);

            FetchData();
            return View(plantList);
        }

        private void FetchData()
        {
            if(plantList.Count > 0)
            {
                plantList.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT TOP (1000) [Id],[Name],[Sun],[Image],[Water],[Fertilize] FROM [HousePlantsContext-fb9b44fa-b0fc-440f-b7b6-5a4ef1bb13f7].[dbo].[Plant]";
                dr = com.ExecuteReader();
                
                while (dr.Read())
                {
                    plantList.Add(new Plant() { Id = Convert.ToInt32(dr["Id"].ToString()) // Added the Convert to satisfy errors
                        , Name = dr["Name"].ToString()
                        , Sun = dr["Sun"].ToString()
                        , Image = dr["Image"].ToString()
                        , Water = dr["Water"].ToString()
                        , Notes = dr["Fertilize"].ToString()

                    });
                }
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
