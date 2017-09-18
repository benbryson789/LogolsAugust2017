using System;
using System.Collections.Generic;
using System.Text;
using Assessment.DAL;
using Assessment.Entities;

namespace Assessment.Domain
{
    public class SubjectService
    {
        private SubjectRepository _repository;

        public SubjectService()
        {
            _repository = new SubjectRepository();
        }

        public int Insert(Subject subject)
        {
            return _repository.Insert(subject);
        }

        public void Delete(Subject subject)
        {
            _repository.Delete(subject);
        }

        public void Update(Subject subject)
        {
            _repository.Update(subject);
        }

        public Subject Get(int subjectID)
        {
            return _repository.Get(subjectID);
        }

        public IEnumerable<Subject> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
