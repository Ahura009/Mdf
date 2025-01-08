using Ahura.Platform.Application.Command.Common;
using Client.Forms.Admin;
using Client.Forms.Users;
using Client.Infra;

namespace Client.Forms;

public partial class FrmLogin : Form
{
    public FrmLogin()
    {
        InitializeComponent();
        TxtUsername.Text = "Admin.1001@gamil.com";
        TxtPassword.Text = "Admin1001Co#";
    }


    private async void button1_Click(object sender, EventArgs e)
    {
        var signin = await new AuthService().SignInAsync("Auth/SingIn", TxtUsername.Text, TxtPassword.Text, true);

        if (signin.Status == (int)ApplicationServiceStatus.Ok)
        {
            AuthService.AccessToken = signin.Data.AccessToken;

            if (signin.Data.AppId == 1)
            {
                var dialog = new FrmHome(signin.Data.AppId, signin.Data.UserId);
                dialog.ShowDialog();
            }
            else
            {
                var userHome = new FrmUserHome(signin.Data.AppId, signin.Data.UserId);
                userHome.ShowDialog();
            }
        }
        else
        {
            MessageBox.Show("invalud username or password", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        TxtUsername.Text = "Admin.1001@gamil.com";
    }

    private void button4_Click(object sender, EventArgs e)
    {
        TxtUsername.Text = "admin--mohamadi@yahoo.com";
    }

    private void button5_Click(object sender, EventArgs e)
    {
        TxtUsername.Text = "admin--sahraei@yahoo.com";
    }

    private void button7_Click(object sender, EventArgs e)
    {
        TxtUsername.Text = "user-1-mohamadi@yahoo.com";
    }

    private void button6_Click(object sender, EventArgs e)
    {
        TxtUsername.Text = "user-1-sahraei@yahoo.com";
    }

    private void button8_Click(object sender, EventArgs e)
    {
        TxtUsername.Text = "user-2-sahraei@yahoo.com";
    }

    private void button9_Click(object sender, EventArgs e)
    {
        TxtUsername.Text = "user-3-sahraei@yahoo.com";
    }

    private void FrmLogin_Load(object sender, EventArgs e)
    {
    }
}