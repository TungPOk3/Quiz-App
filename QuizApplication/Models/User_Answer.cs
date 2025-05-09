namespace QuizApplication.Models
{
    public class User_Answer
    {
        public int UserAnswerId { get; set; }
        public int UserQuizId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }

        // Navigation properties
        public Question Question { get; set; }
        public Answer Answer { get; set; }
        public User_Quiz UserQuiz { get; set; }

    }
}
