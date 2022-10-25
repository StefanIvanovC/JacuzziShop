namespace JacuzziShop.Web.ViewModels.Contacts
{
    using System.ComponentModel.DataAnnotations;

    public class QuestionAskInputModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(5)]
        public string About { get; set; }

        [Required]
        [MinLength(20)]
        public string QuestionDescription { get; set; }

        public string AddedByUserId { get; set; }
    }
}
