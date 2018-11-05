using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Model
{
    public class DBConnection
    {
        private SqlConnection con;
        public DBConnection()
        {
            //DESKTOP-MMSQBFD\SQLEXPRESS
            con = new SqlConnection("Server=DESKTOP-MMSQBFD\\SQLEXPRESS;" +
                "Initial Catalog=Neptuno;" +
                "Integrated Security=true");
        }

        public void Open()
        {
            con.Open();
        }

        public void Close()
        {
            con.Close();
        }
        //listta de empleados mediante un procedure
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                Open();
                SqlCommand command = new SqlCommand("sp_ListaEmpleados", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int codigo = (int)dataReader.GetValue(0);
                    string nombre = dataReader.GetValue(1).ToString();
                    string apellidos = dataReader.GetValue(2).ToString();
                    string cargo = dataReader.GetValue(3).ToString();
                    string ciudad = dataReader.GetValue(4).ToString();

                    Employee e = new Employee(codigo, apellidos, nombre, cargo, ciudad);
                    employees.Add(e);
                }
                dataReader.Close();
            }
            catch
            {
                throw;
            }
            finally
            {
                Close();
            }
            return employees;
        }

        //crear un metodo para la lista de clientes
        public List<Customer> getCustomers()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                Open();
                string sql = "SELECT IdCliente, NombreContacto, CargoContacto, Ciudad, Region FROM Clientes";
                SqlCommand cmd = new SqlCommand(sql,con);
                //execute
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    string codigo = dataReader.GetValue(0).ToString();
                    string nombre = dataReader.GetValue(1).ToString();
                    string contacto = dataReader.GetValue(2).ToString();
                    string ciudad = dataReader.GetValue(3).ToString();
                    string region = dataReader.GetValue(4).ToString();

                    Customer x = new Customer(codigo, nombre, contacto, ciudad, region);
                    customers.Add(x);
                }
                dataReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Close();
            }
            return customers;
        }
    }
}
