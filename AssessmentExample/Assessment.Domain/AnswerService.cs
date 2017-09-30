using System;
using System.Collections.Generic;
using System.Text;
using Assessment.DAL;
using Assessment.Entities;

namespace Assessment.Domain
{
    public class AnswerService
    {
        private AnswerRepository _repository;

        public AnswerService()
        {
            _repository = new AnswerRepository();
        }

        public int Insert(Answer answer)
        {
            return _repository.Insert(answer);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void Update(Answer answer)
        {
            _repository.Update(answer);
        }

        public Answer Get(int answerID)
        {
            return _repository.Get(answerID);
        }

        public IEnumerable<Answer> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
