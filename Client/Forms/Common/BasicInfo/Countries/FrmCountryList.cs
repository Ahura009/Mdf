using Client.Infra;
using Mdf.Application.Command.BasicInfo.Countries.Delete;
using Mdf.Application.Query.BasicInfo.Countries.CommonResult;
using Mdf.Application.Query.BasicInfo.Countries.GetCountry;

namespace Client.Forms.Common.BasicInfo.Countries;

public partial class FrmCountryList : Form
{
    public FrmCountryList()
    {
        InitializeComponent();
        LoadCountry();
    }

    private void SaveCountry_Click(object sender, EventArgs e)
    {
        var frm = new FrmCountrySave(0);
        frm.DataChanged += ChildForm_DataChanged!;
        frm.ShowDialog();
        LoadCountry();
    }

    private void ChildForm_DataChanged(object sender, EventArgs e)
    {
        LoadCountry();
    }


    private void LoadCountry()
    {
        var loadData =
            new HttpService().GetData<List<CountryQr>, GetCountryQuery>("Country/GetCountry", new GetCountryQuery());
        dataGridView1.Columns.CreateCheckBoxColumn(DataGridViewExtension.Select, "انتخاب");
        dataGridView1.BindingSource(loadData.Data!);
        dataGridView1.Columns.CreateTextBoxColumn("Id", "شناسه");
        dataGridView1.Columns.CreateTextBoxColumn("Name", "نام کارگاه");
        dataGridView1.Columns.CreateButtonColumn(DataGridViewExtension.CreateCountry, "ویرایش");
    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {
        var loadData = new HttpService().GetData<List<CountryQr>, GetCountryQuery>("Country/GetCountry",
            new GetCountryQuery
            {
                Name = textBox1.Text
            });
        dataGridView1.Columns.CreateCheckBoxColumn(DataGridViewExtension.Select, "انتخاب");
        dataGridView1.BindingSource(loadData.Data!);
        dataGridView1.Columns.CreateTextBoxColumn("Id", "شناسه");
        dataGridView1.Columns.CreateTextBoxColumn("Name", "نام کارگاه");
        dataGridView1.Columns.CreateButtonColumn(DataGridViewExtension.CreateCountry, "ویرایش");
    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
        var selectedItems = dataGridView1.GetCheckedRows<CountryQr>(DataGridViewExtension.Select);

        var item = selectedItems.Where(c => c.Id != 0).Select(c => c.Id).FirstOrDefault();

        var deleteRole = new DeleteCountryCommand
        {
            Id = item
        };

        new HttpService().Delete("Country/DeleteCountry", deleteRole);
        LoadCountry();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1)
            return;

        if (e.RowIndex + 1 >= dataGridView1.Rows.Count)
            return;


        if (!int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), out var countryId))
            return;

        if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns[DataGridViewExtension.CreateCountry]!.Index)
        {
            var dialog = new FrmCountrySave(countryId);
            dialog.DataChanged += ChildForm_DataChanged!;
            dialog.ShowDialog();
        }
    }
}