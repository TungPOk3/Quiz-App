namespace QuizApplication.Models
{
    public class User_Quiz
    {
        public int UserQuizId { get; set; }
        public int UserId { get; set; }
        public int QuizId { get; set; }
        public int Score { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<User_Answer> UserAnswers { get; set; } = new List<User_Answer>();

        // Navigation properties
        public User User { get; set; }
        public Quiz Quiz { get; set; }
    }
}
