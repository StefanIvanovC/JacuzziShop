namespace JacuzziShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using JacuzziShop.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Jacuzzis = new HashSet<Jacuzzi>();
        }

        public string Name { get; set; }

        public ICollection<Jacuzzi> Jacuzzis { get; set; }
    }
}
