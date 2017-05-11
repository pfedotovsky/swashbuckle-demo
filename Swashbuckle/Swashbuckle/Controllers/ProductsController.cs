using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Models;

namespace Swashbuckle.Controllers
{
    [Route("products/")]
    public class ProductsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Retrieves a specific product by unique id
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <response code="200">Product created</response>
        /// <response code="500">Oops! Can't create your product right now</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(typeof(void), 500)]
        public Product Get(int id)
        {
            return new Product
            {
                Description = "Description",
                Name = "Name",
                ProductID = 1,
                ProductTypeID = 1
            };
        }

        // POST products
        [HttpPost]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(typeof(void), 500)]
        public void Post([FromBody]Product value)
        {
        }
    }
}
