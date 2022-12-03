using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApi;

internal class MySqlTesting
{
    // Scaffold-DbContext "server=db4free.net;port=3306;username=jdancheg;password=20232023;database=vkuint_zhdanov" Microsoft.EntityFrameworkCore -OutputDir ".\Models"

    // Scaffold-DbContext "server=db4free.net;port=3306;username=jdancheg;password=20232023;database=vkuint_zhdanov" MySql.Data.EntityFrameworkCore -OutputDir ".\Models"

    // Scaffold-DbContext "Data Source = 111.db;" Microsoft.EntityFrameworkCore.Sqlite -OutputDir Models -Tables Users

    static string connectionString = "server=db4free.net;port=3306;username=jdancheg;password=20232023;database=vkuint_zhdanov";

    MySqlConnection connection;

    public DataTable DataTable()
    {
        DataTable table = new DataTable();

        using (connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM students";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
        }  
        return table;
    }

}
