using MyeverNote.BusinessLayer;
using MyEverNote.Entities;
using MyEverNote.Entities.Messages;
using MyEverNote.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MyEverNote.WebApp.Controllers
{
    public class HomeController : Controller
    {
        NoteManager nm = new NoteManager();

        // GET: Home
        public ActionResult Index()
        {
            //Test test = new Test();
            ////test.InsertTest();
            ////test.UpdateTest();
            //test.DeleteTest();
            //return View();

            return View(nm.GetAllNote().OrderByDescending(x => x.ModifiedOn).ToList());
        }
        public ActionResult ByCategory(int? id)  //? null gelebilir demek
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryManager cm = new CategoryManager();
            Category cat = cm.GetCategoryById(id.Value); //int e soru işareti koyduk bundan kurtarmak için value dedik.
            if (cat == null)
            {
                return HttpNotFound();
            }
            return View("Index", cat.Nots.OrderByDescending(x => x.ModifiedOn).ToList());
            //Index yazmasak ByCategory e giderdi.

        }
        public ActionResult MostLiked()
        {
            return View("Index", nm.GetAllNote().OrderByDescending(x => x.LikeCount).ToList());
        }
        public ActionResult About()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModal model)
        {
            if (ModelState.IsValid)
            {
                EverNoteUserManager eum = new EverNoteUserManager();
                BusinessLayerResult<EverNoteUser> res = eum.LoginUser(model);
                if (res.Errors.Count > 0)
                {
                    if (res.Errors.Find(x => x.Code == ErrorMessageCode.UserIsNotActive) != null)
                    {
                        ViewBag.SetLink = "http://Home/Activate/1234-4567-789080";
                    }
                    res.Errors.ForEach(x => ModelState.AddModelError("", x.Message));
                    return View(model);
                }
                Session["Login"] = res.Result;
                return RedirectToAction("Index");
            }
            
            return View(model);

        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Register(RegisterViewModal modal)
        {
            if (ModelState.IsValid)
            {

                EverNoteUserManager eum = new EverNoteUserManager();
                BusinessLayerResult<EverNoteUser> res = eum.RegisterUser(modal);
                if (res.Errors.Count > 0)
                {
                    res.Errors.ForEach(x => ModelState.AddModelError("", x.Message));
                    return View(modal);
                }
                return RedirectToAction("RegisterOk");


                /*Yöntem 1*/
                //bool hasError = false;
                //if (modal.UserName == "aaa")
                //{
                //    ModelState.AddModelError("", "Kullanıcı Adı kullanılıyor.");
                //    hasError = true;
                //}
                //if (modal.Email == "aaa@aaa.com")
                //{
                //    ModelState.AddModelError("", "E-Mail adresi kullanılıyor.");
                //    hasError = true;
                //}
                //if (hasError) return View(modal);
                //return RedirectToAction("RegisterOk");
                /*Yöntem 1-SON*/



                /*Yöntem 2*/

                //EverNoteUserManager eum = new EverNoteUserManager();
                //EverNoteUser user = null;

                //try
                //{
                //    user = eum.RegisterUser(modal);

                //}
                //catch (Exception ex)
                //{

                //    ModelState.AddModelError("", ex.Message);
                //}
                //if (user == null)
                //{
                //    return View(modal);
                //}
                //return RedirectToAction("RegisterOk");

                /*Yöntem 2-Son*/
            }

            return View(modal);
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }
        public ActionResult RegisterOk()
        {
            return View();
        }
        public ActionResult UserActivate(Guid id)
        {
            EverNoteUserManager eum = new EverNoteUserManager();
            BusinessLayerResult<EverNoteUser> res = eum.ActivateUser(id);
            if (res.Errors.Count > 0)
            {
                TempData["errors"] = res.Errors;
                return RedirectToAction("UserActivateCancel");

            }
            return RedirectToAction("UserActivateOk");
        }
        public ActionResult UserActivateOk()
        {
            return View();

        }
        public ActionResult UserActivateCancel()
        {
            List<ErrorMesageObj> errors = null;
            if (TempData["errors"] != null)
            {
                errors = TempData["errors"] as List<ErrorMesageObj>;
            }
            return View(errors);
        }
        public ActionResult ShowProfile()
        {
            EverNoteUser currentUser = Session["login"] as EverNoteUser;
            EverNoteUserManager eum = new EverNoteUserManager();
            BusinessLayerResult<EverNoteUser> res = eum.GetUserById(currentUser.Id);

            if (res.Errors.Count > 0)
            {
              
                //kullanıcıyı hata ekranına gönder
            }
            return View(res.Result);
        }
        public ActionResult EditProfile()
        {
            return View();

        }
        [HttpPost]
        public ActionResult EditProfile(EverNoteUser user)
        {
            return View();

        }
        public ActionResult RemoveProfile()
        {
            return View();
        }

    }
}