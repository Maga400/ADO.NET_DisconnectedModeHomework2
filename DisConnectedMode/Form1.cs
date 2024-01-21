using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DisConnectedMode;

public partial class Form1 : Form
{
    SqlConnection? sqlConnection = null;
    SqlDataAdapter? dataAdapter = null;
    DataSet? dataSet = new DataSet();
    DataTable? dataTable = null;
    public Form1()
    {
        InitializeComponent();
        string connectionStr = @"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=Vehicle;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        
        sqlConnection = new SqlConnection(connectionStr);

    }
    private void btn_fill_Click(object sender, EventArgs e)
    {
        try
        {
            FillTableWithDisconnectedMode();
        }
        catch (Exception ex) 
        {
            MessageBox.Show(ex.Message, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

    private void btn_update_Click(object sender, EventArgs e)
    {
        try
        {
            UpdateTableWithDisconnectedMode();
        }

        catch (Exception ex) 
        {
            MessageBox.Show(ex.Message,"INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }

    public void FillTableWithDisconnectedMode() 
    {
        dataSet = new DataSet();
        string insertQuery = searchTextBox.Text;
        dataAdapter = new SqlDataAdapter(insertQuery, sqlConnection);

        dataAdapter.Fill(dataSet!);

        dataGridView.DataSource = dataSet?.Tables[0];
    }
    public void UpdateTableWithDisconnectedMode() 
    {
        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
        sqlCommandBuilder.RefreshSchema();

        dataAdapter?.Update(dataSet!.Tables[0]);
    }
}