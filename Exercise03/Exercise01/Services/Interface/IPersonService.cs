namespace Exercise01.Services.Interface
{
    public interface IPersonService
    {
        string CreatePerson(string name);
        string CreateStudent(string name, int age);
        string CreateTeacher(string name, int age);
    }
}
