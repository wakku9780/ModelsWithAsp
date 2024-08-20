using Models.Models;

namespace Models.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();
        }

        private List<StudentModel> DataSource()
        {
           return  new List<StudentModel>
            {
                new StudentModel{ rollNo = 1, name = "waqar", gender = "Male", standard = 12 },
                new StudentModel{ rollNo = 2, name = "natasha", gender = "Female", standard = 13 },
                new StudentModel{ rollNo = 3, name = "azeem", gender = "Male", standard = 14 },
                new StudentModel{ rollNo = 4, name = "abdul", gender = "Male", standard = 15 },
                new StudentModel{ rollNo = 5, name = "akhir", gender = "Male", standard = 12 },
                new StudentModel{ rollNo = 6, name = "hozaifa", gender = "Male", standard = 11 },
            };

            
        }
    }
}
