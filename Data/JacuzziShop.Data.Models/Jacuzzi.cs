namespace JacuzziShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using JacuzziShop.Data.Common.Models;

    public class Jacuzzi : BaseDeletableModel<int>
    {
        public Jacuzzi()
        {
            this.Extras = new HashSet<JacuzziExtras>();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        public virtual ICollection<JacuzziExtras> Extras { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
