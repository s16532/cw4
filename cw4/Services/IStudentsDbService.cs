using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw4.models;

namespace cw4.Services
{
    public interface IStudentsDbService
    {
        public IEnumerable<StudentInfoDto> GetStudents();

        public StudentInfoDto GetStudent(string id);

        public IEnumerable<EnrollmentInfoDto> GetStudentEnrollments(string id);

        public EnrollmentDto EnrollStudent(EnrollStudentDto newStudent);

        public EnrollmentDto Promote(PromotionDto promotionDto);
    }
}
