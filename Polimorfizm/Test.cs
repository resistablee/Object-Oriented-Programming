using Polimorfizm.Models;
using Polimorfizm.Models.Base;
using Polimorfizm.Services.Base;

namespace Polimorfizm
{
    public class Test
    {
        public void AddStudent()
        {
            BaseService<Student> studentService = new BaseService<Student>();
            studentService.Add(new Student());
        }

        public void AddInstructor()
        {
            BaseService<Instructor> instructorService = new BaseService<Instructor>();
            instructorService.Add(new Instructor());
        }

        public void AddAdmin()
        {
            BaseService<Admin> adminService = new BaseService<Admin>();
            adminService.Add(new Admin());
        }






































        public void asd()
        {
            BaseEntity student = new Student();
            BaseEntity instructor = new Instructor();
        }
    }
}
