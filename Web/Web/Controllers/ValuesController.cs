using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{

    [ApiController]
    [Route("api/retValues")]
    public class ValuesController : ControllerBase
    {

        static double[] _acelerometersensor = new double[3] {0.0,0.0,0.0 };
        static double[] _giroscopesensor = new double[3] { 0.0, 0.0, 0.0 };
        static double[] _magnetometersensor = new double[3] { 0.0, 0.0, 0.0 };

        [HttpGet]
        public IActionResult retValuesSensors()
        {
            var dataret = new
            {
                _acelerometersensor,
                _giroscopesensor,
                _magnetometersensor,
            };
            return Ok(dataret);
        }

        [HttpPost]
        public IActionResult givesensorvalue(double ax,double ay, double az, double gx,double gy, double gz, double mx, double my, double mz)
        {
            _acelerometersensor[0] = ax;
            _acelerometersensor[1] = ay;
            _acelerometersensor[2] = az;

            _giroscopesensor[0] = gx;
            _giroscopesensor[1] = gy;
            _giroscopesensor[2] = gz;

            _magnetometersensor[0] = mx;
            _magnetometersensor[1] = my;
            _magnetometersensor[2] = mz;
            return Ok();
        }
    }

}
