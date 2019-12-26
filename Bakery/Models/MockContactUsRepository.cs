using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class MockContactUsRepository : IContactUsRepository
    {
        public IEnumerable<ContactUs> AllInfo => new List<ContactUs>
        {
            new ContactUs{ShopName = "Nannas Bakery", StreetAddress = "Nannas Address", Email = "nanna@mail.dk", Telephone = 123456 }
        };
    }
}
