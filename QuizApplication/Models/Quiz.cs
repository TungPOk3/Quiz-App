namespace QuizApplication.Models
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Level { get; set; }
        public ICollection<User_Quiz> UserQuizzes { get; set; } = new List<User_Quiz>();
        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}
