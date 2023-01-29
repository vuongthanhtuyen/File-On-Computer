using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLysQuaCafe.DAO;
using QuanLysQuaCafe.DTO;

namespace QuanLysQuaCafe
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            LoadAll();
        }
        void LoadAll()
        {
            dtgvFood.DataSource = foodList;
            LoadDateTimepickerBill();
            LoadThisBIllByDateTime(dateCheckIn.Value, dateCheckOut.Value);
            LoadListFood();
            AddFoodBinding();
            LoadCatoryInCombobox(cbCatogory);
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.Account";
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuyre(query);
        }
        List<Food> SearchFoodByName(string nane)
        {
            List<Food> listFood = listFood = FoodDAO.Instance.SearchFoodByName(Name);
            return listFood;
        }

        #region methods
        void LoadThisBIllByDateTime(DateTime dayCheckIn, DateTime dayCheckOut)
        {
            datagvBill.DataSource = BillDAO.Instance.GetBillListByDay(dayCheckIn, dayCheckOut);
        }
        void LoadDateTimepickerBill()
        {
            DateTime today = DateTime.Now;
            dateCheckIn.Value = new DateTime(today.Year, today.Month, 1);
            dateCheckOut.Value = dateCheckIn.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void LoadCatoryInCombobox(ComboBox combo)
        {
            combo.DataSource = CategoryDAO.Instance.GetListCategory();
            combo.DisplayMember = "name";
        }
        void AddFoodBinding()
        {
            txtFoodname.DataBindings.Add("Text", dtgvFood.DataSource, "name",true,DataSourceUpdateMode.Never);
            txtIDFood.DataBindings.Add("text", dtgvFood.DataSource, "id", true, DataSourceUpdateMode.Never);
            nmFoodPrice.DataBindings.Add("value", dtgvFood.DataSource, "price", true, DataSourceUpdateMode.Never);
        }
        #endregion
        #region event
        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            
            foodList.DataSource = SearchFoodByName(txtSearchFood.Text);

        }
        private void btnViewAccount_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadThisBIllByDateTime(dateCheckIn.Value, dateCheckOut.Value);

        }
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        private void txtIDFood_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["IdCatogory"].Value;
                    Category category = CategoryDAO.Instance.GetCatoryByID(id);
                    cbCatogory.SelectedItem = category;
                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbCatogory.Items)
                    {
                        if (item.Id == category.Id)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbCatogory.SelectedIndex = index;
                    }
         
            }
            catch {
                MessageBox.Show(" Lỗi rồi má");
            }
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtFoodname.Text;
            int idCatogory = (cbCatogory.SelectedItem as Category).Id;
            float price = (float)nmFoodPrice.Value;
            if (FoodDAO.Instance.InsertFood(name, idCatogory, price))
            {
                MessageBox.Show("Thêm thành công");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtFoodname.Text;
            int idCatogory = (cbCatogory.SelectedItem as Category).Id;
            float price = (float)nmFoodPrice.Value;
            int idFood = Convert.ToInt32(txtIDFood.Text);
            if (FoodDAO.Instance.UpdatetFood(idFood,name, idCatogory, price))
            {
                MessageBox.Show("Cập nhập thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhập thức ăn");
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            int idFood = Convert.ToInt32(txtIDFood.Text);
            if (MessageBox.Show("Bạn có thật sự muốn xóa món ăn này", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                BillInfoDAO.Instance.DeleteBillInfoByIdFood(idFood);
                if (FoodDAO.Instance.DeletefoodById(idFood))
                {
                    MessageBox.Show("xóa thành công thành công");
                    LoadListFood();
                    if (deleteFood != null)
                        deleteFood(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa thức ăn thức ăn");
                }
            }

        }
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood+= value;}
            remove { insertFood-= value;}
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }



        #endregion
    }
}
