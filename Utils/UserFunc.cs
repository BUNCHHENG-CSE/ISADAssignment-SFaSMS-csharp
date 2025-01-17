﻿using Microsoft.Data.SqlClient;
using SFaSMS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFaSMS.Utils;

public class UserFunc
{
    public static IEnumerable<User> GetAllUser(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadALLUser", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all User > {ex.Message}");
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
                yield return reader.ToDisplayUser();
            }
        }
        reader?.Close();
    }
    public static User GetOneUser(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneUser", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting user with id, {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        User? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToUserAllData();
            }
        }
        reader?.Close();
        return result;
    }
    public static bool AddUser(SqlConnection con, User user)
    {
        SqlCommand cmd = new SqlCommand("spInsertUser", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@usr", user.Username);
        cmd.Parameters.AddWithValue("@passwd", user.Password);
        cmd.Parameters.AddWithValue("@staid", user.StaffID);
        cmd.Parameters.AddWithValue("@stanKH", user.StaffNameKH);
        cmd.Parameters.AddWithValue("@stapos", user.StaffPosition);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return effected > 0 ;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in adding new user > {ex.Message}");

        }
        finally
        {
            cmd.Dispose();
        }

    }
    public static bool UpdateUser(SqlConnection con, User user)
    {
        SqlCommand cmd = new SqlCommand("spUpdateUser", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", user.UserID);
        cmd.Parameters.AddWithValue("@usr", user.Username);
        cmd.Parameters.AddWithValue("@passwd", user.Password);
        cmd.Parameters.AddWithValue("@staid", user.StaffID);
        cmd.Parameters.AddWithValue("@stanKH", user.StaffNameKH);
        cmd.Parameters.AddWithValue("@stapos", user.StaffPosition);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return (effected > 0);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in updating existing user > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
}
