﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DatabaseConnectionEjemploPOS
{
    internal class DatabaseConnection
    {
        private static DatabaseConnection instance = null;
        private OleDbConnection connection;
        private string connectionString = @"Provider= Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\eduar\source\repos\SistemaPOS\Database1.accdb";

        private DatabaseConnection()
        {
            connection = new OleDbConnection(connectionString);

        }
        public static DatabaseConnection GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseConnection();
            }
            return instance;
        }

        public void OpenConnection()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                Console.WriteLine("Conexión abierta");
            }



        }
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Conexión cerrada");
            }

        }
        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {

                    using (OleDbDataAdapter da = new OleDbDataAdapter(command))
                    {
                        da.Fill(dt);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error ejecutando la consulta: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }

        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;
            try
            {

                OpenConnection();

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {

                    rowsAffected = command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error ejecutando la consulta: " + ex.Message);

            }
            finally
            {

                CloseConnection();
            }
            return rowsAffected;
        }

    }
}
