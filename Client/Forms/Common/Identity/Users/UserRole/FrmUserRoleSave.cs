using Client.Infra;
using Mdf.Application.Command.Identity.Users.CreateUserRole;
using Mdf.Application.Query.Identity.Roles.GetRole;

namespace Client.Forms.Common.Identity.Users.UserRole;

public partial class FrmUserRoleSave : Form
{
    private readonly int _appId;
    private readonly long _userId;

    public FrmUserRoleSave(long userId, int appId, string userName = "")
    {
        _userId = userId;
        _appId = appId;
        InitializeComponent();
        LoadRole();

        if (!string.IsNullOrEmpty(userName)) label1.Text = $@"انتساب نقش به کاربر {userName}";
    }

    public event EventHandler DataChanged;


    private void LoadRole()
    {
        var loadData = new HttpService().GetData<List<RoleQr>, GetRoleQuery>("Role/GetRole", new GetRoleQuery
        {
            AppId = _appId
        });

        dataGridView1.Columns.CreateCheckBoxColumn(DataGridViewExtension.Select, "انتخاب");
        dataGridView1.Columns.CreateTextBoxColumn("Id", "شناسه", 70);
        dataGridView1.Columns.CreateTextBoxColumn("Name", "نام نقش");
        dataGridView1.BindingSource(loadData.Data!);
    }


    private void BtnCreateUserRole_Click(object sender, EventArgs e)
    {
        var selectedItems = dataGridView1.GetCheckedRows<RoleQr>(DataGridViewExtension.Select);

        var items = selectedItems.Where(c => c.Id != 0).Select(c => c.Id);


        var userRole = new CreateUserRoleCommand
        {
            UserId = _userId,
            RoleIds = items
        };

        var result = new HttpService().Post("User/CreateUserRole", userRole);

        new ExceptionResult().ExceptionCommandResult(result);

        Close();
    }

    private void FrmUserRoleSave_FormClosed(object sender, FormClosedEventArgs e)
    {
        DataChanged?.Invoke(this, EventArgs.Empty);
    }
}