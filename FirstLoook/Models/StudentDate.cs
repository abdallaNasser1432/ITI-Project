using System.Collections.Generic;

namespace FirstLoook.Models
{
    public static class StudentDate
    {
        public static List<Student> StudentList { get; set; } = new List<Student>();
        static StudentDate()
        {
            StudentList.Add(new Student() { Id = 1, Name = "Abdalla", Adress = "Ismaila", Image = "5.png",Gpa=3.2m });
            StudentList.Add(new Student() { Id = 2, Name = "Nada", Adress = "Mansoura", Image = "2.jpg", Gpa = 1.2m });
            StudentList.Add(new Student() { Id = 3, Name = "Hamada", Adress = "Cairo", Image = "man.png", Gpa = 2m });
            StudentList.Add(new Student() { Id = 4, Name = "Hadeer", Adress = "Ismaila", Image = "women.jpg", Gpa = 3m });

        }
    }
}
