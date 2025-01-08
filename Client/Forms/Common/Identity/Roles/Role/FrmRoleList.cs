using Ahura.Platform.Application.Query.Base;
using Client.Infra;
using Mdf.Application.Command.Identity.Roles.Delete;
using Mdf.Application.Query.Identity.Roles.GetRole;

namespace Client.Forms.Common.Identity.Roles.Role;

public partial class FrmRoleList : Form
{
    private readonly int _appId;

    public FrmRoleList(int appId, string description)
    {
        _appId = appId;
        InitializeComponent();
        LoadRole();
        label1.Text = description;
    }

    public void LoadRole()
    {
        var loadData = new HttpService().GetData<List<RoleQr>, GetRoleQuery>("Role/GetRole", new GetRoleQuery
        {
            AppId = _appId
        });
        BindGrid(loadData);
    }

    private void BindGrid(QueryResult<List<RoleQr>> roles)
    {
        dataGridView1.Columns.CreateCheckBoxColumn(DataGridViewExtension.Select, "انتخاب");
        dataGridView1.BindingSource(roles.Data);
        dataGridView1.Columns.CreateTextBoxColumn("Id", "شناسه");
        dataGridView1.Columns.CreateTextBoxColumn("Name", "نام کارگاه");
    }

    private void MenuRole_Click(object sender, EventArgs e)
    {
        var dialog = new FrmRoleSave(_appId);
        dialog.DataChanged += ChildForm_DataChanged!;
        dialog.ShowDialog();
    }


    private void ChildForm_DataChanged(object sender, EventArgs e)
    {
        LoadRole();
    }

    private void DeleteRole_Click(object sender, EventArgs e)
    {
        var selectedItems = dataGridView1.GetCheckedRows<RoleQr>(DataGridViewExtension.Select);

        var item = selectedItems.Where(c => c.Id != 0).Select(c => c.Id).FirstOrDefault();

        var deleteRole = new DeleteRoleCommand
        {
            Id = item,
            AppId = _appId
        };

        new HttpService().Delete("Role/DeleteRole", deleteRole);
        LoadRole();
    }
}