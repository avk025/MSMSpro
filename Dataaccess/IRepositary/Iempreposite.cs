using MSMSwebapipro.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MSMSwebapipro.Dataaccess.IRepositary
{
    public interface Iempreposite
    {
        Task<List<Employee>> allemployees();
        Task<int> Insertemployee(Employee Emp); 
        Task<int> Updateemployee(Employee Emp);
        Task<int> Deleteemployee(int Empid);
        Task<Employee> Getemployeebyempid(int Empid);
        Task<Employee> Getemployeebyemailandpassword(string email, string password);
        Task<List<Employee>> Getemployeebydeptno(int Deptno);
        Task<bool> GetEmployeeByEmailAndpasswordGetActiveStatus(string email, string password);
        Task<bool>GetEmployeeByEmailAndGetActiveStatus(string email);
    }
}
