using DemoAPI.Models;

namespace DemoAPI.Infrastructure
{
    public interface IStudents
    {
        Task<bool> CreateStudent(StudentDTO input);
    }
}
