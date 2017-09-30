using System.Collections.Generic;
using System.Data;
using System.Linq;
using Assessment.Entities;
using Dapper;

namespace Assessment.DAL
{
    public class AnswerRepository : Repository
    {
        public int Insert(Answer answer)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Assess.InsertAnswer", new { QuestionID = answer.QuestionID, Text = answer.Text, IsCorrect = answer.IsCorrect }, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(int answerID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Assess.DeleteAnswer", new { AnswerID = answerID }, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(Answer answer)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Assess.UpdateAnswer", answer, commandType: CommandType.StoredProcedure);
            }
        }

        public Answer Get(int answerID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Answer>("Assess.GetAnswer", new { AnswerID = answerID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<Answer> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Answer>("Assess.GetAllAnswers", commandType: CommandType.StoredProcedure);
            }
        }
    }
}
