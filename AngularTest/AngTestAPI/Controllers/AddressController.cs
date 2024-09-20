using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AngTestAPI.Models;
using AngTestAPI.Data;
using Microsoft.AspNetCore.Cors;
using AngTestAPI.NewFolder;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Components.Web;

namespace AngTestAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        public IDataTransform _dataTransform;
        public AddressController(IDataTransform dataTransform) { _dataTransform = dataTransform; }

        //  /api/Address/CreateEdit
        [HttpPost]
        public JsonResult CreateEdit(API_Test address)
        {
            var result = _dataTransform.PostValue(address);
            if(result == 200)
            {
                return new JsonResult(Ok(address));
            }
            else
            {
                return new JsonResult(NotFound());
            }

            

        }

        //  /api/Address/GetAll
        [HttpGet]
        public JsonResult GetAll() {
            var result = _dataTransform.GetValues();

            return new JsonResult(Ok(result));
        }


    }
}
