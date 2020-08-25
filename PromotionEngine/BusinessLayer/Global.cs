using PromotionEngine.Model;
using System.Collections.Generic;

namespace PromotionEngine.BusinessLayer
{
    static class Global
    {
        //public static List<ActivePromotion> activePromotions(PromotionData promotionData)
        //{
        //    List<ActivePromotion> activePromotions = new List<ActivePromotion>();
        //    activePromotions = promotionData.ActivePromotion.ToList();
        //    return activePromotions;
        //}
        public static List<ActivePromotion> activePromotions = new List<ActivePromotion>();
        public static List<SkuIdPrice> skuIdPrice;

        static Global()
        {
            //
            // Allocate the list.
            //
            //activePromotions = new List<ActivePromotion>();
        }
    }
}
