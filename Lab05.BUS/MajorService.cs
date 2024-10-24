using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.BUS
{
    public class MajorService
    {
        public List<Major> GetAllByFaculty(int  facultyId)
        {
            QLSV_DBContext context = new QLSV_DBContext();
            return context.Majors.Where(p => p.FacultyID == facultyId).ToList();
        }
    }
}
