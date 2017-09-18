using System.Collections.Generic;
using System.Data;
using System.Linq;
using Assessment.Entities;
using Dapper;

namespace Assessment.DAL
{
    public class LevelRepository : Repository
    {
        public int Insert(Level level)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<InsertID>("Assess.InsertLevel", level, commandType: CommandType.StoredProcedure).First().ID;
            }
        }

        public void Delete(Level level)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Assess.DeleteLevel", level, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(Level level)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("Assess.UpdateLevel", level, commandType: CommandType.StoredProcedure);
            }
        }

        public Level Get(int levelID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Level>("Assess.GetLevel", new { LevelID = levelID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<Level> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Level>("Assess.GetAllLevels", commandType: CommandType.StoredProcedure);
            }
        }
    }
}
