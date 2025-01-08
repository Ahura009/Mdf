using Client.Infra;
using Mdf.Application.Command.BasicInfo.Translations.Update;
using Mdf.Application.Query.BasicInfo.Translations.GetTranslationById;

namespace Client.Forms.Admin.Language;

public partial class FrmLanguageSave : Form
{
    private readonly int _translationId;

    public FrmLanguageSave(int translationId)
    {
        _translationId = translationId;
        InitializeComponent();

        LoadTranslate();
    }

    public event EventHandler DataChanged;

    private void LoadTranslate()
    {
        var loadData =
            new HttpService().GetData<string, GetTranslationByIdQuery>("Translation/GetTranslationById",
                new GetTranslationByIdQuery
                {
                    Id = _translationId
                });
        textBox1.Text = loadData.Data;
    }


    private void BtnSave_Click(object sender, EventArgs e)
    {
        var data = new UpdateTranslationCommand
        {
            Id = _translationId,
            Value = textBox1.Text
        };

        var result = new HttpService().Put("Translation/UpdateTranslation", data);
        new ExceptionResult().ExceptionCommandResult(result);


        Close();
    }

    private void FrmLanguageSave_FormClosed(object sender, FormClosedEventArgs e)
    {
        DataChanged?.Invoke(this, EventArgs.Empty);
    }
}