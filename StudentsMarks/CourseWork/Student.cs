namespace CourseWork
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GroupNumber { get; set; }
        public int CurrentMark { get; set; }
        public int MiddleMark { get; set; }
        public int FinalMark { get; set; }
    }

    public static class Students
    {
        private static List<Student> students = new List<Student>()
        {
            new Student
            {
                Id = 1,
                FirstName = "Botirjon",
                LastName = "Mo'minov",
                GroupNumber = "163-10",
                CurrentMark = 3,
                MiddleMark = 4,
                FinalMark = 5
            },
            new Student
            {
                Id = 2,
                FirstName = "Bekmurod",
                LastName = "Olimov",
                GroupNumber = "123-01",
                CurrentMark = 3,
                MiddleMark = 4,
                FinalMark = 4
            },
            new Student
            {
                Id = 3,
                FirstName = "Xaqnazar",
                LastName = "Yusupov",
                GroupNumber = "190-12",
                CurrentMark = 5,
                MiddleMark = 5,
                FinalMark = 5
            }
        };

        public static Student Create(
            string fName,
            string lName,
            string groupNumber,
            int currentMark,
            int middleMark,
            int finalMark
        )
        {
            var student = new Student
            {
                Id = students.Last().Id + 1,
                FirstName = fName,
                LastName = lName,
                GroupNumber = groupNumber,
                CurrentMark = currentMark,
                MiddleMark = middleMark,
                FinalMark = finalMark
            };
            students.Add(student);
            return student;
        }

        public static List<Student> GetAll()
        {
            return students;
        }

        public static Student GetById(int id)
        {
            return students.FirstOrDefault(student => student.Id == id);
        }

        public static Student Update(Student _student)
        {
            var student = GetById(_student.Id);
            student = _student;
            return student;
        }

        public static Student Delete(int id)
        {
            var student = GetById(id);
            students.Remove(student);
            return student;
        }
    }
}
