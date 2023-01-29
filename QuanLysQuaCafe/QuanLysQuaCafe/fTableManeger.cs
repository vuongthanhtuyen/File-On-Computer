using QuanLysQuaCafe.DAO;
using QuanLysQuaCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLysQuaCafe
{
    public partial class fTableManeger : Form
    {
        private Account loginAccount;

        public Account LoginAccount { get => loginAccount; set {  loginAccount = value; ChangeAccount(loginAccount.Type); }  }

        public fTableManeger(Account account)
        {
            
            InitializeComponent();
            this.LoginAccount = account;
            LoadTable();
            LoadCategory();
            LoadComboxTable(cbSwicthTable);
        }

        #region Event
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            f.UpdateAccount += F_UpdateAccount;
            f.ShowDialog();

        }

        private void F_UpdateAccount(object? sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DispalyName + ")";
        }

        private void adimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.InsertFood += F_InsertFood;
            f.DeleteFood += F_DeleteFood;
            f.UpdateFood += F_UpdateFood;
            f.ShowDialog();
        }

        private void F_UpdateFood(object? sender, EventArgs e)
        {
            LoadFoodListByCatory((CbCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void F_DeleteFood(object? sender, EventArgs e)
        {
            LoadFoodListByCatory((CbCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

        private void F_InsertFood(object? sender, EventArgs e)
        {
            LoadFoodListByCatory((CbCategory.SelectedItem as Category).Id);
            if(lsvBill.Tag != null)
                 ShowBill((lsvBill.Tag as Table).ID);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int TableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(TableID);
        }
        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iD = 0;
            ComboBox cb = sender as ComboBox ;
            if (cb.SelectedItem == null) return;
            Category selected = cb.SelectedItem as Category;
            iD = selected.Id;
            LoadFoodListByCatory(iD);
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            CbCategory.DataSource = listCategory;
            CbCategory.DisplayMember = "name";

        }
        void LoadFoodListByCatory(int iD)
        {
            List<Food> foods = FoodDAO.Instance.GetListCategoryID(iD);
            cbFood.DataSource = foods;
            cbFood.DisplayMember = "name";

        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listMenuInfo = MeNuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listMenuInfo)
            {
                ListViewItem lvitem = new ListViewItem(item.FoodName.ToString());
                lvitem.SubItems.Add(item.Count.ToString());
                lvitem.SubItems.Add(item.Price.ToString());
                lvitem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lvitem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotalPrice.Text = totalPrice.ToString("c", culture);

        }
        #endregion

        #region Method
        void ChangeAccount(int type)
        {
            adiminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + loginAccount.DispalyName + ")";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tablelist = TableDAO.Instance.LoadTablelist();
            foreach(Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWight, Height = TableDAO.TableHeight};
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag= item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flpTable.Controls.Add(btn); 
            }
        }
        public void LoadComboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTablelist();
            cb.DisplayMember = "Name";
             
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if(table == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn");
                return;
            }
            int idBill = BillDAO.Instance.GeUnCheckBillIDByTableID(table.ID) ;
            int foodID = (cbFood.SelectedItem as Food).Id;
            int count = (int)(nmCount.Value);
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillinfo(BillDAO.Instance.GetMaxIdBill(), foodID,count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillinfo(idBill, foodID, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn");
                return;
            }
            int idBill = BillDAO.Instance.GeUnCheckBillIDByTableID(table.ID);
            int discount = (int)nmDiscount.Value;
            string a = txtTotalPrice.Text;
            a = a.Substring(0, a.Length - 2);
            string[] b = a.Split('.');
            a = "";
            for(int i = 0; i < b.Length; i++)
            {
                a=a+b[i];
            }

            double totalPrice = Convert.ToDouble(a);

            double finalTotalPrice = totalPrice - totalPrice * discount / 100;
            if (idBill != -1)
            {
                if (MessageBox.Show(String.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0} \n Tổng tiền - Tổng tiền * giảm giá / 100 \n=> {1} - {1} * {2} / 100 = {3} ", table.Name,totalPrice,discount,finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill,discount,(float)finalTotalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                }                                               
            }
        }

        private void btnChuyenban_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;

            int id2 = (cbSwicthTable.SelectedItem as Table).ID;
            TableDAO.Instance.SwitchTable(id1,id2);
            LoadTable();
        }
    }
}
