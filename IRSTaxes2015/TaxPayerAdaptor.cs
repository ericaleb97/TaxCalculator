using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace IRSTaxes2015
{
    public class TaxPayerAdaptor
    {
        private static string sqlConn = "Data Source=DESKTOP-H72S0DN\\SQLINSTALL_1;Initial Catalog=IRS_Data_2015;Integrated Security=True";
        
        /// <summary>
        /// Inserts a single Taxpayer object into the database
        /// </summary>
        /// <param name="Taxpayer"></param>
        /// <returns></returns>
        public static int InsertSingleRecord(Taxpayer payer)
        {
            int count = 0;
            try
            {
                using (var connection = new SqlConnection(sqlConn))
                {
                    var command = connection.CreateCommand();
                    command.CommandText = $"insert into IRS_Taxes(SSN, Name, Salary, Tax_Owed, Taxed_Salary) " +
                    $"values('{payer.SSN}','{payer.Name}','{payer.salary}','{payer.tax}','{payer.taxedSalary}')";
                    connection.Open();
                    count = command.ExecuteNonQuery();
                    MessageBox.Show("The record was entered into the database");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The data was not entered into the database");
            }

            return count;
        }

        /// <summary>
        /// Queries database for a single record by SSN
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static Taxpayer SelectSingleRecord(string ssn)
        {
            Taxpayer payer = new Taxpayer();

            try
            {
                using (var connection = new SqlConnection(sqlConn))
                {
                    var command = connection.CreateCommand();
                    command.CommandText = $"select top 1 SSN, Name, Salary, Tax_Owed, Taxed_Salary from IRS_Taxes where SSN = '{ssn}'";
                    connection.Open();
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {
                            payer = GetFromReader(reader);
                            MessageBox.Show("The record was found");
                            //MessageBox.Show("The record was not found");
                        }
                        catch (Exception)
                        {
                            //error logic on failed db read
                            MessageBox.Show("The record was not found");
                        }
                    }
                }
            }
            catch (Exception)
            {
                //error logic for failed method
                MessageBox.Show("The request did not go through");
            }

            return payer;
        }

        /// <summary>
        /// Updates database by SSN
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool UpdateSingleRecord(Taxpayer payer)
        {
            try
            {
                using (var connection = new SqlConnection(sqlConn))
                {
                    var command = connection.CreateCommand();
                    command.CommandText = $"update IRS_Taxes set Name = '{payer.Name}', Salary = '{payer.salary}', Tax_Owed = '{payer.tax}', Taxed_Salary = '{payer.taxedSalary}' " +
                        $"where SSN = '{payer.SSN}'";
                    connection.Open();
                    int rows = command.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("The record was updated");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("The record was not updated");
                        return false;
                    }
                }
            }

            catch (Exception)
            {
                //error logic for failed method
                MessageBox.Show("The request did not go through");
                return false;
            }
        }

        public static Taxpayer DelteSingleRecord(string ssn)
        {
            Taxpayer payer = new Taxpayer();

            try
            {
                using (var connection = new SqlConnection(sqlConn))
                {
                    var command = connection.CreateCommand();
                    command.CommandText = $"delete from IRS_Taxes where SSN = '{ssn}'";
                    connection.Open();
                    var reader = command.ExecuteReader();

                    MessageBox.Show("The record was deleted");

                    while (reader.Read())
                    {
                        try
                        {
                            payer = GetFromReader(reader);
                        }
                        catch (Exception)
                        {
                            //error logic on failed db read
                            MessageBox.Show("The record was not deleted");
                        }
                    }
                }
            }
            catch (Exception)
            {
                //error logic for failed method
                MessageBox.Show("The request did not go through");
            }

            return payer;
        }

        /// <summary>
        /// Helper method to parse the data from the database
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static Taxpayer GetFromReader(SqlDataReader reader)
        {
            Taxpayer payer = new Taxpayer();

            try
            {
                payer.Name = reader.GetString(reader.GetOrdinal("Name"));
                payer.SSN = reader.GetString(reader.GetOrdinal("SSN"));
                payer.salary = reader.GetDouble(reader.GetOrdinal("Salary"));
                payer.tax = reader.GetDouble(reader.GetOrdinal("Tax_Owed"));
                payer.taxedSalary = reader.GetDouble(reader.GetOrdinal("Taxed_Salary"));
            }
            catch (Exception ex)
            {
                //error logic for failed method
                //throw;
            }

            return payer;
        }
    }
}
