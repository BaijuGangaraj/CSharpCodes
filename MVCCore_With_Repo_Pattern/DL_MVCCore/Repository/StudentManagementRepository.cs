using DL_MVCCore.Abstract;
using DL_MVCCore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_MVCCore.Repository
{
    public class StudentManagementRepository: IStudentManagementRepository
    {
        SqlConnection con = new SqlConnection("server=(localdb)\\MSSQLLocalDB;Database=StudentManagement;Integrated Security = True");

        public List<Student> GetAllStudents()
        {
            List<Student> lst = new List<Student>();
            try
            {
                SqlCommand com = new SqlCommand("ShowStudentData",con);
                com.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Student stud = new Student();
                    stud.RollNo = Convert.ToInt32(dr["RollNo"]);
                    stud.StudName = dr["StudName"].ToString();
                    stud.CID = Convert.ToInt32(dr["CID"]);
                    stud.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);

                    lst.Add(stud);
                }
            }
            catch (Exception ex)
            {
                throw;

            }
            return lst;
        }
    }

}


