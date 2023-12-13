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
    public class empwebapicontroller : ControllerBase
    {
        public Iempreposite emppro;
        public empwebapicontroller(Iempreposite _emppro)
        {
            emppro = _emppro;
        }
        [HttpGet]
        [Route("allemployees")]
        public async Task<IActionResult> allemployees()
        {
            try
            {
                var emplist = await emppro.allemployees();
                if (emplist.Count == 0)
                {
                    return NotFound("No records found");
                }
                else
                {
                    return Ok(emplist);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + "\nerror occured");
            }
        }
        [HttpPost]
        [Route("Insertemployee")]
        public async Task<IActionResult> Insertemployee([FromBody] Employee Emp)
        {
            try
            {
                var count = await emppro.Insertemployee(Emp);
                return Created("record inserted successfully", count);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + "\n error occured");
            }
        }
        [HttpPut]
        [Route("Updateemployee")]
        public async Task<IActionResult> Updateemployee([FromBody] Employee Emp)
        {
            try
            {
                var count = await emppro.Updateemployee(Emp);
                return Ok(count);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + "\nError occured");
            }
        }
        [HttpDelete]
        [Route("Deleteemployee")]
        public async Task<IActionResult> Deleteemployee(int Empid)
        {
            try
            {
                var count = await emppro.Deleteemployee(Empid);
                return Ok(count);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + "\nError occured");
            }
        }
        [HttpGet]
        [Route("Getemployeebyempid")]
        public async Task<IActionResult> Getemployeebyempid(int Empid)
        {
            try
            {
                var employee = await emppro.Getemployeebyempid(Empid);
                if (employee == null)
                {
                    return NotFound("no data available.........!");
                }
                else
                {
                    return Ok(employee);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + "\nError occured");
            }

        }
        [HttpGet]
        [Route("Getemployeebyemailandpassword")]
        public async Task<IActionResult> Getemployeebyemailandpassword(string Email, string password)
        {
            try
            {
                var emp = await emppro.Getemployeebyemailandpassword(Email, password);
                if (emp == null)
                {
                    return NotFound("no data available.........!");
                }
                else
                {
                    return Ok(emp);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + "\nError occured");
            }
        }
        [HttpGet]
        [Route("Getemployeebydeptno")]
        public async Task<IActionResult> Getemployeebydeptno(int Deptno)
        {
            try
            {
                var emplist = await emppro.Getemployeebydeptno(Deptno);
                if (emplist.Count == 0)
                {
                    return NotFound("no data available.........!");
                }
                else
                {
                    return Ok(emplist);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + "\nError occured");
            }
        }
        [HttpGet]
        [Route("GetEmployeeByEmailAndpasswordGetActiveStatus")]
        public async Task<IActionResult> GetEmployeeByEmailAndpasswordGetActiveStatus(string Email, string password)
        {
            try
            {
                bool employeeExists = await emppro.GetEmployeeByEmailAndpasswordGetActiveStatus(Email, password);

                if (employeeExists)
                {
                    return Ok(true);
                }
                else
                {
                    return NotFound("False");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred: " + ex.Message);
            }
        }
        [HttpGet]
        [Route("GetEmployeeByEmailAndGetActiveStatus")]
        public async Task<IActionResult> GetEmployeeByEmailAndGetActiveStatus(string Email)
        {
            try
            {
                var employee = await emppro.GetEmployeeByEmailAndGetActiveStatus(Email);

                if (employee)
                {
                    return Ok("True");
                }
                else
                {
                    return NotFound("False");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred: " + ex.Message);
            }
        }

    }
}
