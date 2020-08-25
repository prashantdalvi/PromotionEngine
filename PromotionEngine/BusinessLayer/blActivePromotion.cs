using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.BusinessLayer
{
    class blActivePromotion
    {
        public ActivePromotion GetActivePromotion(int activePromotionId)
        {
            ActivePromotion activePromotion =
                   (from l in Global.activePromotions
                    where l.PromotionId == activePromotionId
                    select new ActivePromotion
                    {
                        Promotions = l.Promotions,
                        ActivePromotions = l.ActivePromotions,
                        unit = l.unit,
                    }).FirstOrDefault();

            return activePromotion;
        }


    }
}
