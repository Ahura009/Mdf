namespace Client.Infra;

public static class DataGridViewExtension
{
    public static string Select = nameof(Select);
    public static string CreateUser = nameof(CreateUser);
    public static string CreateRole = nameof(CreateRole);
    public static string CreateAppPermission = nameof(CreateAppPermission);


    public static string CreateRolePermission = nameof(CreateRolePermission);
    public static string CreateUserRole = nameof(CreateUserRole);
    public static string CreatePermission = nameof(CreatePermission);

    public static string DeleteBtn = nameof(DeleteBtn);
    public static string CreateCountry = nameof(CreateCountry);
    public static string UpdateProvince = nameof(UpdateProvince);
    public static string CreateProvince = nameof(CreateProvince);
    public static string CreateCity = nameof(CreateCity);
    public static string UpdateCity = nameof(UpdateCity);
    public static string UpdateTranslation = nameof(UpdateTranslation);


    public static void BindingSource<T>(this DataGridView dataGridView, List<T> data)
    {
        dataGridView.AutoGenerateColumns = false;
        var bindingSource = new BindingSource();
        bindingSource.DataSource = data;
        dataGridView.DataSource = bindingSource;
        dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
    }

    public static void CreateButtonColumn(this DataGridViewColumnCollection columns, string id, string name,
        int width = 130)
    {
        var column = columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Name == id);

        if (column is not null)
            return;

        var data = new DataGridViewButtonColumn
        {
            Name = id,
            HeaderText = name,
            Text = name,
            UseColumnTextForButtonValue = true,
            Width = width
        };
        columns.Add(data);
    }


    public static void CreateTextBoxColumn(this DataGridViewColumnCollection columns, string id, string title,
        int width = 220)
    {
        var column = columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.DataPropertyName == id);

        if (column is not null)
            return;

        var newColumn = new DataGridViewTextBoxColumn
        {
            DataPropertyName = id,
            HeaderText = title,
            Width = width,
            ReadOnly = true
        };

        columns.Add(newColumn);
    }


    public static void CreateCheckBoxColumn(this DataGridViewColumnCollection columns, string name, string title,
        int width = 70)
    {
        var column = columns.Cast<DataGridViewColumn>()
            .FirstOrDefault(c => c.DataPropertyName.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (column is not null)
        {
            column.HeaderText = title;
            column.Width = width;
            column.Name = name;
            if (column is DataGridViewCheckBoxColumn checkBoxColumn) checkBoxColumn.ThreeState = false;
            return;
        }

        var newColumn = new DataGridViewCheckBoxColumn
        {
            DataPropertyName = name,
            Name = name,
            HeaderText = title,
            Width = width,
            ThreeState = false
        };

        columns.Add(newColumn);
    }

    public static List<T> GetCheckedRows<T>(this DataGridView dataGridView, string checkBoxColumnName) where T : class
    {
        var checkedRows = new List<T>();
        foreach (DataGridViewRow row in dataGridView.Rows)
        {
            var checkBox = row.Cells[0] as DataGridViewCheckBoxCell;

            if (checkBox!.Value != null && (bool)checkBox.Value)
            {
                checkedRows.Add((row.DataBoundItem as T)!);
            }

            else if (checkBox.Selected)
            {
                var s = (T)row.DataBoundItem;
                if (s is null)
                    continue;

                checkedRows.Add((row.DataBoundItem as T)!);
            }
        }

        return checkedRows;
    }
}