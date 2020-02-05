using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _14_WPF_ZooManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;
        string selectedZooId;
        string selectedAnimalId;

        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["_14_WPF_ZooManager.Properties.Settings.PunjututorialDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            ShowZoos();
            ShowAnimals();
            selectedZooId = "";
            selectedAnimalId = "";
        }

        private void ShowZoos()
        {
            try
            {
                string query = "Select * from Zoo";
                //The SqlDataAdapter can be imagined like an interface to make Tables usable by C# Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);

                    //which information of the Table in DataTable should be shown in ListBox 
                    listZoos.DisplayMemberPath = "Location";
                    //which value should be delivered when an item from our ListBox is selected.
                    listZoos.SelectedValuePath = "Id";
                    // The reference to the Data the ListBox should populate
                    listZoos.ItemsSource = zooTable.DefaultView;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void ShowAssociatedAnimals()
        {
            try
            {
                string query = "Select za.Id, a.Name from Animal a Inner Join ZooAnimal za On a.Id = za.AnimalId Where Za.ZooId = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                    DataTable animalTable = new DataTable();
                    sqlDataAdapter.Fill(animalTable);
                    listAssociatedAnimals.DisplayMemberPath = "Name";
                    listAssociatedAnimals.SelectedValuePath = "Id";
                    listAssociatedAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void ListZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedAnimals();
            ShowSelectedZooInTextBox();
        }

        private void ShowAnimals()
        {
            try
            {
                string query = "Select * from Animal";
                //The SqlDataAdapter can be imagined like an interface to make Tables usable by C# Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                using (sqlDataAdapter)
                {
                    DataTable animalTable = new DataTable();
                    sqlDataAdapter.Fill(animalTable);

                    //which information of the Table in DataTable should be shown in ListBox 
                    listAnimals.DisplayMemberPath = "Name";
                    //which value should be delivered when an item from our ListBox is selected.
                    listAnimals.SelectedValuePath = "Id";
                    // The reference to the Data the ListBox should populate
                    listAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void AddAnimalToZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listAnimals.SelectedValue == null)
                {
                    MessageBox.Show("Select Animal to link to Zoo");
                    return;
                }
                if (listZoos.SelectedValue == null)
                {
                    MessageBox.Show("Select Zoo to link to Animal");
                    return;
                }
                string query = "Insert into ZooAnimal values (@ZooId, @AnimalId)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAssociatedAnimals();
            }
        }

        private void DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listZoos.SelectedValue == null)
                {
                    MessageBox.Show("Select Zoo to delete");
                    return;
                }
                string query = "delete from Zoo where Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }

        private void AddZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(enterText.Text == "")
                {
                    MessageBox.Show("Enter text for Zoo");
                    return;
                }
                string query = "Insert into Zoo values (@Location)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Location", enterText.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
                enterText.Text = "";
            }
        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (enterText.Text == "")
                {
                    MessageBox.Show("Enter text for Animal");
                    return;
                }
                string query = "Insert into Animal values (@Name)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Name", enterText.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAnimals();
                enterText.Text = "";
            }
        }
        private void DeleteAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listAnimals.SelectedValue == null)
                {
                    MessageBox.Show("Select Animal to delete");
                    return;
                }
                string query = "delete from Animal where Id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAnimals();
            }
        }

        private void RemoveAssociatedAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listAssociatedAnimals.SelectedValue == null)
                {
                    MessageBox.Show("Select Associated Animal to delete");
                    return;
                }
                string query = "delete from ZooAnimal where Id = @Id";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Id", listAssociatedAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAssociatedAnimals();
            }
        }

        private void ShowSelectedZooInTextBox()
        {
            try
            {
                string query = "Select Location from Zoo Where Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);
                    enterText.Text = zooTable.Rows[0]["Location"].ToString();
                    selectedZooId = listZoos.SelectedValue.ToString();
                    selectedAnimalId = "";
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void ListAnimal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowSelectedAnimalInTextBox();
        }

        private void ShowSelectedAnimalInTextBox()
        {
            try
            {
                string query = "Select Name from Animal Where Id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                    DataTable animalTable = new DataTable();
                    sqlDataAdapter.Fill(animalTable);
                    enterText.Text = animalTable.Rows[0]["Name"].ToString();
                    selectedAnimalId = listAnimals.SelectedValue.ToString();
                    selectedZooId = "";
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void UpdateZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(selectedZooId == "")
                {
                    MessageBox.Show("Text box has not linked to Zoo\n Click Zoo list item.");
                    return;
                }
                string query = "update Zoo Set Location = @Location where Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Location", enterText.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
                enterText.Text = "";
            }
        }

        private void UpdateAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (selectedAnimalId == "")
                {
                    MessageBox.Show("Text box has not linked to Animal\n Click Animal list item.");
                    return;
                }
                string query = "update Animal Set Name = @Name where Id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Name", enterText.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAnimals();
                enterText.Text = "";
            }
        }
    }
}
