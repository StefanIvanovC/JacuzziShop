namespace JacuzziShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using JacuzziShop.Data.Common.Models;

    public class Extra : BaseDeletableModel<int>
    {
        public Extra()
        {
            this.Jacuzzis = new HashSet<JacuzziExtras>();
        }

        public string Name { get; set; }

        public virtual ICollection<JacuzziExtras> Jacuzzis { get; set; }
    }
}
