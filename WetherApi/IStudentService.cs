namespace WetherApi
{
    public interface IStudentService
    {
        Task<List<Student>> GetAll();
        Task<object> GetAny();
    }
}
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}
