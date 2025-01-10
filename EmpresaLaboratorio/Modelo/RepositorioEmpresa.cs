using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Modelo
{
    public class RepositorioEmpresa
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private DataSet datos;
        private SqlCommandBuilder comando;

        public void ConexionSQL(string consulta)
        {
            this.conexion = new SqlConnection();
            this.conexion.ConnectionString = "Data Source=E-104;Initial Catalog=Empresa;Integrated Security=True";
            this.conexion.Open();
            this.adaptador = new SqlDataAdapter(consulta, this.conexion);
            this.comando = new SqlCommandBuilder(this.adaptador);
            this.datos = new DataSet();
            this.adaptador.Fill(this.datos, "Trabajador");
            this.conexion.Close();
        }
        public DataSet GetDatos()
        {
            return this.datos;
        }
    }
}
