using QuanLysQuaCafe.DAO;
using QuanLysQuaCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLysQuaCafe
{
     public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount { get => loginAccount; set { loginAccount = value; ChangeAccount(loginAccount); } }

        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        void ChangeAccount(Account acc)
        {
            txtTanDangNhap.Text = LoginAccount.Username;
            txtDisplayname.Text = LoginAccount.DispalyName;
            
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }  
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void UpdateAccountinfo()
        {
            string displayname = txtDisplayname.Text;
            string password = txtPassword.Text;
            string username = txtTanDangNhap.Text;
            string newpassword = txtNewPassword.Text;
            string reNewpasswprk = txtReEnterPassword.Text;
            if ( !newpassword.Equals(reNewpasswprk))
            {
                MessageBox.Show("Vui lòng nhập trùng mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(username, password, newpassword, displayname))
                {
                    MessageBox.Show("Cập nhập thành công");
                    if (updateAccount != null)
                    {
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUsername(username)));
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
               // Account acc = new
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountinfo();
        }
    }
    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }
        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
