using Client.Infra;
using Mdf.Application.Command.BasicInfo.Countries.Create;
using Mdf.Application.Command.BasicInfo.Countries.Update;
using Mdf.Application.Query.BasicInfo.Countries.CommonResult;
using Mdf.Application.Query.BasicInfo.Countries.GetCountryById;

namespace Client.Forms.Common.BasicInfo.Countries;

public partial class FrmCountrySave : Form
{
    private readonly int _countryId;

    public FrmCountrySave(int countryId)
    {
        _countryId = countryId;
        InitializeComponent();

        if (_countryId != 0)
            GetCountry(_countryId);
    }

    public event EventHandler DataChanged;

    private void SaveCountry_Click(object sender, EventArgs e)
    {
        if (_countryId == 0)
            CreateCountry();
        else
            UpdateCountry();
        Close();
    }

    private void GetCountry(int countryId)
    {
        var data = new HttpService().GetData<CountryQr, GetCountryByIdQuery>("Country/GetCountryById",
            new GetCountryByIdQuery
            {
                Id = countryId
            });
        TxtCountry.Text = data.Data?.Name;
    }

    private void CreateCountry()
    {
        var data = new CreateCountryCommand
        {
            Name = TxtCountry.Text
        };
        var result = new HttpService().Post("Country/CreateCountry", data);

        new ExceptionResult().ExceptionCommandResult(result);
    }

    private void UpdateCountry()
    {
        var data = new UpdateCountryCommand
        {
            Name = TxtCountry.Text,
            Id = _countryId
        };
        var result = new HttpService().Put("Country/UpdateCountry", data);
        new ExceptionResult().ExceptionCommandResult(result);
    }

    private void FrmCountrySave_FormClosed(object sender, FormClosedEventArgs e)
    {
        DataChanged?.Invoke(this, EventArgs.Empty);
    }
}