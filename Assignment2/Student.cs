using System;

namespace Assignment2
{
    class Student
    {
        public Status Status {get;}
        int id;
        string givenName;
        string surName;
        DateTime startDate;
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }

        public Student(int id, string givenName, string surName, DateTime startDate){
            this.id = id;
            this.givenName = givenName;
            this.surName = surName;
            this.startDate = startDate;
            Status = Status.New;
        }

        /*public void changeStatus(status){

        }*/
    }
}
