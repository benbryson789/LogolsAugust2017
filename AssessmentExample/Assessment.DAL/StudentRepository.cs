using System.Collections.Generic;
using System.Data;
using System.Linq;
using Assessment.Entities;
using Dapper;

namespace Assessment.DAL
{
    public class StudentRepository : Repository
    {
        public int Insert(Student student)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Assess.InsertStudent", student, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(Student student)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Assess.DeleteStudent", student, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(Student student)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Assess.UpdateStudent", student, commandType: CommandType.StoredProcedure);
            }
        }

        public Student Get(int studentID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Student>("Assess.GetStudent", new { StudentID = studentID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<Student> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Student>("Assess.GetAllStudents", commandType: CommandType.StoredProcedure);
            }
        }
    }
}
