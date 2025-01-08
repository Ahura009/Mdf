using Ahura.Platform.Application.Query.Common;
using Client.Infra;
using Mdf.Application.Command.BasicInfo.Provinces.Delete;
using Mdf.Application.Query.BasicInfo.Countries.CommonResult;
using Mdf.Application.Query.BasicInfo.Countries.GetCountry;
using Mdf.Application.Query.BasicInfo.Provinces.CommonResult;
using Mdf.Application.Query.BasicInfo.Provinces.GetProvince;

namespace Client.Forms.Common.BasicInfo.Provinces;

public partial class FrmProvinceList : Form
{
    public FrmProvinceList()
    {
        InitializeComponent();
        LoadCountry();
        LoadProvince();
    }

    private void LoadCountry()
    {
        var loadData =
            new HttpService().GetData<List<CountryQr>, GetCountryQuery>("Country/GetCountry", new GetCountryQuery());
        new ComboBoxHelper().BindData(ComCountry, loadData, "Name", "Id");
    }

    private void LoadProvince()
    {
        if (!int.TryParse(ComCountry.SelectedValue!.ToString(), out var countryId)) return;

        var loadData = new HttpService().GetData<List<ProvinceQr>, GetProvinceQuery>("Province/GetProvince",
            new GetProvinceQuery
            {
                CountryId = countryId,
                Name = textBox1.Text
            });

        dataGridView1.Columns.CreateCheckBoxColumn(DataGridViewExtension.Select, "انتخاب");
        dataGridView1.BindingSource(loadData.Data!);
        dataGridView1.Columns.CreateTextBoxColumn("Name", "نام استان");
        dataGridView1.Columns.CreateButtonColumn(DataGridViewExtension.UpdateProvince, "ویرایش ");
    }

    private void SaveCountry_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(ComCountry.SelectedValue!.ToString(), out var countryId))
            return;

        var frm = new FrmProvinceSave(countryId, 0);
        frm.DataChanged += ChildForm_DataChanged!;
        frm.ShowDialog();
        LoadProvince();
    }

    private void ChildForm_DataChanged(object sender, EventArgs e)
    {
        LoadProvince();
    }


    private void ComCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!int.TryParse(ComCountry.SelectedValue!.ToString(), out var countryId))
            return;


        var loadData = new HttpService().GetData<List<ProvinceQr>, GetProvinceQuery>("Province/GetProvince",
            new GetProvinceQuery
            {
                CountryId = countryId,
                Name = textBox1.Text
            });

        if (loadData.Status == ApplicationServiceStatus.Ok)
        {
            dataGridView1.Columns.CreateCheckBoxColumn(DataGridViewExtension.Select, "انتخاب");
            dataGridView1.BindingSource(loadData.Data!);
            dataGridView1.Columns.CreateTextBoxColumn("Id", "شناسه استان");
            dataGridView1.Columns.CreateTextBoxColumn("Name", "نام کشور ");
            dataGridView1.Columns.CreateButtonColumn(DataGridViewExtension.UpdateProvince, "ویرایش");
        }
        else
        {
            new ExceptionResult().ExceptionQueryResult(loadData);
        }
    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {
        LoadProvince();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1)
            return;

        if (e.RowIndex + 1 >= dataGridView1.Rows.Count)
            return;


        if (!int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), out var provinceId))
            return;


        if (!int.TryParse(ComCountry.SelectedValue!.ToString(), out var countryId))
            return;


        if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns[DataGridViewExtension.UpdateProvince]!.Index)
        {
            var dialog = new FrmProvinceSave(countryId, provinceId);
            dialog.DataChanged += ChildForm_DataChanged!;
            dialog.ShowDialog();
        }
    }

    private void BtnDeleteProvince_Click(object sender, EventArgs e)
    {
        var selectedItems = dataGridView1.GetCheckedRows<ProvinceQr>(DataGridViewExtension.Select);

        var items = selectedItems.Where(c => c.Id != 0).Select(c => c.Id).FirstOrDefault();


        var deleteRole = new DeleteProvinceCommand
        {
            Id = items
        };

        new HttpService().Delete("Province/DeleteProvince", deleteRole);
        LoadCountry();
    }
}