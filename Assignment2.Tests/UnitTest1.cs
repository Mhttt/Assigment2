using System;
using Xunit;
using Assignment2;

namespace Assignment2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Status_should_be_new()
        {
            //Arrange
            DateTime Now = DateTime.Now;
            TimeSpan Span = Now.AddMonths(9) - Now;
            Student Student = new Student(13, "Ahmed", "Galal", DateTime.Now.Subtract(Span),DateTime.Now.AddYears(4),DateTime.Now.AddYears(4));
            
            //Act
            Status Status = Student.Status;
            
            Assert.Equal(Status.New,Status);

        }

        [Fact]
        public void Status_should_be_droupout()
        {
            //Arrange
            DateTime Now = DateTime.Now;
            TimeSpan Span = Now.AddYears(1) - Now;
            Student Student = new Student(13, "Ahmed", "Galal", DateTime.Now.Subtract(Span*3),DateTime.Now.Subtract(Span*2),DateTime.Now.AddYears(1));
            
            //Act
            Status Status = Student.Status;
            
            Assert.Equal(Status.Dropout,Status);
        }
        
        [Fact]
        public void Status_should_be_active()
        {
            //Arrange
            DateTime Now = DateTime.Now;
            TimeSpan Span = Now.AddYears(1) - Now;
            Student Student = new Student(13, "Ahmed", "Galal", DateTime.Now.Subtract(Span),DateTime.Now.AddYears(4),DateTime.Now.AddYears(4));
            
            //Act
            Status Status = Student.Status;
            
            Assert.Equal(Status.Active,Status);
        }
        
        [Fact]
        public void Status_should_be_graduated() 
        {
            //Arrange
            DateTime Now = DateTime.Now;
            TimeSpan Span = Now.AddYears(1) - Now;
            DateTime endDate = DateTime.Now.Subtract(Span * 2);
            Student Student = new Student(13, "Ahmed", "Galal", DateTime.Now.Subtract(Span*5),endDate,endDate);
            
            //Act
            Status Status = Student.Status;
            
            Assert.Equal(Status.Graduated,Status);
        }


        
    }
}
