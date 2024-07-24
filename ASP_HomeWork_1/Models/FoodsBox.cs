using System.Collections.Generic;
using System.ComponentModel;

namespace ASP_HomeWork_1.Models
{
    public class FoodsBox
    {
        [DisplayName("Drinks Foods List")]
        public List<Drink> Drinks { get; set; }

        [DisplayName("Hotmeals Foods List")]

        public List<Hotmeal> Hotmeals { get; set; }


        [DisplayName("Fastfoods Foods List")]

        public List<Fastfood> Fastfoods { get; set; }
    }
}
