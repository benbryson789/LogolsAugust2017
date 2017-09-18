using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Training9
{
    public interface IStudentRepository
    {
        int InsertStudent(string firstName, string lastName);

        void UpdateStudent(int studentId, string firstName, string lastName);

        void DeleteStudent(int studentId);

        void DeleteAllStudents();

        Student GetSudent(int studentId);

        IList<Student> GetAllSudents();
    }
}
