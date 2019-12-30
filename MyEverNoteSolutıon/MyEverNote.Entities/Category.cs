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
    [Table("Categories")]
    public class Category:BaseEntities
    {
        [StringLength(50),Required,DisplayName("Başlık")]
        public string Title { get; set; }

        [StringLength(150),DisplayName("Açıklama")]
        public string Description { get; set; }

        public virtual List<Not> Nots { get; set; }

        public Category()
        {
            Nots = new List<Not>();

        }

    }
}
