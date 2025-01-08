using Client.Infra;
using Mdf.Application.Command.BasicInfo.Provinces.Create;
using Mdf.Application.Command.BasicInfo.Provinces.Update;
using Mdf.Application.Query.BasicInfo.Provinces.CommonResult;
using Mdf.Application.Query.BasicInfo.Provinces.GetProvinceById;

namespace Client.Forms.Common.BasicInfo.Provinces;

public partial class FrmProvinceSave : Form
{
    private readonly int _countryId;
    private readonly int _provinceId;

    public FrmProvinceSave(int countryId, int provinceId)
    {
        _countryId = countryId;
        _provinceId = provinceId;
        InitializeComponent();
        if (provinceId != 0)
            GetProvince(provinceId);
    }

    public event EventHandler DataChanged;

    private void GetProvince(int provinceId)
    {
        var data = new HttpService().GetData<ProvinceQr, GetProvinceByIdQuery>("Province/GetProvinceById",
            new GetProvinceByIdQuery
            {
                Id = provinceId
            });
        TxtProvince.Text = data.Data?.Name;
    }


    private void SaveProvince_Click(object sender, EventArgs e)
    {
        if (_provinceId == 0)
            CreateProvince();
        else
            UpdateProvince();
        Close();
    }


    private void CreateProvince()
    {
        var data = new CreateProvinceCommand
        {
            Name = TxtProvince.Text,
            CountryId = _countryId
        };
        var result = new HttpService().Post("Province/CreateProvince", data);

        new ExceptionResult().ExceptionCommandResult(result);
    }

    private void UpdateProvince()
    {
        var data = new UpdateProvinceCommand
        {
            Name = TxtProvince.Text,
            Id = _provinceId,
            CountryId = _countryId
        };
        var result = new HttpService().Put("Province/UpdateProvince", data);

        new ExceptionResult().ExceptionCommandResult(result);
    }


    private void FrmProvinceSave_FormClosed(object sender, FormClosedEventArgs e)
    {
        DataChanged?.Invoke(this, EventArgs.Empty);
    }
}