using Client.Infra;
using Mdf.Application.Command.BasicInfo.Translations.UpdateCache;
using Mdf.Application.Query.BasicInfo.Translations.GetTranslation;

namespace Client.Forms.Admin.Language;

public partial class FrmLanguageList : Form
{
    public FrmLanguageList()
    {
        InitializeComponent();

        LoadLanguage();
    }

    private void LoadLanguage()
    {
        var languages = new List<KeyValuePair<byte, string>>
        {
            new(10, ""),
            new((byte)Mdf.Core.Enum.Language.Fa, Mdf.Core.Enum.Language.Fa.ToString()),
            new((byte)Mdf.Core.Enum.Language.En, Mdf.Core.Enum.Language.En.ToString())
        };
        ComLanguage.DataSource = languages;
        ComLanguage.DisplayMember = "Value";
        ComLanguage.ValueMember = "Key";
    }

    private void TxtKey_TextChanged(object sender, EventArgs e)
    {
        LoadLanguageData();
    }

    private void TxtValue_TextChanged(object sender, EventArgs e)
    {
        LoadLanguageData();
    }

    private void ComLanguage_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadLanguageData();
    }

    private void ChildForm_DataChanged(object sender, EventArgs e)
    {
        LoadLanguageData();
    }

    private void LoadLanguageData()
    {
        Mdf.Core.Enum.Language? languageSearch = null;

        if (byte.TryParse(ComLanguage.SelectedValue?.ToString(), out var languageValue) && languageValue != 10)
            languageSearch = (Mdf.Core.Enum.Language)languageValue;

        var loadData = new HttpService().GetData<List<TranslateQr>, GetTranslationQuery>("Translation/GetTranslation",
            new GetTranslationQuery
            {
                Language = languageSearch.ToString(),
                Key = TxtKey.Text,
                Value = TxtValue.Text
            });

        dataGridView1.BindingSource(loadData.Data!);
        dataGridView1.Columns.CreateTextBoxColumn("Id", "شناسه", 70);
        dataGridView1.Columns.CreateTextBoxColumn("Language", "زبان", 70);
        dataGridView1.Columns.CreateTextBoxColumn("Key", "کلید", 300);
        dataGridView1.Columns.CreateTextBoxColumn("Value", "مقدار", 380);
        dataGridView1.Columns.CreateButtonColumn(DataGridViewExtension.UpdateTranslation, "ویرایش کلید", 90);
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1)
            return;

        if (e.RowIndex + 1 >= dataGridView1.Rows.Count)
            return;

        if (!int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out var id))
            return;

        if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns[DataGridViewExtension.UpdateTranslation]!.Index)
        {
            var dialog = new FrmLanguageSave(id);
            dialog.DataChanged += ChildForm_DataChanged!;
            dialog.ShowDialog();
        }
    }

    private void BtnLoadCachce_Click(object sender, EventArgs e)
    {
        var result = new HttpService().Put("Translation/UpdateTranslationCache", new UpdateTranslationCacheCommand());

        new ExceptionResult().ExceptionCommandResult(result);
        LoadLanguageData();
    }
}