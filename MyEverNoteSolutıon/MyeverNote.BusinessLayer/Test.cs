using MyeverNote.DataAccessLayer.EntityFramework;
using MyEverNote.DataAccessLayer;
using MyEverNote.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyeverNote.BusinessLayer
{
    public class Test
    {
        private Repository<Category> repo_category = new Repository<Category>();

        private Repository<EverNoteUser> repo_user = new Repository<EverNoteUser>();
        public Test()
        {
            //  DatabaseContext db = new DatabaseContext();
            ////db.Database.CreateIfNotExists();    //Database i sildik aşağıdaki kodu yazdık.Kendisi database oluşturacak
            //  db.EverNoteUsers.ToList();

            //  //db den databaseContex tetiklenir.Sonra databaseContexten MyInitilazer a gider ordaki bilgilerden database oluşturur...

            List<Category> categories = repo_category.List();
        }
        public void InsertTest()
        {
            int result = repo_user.Insert(new EverNoteUser()
            {
                Name = "Serpil",
                Surname = "Ağıcı",
                Email = "serpil@gmail.com",
                ActiveGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin=false,
                Username="serpila",
                Password="54321",
                CreatedOn=DateTime.Now,
                ModifiedOn=DateTime.Now.AddMinutes(5),
                ModifiedUserName="onura"
            
            

            });
        }
        public void UpdateTest()
        {
            EverNoteUser user = repo_user.Find(x => x.Name == "Serpil");
            if(user != null)
            {
                user.Username = "serpils";
                repo_user.Update(user);
            
}
        }
        public void DeleteTest()
        {
            EverNoteUser user = repo_user.Find(x => x.Username == "serpils");
            if(user != null)
            {
                repo_user.Delete(user);
            }
        }
       

        
    }
}
