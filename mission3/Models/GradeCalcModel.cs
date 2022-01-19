using System;
using System.ComponentModel.DataAnnotations;

namespace mission3.Models
{
    public class GradeCalcModel
    {
        [Required(ErrorMessage = "Must have a integer value")]
        [Range(0, 100, ErrorMessage = "Must be a value between 0-100")]
        public int? Assignments { get; set; }

        [Required(ErrorMessage = "Must have a integer value")]
        [Range(0, 100, ErrorMessage = "Must be a value between 0-100")]
        public int? GroupProjects { get; set; }

        [Required(ErrorMessage = "Must have a integer value")]
        [Range(0, 100, ErrorMessage = "Must be a value between 0-100")]
        public int? Quizzes { get; set; }

        [Required(ErrorMessage = "Must have a integer value")]
        [Range(0, 100, ErrorMessage = "Must be a value between 0-100")]
        public int? Exams { get; set; }

        [Required(ErrorMessage = "Must have a integer value")]
        [Range(0, 100, ErrorMessage = "Must be a value between 0-100")]
        public int? Intex { get; set; }
    }
}