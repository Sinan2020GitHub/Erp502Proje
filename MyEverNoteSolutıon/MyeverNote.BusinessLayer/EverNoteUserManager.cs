using MyeverNote.Common.Helpers;
using MyeverNote.DataAccessLayer.EntityFramework;
using MyEverNote.Entities;
using MyEverNote.Entities.Messages;
using MyEverNote.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyeverNote.BusinessLayer
{
    public class EverNoteUserManager
    {
        private Repository<EverNoteUser> repo_user = new Repository<EverNoteUser>();
        /* Yöntem 2 */

        //public EverNoteUser RegisterUser(RegisterViewModal data)
        //{
        //    EverNoteUser user = repo_user.Find(x => x.Username == data.UserName || x.Email==data.Email);

        //    if (user != null)
        //    {
        //        throw new Exception("Kayıtlı Kullanıcı ya da E-posta adresi.");
        //    }
        //    return user;
        //}

        /* Yöntem 2 Son */

        public BusinessLayerResult<EverNoteUser> RegisterUser(RegisterViewModal data)
        {
            EverNoteUser user = repo_user.Find(x => x.Username == data.UserName || x.Email == data.Email);
            BusinessLayerResult<EverNoteUser> res = new BusinessLayerResult<EverNoteUser>();

            if (user != null)
            {
                if (user.Username == data.UserName)
                {
                    res.AddError(ErrorMessageCode.UserNameAlreadyExist, "Kullanıcı adı kayıtlı");
                }
                if (user.Email == data.Email)
                {
                    res.AddError(ErrorMessageCode.EmailAlreadyExist, "E-Posta kayıtlı");
                }
            }
            else
            {
                int dbResult = repo_user.Insert(new EverNoteUser()
                {
                    Username=data.UserName,
                    Email=data.Email,
                    Password=data.Password,
                    ActiveGuid=Guid.NewGuid(),
                    IsActive=false,
                    IsAdmin=false,
                    


                });
                if (dbResult > 0)
                {
                    res.Result = repo_user.Find(x => x.Email == data.Email && x.Username == data.UserName);
                    string siteUri = ConfigHelper.Get<string>("SiteRootUri");
                    string activateUri = $"{siteUri}/Home/UserActivate/{res.Result.ActiveGuid}";
                    string body = $"Merhaba {res.Result.Username};\n Hesabınızı aktifleştirmek için <a href='{activateUri}' target='_blank'>tıklayınız.</a>";
                    MailHelper.SendMail(body, res.Result.Email, "MyeverNote Hesap Aktifleştirme");

                }
            }
            return res;
        }
        public BusinessLayerResult<EverNoteUser> LoginUser(LoginViewModal data)
        {
            BusinessLayerResult<EverNoteUser> res = new BusinessLayerResult<EverNoteUser>();
            res.Result = repo_user.Find(x => x.Username == data.UserName && x.Password == data.Password);
            if (res.Result!=null)
            {
                if (!res.Result.IsActive)
                {
                    res.AddError(ErrorMessageCode.UserIsNotActive, "Kullanıcı aktifleştirilmemiştir.");
                    res.AddError(ErrorMessageCode.CheckYourEmail, "Lütfen e-posta adresinizi kontrol ediniz.");                                   
                }
            }
            else
            {
                res.AddError(ErrorMessageCode.UserNameOrPassWrong, "Kullanıcı adı veya şifre uyuşmuyor.");
            }
            return res;
        }
        public BusinessLayerResult<EverNoteUser> ActivateUser(Guid activateId)
        {
            BusinessLayerResult<EverNoteUser> res = new BusinessLayerResult<EverNoteUser>();
            res.Result = repo_user.Find(x => x.ActiveGuid == activateId);
            if (res.Result != null)
            {
                if (res.Result.IsActive)
                {
                    res.AddError(ErrorMessageCode.UserAlreadyActive, "Kullanıcı zaten aktif edilmiş.");
                    return res;
                }
                res.Result.IsActive = true;
                repo_user.Update(res.Result);
            }
            else
            {
                res.AddError(ErrorMessageCode.ActivateIdDoesNotExist, "Aktivasyon kodu hatalı");

            }
            return res;

        }

        public BusinessLayerResult<EverNoteUser> GetUserById(int id)
        {
            BusinessLayerResult<EverNoteUser> res = new BusinessLayerResult<EverNoteUser>();
            res.Result = repo_user.Find(x => x.Id == id);
            if (res.Result == null)
            {
                res.AddError(ErrorMessageCode.UserNotFound, "Kullanıcı bulunamadı");
            }
            return res;

        }
    }
}
