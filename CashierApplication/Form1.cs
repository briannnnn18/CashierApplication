using System;
using System.Windows.Forms;
namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void btnCompute_Click_1(object sender, EventArgs e)
            {
                try
                {
                    string itemName = TextItemName.Text;
                    double price = Convert.ToDouble(TextPrice.Text);
                    int quantity = Convert.ToInt32(TextQuantity.Text);
                    double discount = Convert.ToDouble(TextDiscount.Text);

                    ItemNamespace.DiscountedItem item = new ItemNamespace.DiscountedItem(itemName, price, quantity, discount);

                    double totalAmount = item.ComputeTotalAmount();
                    lblTotalAmount.Text = "Total Amount: " + totalAmount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
                try
                {
                    double totalAmount = Convert.ToDouble(lblTotalAmount.Text.Replace("Total Amount: ", ""));
                    double amountPaid = Convert.ToDouble(TextAmountPaid.Text);

                    double change = amountPaid - totalAmount;
                    lblChange.Text = "Change: " + change.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
    }
}
namespace ItemNamespace
{
    
    public class Item
    {
        protected string itemName;
        protected double price;
        protected int quantity;

        public Item(string itemName, double price, int quantity)
        {
            this.itemName = itemName;
            this.price = price;
            this.quantity = quantity;
        }

        public virtual double ComputeTotalAmount()
        {
            return price * quantity;
        }
    }

 
    public class DiscountedItem : Item
    {
        private double discount;

        public DiscountedItem(string itemName, double price, int quantity, double discount)
            : base(itemName, price, quantity)
        {
            this.discount = discount;
        }

        public override double ComputeTotalAmount()
        {
            double discountedPrice = base.price - (base.price * (discount * 0.01));
            return discountedPrice * base.quantity;
        }
    }
}

