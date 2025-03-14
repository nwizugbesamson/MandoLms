namespace MandoLms.WebApp.Models
{
    public class ClassRegistrationReport
    {
        public string ClassName { get; set; }
        public string TeacherName { get; set; }
        public int NumberOfRegisteredStudents { get; set; }
        public int NumberOfStudentsWithPaidFees { get; set; }
    }
}
