using PromotionEngine.BusinessLayer;
using PromotionEngine.Model;
using PromotionEngine.Utility;
using System;
using System.IO;
using System.Windows.Forms;

namespace PromotionEngine
{
    public partial class PromotionEngine : Form
    {
        private PromotionData promotionData = new PromotionData();
        public PromotionEngine()
        {
            InitializeComponent();

            try
            {
                string path = Path.Combine(Environment.CurrentDirectory, "SkuIdPrice.json");
                JsonParser.JsonParserToList(path, promotionData);

            }
            catch (Exception ex)
            {
                Logger.WriteException(ex);
            }
            BindData();
        }

        private void BindData()
        {
            cmbSKUIDPrice.DataSource = Global.skuIdPrice;
            cmbSKUIDPrice.ValueMember = "skuid";
            cmbSKUIDPrice.DisplayMember = "sku";

            cmbActivePromotion.DataSource = Global.activePromotions;
            cmbActivePromotion.ValueMember = "PromotionId";
            cmbActivePromotion.DisplayMember = "ActivePromotions";
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result is:" +  calculatePromotion().ToString();
        }

        private int calculatePromotion()
        {
            int calculateValue = 0;
            try
            {
                int activePromotionId = Convert.ToInt32(cmbActivePromotion.SelectedValue == null ? "0" : cmbActivePromotion.SelectedValue);
                int skuId = Convert.ToInt32(cmbSKUIDPrice.SelectedValue == null ? "0" : cmbSKUIDPrice.SelectedValue);

                CalculateResult calculateResult = new CalculateResult();
                calculateValue = calculateResult.CalculateFinalResult(skuId, activePromotionId, Convert.ToInt32(txtUnit.Text));
            }
            catch (Exception ex)
            {
                Logger.WriteException(ex);
            }
            return calculateValue;
        }
    }
}
