using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SistemaFacturacion.Models;

namespace SistemaFacturacion.Data
{
    public class DataAcces
    {
        private readonly string connectionString = "Data Source=localhost;Initial Catalog=SISTEMA_FACTURACION;Integrated Security=True;TrustServerCertificate=True";


        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente> ();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT IdCliente, Nombre, FechaCreacion FROM CLIENTE";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            IdCliente = Convert.ToInt32(reader["IdCliente"]),
                            Nombre = reader["Nombre"].ToString(),
                            FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"])
                        };

                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }

    }
}
