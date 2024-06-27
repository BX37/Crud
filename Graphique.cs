using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Crud
{
    public partial class Graphique : Form
    {
        DBConnection laConnexion = new DBConnection();
        List<Log> logList = new List<Log>();
        List<Utilisateur> userList = new List<Utilisateur>();
        public Graphique(DBConnection laCo)
        {
            InitializeComponent();
            laConnexion = laCo;
            RecupLogs();
            RecupUsers();
            fillChart();
            fillChart2();
        }

        private void BTRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RecupLogs()
        {
            if (laConnexion.IsConnect())
            {
                string query = "select ID_Log, ID_User, Login, logDateTimeConnexion, logDateTimeDeconnexion from log;";
                var cmd = new MySqlCommand(query, laConnexion.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string someStringFromColumOne = reader.GetString(1);
                    string someStringFromColumThree = reader.GetString(3);
                    Log unLog = new Log
                    {
                        Log_ID = (int)reader["ID_Log"],
                        Log_Id_User = (int)reader["ID_User"],
                        Log_Login = (string)reader["Login"],
                        Log_DateTimeConnexion = (DateTime)reader["logDateTimeConnexion"],
                        Log_DateTimeDeconnexion = (DateTime)reader["logDateTimeDeconnexion"]
                    };
                    logList.Add(unLog);
                }
                reader.Close();
            }
        }
        private void RecupUsers()
        {
            if (laConnexion.IsConnect())
            {
                string query = "select ID_User, Nom, Prenom, Login, Archive, Niveau, DateHeureConnexion, DateHeureDeconnexion, NbMauvaisMDP from user;";
                var cmd = new MySqlCommand(query, laConnexion.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string someStringFromColumOne = reader.GetString(1);
                    string someStringFromColumThree = reader.GetString(3);
                    Utilisateur employé = new Utilisateur
                    {
                        UtilisateurID = (int)reader["ID_User"],
                        UtilisateurNom = (string)reader["Nom"],
                        UtilisateurPrenom = (string)reader["Prenom"],
                        UtilisateurLogin = (string)reader["Login"],
                        UtilisateurArchive = (bool)reader["Archive"],
                        UtilisateurNiveau = (string)reader["Niveau"],
                        UtilisateurDerniereConnexion = (DateTime)reader["DateHeureConnexion"],
                        UtilisateurDerniereDeconnexion = (DateTime)reader["DateHeureDeconnexion"],
                        UtilisateurNbMauvaisMDP = (int)reader["NbMauvaisMDP"]
                    };
                    userList.Add(employé);
                }
                reader.Close();
            }
        }

        private void fillChart()
        {
            // Create a new data source for the chart
            var data = logList.GroupBy(l => l.Log_Login)
                              .Select(g => new { UserId = g.Key, ConnectionCount = g.Count() })
                              .ToList();

            // Bind the chart to the data source
            chartTest.DataSource = data;

            // Set the data members for the chart series and category
            chartTest.Series["Series1"].XValueMember = "UserId";
            chartTest.Series["Series1"].YValueMembers = "ConnectionCount";

            // Set the chart title and axis labels
            chartTest.Titles.Add("User Connections Chart");
            chartTest.ChartAreas[0].AxisX.Title = "Login";
            chartTest.ChartAreas[0].AxisY.Title = "Number of Connections";
        }
        private void fillChart2()
        {
            // Create a new data source for the chart
            var data2 = userList.Select(u => new { Login = u.UtilisateurLogin, LastConnectionDate = u.UtilisateurDerniereConnexion })
                               .ToList();

            // Bind the chart to the data source
            chart2.DataSource = data2;

            // Set the data members for the chart series and category
            chart2.Series["Series2"].XValueMember = "Login";
            chart2.Series["Series2"].YValueMembers = "LastConnectionDate";

            // Set the chart type to Column
            chart2.Series["Series2"].ChartType = SeriesChartType.Column;

            // Set the chart title and axis labels
            chart2.Titles.Add("User Last Connections Chart");
            chart2.ChartAreas[0].AxisX.Title = "Login";
            chart2.ChartAreas[0].AxisY.Title = "Last Connection Date";
        }
    }
}
