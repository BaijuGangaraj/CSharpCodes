using DL_AgentDetail.Abstract;
using DL_AgentDetail.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_AgentDetail.Repository
{
    public class DL_AgentRepo: IDL_AgentRepo
    {
        Agent_Detail_Context _Context = new Agent_Detail_Context();
        public  List<Agent> GetAllAgents()
        {
            List<Agent> lstAgents = new List<Agent>();

            try
            {
                lstAgents=_Context.AgentInfo.ToList();  
            }
            catch (Exception ex)
            {
               
            }


            return lstAgents;
        }
    }
}
