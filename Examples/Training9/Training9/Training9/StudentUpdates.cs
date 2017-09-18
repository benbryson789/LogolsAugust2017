using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training9
{
    public class StudentUpdates
    {
        private IStudentRepository StudentRepository;

        public StudentUpdates(IStudentRepository studentRepository)
        {
            StudentRepository = studentRepository;
        }

        public void SwitchNames()
        {
            var students = StudentRepository.GetAllSudents();

            foreach(Student student in students)
            {
                StudentRepository.UpdateStudent(student.StudentID, student.LastName, student.FirstName);
            }
        }
    }
}
