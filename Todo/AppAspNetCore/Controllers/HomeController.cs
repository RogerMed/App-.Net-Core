using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AppAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ORM.Interfaces;

namespace Aplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITodoRepository _todoRepository;

        public HomeController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }



        public IActionResult Index()
        {

            return View(_todoRepository.GetAll());
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Entities.ToDo obj)
        {
            if (ModelState.IsValid)
            {
                _todoRepository.add(obj);
                Notification.Set(TempData, new Notificacao() { Mensagem = "A Tarefa foi cadastrada com sucesso.", Tipo = TipoNotificacao.success });
                return View("Index", _todoRepository.GetAll());
            }
            else
            {
                Notification.Set(TempData, new Notificacao() { Mensagem = "Não foi possivel cadastrar essa tarefa.", Tipo = TipoNotificacao.danger });
                return View();
            }
        }


        public IActionResult Editar(int id)
        {
            return View(_todoRepository.Get(id));
        }

        [HttpPost]
        public IActionResult Editar(Entities.ToDo obj)
        {

            if (ModelState.IsValid)
            {
                _todoRepository.Update(obj);
                Notification.Set(TempData, new Notificacao() { Mensagem = "A Tarefa foi editada com sucesso.", Tipo = TipoNotificacao.success });
                return View("Index", _todoRepository.GetAll());
            }
            else
            {
                Notification.Set(TempData, new Notificacao() { Mensagem = "Não foi possivel editar essa tarefa.", Tipo = TipoNotificacao.danger });
                return View();
            }
        }

        public IActionResult Remover(int id)
        {
            return View(_todoRepository.Get(id));
        }

        public IActionResult ConfirmaRemover(int id)
        {
            _todoRepository.Revome(_todoRepository.Get(id));
            return View("Index", _todoRepository.GetAll());
        }

    }
}
