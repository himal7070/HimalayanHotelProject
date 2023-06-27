using BusinessLogicLayer.BLL;
using BusinessLogicLayer.InterfacesBLL;
using DataAccessLayer.DAL;
using DataTransferClasses.Classes;
using System.Text.RegularExpressions;

namespace PresentationLayer.Views
{
    public partial class Discounts : Form
    {
        DiscountBLL discountBLL = new DiscountBLL(new DiscountDAL());
        public Discounts()
        {
            InitializeComponent();
        }


        private Discount FillEntity()
        {

            var discount = new Discount();


            discount.Name = this.tbDiscountOfferName.Text;
            discount.Description = this.tbDiscountDetails.Text;
            discount.Rate = Convert.ToInt32(this.cbDiscountRate.Text);
            discount.StartDate = Convert.ToDateTime(dtpStartDate.Text);
            discount.EndDate = Convert.ToDateTime(dtpExpiryDate.Text);

            return discount;
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrEmpty(tbDiscountOfferName.Text) ||
                string.IsNullOrEmpty(tbDiscountDetails.Text) ||
                string.IsNullOrEmpty(cbDiscountRate.Text) ||
                dtpStartDate.Value == DateTime.MinValue ||
                dtpExpiryDate.Value == DateTime.MinValue)
                
            {
                MessageBox.Show("Please fill all information", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (!Regex.Match(tbDiscountOfferName.Text, @"^[\w\s.,%!?\-%]+$").Success)
            {
                MessageBox.Show("Discount name must only contain alphabets, numbers, and punctuation.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(tbDiscountDetails.Text, @"^[\w\s.,%!?\-]+$"))
            {
                MessageBox.Show("Invalid description. Only alphanumeric characters, spaces, and punctuation marks are allowed.", "Error", MessageBoxButtons.OK);
                return false;
            }

            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpExpiryDate.Value.Date;

            if (endDate < startDate)
            {
                MessageBox.Show("End date cannot be earlier than the start date.", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                Discount discount = this.FillEntity();
                try
                {
                    bool success = discountBLL.UpdateDiscount(discount, tbDiscountId.Text);
                    if (success)
                    {
                        MessageBox.Show("Discount updated Successfully!", "Message", MessageBoxButtons.OK);
                        DisplayAllDiscounts(dgvDiscount);
                        btnClear_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Discount updating Failed!", "Message", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                Discount discount = this.FillEntity();
                try
                {
                    bool success = discountBLL.InsertDiscount(discount);
                    if (success)
                    {
                        MessageBox.Show("Discount added Successfully!", "Message", MessageBoxButtons.OK);
                        DisplayAllDiscounts(dgvDiscount);
                        btnClear_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Discount added Failed!", "Message", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
               
            }
        }




        private void DisplayAllDiscounts(DataGridView data)
        {
            try
            {
                data.DataSource = discountBLL.GetAllDiscountInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Discounts_Load(object sender, EventArgs e)
        {
            DisplayAllDiscounts(dgvDiscount);
        }

        private void dgvDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbDiscountId.Text = dgvDiscount.CurrentRow.Cells[0].Value.ToString();
            tbDiscountOfferName.Text = dgvDiscount.CurrentRow.Cells[1].Value.ToString();
            tbDiscountDetails.Text = dgvDiscount.CurrentRow.Cells[2].Value.ToString();
            cbDiscountRate.Text = dgvDiscount.CurrentRow.Cells[3].Value.ToString();
            dtpStartDate.Text = dgvDiscount.CurrentRow.Cells[4].Value.ToString();
            dtpExpiryDate.Text = dgvDiscount.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bool deletionResult = discountBLL.DeleteDiscount(Convert.ToInt32(tbDiscountId.Text));
                    if (deletionResult)
                    {
                        MessageBox.Show("Discount deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Discount deletion failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }

            DisplayAllDiscounts(dgvDiscount);
            btnClear_Click(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDiscountId.Clear();
            tbDiscountOfferName.Clear();
            tbDiscountDetails.Clear();
            cbDiscountRate.Text = string.Empty;
        }


    }
}
