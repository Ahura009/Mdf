using Client.Infra;
using Mdf.Application.Command.Identity.Users.DeleteUserRole;
using Mdf.Application.Query.Identity.User.CommonResult;
using Mdf.Application.Query.Identity.User.GetUser;
using Mdf.Application.Query.Identity.User.GetUserRole;

namespace Client.Forms.Common.Identity.Users.UserRole;

public partial class FrmUserRoleList : Form
{
    private readonly int _appId;

    public FrmUserRoleList(int appId, string description)
    {
        _appId = appId;
        InitializeComponent();
        LoadData();
        LoadUserRole();
        label1.Text = description;
    }

    public void LoadUserRole()
    {
        var loadData = new HttpService().GetData<List<UserRoleQr>, GetUserRoleQuery>("User/GetUserRole",
            new GetUserRoleQuery
            {
                UserId = GetUserId()
            });
        dataGridView1.Columns.CreateCheckBoxColumn(DataGridViewExtension.Select, "انتخاب");
        dataGridView1.BindingSource(loadData.Data!);
        dataGridView1.Columns.CreateTextBoxColumn("UserName", "نام کاربر");
        dataGridView1.Columns.CreateTextBoxColumn("RoleName", "نام نقش");
    }

    private void MenuUserRole_Click(object sender, EventArgs e)
    {
        var userId = long.Parse(ComUser.SelectedValue!.ToString()!);
        var userName = ComUser.Text!;
        var dialog = new FrmUserRoleSave(userId, _appId, userName);
        dialog.DataChanged += ChildForm_DataChanged!;
        dialog.ShowDialog();
    }


    private void ChildForm_DataChanged(object sender, EventArgs e)
    {
        LoadUserRole();
    }

    public void LoadData()
    {
        var loadData = new HttpService().GetData<List<UserQr>, GetUserQuery>("User/GetUser", new GetUserQuery
        {
            AppId = _appId
        });
        new ComboBoxHelper().BindData(ComUser, loadData.Data, "Username", "Id");
    }


    private void ComUser_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadUserRole();
        var loadData = new HttpService().GetData<List<UserRoleQr>, GetUserRoleQuery>("User/GetUserRole",
            new GetUserRoleQuery
            {
                UserId = GetUserId()
            });
    }


    private long GetUserId()
    {
        if (string.IsNullOrEmpty(ComUser.SelectedValue?.ToString()))
            return 0;

        return long.Parse(ComUser.SelectedValue.ToString() ?? string.Empty);
    }


    private void DeleteUserRole_Click(object sender, EventArgs e)
    {
        var selectedItems = dataGridView1.GetCheckedRows<UserRoleQr>(DataGridViewExtension.Select);

        var items = selectedItems.Where(c => c.RoleId != 0).Select(c => c.RoleId);


        var deleteRole = new DeleteUserRoleCommand
        {
            UserId = GetUserId(),
            RoleIds = items
        };

        new HttpService().Delete("User/DeleteUserRole", deleteRole);
        LoadUserRole();
    }
}