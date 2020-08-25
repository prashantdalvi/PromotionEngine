using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.BusinessLayer
{
    class blSkuIdPrice
    {
        public SkuIdPrice GetSkuIdPrice(int skuId)
        {
            SkuIdPrice skuidPrice =
                   (from l in Global.skuIdPrice
                    where l.skuid == skuId
                    select new SkuIdPrice
                    {
                        unitprice = l.unitprice,
                    }).FirstOrDefault();

            return skuidPrice;
        }

    }
}
