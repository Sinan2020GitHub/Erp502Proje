using MyEverNote.Entities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyeverNote.BusinessLayer
{
    public class BusinessLayerResult<T> where T:class
    {
        public List<ErrorMesageObj> Errors { get; set; }
        public T Result { get; set; }
        public BusinessLayerResult()
        {
            Errors = new List<ErrorMesageObj>();

        }
        public void AddError(ErrorMessageCode code,string message)
        {
            Errors.Add(new ErrorMesageObj() { Code = code, Message = message });
        }
    }
}
