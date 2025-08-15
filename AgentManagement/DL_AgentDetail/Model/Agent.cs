using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_AgentDetail.Model
{
    [Table("Agents")]
    public class Agent
    {
        [Key]
        public int AgentId { get; set; }    

        public string AgentName { get; set; }

        public int CityID { get; set; }
    }
}
