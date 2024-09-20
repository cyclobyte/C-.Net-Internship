using DemoAPI.Models;

namespace DemoAPI.Infrastructure
{
    public class StudentRepository : IStudents
    {
        private readonly ApplicationDBContext _dbContext;
        public StudentRepository(ApplicationDBContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task<bool> CreateStudent(StudentDTO input)
        {
            try
            {
                var student = new Student();
                student.Name = input.Name;
                student.Age = input.Age;
                student.Address = input.Address;
                await _dbContext.Students.AddAsync(student);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
