using DL_AgentDetail.Abstract;
using DL_AgentDetail.Model;
using DL_AgentDetail.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BL_AgentDetail
{
    public  class BL_AgentInfo
    {
        IDL_AgentRepo _repo = new  DL_AgentRepo();
        public List<Agent> GetAllAgents()
        {
            List<Agent> lstAgents = new List<Agent>();

            try
            {
                lstAgents = _repo.GetAllAgents();

                //Operations on the data can be done here if needed
            }
            catch (Exception ex)
            {

            }


            return lstAgents;
        }
    }
}
