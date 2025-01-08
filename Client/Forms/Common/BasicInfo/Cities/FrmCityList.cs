using Client.Infra;
using Mdf.Application.Command.BasicInfo.Cities.Delete;
using Mdf.Application.Query.BasicInfo.Cities.CommonResult;
using Mdf.Application.Query.BasicInfo.Cities.GetCity;
using Mdf.Application.Query.BasicInfo.Countries.CommonResult;
using Mdf.Application.Query.BasicInfo.Countries.GetCountry;
using Mdf.Application.Query.BasicInfo.Provinces.CommonResult;
using Mdf.Application.Query.BasicInfo.Provinces.GetProvince;

namespace Client.Forms.Common.BasicInfo.Cities;

public partial class FrmCityList : Form
{
    public FrmCityList()
    {
        InitializeComponent();
        LoadCountry();
        LoadCity();
    }

    private void LoadCountry()
    {
        var loadData =
            new HttpService().GetData<List<CountryQr>, GetCountryQuery>("Country/GetCountry", new GetCountryQuery());
        new ComboBoxHelper().BindData(ComCountry, loadData, "Name", "Id");
        LoadProvince();
    }

    private void LoadProvince()
    {
        if (!int.TryParse(ComCountry.SelectedValue!.ToString(), out var countryId))
            return;

        var loadData = new HttpService().GetData<List<ProvinceQr>, GetProvinceQuery>("Province/GetProvince",
            new GetProvinceQuery
            {
                CountryId = countryId
            });
        new ComboBoxHelper().BindData(ComProvince, loadData, "Name", "Id");
    }


    private void SaveCountry_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(ComProvince.SelectedValue!.ToString(), out var provinceId))
            return;

        var frm = new FrmCitySave(0, provinceId);
        frm.DataChanged += ChildForm_DataChanged!;
        frm.ShowDialog();
        LoadCity();
    }

    private void ChildForm_DataChanged(object sender, EventArgs e)
    {
        LoadCity();
    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {
        LoadCity();
    }

    private void BtnDeleteCity_Click(object sender, EventArgs e)
    {
        var selectedItems = dataGridView1.GetCheckedRows<CityQr>(DataGridViewExtension.Select);

        var item = selectedItems.Where(c => c.Id != 0).Select(c => c.Id).FirstOrDefault();

        var deleteRole = new DeleteCityCommand
        {
            Id = item
        };

        new HttpService().Delete("City/DeleteCity", deleteRole);
        LoadCity();
    }

    private void ComProvince_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadCity();
    }


    private void LoadCity()
    {
        if (!int.TryParse(ComProvince.SelectedValue!.ToString(), out var provinceId)) return;

        var loadData = new HttpService().GetData<List<CityQr>, GetCityQuery>("City/GetCity", new GetCityQuery
        {
            ProvinceId = provinceId,
            Name = textBox1.Text
        });

        dataGridView1.Columns.CreateCheckBoxColumn(DataGridViewExtension.Select, "انتخاب");
        dataGridView1.BindingSource(loadData.Data!);
        dataGridView1.Columns.CreateTextBoxColumn("Id", "شناسه شهر");
        dataGridView1.Columns.CreateTextBoxColumn("Name", "نام شهر");
        dataGridView1.Columns.CreateButtonColumn(DataGridViewExtension.UpdateCity, "ویرایش ");
    }


    private void ComCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadProvince();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1)
            return;

        if (e.RowIndex + 1 >= dataGridView1.Rows.Count)
            return;


        if (!int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), out var cityId))
            return;


        if (!int.TryParse(ComProvince.SelectedValue!.ToString(), out var provinceId))
            return;


        if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns[DataGridViewExtension.UpdateCity]!.Index)
        {
            var dialog = new FrmCitySave(cityId, provinceId);
            dialog.DataChanged += ChildForm_DataChanged!;
            dialog.ShowDialog();
        }
    }
}