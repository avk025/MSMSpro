using Microsoft.EntityFrameworkCore;
using MSMSwebapipro.Contexts;
using MSMSwebapipro.Dataaccess.IRepositary;
using MSMSwebapipro.Models;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MSMSwebapipro.Dataaccess.Repositary
{
    public class deptreposite: Ideptreposite
    {
        public ProjectDBcontext pro;//here projectDBcontext is return data
        public deptreposite(ProjectDBcontext project)
        {
            pro = project;
        }
        public async Task<List<Department>> alldepartments()
        {
            return await pro.Departments.ToListAsync();
        }
        public async Task<int>insertdepartments(Department dept)
        {
            pro.Departments.Add(dept);
            return await pro.SaveChangesAsync();
        }
    }
}
