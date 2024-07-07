
namespace WetherApi
{
    public class StudentService : IStudentService
    {
        public async Task<List<Student>> GetAll()
        {
            var result = new List<Student>()
            {
                new Student() { Id = 1, Name ="A"},
                new Student() { Id = 1, Name ="A"},
            };
            return await Task.FromResult(result);
        }

        public Task<object> GetAny()
        {
            throw new NotImplementedException();
        }
    }
}
