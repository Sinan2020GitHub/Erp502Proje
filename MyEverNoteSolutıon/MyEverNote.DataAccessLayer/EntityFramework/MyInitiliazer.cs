using FakeData;
using MyEverNote.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEverNote.DataAccessLayer.EntityFramework
{
    public class MyInitiliazer: CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            //Adding Admin User
            EverNoteUser admin = new EverNoteUser()
            {
                Name = "Sinan",
                Surname = "AKKEÇELİ",
                Email = "sakkceli@gmail.com",
                ActiveGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = true,
                Username = "sinana",
                Password = "12345",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now.AddMinutes(5),
                ModifiedUserName = "sinana",
                ProfileImageFileName = "userImg2.jpg"

            };

            //Adding Standart User           
            EverNoteUser standartUser = new EverNoteUser()
            {
                Name = "Selin",
                Surname = "AKKEÇELİ",
                Email = "selin@gmail.com",
                ActiveGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = false,
                Username = "selina",
                Password = "54321",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now.AddMinutes(5),
                ModifiedUserName = "sinana",
                ProfileImageFileName = "userImg2.jpg"
            };

            context.EverNoteUsers.Add(admin);  //context db yerine geçiyor..
            context.EverNoteUsers.Add(standartUser);

            //Adding Fake User
            for (int i = 0; i < 8; i++)
            {
                EverNoteUser fakeuser = new EverNoteUser()
                {
                    Name = NameData.GetFirstName(),
                    Surname = NameData.GetSurname(),
                    Email = NetworkData.GetEmail(),
                    ActiveGuid = Guid.NewGuid(),
                    IsActive = true,
                    IsAdmin = false,
                    Username = $"user{i}",
                    Password = "123",
                    CreatedOn =DateTimeData.GetDatetime(DateTime.Now.AddYears(-2),DateTime.Now),//2 yıl öncedenbaşla
                    ModifiedOn = DateTimeData.GetDatetime(DateTime.Now.AddYears(-2), DateTime.Now),
                    ModifiedUserName = $"user{i}",
                    ProfileImageFileName = "userImg2.jpg"

                };
                context.EverNoteUsers.Add(fakeuser);
            }
            context.SaveChanges();

            //User List For using
            List<EverNoteUser> userList = context.EverNoteUsers.ToList();

            //Adding fake Categories
            for (int i = 0; i < 10; i++)
            {
                Category cat = new Category()
                {
                    Title = PlaceData.GetStreetName(),
                    Description = PlaceData.GetAddress(),
                    CreatedOn=DateTime.Now,
                    ModifiedOn=DateTime.Now,
                    ModifiedUserName="sinana"
                    


                };
                context.Categories.Add(cat);
                //Adding fake Nots
                for (int k = 0; k < NumberData.GetNumber(5,9); k++)
                {
                    EverNoteUser owner = userList[NumberData.GetNumber(0, userList.Count - 1)];
                    Not note = new Not()
                    {
                        Title=TextData.GetAlphabetical(NumberData.GetNumber(5,25)),
                        Text= TextData.GetSentences(NumberData.GetNumber(1,3)),
                        Category=cat,
                        IsDraft=false,
                        LikeCount=NumberData.GetNumber(1,9),
                        Owner=owner,
                        CreatedOn= DateTimeData.GetDatetime(DateTime.Now.AddYears(-2), DateTime.Now),
                        ModifiedOn= DateTimeData.GetDatetime(DateTime.Now.AddYears(-2), DateTime.Now),
                        ModifiedUserName=owner.Username
                    };

                    cat.Nots.Add(note);

                    //Adding fake Comments
                    for (int j = 0; j < NumberData.GetNumber(3,5); j++)
                    {
                        EverNoteUser comment_owner = userList[NumberData.GetNumber(0, userList.Count - 1)];
                        Comment comment = new Comment()
                        {
                            Text = TextData.GetSentence(),
                            Owner = comment_owner,
                            CreatedOn = DateTimeData.GetDatetime(DateTime.Now.AddYears(-2), DateTime.Now),
                            ModifiedOn = DateTimeData.GetDatetime(DateTime.Now.AddYears(-2), DateTime.Now),
                            ModifiedUserName = comment_owner.Username,
                            //Note=note

                        };
                        note.Comments.Add(comment);
                        //Adding fake Likes
                        for (int m = 0; m < note.LikeCount; m++)
                        {
                            Liked liked = new Liked()
                            {
                                LikedUser=userList[m],

                            };
                            note.Likes.Add(liked);

                        }

                    }

                }
                context.SaveChanges();


            }

        }
    }
}
