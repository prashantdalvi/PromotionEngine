using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Model
{
    public class PromotionData
    {
        public List<SkuIdPrice> SkuIdPrice { get; set; }
        public List<ActivePromotion> ActivePromotion { get; set; }
    }
}
