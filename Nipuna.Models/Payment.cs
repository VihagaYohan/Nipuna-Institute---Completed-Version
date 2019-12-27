using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nipuna.Model
{
    public class Payment
    {
        // properties
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public string RegistrationId { get; set; }
        public string StudentName { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }

        public string LecturerId { get; set; }
        public string LectuerName { get; set; }
        public decimal Fee { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime Invoicedate { get; set; }
        public bool AbsentPayment { get; set; }
        public string Username { get; set; }

        public bool IsRemoved { get; set; }

        public Payment()
        {
            IsRemoved = false;
        }
    }
}
