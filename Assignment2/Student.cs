using System;

namespace Assignment2
{
    public class Student
    {
        public Status Status
        {
            get
            {
                if (EndDate < DateTime.Now && EndDate < GraduationDate) {return Status.Dropout;}
                if (DateTime.Now <= startDate.AddYears(1)) {return Status.New;}
                if (DateTime.Now > startDate && DateTime.Now < GraduationDate) {return Status.Active;}
                if (DateTime.Now > GraduationDate && GraduationDate <= EndDate) {return Status.Graduated;}

                throw new InvalidOperationException("Please write another date");

            } 
            
        }
        int id;
        string givenName;
        string surName;
        DateTime startDate;
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }

        public Student(int id, string givenName, string surName, DateTime startDate, DateTime endDate, DateTime graduationDate){
            this.id = id;
            this.givenName = givenName;
            this.surName = surName;
            this.startDate = startDate;
            this.EndDate = endDate;
            this.GraduationDate = graduationDate;
        }

        public override string ToString()
        {
            return String.Format("Name:{0} {1}, ID: {2}, Start Date: {3:d}, Graduation Date: {4:d}, End Date: {5:d}, Status: {6}", givenName, surName, id, startDate,GraduationDate,EndDate,Status);
        }

        public static void main(string[] args) 
        {   
            DateTime Now = DateTime.Now;
            TimeSpan Span = Now.AddMonths(9) - Now;
            Student Student = new Student(13, "Ahmed", "Galal", DateTime.Now.Subtract(Span),DateTime.Now.AddYears(4),DateTime.Now.AddYears(4));
            Console.WriteLine(Student.ToString());

            var imStudent = new ImmutableStudent() { Id = 10, GivenName = "Mikkel"};

        }
    }

    public record ImmutableStudent{
        public int Id {get; init;}
        public string GivenName{get; init;}
        public string Surname {get; init;}
        public Status Status {get; init;}
        public DateTime StartDate {get; init;}
        public DateTime EndDate {get; init;}
        public DateTime GraduationDate {get; init;}

    }
}
