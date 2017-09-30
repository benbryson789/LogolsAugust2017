using System;
using System.Collections.Generic;
using System.Text;
using Assessment.DAL;
using Assessment.Entities;

namespace Assessment.Domain
{
    public class QuestionService
    {
        private QuestionRepository _repository;

        public QuestionService()
        {
            _repository = new QuestionRepository();
        }

        public int Insert(Question question)
        {
            return _repository.Insert(question);
        }

        public void Delete(int questionID)
        {
            _repository.Delete(questionID);
        }

        public void Update(Question question)
        {
            _repository.Update(question);
        }

        public Question Get(int questionID)
        {
            return _repository.Get(questionID);
        }

        public IEnumerable<Question> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Answer> GetAnswers(int questionID)
        {
            return _repository.GetAnswers(questionID);
        }
    }
}
