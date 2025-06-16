using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpController : ControllerBase
    {

        [HttpGet(Name = "GetEmps")]
       
        public IEnumerable<Employee> Get()
        {
            List<Employee> emps = new List<Employee>();
            emps.Add(new Employee() { Id=1, Name="Bhakti", Email="bhaktibelan@gmail.com" });
            emps.Add(new Employee() { Id = 2, Name = "Bhakti", Email = "bhaktibelan@gmail.com" });

            return emps.ToArray();
        }
    }
}
