namespace DND2_OOPSPrograms
{
    internal class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            bool debug = false;

            //Create a Person and make it say hello
            Person person = new Person();
            person.Greet();

            /*Create a student, set his age to 21, 
              tell him to Greet and display his age*/
            Student student = new Student();
            student.SetAge(21);
            student.Greet();
            student.ShowAge();

            /*Create a teacher, 30 years old, 
             *ask him to say hello and then explain*/
            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();

            if (debug)
                Console.ReadLine();
        }
    }
}