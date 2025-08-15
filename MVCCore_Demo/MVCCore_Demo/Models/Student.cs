using System.Reflection.Metadata.Ecma335;

namespace MVCCore_Demo.Models
{
    public class Student
    {
        public int RollNo { get; set; }

        public string StudName { get; set; }

        public int CID { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<Student> GetStudentDetails()
        {
            List<Student> lst = new List<Student>()
            {
                new Student { RollNo = 1, StudName = "Amit", CID = 1, CreatedDate = DateTime.Now},
               new Student { RollNo = 2, StudName = "Dillip", CID = 2, CreatedDate = DateTime.Now},
               new Student { RollNo = 3, StudName = "Sunil", CID = 3, CreatedDate = DateTime.Now }

            };
            return lst;
        }
    }
}
