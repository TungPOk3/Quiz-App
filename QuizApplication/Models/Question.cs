namespace QuizApplication.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Content { get; set; }
        public int Order { get; set; }
        public int QizId { get; set; }
        public ICollection<Answer> Answers { get; set; } = new List<Answer>();
        public ICollection<User_Answer> UserAnswers { get; set; } = new List<User_Answer>();

        /// Navigation properties
        public Quiz Quiz { get; set; }
    }
}
