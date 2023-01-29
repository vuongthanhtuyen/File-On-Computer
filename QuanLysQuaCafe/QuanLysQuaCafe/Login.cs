using QuanLysQuaCafe.DAO;
using QuanLysQuaCafe.DTO;

namespace QuanLysQuaCafe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (login(username,password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUsername(username);
                fTableManeger f = new fTableManeger(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show(" Bạn vừa nhập sai mật khẩu hoặc tài khoản");
            }
          
        }
        bool login(string username, string password)
        {
           // return true;
           return AccountDAO.Instance.Login(username,password);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show(" Bạn có thật sự muốn thoát chương trình?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}