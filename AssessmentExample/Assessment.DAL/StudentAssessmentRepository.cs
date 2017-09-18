using System.Collections.Generic;
using System.Data;
using System.Linq;
using Assessment.Entities;
using Dapper;

namespace Assessment.DAL
{
    public class StudentAssessmentRepository : Repository
    {
        public int Insert(StudentAssessment studentAssessment)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Assess.InsertStudentAssessment", studentAssessment, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(StudentAssessment studentAssessment)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Assess.DeleteStudentAssessment", studentAssessment, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(StudentAssessment studentAssessment)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Assess.UpdateStudentAssessment", studentAssessment, commandType: CommandType.StoredProcedure);
            }
        }

        public StudentAssessment Get(int studentAssessmentID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<StudentAssessment>("Assess.GetStudentAssessment", new { StudentAssessmentID = studentAssessmentID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<StudentAssessment> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<StudentAssessment>("Assess.GetAllStudentAssessments", commandType: CommandType.StoredProcedure);
            }
        }
    }
}
