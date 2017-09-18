using System.Collections.Generic;
using System.Data;
using System.Linq;
using Assessment.Entities;
using Dapper;

namespace Assessment.DAL
{
    public class SubjectRepository : Repository
    {
        public int Insert(Subject subject)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Assess.InsertSubject", subject, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(Subject subject)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Assess.DeleteSubject", subject, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(Subject subject)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Assess.UpdateSubject", subject, commandType: CommandType.StoredProcedure);
            }
        }

        public Subject Get(int subjectID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Subject>("Assess.GetSubject", new { SubjectID = subjectID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<Subject> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Subject>("Assess.GetAllSubjects", commandType: CommandType.StoredProcedure);
            }
        }
    }
}
