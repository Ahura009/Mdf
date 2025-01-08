using Ahura.Platform.Application.Query.Base;
using Client.Infra;
using Mdf.Application.Command.Identity.Users.Delete;
using Mdf.Application.Query.Identity.User.CommonResult;
using Mdf.Application.Query.Identity.User.GetUser;

namespace Client.Forms.Common.Identity.Users.User;

public partial class FrmUserList : Form
{
    private readonly int _appId;

    public FrmUserList(int appId, string description)
    {
        _appId = appId;
        InitializeComponent();
        LoadUser();
        label1.Text = description;
    }

    public void LoadUser()
    {
        var loadData = new HttpService().GetData<List<UserQr>, GetUserQuery>("User/GetUser", new GetUserQuery
        {
            AppId = _appId
        });
        BindGrid(loadData);
    }

    private void BindGrid(QueryResult<List<UserQr>> users)
    {
        dataGridView1.Columns.CreateCheckBoxColumn(DataGridViewExtension.Select, "انتخاب");
        dataGridView1.BindingSource(users.Data);
        dataGridView1.Columns.CreateTextBoxColumn("Id", "شناسه", 100);
        dataGridView1.Columns.CreateTextBoxColumn("Username", "نام کاربری");
        dataGridView1.Columns.CreateTextBoxColumn("Email", "ایمیل");
        dataGridView1.Columns.CreateTextBoxColumn("PhoneNumber", "تلفن");
    }

    private void MenuUser_Click(object sender, EventArgs e)
    {
        var dialog = new FrmUserSave(_appId);
        dialog.DataChanged += ChildForm_DataChanged!;
        dialog.ShowDialog();
    }

    private void ChildForm_DataChanged(object sender, EventArgs e)
    {
        LoadUser();
    }

    private void DeleteUser_Click(object sender, EventArgs e)
    {
        var selectedItems = dataGridView1.GetCheckedRows<UserQr>(DataGridViewExtension.Select);

        var items = selectedItems.Where(c => c.Id != 0).Select(c => c.Id).FirstOrDefault();


        var deleteRole = new DeleteUserCommand
        {
            UserId = items
        };

        new HttpService().Delete("User/DeleteUser", deleteRole);
        LoadUser();
    }
}