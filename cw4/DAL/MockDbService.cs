using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw4.models;

namespace cw4.DAL
{
    interface MockDbService
    {
        public class MockDbService : IDbService
        {
            private static IEnumerable<StudentDto> _students;

            static MockDbService()
            {
                _students = new List<StudentDto>
            {
                new StudentDto{IdStudent=1, FirstName="Adam", LastName="Majewski"},
                new StudentDto{IdStudent=2, FirstName="Kaolina", LastName="Kowalczyk"},
                new StudentDto{IdStudent=3, FirstName="Sefan", LastName="Stonoga"}
            };
            }

            public IEnumerable<StudentDto> GetStudents()
            {
                return _students;
            }
        }
}
