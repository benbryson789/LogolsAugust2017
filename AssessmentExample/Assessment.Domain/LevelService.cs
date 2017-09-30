using System;
using System.Collections.Generic;
using System.Text;
using Assessment.DAL;
using Assessment.Entities;

namespace Assessment.Domain
{
    public class LevelService
    {
        private LevelRepository _repository;

        public LevelService()
        {
            _repository = new LevelRepository();
        }

        public int Insert(Level level)
        {
            return _repository.Insert(level);
        }

        public void Delete(int levelID)
        {
            _repository.Delete(levelID);
        }

        public void Update(Level level)
        {
            _repository.Update(level);
        }

        public Level Get(int levelID)
        {
            return _repository.Get(levelID);
        }

        public IEnumerable<Level> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
