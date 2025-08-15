using DL_AgentDetail.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_AgentDetail.Abstract
{
    public  interface IDL_AgentRepo
    {
        List<Agent> GetAllAgents();

    }
}
