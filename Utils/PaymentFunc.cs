using Microsoft.Data.SqlClient;
using SFaSMS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFaSMS.Utils
{
    public class PaymentFunc
    {

        public static IEnumerable<Payment> GetAllPayment(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("spReadALLPayment", con);
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all Payment > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
            if (reader != null && reader.HasRows == true)
            {
                var queryAbles = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryAbles)
                {
                    yield return reader.ToDisplayPayment();
                }
            }
            reader?.Close();
        }
        public static Payment GetOnePayment(SqlConnection con, int no)
        {
            SqlCommand cmd = new SqlCommand("spReadOnePayment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@no", no);
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting payment with id, {no} > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
            Payment? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToPaymentAllData();
                }
            }
            reader?.Close();
            return result;
        }
        public static Student GetOneStudentNameKH(SqlConnection con, int no)
        {
            SqlCommand cmd = new SqlCommand("spReadOneStudentNameKHPayment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@no", no);
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting student name with id, {no} > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
            Student? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToStudentGetNameKH();
                }
            }
            reader?.Close();
            return result;
        }

        public static bool AddPayment(SqlConnection con, Payment payment)
        {
            SqlCommand cmd = new SqlCommand("spInsertPayment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pd", payment.PayDate);
            cmd.Parameters.AddWithValue("@pa", payment.PaidAmount);
            cmd.Parameters.AddWithValue("@pmsid", payment.PaymentStatusID);
            cmd.Parameters.AddWithValue("@staid", payment.StaffID);
            cmd.Parameters.AddWithValue("@mid", payment.MajorID);
            cmd.Parameters.AddWithValue("@stanKH", payment.StaffNameKH);
            cmd.Parameters.AddWithValue("@stapos", payment.StaffPosition);
            cmd.Parameters.AddWithValue("@mcost", payment.MajorCost);
            try
            {
                int effected = cmd.ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in adding new Payment  > {ex.Message}");

            }
            finally
            {
                cmd.Dispose();
            }
        }
        public static bool UpdatePayment(SqlConnection con, Payment payment)
        {
            SqlCommand cmd = new SqlCommand("spUpdatePayment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@no", payment.PaymentNo);
            cmd.Parameters.AddWithValue("@pd", payment.PayDate);
            cmd.Parameters.AddWithValue("@pa", payment.PaidAmount);
            cmd.Parameters.AddWithValue("@pmsid", payment.PaymentStatusID);
            cmd.Parameters.AddWithValue("@staid", payment.StaffID);
            cmd.Parameters.AddWithValue("@mid", payment.MajorID);
            cmd.Parameters.AddWithValue("@stanKH", payment.StaffNameKH);
            cmd.Parameters.AddWithValue("@stapos", payment.StaffPosition);
            cmd.Parameters.AddWithValue("@mcost", payment.MajorCost);
            try
            {
                int effected = cmd.ExecuteNonQuery();
                return (effected > 0);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating existing Payment > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
        }
    }
}