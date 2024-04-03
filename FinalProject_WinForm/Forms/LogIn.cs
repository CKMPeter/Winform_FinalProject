using FinalProject_WinForm.Properties;

namespace FinalProject_WinForm
{
    public partial class FormEntry : Form
    {
        public HomePage homePage;
        public UserDAO userDAO = new UserDAO();
        public List<User> usersList = new List<User>();
        public User user;
        public FormEntry()
        {
            
            this.usersList = userDAO.LoadUInfo();
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text != "Login.")
            {
                this.btnLogin.ForeColor = Color.FromArgb(204, 233, 255);
                this.btnSUp.ForeColor = Color.Black;
                this.btnLogin.BackColor = Color.FromArgb(60, 100, 159);
                this.btnSUp.BackColor = Color.LightGray;
                this.lbMode.Text = "Login.";
                this.btnLogSign_Main.Text = "Login";
            }
        }

        private void btnSUp_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text != "Sign Up.")
            {
                this.btnSUp.ForeColor = Color.FromArgb(204, 233, 255);
                this.btnLogin.ForeColor = Color.Black;
                this.btnSUp.BackColor = Color.FromArgb(60, 100, 159);   
                this.btnLogin.BackColor = Color.LightGray;
                this.lbMode.Text = "Sign Up.";
                this.btnLogSign_Main.Text = "Sign Up";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogSign_Click(object sender, EventArgs e)
        {
            if (lbMode.Text == "Login.")
            { 
                homePage = new HomePage(Functions.checkValidLogin(ucLogin.UserName(), ucLogin.Password(), usersList));
                this.Hide();
                homePage.Closed += (s, args) => this.Close();
                homePage.Show();
            }
            else
            {
                User Tmp = new User(ucLogin.UserName(), ucLogin.Password(), "", "", 2, null, 5);
                userDAO.AddUser(Tmp);
                usersList = userDAO.LoadUInfo();
                MessageBox.Show("User name: " + ucLogin.UserName() + "\npassword: "+ ucLogin.Password());
            }
        }
        private void ucLogin1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}