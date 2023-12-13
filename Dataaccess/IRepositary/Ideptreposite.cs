using MSMSwebapipro.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MSMSwebapipro.Dataaccess.IRepositary
{
    public interface Ideptreposite
    {
        Task<List<Department>> alldepartments();
        Task<int> insertdepartments(Department dept);
    }
}
