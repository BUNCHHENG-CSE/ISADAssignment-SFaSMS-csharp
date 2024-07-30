using Microsoft.Data.SqlClient;
using SFaSMS.Models;
using System.Data;

namespace SFaSMS.Utils;

public class StudentFunc
{

    public static IEnumerable<Student> GetAllStudent(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadALLStudent", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Student > {ex.Message}");
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
                yield return reader.ToDisplayStudent();
            }
        }
        reader?.Close();
    }
    public static IEnumerable<Student> GetAllStudentID(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadALLStudentID", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Student ID > {ex.Message}");
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
                yield return reader.ToDisplayStudentID();
            }
        }
        reader?.Close();
    }
    public static Student GetOneStudentIDandPhoto(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneStudentIDandPhoto", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting student with id, {id} > {ex.Message}");
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
                result = reader.ToStudentIDandPhoto();
            }
        }
        reader?.Close();
        return result;
    }
    public static Student GetOneStudent(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneStudent", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting student with id, {id} > {ex.Message}");
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
                result = reader.ToStudentAllData();
            }
        }
        reader?.Close();
        return result;
    }
    public static Student GetOneStudentNameKH(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneStudentNameKH", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting student with id, {id} > {ex.Message}");
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
    public static bool AddStudent(SqlConnection con, Student student)
    {
        SqlCommand cmd = new SqlCommand("spInsertStudent", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@stunKH", student.StudentNameKH);
        cmd.Parameters.AddWithValue("@stunEN", student.StudentNameEN);
        cmd.Parameters.AddWithValue("@gen", student.Gender);
        cmd.Parameters.AddWithValue("@bd", student.BirthDate);
        cmd.Parameters.AddWithValue("@stuad", student.StudentAddress);
        cmd.Parameters.AddWithValue("@psn", student.PersonalNumber);
        cmd.Parameters.AddWithValue("@prn", student.ParentNumber);
        cmd.Parameters.AddWithValue("@stuph", student.Photo);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return effected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in adding new student > {ex.Message}");

        }
        finally
        {
            cmd.Dispose();
        }


    }
    public static bool UpdateStudent(SqlConnection con, Student student)
    {
        SqlCommand cmd = new SqlCommand("spUpdateStudent", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", student.StudentID);
        cmd.Parameters.AddWithValue("@stunKH", student.StudentNameKH);
        cmd.Parameters.AddWithValue("@stunEN", student.StudentNameEN);
        cmd.Parameters.AddWithValue("@gen", student.Gender);
        cmd.Parameters.AddWithValue("@bd", student.BirthDate);
        cmd.Parameters.AddWithValue("@stuad", student.StudentAddress);
        cmd.Parameters.AddWithValue("@psn", student.PersonalNumber);
        cmd.Parameters.AddWithValue("@prn", student.ParentNumber);
        cmd.Parameters.AddWithValue("@stuph", student.Photo);

        try
        {
            int effected = cmd.ExecuteNonQuery();
            return (effected > 0);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in updating existing Student > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
}
