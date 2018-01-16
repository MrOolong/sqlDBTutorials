using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Cookbook1
{
    public partial class FrmMain : Form
    {
        SqlConnection connection;
        string connectionString;

        public FrmMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Cookbook1.Properties.Settings.Cookbook1ConnectionString"].ConnectionString;
            PopulateRecipes();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void PopulateRecipes()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe", connection))
            {
                // connection.Open(); //uneeded when using SqlDataAdapter

                DataTable RecipeTable = new DataTable();
                adapter.Fill(RecipeTable);

                lstRecipes.DisplayMember = "Name";
                lstRecipes.ValueMember = "Id";
                lstRecipes.DataSource = RecipeTable;
            }
        }

        private void PopulateIngredients()
        {
            string query = "SELECT a.Name FROM Ingredient a " +
                "INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId " +
                "WHERE b.RecipeID = @RecipeId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@RecipeId", lstRecipes.SelectedValue);

                DataTable IngredientTable = new DataTable();
                adapter.Fill(IngredientTable);

                lstIngredients.DisplayMember = "Name";
                lstIngredients.ValueMember = "Id";
                lstIngredients.DataSource = IngredientTable;
            }
        }

        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lstRecipes.SelectedValue.ToString());
            PopulateIngredients();
        }
    }
}
