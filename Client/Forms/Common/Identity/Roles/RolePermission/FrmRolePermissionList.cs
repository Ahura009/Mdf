using Client.Infra;
using Mdf.Application.Command.Identity.Roles.DeletePermissionToRole;
using Mdf.Application.Query.Identity.Roles.GetRole;
using Mdf.Application.Query.Identity.Roles.GetRolePermission;

namespace Client.Forms.Common.Identity.Roles.RolePermission;

public partial class FrmRolePermissionList : Form
{
    private readonly int _appId;

    public FrmRolePermissionList(int appId, string description)
    {
        _appId = appId;
        InitializeComponent();
        LoadRole();
        label1.Text = description;
    }

    private void LoadRole()
    {
        var loadData = new HttpService().GetData<List<RoleQr>, GetRoleQuery>("Role/GetRole", new GetRoleQuery
        {
            AppId = _appId
        });
        new ComboBoxHelper().BindData(ComRole, loadData, "Name", "Id");
    }

    private void BtnCreateRolePermission_Click(object sender, EventArgs e)
    {
        if (!long.TryParse(ComRole.SelectedValue?.ToString(), out var roleId))
            return;

        var roleName = ComRole.Text;

        var dialog = new FrmRolePermissionSave(_appId, roleId, roleName);
        dialog.DataChanged += ChildForm_DataChanged!;
        dialog.ShowDialog();
    }

    private void ChildForm_DataChanged(object sender, EventArgs e)
    {
        LoadRolePermission();
    }


    private void ComRole_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadRolePermission();
    }

    private void LoadRolePermission()
    {
        if (!long.TryParse(ComRole.SelectedValue?.ToString(), out var roleId))
            return;
        //
        var rolePermission = new HttpService().GetData<List<RolePermissionQr>, GetRolePermissionQuery>(
            "Role/GetRolePermission", new GetRolePermissionQuery
            {
                Id = roleId
            });

        dataGridView1.Columns.CreateCheckBoxColumn(DataGridViewExtension.Select, "انتخاب");
        dataGridView1.BindingSource(rolePermission.Data!);
        dataGridView1.Columns.CreateTextBoxColumn("RequestType", "نوع درخواست");
        dataGridView1.Columns.CreateTextBoxColumn("Name", "نام درخواست");
        dataGridView1.Columns.CreateTextBoxColumn("Description", "توضیحات");
    }

    private void BtnDeleteRolePermission_Click(object sender, EventArgs e)
    {
        if (!long.TryParse(ComRole.SelectedValue?.ToString(), out var roleId))
            return;

        var selectedItems = dataGridView1.GetCheckedRows<RolePermissionQr>(DataGridViewExtension.Select);

        var items = selectedItems.Where(c => c.PermissionId != 0).Select(c => c.PermissionId);

        new HttpService().Delete("Role/DeletePermissionToRole", new DeletePermissionToRoleCommand
        {
            RoleId = roleId,
            AppId = _appId,
            PermissionIds = items
        });
        LoadRolePermission();
    }
}