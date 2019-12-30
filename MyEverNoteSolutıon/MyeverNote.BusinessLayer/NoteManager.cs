using MyeverNote.DataAccessLayer.EntityFramework;
using MyEverNote.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyeverNote.BusinessLayer
{
    public class NoteManager
    {
        private Repository<Not> repo_note = new Repository<Not>();
        public List<Not> GetAllNote()
        {
            return repo_note.List();
        }

    }
}
