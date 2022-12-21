using Datastore.Abstract.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Abstract.Models.Impl
{
    public class Fees : BaseModel, IFees
    {
        public string TermFee { get; set; }

        public string ExamFee { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }


    }
}
