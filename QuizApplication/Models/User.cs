namespace QuizApplication.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<User_Quiz> UserQuizzes { get; set; } = new List<User_Quiz>();

    }
}
