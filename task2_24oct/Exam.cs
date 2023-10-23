using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_24oct
{
    internal class Exam
    {
        public string Subject { get; set; }
        public TimeSpan ExamDuration { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate {
            get 
            { 
                EndDate = StartDate + ExamDuration;
                return EndDate;
            }
            set
            {
                EndDate = value;
            }
        }

       

    }
}
