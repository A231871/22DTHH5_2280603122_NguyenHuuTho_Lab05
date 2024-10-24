using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.BUS
{
    public class StudentService
    {
        public List<Student> GetAll()
        {
            QLSV_DBContext context = new QLSV_DBContext();
            return context.Students.ToList();
        }
        public List<Student> GetAllHasNoMajor()
        {
            QLSV_DBContext context = new QLSV_DBContext();
            return context.Students.Where(p => p.MajorID == null).ToList();
        }
        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            QLSV_DBContext context = new QLSV_DBContext();
            return context.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
        }
        public Student FindById(string studentId)
        {
            QLSV_DBContext context = new QLSV_DBContext();
            return context.Students.FirstOrDefault(p => p.StudentID == studentId);
        }
        public void InsertUpdate(Student s)
        {
            using (QLSV_DBContext context = new QLSV_DBContext())
            {
                if (s.MajorID == -1)
                {
                    s.MajorID = null;
                }
                context.Students.AddOrUpdate(s);
                context.SaveChanges();
            }
        }

        public void Delete(Student s)
        {

            QLSV_DBContext context = new QLSV_DBContext();
            if (s != null)
            {
                context.Students.Remove(s);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Student not found.");
            }
        }
    }
}
