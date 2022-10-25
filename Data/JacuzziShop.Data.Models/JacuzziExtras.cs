namespace JacuzziShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class JacuzziExtras
    {
        public int Id { get; set; }

        public int JacuzziId { get; set; }

        public virtual Jacuzzi Jacuzzi { get; set; }

        public int ExtrasId { get; set; }

        public virtual Extra Extras { get; set; }
    }
}
