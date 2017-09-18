using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Training9;
using System.Transactions;

namespace Training9.IntegrationTests
{
    [TestFixture]
    public class StudentTests
    {
        StudentRepository Repository;
        TransactionScope Scope;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Repository = new StudentRepository();
        }

        [SetUp]
        public void Setup()
        {
            Scope = new TransactionScope();
        }

        [TearDown]
        public void TearDown()
        {
            Scope.Dispose();
            Scope = null;
        }

        [Test]
        [Category("Student")]
        public void InsertStudentTest()
        {
            //Arrange

            //Act
            int id = Repository.InsertStudent("Joe", "Mackie");
            var newStudent = Repository.GetSudent(id);

            //Assert
            Assert.That(newStudent.FirstName == "Joe");
            Assert.That(newStudent.LastName == "Mackie");
        }

        [Test]
        [Category("Student")]
        public void UpdateStudentTest()
        {
            //Arrange
            int id = Repository.InsertStudent("Joe", "Mackie");

            //Act
            Repository.UpdateStudent(id, "Test1", "Test2");
            var newStudent = Repository.GetSudent(id);

            //Assert
            Assert.That(newStudent.FirstName == "Test1");
            Assert.That(newStudent.LastName == "Test2");
        }
    }
}
