using Microsoft.Data.SqlClient;
using SFaSMS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFaSMS.Utils;

public class LecturerFunc
{
    public static IEnumerable<Lecturer> GetAllLecturer(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadALLLecturer", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Lecturer > {ex.Message}");
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
                yield return reader.ToDisplayLecturer();
            }
        }
        reader?.Close();
    }
    public static IEnumerable<Lecturer> GetAllLecturerID(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadALLLecturerID", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Lecturer > {ex.Message}");
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
                yield return reader.ToDisplayLecturerID();
            }
        }
        reader?.Close();
    }
    public static Lecturer GetOneLecturer(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneLecturer", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting Lecturer with id, {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        Lecturer? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToLecturerAllData();
            }
        }
        reader?.Close();
        return result;
    }
    public static Lecturer GetOneLecturerNameKH(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneLecturerNameKH", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting Lecturer with id, {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        Lecturer? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToDisplayLecturerNameKH();
            }
        }
        reader?.Close();
        return result;
    }

    public static bool AddLecturer(SqlConnection con, Lecturer lecturer)
    {
        SqlCommand cmd = new SqlCommand("spInsertLecturer", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@lecnKH", lecturer.LecturerNameKH);
        cmd.Parameters.AddWithValue("@lecnEN", lecturer.LecturerNameEN);
        cmd.Parameters.AddWithValue("@gen", lecturer.Gender);
        cmd.Parameters.AddWithValue("@bd", lecturer.BirthDate);
        cmd.Parameters.AddWithValue("@lecad", lecturer.LecturerAddress);
        cmd.Parameters.AddWithValue("@cn", lecturer.ContactNumber);
        cmd.Parameters.AddWithValue("@pn", lecturer.PersonalNumber);
        cmd.Parameters.AddWithValue("@lecph", lecturer.Photo);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return (effected > 0);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in adding new lecturer > {ex.Message}");

        }
        finally
        {
            cmd.Dispose();
        }
    }
    public static bool UpdateLecturer(SqlConnection con, Lecturer lecturer)
    {
        SqlCommand cmd = new SqlCommand("spUpdateLecturer", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", lecturer.LecturerID);
        cmd.Parameters.AddWithValue("@lecnKH", lecturer.LecturerNameKH);
        cmd.Parameters.AddWithValue("@lecnEN", lecturer.LecturerNameEN);
        cmd.Parameters.AddWithValue("@gen", lecturer.Gender);
        cmd.Parameters.AddWithValue("@bd", lecturer.BirthDate);
        cmd.Parameters.AddWithValue("@lecad", lecturer.LecturerAddress);
        cmd.Parameters.AddWithValue("@cn", lecturer.ContactNumber);
        cmd.Parameters.AddWithValue("@pn", lecturer.PersonalNumber);
        cmd.Parameters.AddWithValue("@lecph", lecturer.Photo);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return (effected > 0);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in updating existing lecturer > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
}