using Dtos;
using Microsoft.AspNetCore.Mvc;
using Model;
using pruebaExperticket.Repositories;

namespace pruebaExperticket.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepository repository;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string DNI)
        {
            return View(ClienteModel.GetInstance().GetClient(DNI));
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(ClienteDto dto)
        {
            try
            {
                ClienteModel.GetInstance().CreateClient(dto);
            }
            catch
            {
            }
            return View();
        }

        public ActionResult Edit(string DNI)
        {
            return View(ClienteModel.GetInstance().GetClient(DNI));
        }

        public ActionResult Edit(ClienteDto dto)
        {
            try
            {
                ClienteModel.GetInstance().UpdateClient(dto);
            }
            catch
            {
            }
            return View();
        }

        public ActionResult Delete(string DNI)
        {
            try
            {
                ClienteModel.GetInstance().DeleteClient(DNI);
            }
            catch
            {
            }
            return View();
        }

        public ActionResult List()
        {
            var list = ClienteModel.GetInstance().ListClients();
            return View(list);
        }

    }
}
