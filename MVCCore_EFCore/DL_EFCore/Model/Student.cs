using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_EFCore.Model
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int RollNo { get; set; }

        public string Name { get; set; }

        public int CID { get; set; }    
    }
}
