using System.Collections.Generic;
using System.Data;
using System.Linq;
using Assessment.Entities;
using Dapper;

namespace Assessment.DAL
{
    public class QuestionRepository : Repository
    {
        public int Insert(Question question)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Assess.InsertQuestion", new { AssessmentID = question.AssessmentID, Text = question.Text }, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(int questionID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Assess.DeleteQuestion", new { QuestionID = questionID }, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(Question question)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Assess.UpdateQuestion", question, commandType: CommandType.StoredProcedure);
            }
        }

        public Question Get(int questionID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Question>("Assess.GetQuestion", new { QuestionID = questionID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<Question> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Question>("Assess.GetAllQuestions", commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Answer> GetAnswers(int questionID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Answer>("Assess.GetAllAnswersByQuestionID", new { QuestionID = questionID }, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
