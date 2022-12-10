namespace OSeminar7
{
    class StudentService
    {
        private List<Student> students;

        public StudentService(List<Student> students)
        {
            this.students = students;
        }

        public void service()
        {
            Console.Clear();
            foreach (Student student in students)
            {
                student.getAllMethods();
                Console.WriteLine();
            }
        }
    }
}