using Microsoft.EntityFrameworkCore;
using restapi.Entities;
using restapi.Repository;

namespace restapi.Services
{
    public class StudentService
    {
        private readonly StudentRepo repo;

        public StudentService(StudentRepo repo) {
            this.repo = repo;
        }

        public IEnumerable<StudentEntity>? GetAllStudents() {
            return repo.Students?.ToList();
        }

        public StudentEntity? GetStudentById(int id) {
            return repo.Students.Find(id);
        }

        public void AddStudent(StudentEntity student) {
            repo.Students.Add(student);
            repo.SaveChanges();
        }

        public void UpdateStudent(StudentEntity student) {
            repo.Entry(student).State = EntityState.Modified;
            repo.SaveChanges();
        }

        public void DeleteStudent(int id) {
            var student = repo.Students.Find(id);
            if (student != null) {
                repo.Students.Remove(student);
                repo.SaveChanges();
            }
        }

    }
}