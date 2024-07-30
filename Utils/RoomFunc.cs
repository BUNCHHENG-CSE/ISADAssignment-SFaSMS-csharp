using Microsoft.Data.SqlClient;
using SFaSMS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFaSMS.Utils;

public class RoomFunc
{
    public static IEnumerable<Room> GetAllRoom(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadALLRoom", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all room > {ex.Message}");
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
                yield return reader.ToDisplayRoom();
            }
        }
        reader?.Close();
    }
    public static IEnumerable<Room> GetAllRoomNo(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadALLRoomNo", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all room no > {ex.Message}");
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
                yield return reader.ToDisplayRoomNo();
            }
        }
        reader?.Close();
    }
    public static Room GetOneRoom(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneRoom", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting room with id, {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        Room? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToDisplayRoom();
            }
        }
        reader?.Close();
        return result;
    }
    public static bool AddRoom(SqlConnection con, Room room)
    {
        SqlCommand cmd = new SqlCommand("spInsertRoom", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@rn", room.RoomNumber);
        cmd.Parameters.AddWithValue("@bl", room.BuildingLetter);
       
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return effected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in adding new room > {ex.Message}");

        }
        finally
        {
            cmd.Dispose();
        }
    }
    public static bool UpdateRoom(SqlConnection con, Room room)
    {
        SqlCommand cmd = new SqlCommand("spUpdateRoom", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@no", room.RoomNo);
        cmd.Parameters.AddWithValue("@rn", room.RoomNumber);
        cmd.Parameters.AddWithValue("@bl", room.BuildingLetter);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return (effected > 0);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in updating existing room > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
}
