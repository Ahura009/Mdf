using Client.Infra;
using Mdf.Application.Command.Identity.Users.UpdateUserSetting;
using Mdf.Application.Query.Identity.User.GetUsetSetting;
using Mdf.Core.Enum;

namespace Client.Forms.Common.Identity.Users.UserSetting;

public partial class FrmUserSetting : Form
{
    private readonly long _userId;

    public FrmUserSetting(long userId)
    {
        _userId = userId;
        InitializeComponent();

        GetUserSetting();
    }

    private void GetUserSetting()
    {
        var loadData = new HttpService().GetData<UserSettingQr, GetUserSettingQuery>("User/GetUserSetting",
            new GetUserSettingQuery
            {
                UserId = _userId
            });

        if (loadData.Data!.Language == Language.En)
            RdEnglish.Checked = true;
        else
            RdFarsi.Checked = true;
    }

    private void BtnCreateUserRole_Click(object sender, EventArgs e)
    {
        if (!RdEnglish.Checked)
        {
            var userRole = new UpdateUserSettingCommand
            {
                Language = Language.Fa
            };
            var result = new HttpService().Put("User/UpdateUserSetting", userRole);
            new ExceptionResult().ExceptionCommandResult(result);
        }
        else
        {
            var userRole = new UpdateUserSettingCommand
            {
                Language = Language.En
            };
            var result = new HttpService().Put("User/UpdateUserSetting", userRole);
            new ExceptionResult().ExceptionCommandResult(result);
        }


        Close();
    }
}