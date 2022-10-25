namespace JacuzziShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using JacuzziShop.Data.Common.Models;

    public class Question : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string QuestionTitle { get; set; }

        public string QuestionDescription { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }
    }
}
