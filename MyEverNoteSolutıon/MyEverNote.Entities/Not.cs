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
    [Table("Notes")]
     public class Not:BaseEntities  //public olmalı
    {
        [StringLength(60), Required, DisplayName("Başlık")]
        public string Title { get; set; }

        [StringLength(3000), Required, DisplayName("Metin")]
        public string Text { get; set; }

        [DisplayName("Taslak")]
        public bool IsDraft { get; set; }  //taslak

        [DisplayName("Beğeni Sayısı")]
        public int LikeCount { get; set; }

        public virtual EverNoteUser Owner { get; set; } // bir tane 

        public virtual Category Category { get; set; }

        public virtual List<Comment> Comments { get; set; }

        public virtual List<Liked> Likes { get; set; }

        public Not()
        {
            Comments = new List<Comment>();
            Likes = new List<Liked>();
        }



    }
}
