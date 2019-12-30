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
    //ortak olan alanları yazacağımız yer.
     public class BaseEntities //public yap...
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Id görünce otomatik primary key yapıyor.Bunu yazmamamiza gerek yoktu.CategoryId olsa bile primary yapar.
         public int Id  { get; set; }

        [Required,DisplayName("Oluşturulma Tarihi")]
        public DateTime CreatedOn { get; set; }

        [Required, DisplayName("Güncelleme Tarihi")]
        public DateTime ModifiedOn { get; set; }

        [Required, DisplayName("Oluşturan Kullanıcı"),StringLength(30)]
        public string ModifiedUserName { get; set; }



    }
}
