using Exercise01.Models;
using Exercise01.Services.Interface;

namespace Exercise01.Services.Implementations
{
    public class PersonService : IPersonService
    {
        public string CreatePerson(string name)
        {
            var student = new Student() { Name = name };
            return student.Greet();
        }

        public string CreateStudent(string name, int age)
        {
            var student = new Student() { Name = name };
            student.SetAge(age);
            return $"{student.Greet()}. {student.ShowAge()}";
        }

        public string CreateTeacher(string name, int age)
        {
            var teacher = new Teacher() { Name = name };
            teacher.SetAge(age);
            return $"{teacher.Greet()}. {teacher.Teach()}";
        }
    }

}
