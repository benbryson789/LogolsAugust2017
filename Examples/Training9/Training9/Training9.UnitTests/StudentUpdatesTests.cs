using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;

namespace Training9.UnitTests
{
    [TestFixture]
    public class StudentUpdatesTests
    {
        Mock<IStudentRepository> Repository;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Repository = new Mock<IStudentRepository>();
        }

        [Test]
        [Category("StudentUpdates")]
        public void SwitchNamesTest()
        {
            //Arrange
            IList<Student> students = new List<Student>()
            {
                new Student() { StudentID = 1, FirstName = "first 1", LastName = "last 1" },
                new Student() { StudentID = 2, FirstName = "first 2", LastName = "last 2" },
                new Student() { StudentID = 3, FirstName = "first 3", LastName = "last 3" }
            };
            Repository.Setup(r => r.GetAllSudents()).Returns(students);
            var studentUpdates = new StudentUpdates(Repository.Object);

            //Act
            studentUpdates.SwitchNames();

            //Assert
            Repository.Verify(r => r.GetAllSudents(), Times.Exactly(1));
            Repository.Verify(r => r.UpdateStudent(1, "last 1", "first 1"), Times.Exactly(1));
            Repository.Verify(r => r.UpdateStudent(2, "last 2", "first 2"), Times.Exactly(1));
            Repository.Verify(r => r.UpdateStudent(3, "last 3", "first 3"), Times.Exactly(1));
        }
    }
}
