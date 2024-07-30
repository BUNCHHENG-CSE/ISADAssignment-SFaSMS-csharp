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
    public class AttendanceFunc
    {

        public static IEnumerable<Attendance> GetAllAttendances(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("spReadALLAttendance", con);
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all Attendance > {ex.Message}");
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
                    yield return reader.ToDisplayAttendance();
                }
            }
            reader?.Close();
        }
        public static Attendance GetOneAttendance(SqlConnection con, int id)
        {
            SqlCommand cmd = new SqlCommand("spReadOneAttendance", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@attid", id);
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting attendance with id, {id} > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
            Attendance? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToAttendanceAllData();
                }
            }
            reader?.Close();
            return result;
        }
        public static bool AddAttendance(SqlConnection con, Attendance attendance)
        {
            SqlCommand cmd = new SqlCommand("spInsertAttendance", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tr", attendance.TimeRecorded);
            cmd.Parameters.AddWithValue("@dr", attendance.DateRecorded);
            cmd.Parameters.AddWithValue("@st", attendance.Status);
            cmd.Parameters.AddWithValue("@gen", attendance.Generation);
            cmd.Parameters.AddWithValue("@sty", attendance.StudyYear);
            cmd.Parameters.AddWithValue("@cla", attendance.Class);
            cmd.Parameters.AddWithValue("@stuid", attendance.StudentID);
            cmd.Parameters.AddWithValue("@stunKH", attendance.StudentNameKH);
            try
            {
                int effected = cmd.ExecuteNonQuery();
                return effected > 0 ;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in adding new attendance > {ex.Message}");

            }
            finally
            {
                cmd.Dispose();
            }
        }
        public static bool UpdateAttendance(SqlConnection con, Attendance attendance)
        {
            SqlCommand cmd = new SqlCommand("spUpdateAttendance", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@attid", attendance.AttendanceID);
            cmd.Parameters.AddWithValue("@tr", attendance.TimeRecorded);
            cmd.Parameters.AddWithValue("@dr", attendance.DateRecorded);
            cmd.Parameters.AddWithValue("@st", attendance.Status);
            cmd.Parameters.AddWithValue("@gen", attendance.Generation);
            cmd.Parameters.AddWithValue("@sty", attendance.StudyYear);
            cmd.Parameters.AddWithValue("@cla", attendance.Class);
            cmd.Parameters.AddWithValue("@stuid", attendance.StudentID);
            cmd.Parameters.AddWithValue("@stunKH", attendance.StudentNameKH);

            try
            {
                int effected = cmd.ExecuteNonQuery();
                return (effected > 0);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating existing Attendance > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
        }

    }
}
