using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEverNote.Entities
{
    [Table("EverNoteUsers")]
    public class EverNoteUser : BaseEntities
    {
        [StringLength(30),DisplayName("Ad")]
        public string Name { get; set; }

        [StringLength(30), DisplayName("Soyad")]
        public string Surname { get; set; }

        [StringLength(30), DisplayName("KUllanıcı Adı")]
        public string Username { get; set; }

        [StringLength(150), DisplayName("E-Posta")]
        public string Email { get; set; }

        [DisplayName("Şifre")]
        public string Password { get; set; }

        [StringLength(30)] //user12.jpg
        public string ProfileImageFileName { get; set; }




        [DisplayName("Aktif Mi")]
        public bool IsActive { get; set; }

        [DisplayName("Admin Mi")]
        public bool IsAdmin { get; set; }

        [DisplayName("Benzersiz Id")]
        public Guid ActiveGuid { get; set; }

        public virtual List<Not> Nots { get; set; }

        public virtual List<Comment> Comments { get; set; }

        public virtual List<Liked> Likes { get; set; }
      

        


    }
}
