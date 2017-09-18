using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Training9
{
    public class StudentRepository : IStudentRepository
    {
        Func<SqlDataReader, Student> MapFunction = (dr =>
        {
            Student newStudent = new Student();
            newStudent.StudentID = dr.GetInt32(dr.GetOrdinal("StudentID"));
            newStudent.FirstName = dr.GetString(dr.GetOrdinal("FirstName"));
            newStudent.LastName = dr.GetString(dr.GetOrdinal("LastName"));
            return newStudent;
        });

        public int InsertStudent(string firstName, string lastName)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO [Assess].[Student] (FirstName, LastName) VALUES (@FirstName, @LastName); SELECT CAST(SCOPE_IDENTITY() AS INT) AS StudentID;";
            command.Parameters.Add(new SqlParameter("@FirstName", firstName));
            command.Parameters.Add(new SqlParameter("@LastName", lastName));
            return DataAccess.GetData<Student>(command, dr => new Student { StudentID = dr.GetInt32(dr.GetOrdinal("StudentID")) })[0].StudentID;
        }

        public void UpdateStudent(int studentId, string firstName, string lastName)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE [Assess].[Student] SET FirstName = @FirstName, LastName = @LastName WHERE StudentID = @StudentID;";
            command.Parameters.Add(new SqlParameter("@FirstName", firstName));
            command.Parameters.Add(new SqlParameter("@LastName", lastName));
            command.Parameters.Add(new SqlParameter("@StudentID", studentId));
            DataAccess.ExecuteCommand(command);
        }

        public void DeleteStudent(int studentId)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM [Assess].[Student] WHERE StudentID = @StudentID;";
            command.Parameters.Add(new SqlParameter("@StudentID", studentId));
            DataAccess.ExecuteCommand(command);
        }

        public void DeleteAllStudents()
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM [Assess].[Student];";
            DataAccess.ExecuteCommand(command);
        }

        public Student GetSudent(int studentId)
        {
            Student student = new Student();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT StudentID, FirstName, LastName FROM [Assess].[Student] WHERE StudentID = @StudentID;";
            command.Parameters.Add(new SqlParameter("@StudentID", studentId));
            IList<Student> students = DataAccess.GetData<Student>(command, MapFunction);

            if(students != null && students.Count > 0)
            {
                return students[0];
            }
            else
            {
                return null;
            }
        }

        public IList<Student> GetAllSudents()
        {
            Student student = new Student();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT StudentID, FirstName, LastName FROM [Assess].[Student];";
            return DataAccess.GetData<Student>(command, MapFunction);
        }
    }
}
