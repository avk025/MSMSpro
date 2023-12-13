using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSMSwebapipro.Dataaccess.IRepositary;
using MSMSwebapipro.Models;
using System;
using System.Threading.Tasks;

namespace MSMSwebapipro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class deptwebapicontroller : ControllerBase
    {
        public Ideptreposite deppro;
        public deptwebapicontroller(Ideptreposite _deppro)
        {
            deppro = _deppro;
        }
        [HttpPost]
        [Route("insertdepartments")]
        public async Task<IActionResult> insertdepartments([FromBody] Department dept)
        {
            try
            {
                var count = await deppro.insertdepartments(dept);
                return Created("record inserted successfully", count);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message + "\n error occured");
            }
            
        }
        [HttpGet]
        [Route("alldepartments")]
        public async Task<IActionResult> alldepartments()
        {
            try
            {
                var deptlist = await deppro.alldepartments();
               if(deptlist.Count == 0)

                { 
                    return NotFound("no records found");
                }
                else
                {
                    return Ok(deptlist);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + "\n error occured");
            }

        }

    }
}
