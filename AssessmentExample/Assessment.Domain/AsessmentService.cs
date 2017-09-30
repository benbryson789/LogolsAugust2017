using System;
using System.Collections.Generic;
using System.Text;
using Assessment.DAL;
using Assessment.Entities;

namespace Assessment.Domain
{
    public class AssessmentService
    {
        private AssessmentRepository _repository;

        public AssessmentService()
        {
            _repository = new AssessmentRepository();
        }

        public int Insert(Assessment.Entities.Assessment assessment)
        {
            return _repository.Insert(assessment);
        }

        public void Delete(int assessmentID)
        {
            _repository.Delete(assessmentID);
        }

        public void Update(Assessment.Entities.Assessment assessment)
        {
            _repository.Update(assessment);
        }

        public Assessment.Entities.Assessment Get(int assessmentID)
        {
            return _repository.Get(assessmentID);
        }

        public IEnumerable<Assessment.Entities.Assessment> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Question> GetQuestions(int assessmentID)
        {
            return _repository.GetQuestions(assessmentID);
        }

        public IEnumerable<Answer> GetAnswers(int assessmentID)
        {
            return _repository.GetAnswers(assessmentID);
        }
    }
}
