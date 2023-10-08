namespace backend_skincare_2023.Models
{
    public class Routine
    {
        [Key]
        public int RoutineId { get; set; }

        [Required(ErrorMessage = "Routine text is required")]
        [StringLength(5000)]
        public string RoutineText { get; set; }


        [Required(ErrorMessage = "Created at date is required")]
        public DateTime CreatedAt { get; set; }


        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
