using Microsoft.EntityFrameworkCore;
using MSMSwebapipro.Contexts;
using MSMSwebapipro.Dataaccess.IRepositary;
using MSMSwebapipro.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSMSwebapipro.Dataaccess.Repositary
{
    public class empreposite : Iempreposite
    {
        public ProjectDBcontext pro;
        public empreposite(ProjectDBcontext project)
        {
            pro = project;
        }


        public async Task<List<Employee>> allemployees()
        {
            return await pro.employees.ToListAsync();
        }

        public async Task<int> Deleteemployee(int Empid)
        {
            var emp = pro.employees.Find(Empid);
            pro.employees.Remove(emp);
            return await pro.SaveChangesAsync();
        }


        public async Task<List<Employee>> Getemployeebydeptno(int Deptno)
        {
            return await pro.employees.Where(x => x.DeptNo == Deptno).ToListAsync();
        }

        public async Task<bool> GetEmployeeByEmailAndGetActiveStatus(string email)
        {
            var employee = await pro.employees
                 .Where(e => e.Email == email)
                 .Select(e => e.Active)
                 .FirstOrDefaultAsync();
                  return employee;
        }

        public async Task<Employee> Getemployeebyemailandpassword(string email, string password)
        {
         return await pro.employees.Where(x => x.Email == email && x.password == password).SingleOrDefaultAsync();   
        }

        public async Task<bool> GetEmployeeByEmailAndpasswordGetActiveStatus(string email, string password)
        {
            bool employeeExists = await pro.employees.AnyAsync(e => e.Email == email && e.password == password);
            return employeeExists;
        }

        public async Task<Employee> Getemployeebyempid(int Empid)
        {
            return await pro.employees.FindAsync(Empid);
        }

        public async Task<int>Insertemployee(Employee Emp)
        {
            pro.employees.Add(Emp);
            return await pro.SaveChangesAsync();
        }

        public async Task<int> Updateemployee(Employee Emp)
        {
            pro.employees.Update(Emp);
            return await pro.SaveChangesAsync();
        }
    }
}
