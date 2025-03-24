using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using ApiStudent.Data;
using ApiStudent.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiStudent.Services
{
    public class StudentService
    {
        private ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        private async Task<bool> SaveAsync()
        {
            try
            {
                return await _context.SaveChangesAsync() > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> CreateStudentAsync(Student student)
        {
            try
            {
                _context.Students.Add(student);
                return await SaveAsync();
            }
            catch
            { 
                return false;
            }

        }

        public async Task<List<Student>?> GetStudentsAsync()
        {
            try
            {
                return await _context.Students.ToListAsync();
            }
            catch
            {
                return null;
            }
        }
    }
}
