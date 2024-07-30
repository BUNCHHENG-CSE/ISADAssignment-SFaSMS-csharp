using Microsoft.Data.SqlClient;
using SFaSMS.Models;
using System.Data;

namespace SFaSMS.Utils;

public class MajorFunc
{
    public static IEnumerable<Major> GetAllMajor(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadALLMajor", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Major > {ex.Message}");
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
                yield return reader.ToDisplayMajor();
            }
        }
        reader?.Close();
    }
    public static IEnumerable<Major> GetAllMajorID(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadALLMajorID", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Major > {ex.Message}");
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
                yield return reader.ToDisplayMajorID();
            }
        }
        reader?.Close();
    }
    public static Major GetOneMajor(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneMajor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting major with id, {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        Major? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToDisplayMajor();
            }
        }
        reader?.Close();
        return result;
    }

    public static Major GetOneMajorNameKH(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneMajorNameKH", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting major with id, {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        Major? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToDisplayMajorNameKH();
            }
        }
        reader?.Close();
        return result;
    }
    public static Major GetOneMajorNameEN(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneMajorNameEN", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting major with id, {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        Major? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToDisplayMajorNameEN();
            }
        }
        reader?.Close();
        return result;
    }
    public static Major GetOneMajorCost(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneMajorCost", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting Major with id, {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        Major? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToDisplayMajorCost();
            }
        }
        reader?.Close();
        return result;
    }
    public static bool AddMajor(SqlConnection con, Major major)
    {
        SqlCommand cmd = new SqlCommand("spInsertMajor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@mnKH", major.MajorNameKH);
        cmd.Parameters.AddWithValue("@mnEN", major.MajorNameEN);
        cmd.Parameters.AddWithValue("@mna", major.MajorNameAbbreviation);
        cmd.Parameters.AddWithValue("@mc", major.MajorCost);
        cmd.Parameters.AddWithValue("@mdec", major.MajorDescription);

        try
        {
            int effected = cmd.ExecuteNonQuery();
            return effected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in adding new major > {ex.Message}");

        }
        finally
        {
            cmd.Dispose();
        }


    }
    public static bool UpdateMajor(SqlConnection con, Major major)
    {
        SqlCommand cmd = new SqlCommand("spUpdateMajor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", major.MajorID);
        cmd.Parameters.AddWithValue("@mnKH", major.MajorNameKH);
        cmd.Parameters.AddWithValue("@mnEN", major.MajorNameEN);
        cmd.Parameters.AddWithValue("@mna", major.MajorNameAbbreviation);
        cmd.Parameters.AddWithValue("@mc", major.MajorCost);
        cmd.Parameters.AddWithValue("@mdec", major.MajorDescription);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return (effected > 0);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in updating existing major > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }

}
