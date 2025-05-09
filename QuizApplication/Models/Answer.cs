namespace QuizApplication.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string Content { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }
        public ICollection<User_Answer> UserAnswers { get; set; } = new List<User_Answer>();

        /// Navigation properties
        public Question Question { get; set; }
    }
}
