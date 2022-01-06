using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleCRUD.Data;
using SampleCRUD.Model;

namespace SampleCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturer _manufacturer;
        public ManufacturerController(IManufacturer manufacturer)
        {
            _manufacturer = manufacturer;
        }

        [HttpGet]
        public  IActionResult Get()
        {
            return Ok( _manufacturer.GetManufacturers());
        } 

        [HttpPost]
        public IActionResult Post([FromBody]string manufacturer)
        {
            var mf = manufacturer.ToString();
            _manufacturer.Post(mf);
            
            return Ok();
        }
    }
}
