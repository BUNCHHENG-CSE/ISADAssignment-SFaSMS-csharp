using Microsoft.Data.SqlClient;
using SFaSMS.Models;
using System.Data;

namespace SFaSMS.Utils;

public class PaymentStatusFunc
{
    public static IEnumerable<PaymentStatus> GetAllPaymentStatus(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadALLPaymentStatus", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Payment Status > {ex.Message}");
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
                yield return reader.ToDisplayPaymentStatus();
            }
        }
        reader?.Close();
    }
    public static IEnumerable<PaymentStatus> GetAllPaymentStatusID(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadALLPaymentStatusID", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Payment Status ID > {ex.Message}");
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
                yield return reader.ToDisplayPaymentStatusID();
            }
        }
        reader?.Close();
    }
    public static PaymentStatus GetOnePaymentStatus(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOnePaymentStatus", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting payment status with id, {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        PaymentStatus? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToPaymentStatusAllData();
            }
        }
        reader?.Close();
        return result;
    }
    public static bool AddPaymentStatus(SqlConnection con, PaymentStatus paymentStatus)
    {
        SqlCommand cmd = new SqlCommand("spInsertPaymentStatus", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@sos", paymentStatus.SemesterOneStatus);
        cmd.Parameters.AddWithValue("@sts", paymentStatus.SemesterTwoStatus);
        cmd.Parameters.AddWithValue("@oys", paymentStatus.OneYearStatus);
        cmd.Parameters.AddWithValue("@stuid", paymentStatus.StudentID);
        cmd.Parameters.AddWithValue("@stunKH", paymentStatus.StudentNameKH);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return effected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in adding new Payment Status > {ex.Message}");

        }
        finally
        {
            cmd.Dispose();
        }
    }
    public static bool UpdatePaymentStatus(SqlConnection con, PaymentStatus paymentStatus)
    {
        SqlCommand cmd = new SqlCommand("spUpdatePaymentStatus", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", paymentStatus.PaymentStatusID);
        cmd.Parameters.AddWithValue("@sos", paymentStatus.SemesterOneStatus);
        cmd.Parameters.AddWithValue("@sts", paymentStatus.SemesterTwoStatus);
        cmd.Parameters.AddWithValue("@oys", paymentStatus.OneYearStatus);
        cmd.Parameters.AddWithValue("@stuid", paymentStatus.StudentID);
        cmd.Parameters.AddWithValue("@stunKH", paymentStatus.StudentNameKH);

        try
        {
            int effected = cmd.ExecuteNonQuery();
            return (effected > 0);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in updating existing Payment Status > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
}