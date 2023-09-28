using Microsoft.AspNetCore.Mvc;
using testapi.Models;

namespace testapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OfferServiceController : ControllerBase
    {
      

        private readonly ILogger<WeatherForecastController> _logger;

        private  List<Product> Inventory;
        private List<Product> createInventory()
        {
            Inventory = new List<Product>();
            Product p1= new Product();
            p1.ProductName = "P1";
            p1.Price = 1000;
            p1.Description = "P1 desc";
            Inventory.Add(p1);
            Product p2 = new Product();
            p2.ProductName = "P2";
            p2.Price = 200;
            p2.Description = "P2 desc";
            Inventory.Add(p2);
            Product p3 = new Product();
            p3.ProductName = "P3";
            p3.Price = 400;
            p3.Description = "P3 desc";
            Inventory.Add(p3);

            Product p4 = new Product();
            p4.ProductName = "P4";
            p4.Price = 700;
            p4.Description = "P4 desc";
            Inventory.Add(p4);

            Product p5 = new Product();
            p5.ProductName = "P5";
            p5.Price = 600;
            p5.Description = "P5 desc";
            Inventory.Add(p5);

            Product p6 = new Product();
            p6.ProductName = "P6";
            p6.Price = 800;
            p6.Description = "P6 desc";
            Inventory.Add(p6);
            return Inventory;
        }

        public OfferServiceController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            Inventory = createInventory();
        }

        [HttpGet("~/OfferService/GetAllProducts")]
        public IEnumerable<Product> GetAllProducts()
        {

            return Inventory;


        }

     

        [HttpGet("~/OfferService/GetTodaysOffers/{Package}")]
        public IEnumerable<Product> GetAllProducts(int Package)
        {
            List<Product> products = new List<Product>();

            if (Package == 1)
            {
                Product p1 = new Product();
                p1.ProductName = "P1";
                p1.Price = 1000;
                p1.Description = "P1 desc";
                products.Add(p1);
                Product p2 = new Product();
                p2.ProductName = "P2";
                p2.Price = 200;
                p2.Description = "P2 desc";
                products.Add(p2);
                Product p3 = new Product();
                p3.ProductName = "P3";
                p3.Price = 400;
                p3.Description = "P3 desc";
                products.Add(p3);

               
                
            
                    }
            else if (Package == 2)
            {
              
                Product p2 = new Product();
                p2.ProductName = "P2";
                p2.Price = 200;
                p2.Description = "P2 desc";
                products.Add(p2);
                Product p3 = new Product();
                p3.ProductName = "P3";
                p3.Price = 400;
                p3.Description = "P3 desc";
                products.Add(p3);

                Product p4 = new Product();
                p4.ProductName = "P3";
                p4.Price = 400;
                p4.Description = "P3 desc";
                products.Add(p4);



            }

            return products;

        }
    }
}