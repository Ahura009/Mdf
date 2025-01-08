using Client.Forms.Common.BasicInfo.Cities;
using Client.Forms.Common.BasicInfo.Countries;
using Client.Forms.Common.BasicInfo.Provinces;
using Client.Forms.Common.Identity.Roles.Role;
using Client.Forms.Common.Identity.Roles.RolePermission;
using Client.Forms.Common.Identity.Users.User;
using Client.Forms.Common.Identity.Users.UserRole;
using Client.Forms.Common.Identity.Users.UserSetting;

namespace Client.Forms.Users;

public partial class FrmUserHome : Form
{
    private readonly int _appId;
    private readonly long _userId;

    public FrmUserHome(int appId, long userId)
    {
        _appId = appId;
        _userId = userId;
        InitializeComponent();
    }

    private void BtnUser_Click(object sender, EventArgs e)
    {
        var userList = new FrmUserList(_appId, "");
        userList.ShowDialog();
    }

    private void BtnRole_Click(object sender, EventArgs e)
    {
        var role = new FrmRoleList(_appId, "");
        role.ShowDialog();
    }

    private void BtnRolePermission_Click(object sender, EventArgs e)
    {
        var rolePermission = new FrmRolePermissionList(_appId, "");
        rolePermission.ShowDialog();
    }

    private void BtnUserRole_Click(object sender, EventArgs e)
    {
        var userRole = new FrmUserRoleList(_appId, "");
        userRole.ShowDialog();
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

    private void BtnCountry_Click(object sender, EventArgs e)
    {
        var frm = new FrmCountryList();
        frm.ShowDialog();
    }

    private void BtnUserSetting_Click(object sender, EventArgs e)
    {
        new FrmUserSetting(_userId).ShowDialog();
    }
}