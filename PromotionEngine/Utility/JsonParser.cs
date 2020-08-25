using PromotionEngine.BusinessLayer;
using PromotionEngine.Model;
using System.IO;
using System.Linq;

namespace PromotionEngine.Utility
{
    static class JsonParser
    {
        public static void JsonParserToList(string filePath, PromotionData promotionData)
        {
            try
            {
                using (StreamReader r = new StreamReader(filePath))
                {
                    string json = r.ReadToEnd();
                    promotionData = Newtonsoft.Json.JsonConvert.DeserializeObject<PromotionData>(json);
                    Global.activePromotions = promotionData.ActivePromotion.ToList();
                    Global.skuIdPrice = promotionData.SkuIdPrice.ToList();
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
