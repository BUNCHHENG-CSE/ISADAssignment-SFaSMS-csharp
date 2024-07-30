using Microsoft.Data.SqlClient;
using SFaSMS.Models;
using System.Data;

namespace SFaSMS.Utils;

public class SubjectFunc
{

    public static IEnumerable<Subject> GetAllSubject(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadALLSubject", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Subject > {ex.Message}");
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
                yield return reader.ToDisplaySubject();
            }
        }
        reader?.Close();
    }
    public static IEnumerable<Subject> GetAllSubjectID(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadALLSubjectID", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Subject ID > {ex.Message}");
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
                yield return reader.ToDisplaySubjectID();
            }
        }
        reader?.Close();
    }
    public static Subject GetOneSubject(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneSubject", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting subject with id, {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        Subject? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToDisplaySubject();
            }
        }
        reader?.Close();
        return result;
    }
    public static Subject GetOneSubjectname(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneSubjectName", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting subject name with id, {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        Subject? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToDisplaySubjectName();
            }
        }
        reader?.Close();
        return result;
    }
    public static bool AddSubject(SqlConnection con, Subject subject)
    {
        SqlCommand cmd = new SqlCommand("spInsertSubject", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@subn", subject.SubjectName);
        cmd.Parameters.AddWithValue("@subdec", subject.SubjectDescription);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return effected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in adding new subject > {ex.Message}");

        }
        finally
        {
            cmd.Dispose();
        }


    }
    public static bool UpdateSubject(SqlConnection con, Subject subject)
    {
        SqlCommand cmd = new SqlCommand("spUpdateSubject", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", subject.SubjectID);
        cmd.Parameters.AddWithValue("@subn", subject.SubjectName);
        cmd.Parameters.AddWithValue("@subdec", subject.SubjectDescription);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return (effected > 0);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in updating existing subject > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
}
