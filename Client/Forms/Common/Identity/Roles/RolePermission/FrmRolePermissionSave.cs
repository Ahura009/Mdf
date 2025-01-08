using Client.Infra;
using Mdf.Application.Command.Identity.Roles.CreatePermissionToRole;
using Mdf.Application.Query.Core.App.GetAppPermission;

namespace Client.Forms.Common.Identity.Roles.RolePermission;

public partial class FrmRolePermissionSave : Form
{
    private readonly int _appId;
    private readonly long _roleId;

    public FrmRolePermissionSave(int appId, long roleId, string roleName)
    {
        _appId = appId;
        _roleId = roleId;
        InitializeComponent();
        LoadAppPermission();
        label1.Text = $@"در حال انجام عملیات روی نقش {roleName}";
    }

    public event EventHandler DataChanged;


    private void BtnCreateRolePermission_Click(object sender, EventArgs e)
    {
        var selectedItems = dataGridView1.GetCheckedRows<AppPermissionQr>(DataGridViewExtension.Select);
        var items = selectedItems.Where(c => c.PermissionId != 0).Select(c => c.PermissionId);

        var result = new HttpService().Post("Role/CreatePermissionToRole", new CreatePermissionToRoleCommand
        {
            RoleId = _roleId,
            PermissionIds = items,
            AppId = _appId
        });

        new ExceptionResult().ExceptionCommandResult(result);
        Close();
    }

    private void FrmRolePermissionSave_FormClosed(object sender, FormClosedEventArgs e)
    {
        DataChanged?.Invoke(this, EventArgs.Empty);
    }

    private void LoadAppPermission(string txtPermissionText = "")
    {
        var rolePermission = new HttpService().GetData<List<AppPermissionQr>, GetAppPermissionQuery>(
            "App/GetAppPermission", new GetAppPermissionQuery
            {
                AppId = _appId,
                PermissionName = txtPermissionText
            });

        dataGridView1.Columns.CreateCheckBoxColumn(DataGridViewExtension.Select, "انتخاب");
        dataGridView1.BindingSource(rolePermission.Data!);
        dataGridView1.Columns.CreateTextBoxColumn("Id", "شناسه");
        dataGridView1.Columns.CreateTextBoxColumn("AppName", "نام اپ");
        dataGridView1.Columns.CreateTextBoxColumn("PermissionName", "نام  مجوز");
    }

    private void TxtPermission_TextChanged(object sender, EventArgs e)
    {
        LoadAppPermission(TxtPermission.Text);
    }
}