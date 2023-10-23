using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftCard
{
    internal class GiftCard
    {
        private int giftCardId;
        private string giftCardBrand;
        private double giftCardValue;
        private string giftCardName;
        private string giftCardDescription;
        private string giftCardCode;

        public GiftCard(int giftCardId, string giftCardBrand, double giftCardValue, string giftCardName, string giftCardDescription, string giftCardCode)
        {
            this.giftCardId = giftCardId;
            this.giftCardBrand = giftCardBrand;
            this.giftCardValue = giftCardValue;
            this.giftCardName = giftCardName;
            this.giftCardDescription = giftCardDescription;
            this.giftCardCode = giftCardCode;
        }

        public int GiftCardId { get {  return giftCardId; } }
        public string GiftCardBrand { get {  return giftCardBrand; } }
        public double GiftCardValue { get {  return giftCardValue; } }
        public string GiftCardName { get {  return giftCardName; } }
        public string GiftCardDescription { get {  return giftCardDescription; } }

        public string GiftCardCode { get {  return giftCardCode; } }


    }
}
