using PromotionEngine.BusinessLayer;
using PromotionEngine.Model;
namespace PromotionEngine.Utility
{
    class CalculateResult
    {
        public int CalculateFinalResult(int skuId, int promptioid, int orderUnit)
        {
            int calculateValue = 0;
            try
            {
                blActivePromotion blActivePromotion = new blActivePromotion();
                ActivePromotion activePromotion = blActivePromotion.GetActivePromotion(promptioid);

                blSkuIdPrice blSkuIdPrice = new blSkuIdPrice();
                SkuIdPrice skuidPrice = blSkuIdPrice.GetSkuIdPrice(skuId);
                //int orderUnit = Convert.ToInt32(txtUnit.Text);
                int remainingUnit = orderUnit % activePromotion.unit * skuidPrice.unitprice;
                int groupedUnit = orderUnit / activePromotion.unit * activePromotion.Promotions;

                calculateValue = remainingUnit + groupedUnit;
            }
            catch (System.Exception)
            {
                throw;
            }
            return calculateValue;
        }
    }
}
