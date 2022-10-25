namespace JacuzziShop.Web.ViewModels.Jacuzzis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class JacuzzisExtraInputModel
    {
        [MinLength(5)]
        public string Name { get; set; }
    }
}
