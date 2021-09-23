using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF_Chat;

namespace MVC_Chat.Controllers
{
    public class ChatsController : Controller
    {
        public static ServiceReferenceChat.ServiceClient myChats = new ServiceReferenceChat.ServiceClient();
        // GET: Chats
        public ActionResult Index()
        {
            if (Session["LoginUser"] != null)
            {
                return View(myChats.GetAllChat().ToList());
            }
            else
            {
                return RedirectToAction("Login");
            }

            //return View();
        }

        // GET: Chats/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Chats/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chats/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chats/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Chats/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chats/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Chats/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(ServiceReferenceChat.User u)
        {
            
            if (ModelState.IsValid)
            {               
                if (myChats.Login(u.UserName, u.Password) == true)
                {
                    //add session
                    Session["LoginUser"] = u.UserName;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return View();
                }
            }
            return View();

        }
        public ActionResult Register()
        {
            return View();
        }

        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(ServiceReferenceChat.User u)
        {
            if (ModelState.IsValid)
            {

                if(myChats.Register(u.UserName, u.Password).Equals("Register thanh cong"))
                {
                    Session["LoginUser"] = u.UserName;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Register failed";
                    return View();
                }               
                
            }
            return View();
        }

        public ActionResult SendChat()
        {
            if (Session["LoginUser"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SendChat(ServiceReferenceChat.Chat chat)
        {
            
                if(myChats.SendChat(chat.Content, chat.UserName).Equals("Send chat thanh cong"))
                {
                    return RedirectToAction("Index");
                }
                return View();
            
        }

    }
}
