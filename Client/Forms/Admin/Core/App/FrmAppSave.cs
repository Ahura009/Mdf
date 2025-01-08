using Client.Infra;
using Mdf.Application.Command.Core.Apps.Create;
using Mdf.Application.Query.BasicInfo.Cities.CommonResult;
using Mdf.Application.Query.BasicInfo.Cities.GetCity;
using Mdf.Application.Query.BasicInfo.Countries.CommonResult;
using Mdf.Application.Query.BasicInfo.Countries.GetCountry;
using Mdf.Application.Query.BasicInfo.Provinces.CommonResult;
using Mdf.Application.Query.BasicInfo.Provinces.GetProvince;
using Mdf.Application.Query.Core.App.GetApp;

namespace Client.Forms.Admin.Core.App;

public partial class FrmAppSave : Form
{
    private readonly FrmAppList _frmAppList;

    public FrmAppSave(FrmAppList frmAppList)
    {
        _frmAppList = frmAppList;
        InitializeComponent();
        LoadCountry();
    }

    private void LoadCountry()
    {
        ComExpired.Items.Add("1");
        ComExpired.Items.Add("2");
        ComExpired.Items.Add("3");
        ComExpired.Items.Add("4");
        ComExpired.Items.Add("5");
        ComExpired.Items.Add("6");
        ComExpired.Items.Add("7");
        ComExpired.Items.Add("8");
        ComExpired.Items.Add("9");
        ComExpired.Items.Add("10");
        ComExpired.Items.Add("11");
        ComExpired.Items.Add("12");

        ComExpired.SelectedIndex = 0;

        var loadData =
            new HttpService().GetData<List<CountryQr>, GetCountryQuery>("Country/GetCountry", new GetCountryQuery());
        new ComboBoxHelper().BindData(ComCountry, loadData, "Name", "Id");
    }

    private void ComCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        var countryId = (int)ComCountry.SelectedValue!;

        if (countryId == 0)
            return;

        var loadData = new HttpService().GetData<List<ProvinceQr>, GetProvinceQuery>("Province/GetProvince",
            new GetProvinceQuery
            {
                CountryId = countryId
            });
        new ComboBoxHelper().BindData(ComProvince, loadData, "Name", "Id");
    }

    private void ComProvince_SelectedIndexChanged(object sender, EventArgs e)
    {
        var provinceId = (int)ComProvince.SelectedValue!;

        if (provinceId == 0)
            return;

        var loadData = new HttpService().GetData<List<CityQr>, GetCityQuery>("City/GetCity", new GetCityQuery
        {
            ProvinceId = provinceId
        });
        new ComboBoxHelper().BindData(ComCity, loadData, "Name", "Id");
    }

    private void BtnCreateUser_Click(object sender, EventArgs e)
    {
        var data = new CreateAppCommand
        {
            Name = TxtName.Text,
            OwnerName = TxtOwnerName.Text,
            Mobile = TxtMobile.Text,
            Telephone = TxtTelephone.Text,
            Address = TxtAddress.Text,
            ExpireTime = DateTime.Now.AddMonths(int.Parse(ComExpired.SelectedItem!.ToString()!)),
            CityId = (int)ComCity.SelectedValue!
        };

        var result = new HttpService().Post("App/CreateApp", data);
        new ExceptionResult().ExceptionCommandResult(result);
        Close();
    }

    private void FrmAppSave_FormClosed(object sender, FormClosedEventArgs e)
    {
        _frmAppList.LoadApp(new GetAppQuery());
    }
}