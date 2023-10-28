using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftCard
{
    public class UserGiftCards
    {
        public int id { get; set; }
        public string username { get; set; }
        public int Giftcard_id { get; set; }

        public decimal Giftcard_availablefunds { get; set; }

        public string Giftcard_code { get; set; }

    }
}
