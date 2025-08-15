using Microsoft.AspNetCore.Mvc;
using BL_AgentDetail;
using DL_AgentDetail.Model;

namespace AgentManagement.Controllers
{
    public class AgentDetailController : Controller
    {
        BL_AgentInfo _bl = new BL_AgentInfo();
        public IActionResult Index()
        {
            List<Agent> lst = _bl.GetAllAgents();
            return View(lst);
        }
    }
}
