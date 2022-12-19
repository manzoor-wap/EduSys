using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Abstract
{
    public interface IFees : IBaseModel
    {
        public string TermFee { get; set; }

        public string ExamFee { get; set; }

        string Email { get; set; }

        string Phone { get; set; }


    }
}
