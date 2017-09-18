using System;
using System.Collections.Generic;
using System.Text;
using Assessment.DAL;
using Assessment.Entities;

namespace Assessment.Domain
{
    public class StudentService
    {
        private StudentRepository _repository;

        public StudentService()
        {
            _repository = new StudentRepository();
        }

        public int Insert(Student student)
        {
            return _repository.Insert(student);
        }

        public void Delete(Student student)
        {
            _repository.Delete(student);
        }

        public void Update(Student student)
        {
            _repository.Update(student);
        }

        public Student Get(int studentID)
        {
            return _repository.Get(studentID);
        }

        public IEnumerable<Student> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
