using Client.Infra;
using Mdf.Application.Command.Core.Apps.CreateAppPermission;
using Mdf.Application.Query.Identity.Permissions.GetPermission;
using Mdf.Core.Const;

namespace Client.Forms.Admin.Core.AppPermission;

public partial class FrmAppPermissionSave : Form
{
    private readonly int _appId;

    public FrmAppPermissionSave(int appId)
    {
        _appId = appId;
        InitializeComponent();
        BindDropDown();
        LoadUser(null, null);
    }

    private void BindDropDown()
    {
        var messageType = new List<KeyValuePair<byte, string>>
        {
            new(10, ""),
            new((byte)RequestType.Query, RequestType.Query.ToString()),
            new((byte)RequestType.Command, RequestType.Command.ToString()),
            new((byte)RequestType.Menu, RequestType.Menu.ToString())
        };
        ComMessageType.DataSource = messageType;
        ComMessageType.DisplayMember = "Value";
        ComMessageType.ValueMember = "Key";
    }

    public event EventHandler DataChanged;


    public void LoadUser(string? request, RequestType? requestType)
    {
        var loadData = new HttpService().GetData<List<PermissionQr>, GetPermissionQuery>("Permission/GetPermission",
            new GetPermissionQuery { RequestType = requestType, Name = request });
        dataGridView1.Columns.CreateCheckBoxColumn(DataGridViewExtension.Select, "انتخاب");
        dataGridView1.BindingSource(loadData.Data!);
        dataGridView1.Columns.CreateTextBoxColumn("Id", "شناسه", 70);
        dataGridView1.Columns.CreateTextBoxColumn("RequestType", "نوع فرمان", 120);
        dataGridView1.Columns.CreateTextBoxColumn("Name", "نوع فرمان", 260);
        dataGridView1.Columns.CreateTextBoxColumn("Description", "توضیحات", 260);
    }

    private void MenuAppPermissionSave_Click(object sender, EventArgs e)
    {
        var selectedItems = dataGridView1.GetCheckedRows<PermissionQr>(DataGridViewExtension.Select);

        var items = selectedItems.Where(c => c.Id != 0).Select(c => c.Id);

        var result = new HttpService().Post("App/CreateAppPermission", new CreateAppPermissionCommand
        {
            AppId = _appId,
            PermissionId = items
        });

        new ExceptionResult().ExceptionCommandResult(result);
        Close();
    }

    private void FrmAppPermissionSave_FormClosed(object sender, FormClosedEventArgs e)
    {
        DataChanged?.Invoke(this, EventArgs.Empty);
    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {
        RequestType? request = null;

        if (byte.TryParse(ComMessageType.SelectedValue?.ToString(), out var requestTypeValue) && requestTypeValue != 10)
            request = (RequestType)requestTypeValue;

        LoadUser(TxtMessage.Text, request);
    }
}