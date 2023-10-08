namespace backend_skincare_2023.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }

        [Required(ErrorMessage = "Question text is required")]
        [StringLength(150)]
        public string QuestionText { get; set; }


        [Required(ErrorMessage = "Answer text is required")]
        [StringLength(100)]
        public string AnswerText { get; set; }


        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }


        [ForeignKey("Routine")]
        public int RoutineId { get; set; }
        public Routine Routine { get; set; }
    }
}
