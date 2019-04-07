    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum StudentStatus
    {
        Active = 1,
        NotActive = 0
    }
    public enum ResourseType
    {
        DVD,
        RefrenceManual,
        RefrenceBook
    }
    public enum ResourceStatus
    {
        Available,
        OnLoan,
        NotAvailable
    }
    public enum LoanStatus
    {
        OnLoan,
        Returned,
        ReturnedDamaged,
        NotReturned
    }
}
