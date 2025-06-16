namespace WebApiDemo
{
    public class StudentDB

    {
        static StudentDB()
        {
           students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Bhakti" });
            students.Add(new Student() { Id = 2, Name = "Aqsa" });
            students.Add(new Student() { Id = 3, Name = "Neeta" });

        }
        public static List<Student> students;
       
        public static List<Student> getAll()
        {
            return students;
        }
        public static Student GetStudent(int id)
        {
            foreach (Student s in students)
            {
                if (s.Id == id)
                {
                    return s;
                }
                
            }
            return null;
        }
        public static bool DeleteStudent(int id)
        {
            foreach (Student s in students)
            {
                if (s.Id == id)
                {
                    students.Remove(s);
                    return true;
                }
            }
            return false;
        }
        public static bool UpdateStudent(int id,String name)
        {
            foreach (Student s in students)
            {
                if (s.Id == id)
                {
                    s.Name = name;
                    return true;
                }
            }
            return false;
        }
        public static void add(Student s)
        {
            students.Add(s);
        }
    }
}
