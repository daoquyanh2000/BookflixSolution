using System.ComponentModel.DataAnnotations;

namespace BookflixSolution.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}