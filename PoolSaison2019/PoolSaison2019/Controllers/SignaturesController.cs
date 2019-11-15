using Microsoft.AspNetCore.Mvc;
using PoolSaison2019.Data;
using PoolSaison2019.Models;
using System.Threading.Tasks;

namespace PoolSaison2019.Controllers
{
    public class SignaturesController : Controller
    {
        private IRepository<Signatures> _signaturesRepository;

        public SignaturesController(IRepository<Signatures> signaturesRepository)
        {
            _signaturesRepository = signaturesRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _signaturesRepository.GetAll());
        }
        public IActionResult SignatureRecente(string name, string ville, string id = "-1")
        {
            ViewData["id"] = id;
            ViewData["name"] = name;
            ViewData["ville"] = ville;
            return View();
        }
    }
}