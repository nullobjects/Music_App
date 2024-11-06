using MusicApp.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Domain.Domain
{
    public class Order : BaseEntity
    {
        public string userId { get; set; }
        public EShopApplicationUser User { get; set; }
        public ICollection<ProductInOrder> productInOrders { get; set; }

    }
}
