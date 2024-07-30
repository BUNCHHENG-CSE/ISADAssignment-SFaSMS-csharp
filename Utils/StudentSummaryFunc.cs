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
    public class StudentSummaryFunc
    {
        public static IEnumerable<StudentSummary> GetAllStudentSummary(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("spReadALLStudentSummary", con);
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all Student Summary > {ex.Message}");
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
                    yield return reader.ToDisplayStudentSummary();
                }
            }
            reader?.Close();
        }
        public static StudentSummary GetOneStudentSummary(SqlConnection con, int id)
        {
            SqlCommand cmd = new SqlCommand("spReadOneStudentSummary", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting student summary with id, {id} > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
            StudentSummary? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToStudentSummaryAllData();
                }
            }
            reader?.Close();
            return result;
        }
        public static bool AddStudentSummary(SqlConnection con, StudentSummary studentsummary)
        {
            SqlCommand cmd = new SqlCommand("spInsertStudentSummary", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@rd", studentsummary.RegisterDate);
            cmd.Parameters.AddWithValue("@deg", studentsummary.Degree);
            cmd.Parameters.AddWithValue("@stuid", studentsummary.StudentID);
            cmd.Parameters.AddWithValue("@rn", studentsummary.RoomNo);
            cmd.Parameters.AddWithValue("@maid", studentsummary.MajorID);
            cmd.Parameters.AddWithValue("@stunKH", studentsummary.StudentNameKH);
            cmd.Parameters.AddWithValue("@mnKH", studentsummary.MajorNameKH);
            try
            {
                int effected = cmd.ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in adding new student summary > {ex.Message}");

            }
            finally
            {
                cmd.Dispose();
            }
        }
        public static bool UpdateStudentSummary(SqlConnection con, StudentSummary studentsummary)
        {
            SqlCommand cmd = new SqlCommand("spUpdateStudentSummary", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", studentsummary.StuSumID);
            cmd.Parameters.AddWithValue("@rd", studentsummary.RegisterDate);
            cmd.Parameters.AddWithValue("@deg", studentsummary.Degree);
            cmd.Parameters.AddWithValue("@stuid", studentsummary.StudentID);
            cmd.Parameters.AddWithValue("@rn", studentsummary.RoomNo);
            cmd.Parameters.AddWithValue("@maid", studentsummary.MajorID);
            cmd.Parameters.AddWithValue("@stunKH", studentsummary.StudentNameKH);
            cmd.Parameters.AddWithValue("@mnKH", studentsummary.MajorNameKH);

            try
            {
                int effected = cmd.ExecuteNonQuery();
                return (effected > 0);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating existing Student Summary > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
        }
    }
}
