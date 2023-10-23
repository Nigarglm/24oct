using System.Collections.Generic;

namespace task2_24oct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>
            {
            new Exam { Subject = "Bck-end programming", ExamDuration = TimeSpan.FromHours(3), StartDate = DateTime.Now, EndDate = DateTime.Now },
            new Exam { Subject = "Artificial Intelligence", ExamDuration = TimeSpan.FromHours(1.5), StartDate = DateTime.Now, EndDate = DateTime.Now},
            new Exam { Subject = "System Adminstration", ExamDuration = TimeSpan.FromHours(2), StartDate = DateTime.Now, EndDate = DateTime.Now },
            
            };


            var recentExams = exams.FindAll(e => e.StartDate >= DateTime.Now);
            Console.WriteLine("Indiki imtahanlar:");
            foreach (var exam in recentExams)
            {
                Console.WriteLine($"Subject: {exam.Subject}, Duration: {exam.ExamDuration}");
            }


            var longExams = exams.FindAll(e => e.ExamDuration > TimeSpan.FromHours(2));
            Console.WriteLine("2 saatdan uzun cheken imtahanlar:");
            foreach (var exam in longExams)
            {
                Console.WriteLine($"Subject: {exam.Subject}, Duration: {exam.ExamDuration}");
            }


            var ongoingExams = exams.FindAll(e => e.StartDate <= DateTime.Now && e.EndDate >= DateTime.Now);
            Console.WriteLine("Davam eden imtahanlar:");
            foreach (var exam in ongoingExams)
            {
                Console.WriteLine($"Subject: {exam.Subject}, Duration: {exam.ExamDuration}");
            }
        }
    }
}
   



        