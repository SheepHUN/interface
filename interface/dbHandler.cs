using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace @interface
{
    public class dbHandler : IdbHandler
    {
        MySqlConnection connection;
        string tableName = "users";

        public dbHandler() {
            string user = "root";
            string password = "";
            string dbName = "kolbasz";
            string host = "localhost";
            string connectionString = $"username={user};password={password};database={dbName};host={host}";
            connection = new MySqlConnection(connectionString);
        }
        public void DeleteAll()
        {
            try
            {
                connection.Open();
                string query = $"delete from {tableName}";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void DeleteOne(User user)
        {
            try
            {
                connection.Open();
                string query = $"delete from {tableName} where id={user.id}";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void InsertOne(User user)
        {
            try
            {
                connection.Open();
                string query = $"insert into {tableName} (id, username,password,points)" +
                    $"values ({user.id},'{user.username}', '{user.password}',{user.points})";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                   
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ReadAll()
        {
            try
            {
                connection.Open();
                string query = $"select * from {tableName}";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read()) {
                    User oneUser = new User();
                    oneUser.id = read.GetInt32(read.GetOrdinal("id"));
                    oneUser.points = read.GetInt32(read.GetOrdinal("points"));
                    oneUser.username = read.GetString(read.GetOrdinal("username"));
                    oneUser.password = read.GetString(read.GetOrdinal("password"));
                    User.allUser.Add(oneUser);
                }
                read.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void UpdateOne(User oneUser)
        {
            try
            {
                connection.Open();
                string query = $"update {tableName} set points = {oneUser.points} where id = {oneUser.id}";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
