using Client.Forms.Admin.Core.App;
using Client.Forms.Admin.Language;
using Client.Forms.Common.BasicInfo.Cities;
using Client.Forms.Common.BasicInfo.Countries;
using Client.Forms.Common.BasicInfo.Provinces;
using Client.Forms.Common.Identity.Users.UserSetting;

namespace Client.Forms.Admin;

public partial class FrmHome : Form
{
    private readonly int _appId;
    private readonly long _userId;

    public FrmHome(int appId, long userId)
    {
        _appId = appId;
        _userId = userId;
        InitializeComponent();
    }

    private void MenuApp_Click(object sender, EventArgs e)
    {
        var app = new FrmAppList();
        app.Show();
    }

    private void BtnCountry_Click(object sender, EventArgs e)
    {
        var frm = new FrmCountryList();
        frm.ShowDialog();
    }

    private void BtnCity_Click(object sender, EventArgs e)
    {
        var frm = new FrmCityList();
        frm.ShowDialog();
    }

    private void BtnProvince_Click(object sender, EventArgs e)
    {
        var frm = new FrmProvinceList();
        frm.ShowDialog();
    }

    private void BtnUserSetting_Click(object sender, EventArgs e)
    {
        new FrmUserSetting(_userId).ShowDialog();
    }

    private void BtnLanguage_Click(object sender, EventArgs e)
    {
        new FrmLanguageList().ShowDialog();
    }
}