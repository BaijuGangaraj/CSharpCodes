using DL_EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_EFCore.Repository
{
    public class DLStudDetails
    {
        StudMgmtContext _context = new StudMgmtContext();
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            lst = _context.StudentInfo.ToList();

            return lst;
        }
    }
}
