using System.Collections.Generic;
using System.Data;
using System.Linq;
using Assessment.Entities;
using Dapper;

namespace Assessment.DAL
{
    public class AssessmentRepository : Repository
    {
        public int Insert(Assessment.Entities.Assessment assessment)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Assess.InsertAssessment"
                    , new { LevelNumber = assessment.LevelNumber, SubjectID = assessment.SubjectID, Name = assessment.Name }
                    , commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(int assessmentID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Assess.DeleteAssessment", new { AssessmentID = assessmentID }, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(Assessment.Entities.Assessment assessment)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Assess.UpdateAssessment", assessment, commandType: CommandType.StoredProcedure);
            }
        }

        public Assessment.Entities.Assessment Get(int assessmentID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Assessment.Entities.Assessment>("Assess.GetAssessment", new { AssessmentID = assessmentID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<Assessment.Entities.Assessment> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Assessment.Entities.Assessment>("Assess.GetAllAssessments", commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Question> GetQuestions(int assessmentID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Question>("Assess.GetAllQuestionsByAssessmentID", new { AssessmentID = assessmentID }, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Answer> GetAnswers(int assessmentID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Answer>("Assess.GetAllAnswersByAssessmentID", new { AssessmentID = assessmentID }, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
