using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    class Employee
    {
        public string EmpName { get; set; }
        public decimal EmpSal { get; set; }
        public char EmpType { get; set; }
        DataAccess da = new DataAccess();
        public int AddEmployee()
        {
            Console.WriteLine("Enter Employee Name");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            EmpSal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Employee Type (F/P)");
            EmpType = Convert.ToChar(Console.ReadLine());
            return da.InsertEmployee(EmpName, EmpSal, EmpType);
        }
        public SqlDataReader ShowEmployees()
        {
            return da.GetEmployees();
        }
    }
    class DataAccess
    {
        static SqlConnection con = null;
        static SqlCommand cmd = null;
        static SqlDataReader dr = null;
        static int result;
        public SqlConnection GetConnection()
        {
            string str =
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=Employeemanagement;" +
                "Integrated Security=True";
            con = new SqlConnection(str);
            con.Open();
            return con;
        }
        public int InsertEmployee(string name, decimal sal, char type)
        {
            try
            {
                con = GetConnection();
                cmd = new SqlCommand("sp_insert_employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empname", name);
                cmd.Parameters.AddWithValue("@empsal", sal);
                cmd.Parameters.AddWithValue("@emptype", type);
                result = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
        public SqlDataReader GetEmployees()
        {
            try
            {
                con = GetConnection();
                cmd = new SqlCommand(
                    "select * from employee_details", con);
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("------ Insert Employee ------");
            int res = emp.AddEmployee();
            if (res > 0)
            {
                Console.WriteLine("Employee Inserted Successfully");
            }
            else
            {
                Console.WriteLine("Insertion Failed");
            }
            Console.WriteLine("\n------ Employee Details ------");
            SqlDataReader dr = emp.ShowEmployees();
            while (dr.Read())
            {
                Console.WriteLine(
                    dr["Empno"] + " " +
                    dr["EmpName"] + " " +
                    dr["Empsal"] + " " +
                    dr["Emptype"]);
            }
            Console.ReadLine();
        }
    }
}