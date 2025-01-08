using Client.Infra;
using Mdf.Application.Command.Identity.Users.Create;

namespace Client.Forms.Common.Identity.Users.User;

public partial class FrmUserSave : Form
{
    private readonly int _appId;

    public FrmUserSave(int appId)
    {
        _appId = appId;
        InitializeComponent();
    }

    public event EventHandler DataChanged = null!;

    private void BtnSaveUser_Click(object sender, EventArgs e)
    {
        var newUser = new CreateUserCommand
        {
            AppId = _appId,
            PhoneNumber = TxtPhoneNumber.Text,
            Email = TxtUsername.Text,
            Password = TxtPassword.Text,
            NationalCode = TxtNationalCode.Text
        };

        var result = new HttpService().Post("User/CreateUser", newUser);

        new ExceptionResult().ExceptionCommandResult(result);
        Close();
    }

    private void FrmUserSave_FormClosed(object sender, FormClosedEventArgs e)
    {
        DataChanged?.Invoke(this, EventArgs.Empty);
    }
}