using Client.Infra;
using Mdf.Application.Command.BasicInfo.Cities.Create;
using Mdf.Application.Command.BasicInfo.Cities.Update;
using Mdf.Application.Query.BasicInfo.Cities.CommonResult;
using Mdf.Application.Query.BasicInfo.Cities.GetCityById;

namespace Client.Forms.Common.BasicInfo.Cities;

public partial class FrmCitySave : Form
{
    private readonly int _cityId;
    private readonly int _provinceId;

    public FrmCitySave(int cityId, int provinceId)
    {
        _cityId = cityId;
        _provinceId = provinceId;
        InitializeComponent();


        if (_cityId != 0)
            GetCity(_cityId);
    }

    public event EventHandler DataChanged;

    private void FrmCitySave_FormClosed(object sender, FormClosedEventArgs e)
    {
        DataChanged?.Invoke(this, EventArgs.Empty);
    }

    private void SaveCity_Click(object sender, EventArgs e)
    {
        if (_cityId == 0)
            CreateCity();
        else
            UpdateProvince();
        Close();
    }


    private void GetCity(int cityId)
    {
        var data = new HttpService().GetData<CityQr, GetCityByIdQuery>("City/GetCityById", new GetCityByIdQuery
        {
            Id = cityId
        });
        TxtCity.Text = data.Data?.Name;
    }

    private void CreateCity()
    {
        var data = new CreateCityCommand
        {
            Name = TxtCity.Text,
            ProvinceId = _provinceId
        };
        var result = new HttpService().Post("City/CreateCity", data);

        new ExceptionResult().ExceptionCommandResult(result);
    }

    private void UpdateProvince()
    {
        var data = new UpdateCityCommand
        {
            Name = TxtCity.Text,
            Id = _cityId,
            ProvinceId = _provinceId
        };
        var result = new HttpService().Put("City/UpdateCity", data);
        new ExceptionResult().ExceptionCommandResult(result);
    }
}