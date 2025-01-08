using Client.Infra;
using Mdf.Application.Command.Identity.Roles.Create;

namespace Client.Forms.Common.Identity.Roles.Role;

public partial class FrmRoleSave : Form
{
    private readonly int _appId;

    public FrmRoleSave(int appId)
    {
        _appId = appId;
        InitializeComponent();
    }

    public event EventHandler DataChanged = null!;

    private void BtnCreateRole_Click(object sender, EventArgs e)
    {
        var newUser = new CreateRoleCommand
        {
            Name = TxtRoleName.Text,
            AppId = _appId
        };
        var result = new HttpService().Post("Role/CreateRole", newUser);

        new ExceptionResult().ExceptionCommandResult(result);
        Close();
    }

    private void FrmRoleSave_FormClosed(object sender, FormClosedEventArgs e)
    {
        DataChanged?.Invoke(this, EventArgs.Empty);
    }
}