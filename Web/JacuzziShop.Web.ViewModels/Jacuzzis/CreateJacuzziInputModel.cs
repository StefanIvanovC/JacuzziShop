namespace JacuzziShop.Web.ViewModels.Jacuzzis
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using JacuzziShop.Data.Models;

    public class CreateJacuzziInputModel
    {
        [Required]
        [MinLength(5)]
        public string Title { get; set; }

        [Required]
        [MinLength(50)]
        public string Description { get; set; }

        public string AddedByUserId { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<JacuzzisExtraInputModel> Extras { get; set; }
    }
}
