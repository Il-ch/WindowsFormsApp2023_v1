using WindowsFormsApp2023_v1;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;

namespace WindowsFormsApp2023_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            dataGridViewDB.Rows.Clear();
            MySqlConnection connect = DBUtils.GetMySqlConnection();
            connect.Open();

            string sqlQuery = "SELECT * FROM departments";

            MySqlCommand cmd = new MySqlCommand(sqlQuery);

            cmd.Connection = connect;
            cmd.CommandText = sqlQuery;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                }
                reader.Close();
                connect.Close();

                foreach (string[] dataFromDb in data)
                {
                    dataGridViewDB.Rows.Add(dataFromDb);
                }
            }
        }
    }
}
