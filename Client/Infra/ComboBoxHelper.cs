using Ahura.Platform.Application.Query.Base;

namespace Client.Infra;

public class ComboBoxHelper
{
    public void BindData<T>(ComboBox comboBox, QueryResult<T> loadData, string displayMember, string valueMember)
    {
        comboBox.DisplayMember = displayMember;
        comboBox.ValueMember = valueMember;
        comboBox.DataSource = loadData.Data;
    }

    public void BindData<T>(ComboBox comboBox, List<T> loadData, string displayMember, string valueMember)
    {
        comboBox.DisplayMember = displayMember;
        comboBox.ValueMember = valueMember;
        comboBox.DataSource = loadData;
    }
}