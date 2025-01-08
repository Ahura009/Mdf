using Client.Infra;
using Mdf.Application.Command.Core.Apps.DeleteAppPermission;
using Mdf.Application.Query.Core.App.GetAppPermission;

namespace Client.Forms.Admin.Core.AppPermission;

public partial class FrmAppPermissionList : Form
{
    private readonly int _appId;

    public FrmAppPermissionList(int appId, string description)
    {
        _appId = appId;
        InitializeComponent();
        LoadUser();
        label1.Text = description;
    }

    public void LoadUser()
    {
        var loadData = new HttpService().GetData<List<AppPermissionQr>, GetAppPermissionQuery>("App/GetAppPermission",
            new GetAppPermissionQuery
            {
                AppId = _appId
            });
        dataGridView1.Columns.CreateCheckBoxColumn(DataGridViewExtension.Select, "انتخاب");
        dataGridView1.BindingSource(loadData.Data!);
        dataGridView1.Columns.CreateTextBoxColumn("Id", "شناسه", 70);
        dataGridView1.Columns.CreateTextBoxColumn("AppName", "نوع فرمان");
        dataGridView1.Columns.CreateTextBoxColumn("PermissionName", "نام مجوز", 300);
    }

    private void MenuAppPermissionSave_Click(object sender, EventArgs e)
    {
        var dialog = new FrmAppPermissionSave(_appId);
        dialog.DataChanged += ChildForm_DataChanged!;
        dialog.ShowDialog();
    }

    private void ChildForm_DataChanged(object sender, EventArgs e)
    {
        LoadUser();
    }

    private void MenuAppPermissionDelete_Click(object sender, EventArgs e)
    {
        var selectedItems = dataGridView1.GetCheckedRows<AppPermissionQr>(DataGridViewExtension.Select);

        var items = selectedItems.Where(c => c.Id != 0).Select(c => c.Id);

        var result = new HttpService().Post("App/DeleteAppPermission", new DeleteAppPermissionCommand
        {
            AppId = _appId,
            PermissionId = items
        });

        new ExceptionResult().ExceptionCommandResult(result);
        LoadUser();
    }
}