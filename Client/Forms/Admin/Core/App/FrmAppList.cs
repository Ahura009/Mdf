using Ahura.Platform.Application.Query.Base;
using Client.Forms.Admin.Core.AppPermission;
using Client.Forms.Common.Identity.Roles.Role;
using Client.Forms.Common.Identity.Roles.RolePermission;
using Client.Forms.Common.Identity.Users.User;
using Client.Forms.Common.Identity.Users.UserRole;
using Client.Infra;
using Mdf.Application.Query.Core.App.GetApp;

namespace Client.Forms.Admin.Core.App;

public partial class FrmAppList : Form
{
    public FrmAppList()
    {
        InitializeComponent();
        LoadApp(new GetAppQuery());
    }

    private void SaveApp_Click(object sender, EventArgs e)
    {
        var user = new FrmAppSave(this);
        user.ShowDialog();
    }


    public void LoadApp(GetAppQuery query)
    {
        var loadData = new HttpService().GetData<List<AppQr>, GetAppQuery>("App/GetApp", new GetAppQuery());
        BindGrid(loadData);
    }

    private void BindGrid(QueryResult<List<AppQr>> apps)
    {
        dataGridView1.BindingSource(apps.Data!);

        dataGridView1.Columns.CreateTextBoxColumn("Id", "شناسه", 60);
        dataGridView1.Columns.CreateTextBoxColumn("Name", "نام کارگاه");
        dataGridView1.Columns.CreateTextBoxColumn("OwnerName", "نام  مالک");
        //dataGridView1.Columns.CreateTextBoxColumn("Mobile", "موبایل", 100);
        //dataGridView1.Columns.CreateTextBoxColumn("Telephone", "تلفن", 100);
        //dataGridView1.Columns.CreateTextBoxColumn("Address", "آدرس", 200);
        //dataGridView1.Columns.CreateTextBoxColumn("ExpireTime", "انقضا", 100);
        //dataGridView1.Columns.CreateTextBoxColumn("CityName", "شهر", 80);

        dataGridView1.Columns.CreateButtonColumn(DataGridViewExtension.CreateUser, "مدیریت کاربر");
        dataGridView1.Columns.CreateButtonColumn(DataGridViewExtension.CreateRole, " مدیریت نقش");
        dataGridView1.Columns.CreateButtonColumn(DataGridViewExtension.CreateUserRole, "مدیریت نقش به کاربر", 200);
        dataGridView1.Columns.CreateButtonColumn(DataGridViewExtension.CreateRolePermission, "مدیریت مجوزهای نقش", 200);
        dataGridView1.Columns.CreateButtonColumn(DataGridViewExtension.CreateAppPermission, "مدیریت مجوزهای اپ", 200);

        dataGridView1.Refresh();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        var name = string.Empty;
        var ownerName = string.Empty;
        var description = string.Empty;

        if (e.RowIndex == -1)
            return;

        if (e.RowIndex + 1 >= dataGridView1.Rows.Count)
            return;

        if (string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
            return;

        if (!string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()))
            name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        if (!string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()))
            ownerName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(ownerName))
            description = $"در حال انجام عملیات {name} با مدیریت {ownerName} ";


        if (!int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out var appId))
            return;

        if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns[DataGridViewExtension.CreateUser]!.Index)
            new FrmUserList(appId, description).ShowDialog();

        else if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns[DataGridViewExtension.CreateRole]!.Index)
            new FrmRoleList(appId, description).ShowDialog();

        else if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns[DataGridViewExtension.CreateUserRole]!.Index)
            new FrmUserRoleList(appId, description).ShowDialog();
        else if (e.RowIndex >= 0 &&
                 e.ColumnIndex == dataGridView1.Columns[DataGridViewExtension.CreateAppPermission]!.Index)
            new FrmAppPermissionList(appId, description).ShowDialog();
        else if (e.RowIndex >= 0 &&
                 e.ColumnIndex == dataGridView1.Columns[DataGridViewExtension.CreateRolePermission]!.Index)
            new FrmRolePermissionList(appId, description).ShowDialog();
    }
}