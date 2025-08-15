using DL_MVCCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_MVCCore.Abstract
{
    public  interface IStudentManagementRepository
    {
        List<Student> GetAllStudents();
    }
    
}
