
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace WetherApi
{
    public class StudentService : IStudentService
    {
        public Guid Id { get; set; }
        public StudentService()
        {
            Id = Guid.NewGuid();
        }
        public async Task<List<Student>> GetAll()
        {
            var result = new List<Student>()
            {
                new Student() { Id = 1, Name ="A"},
                new Student() { Id = 1, Name ="A"},
            };
            return await Task.FromResult(result);
        }

        public async Task<object> GetAny()
        {
            var rs = new
            {
                Id = Id,
                Code = this.GetHashCode()
            };
            return await Task.FromResult<object>(rs);
        }
        public override int GetHashCode()
        {
            // Implementing GetHashCode() based on the name field
            return Id.GetHashCode();
        }
    }
}
