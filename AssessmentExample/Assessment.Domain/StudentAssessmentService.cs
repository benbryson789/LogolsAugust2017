using System;
using System.Collections.Generic;
using System.Text;
using Assessment.DAL;
using Assessment.Entities;

namespace Assessment.Domain
{
    public class StudentAssessmentService
    {
        private StudentAssessmentRepository _repository;

        public StudentAssessmentService()
        {
            _repository = new StudentAssessmentRepository();
        }

        public int Insert(StudentAssessment studentAssessment)
        {
            return _repository.Insert(studentAssessment);
        }

        public void Delete(StudentAssessment studentAssessment)
        {
            _repository.Delete(studentAssessment);
        }

        public void Update(StudentAssessment studentAssessment)
        {
            _repository.Update(studentAssessment);
        }

        public StudentAssessment Get(int studentAssessmentID)
        {
            return _repository.Get(studentAssessmentID);
        }

        public IEnumerable<StudentAssessment> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
