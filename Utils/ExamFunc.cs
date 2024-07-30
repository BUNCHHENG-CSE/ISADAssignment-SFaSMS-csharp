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
    public class ExamFunc
    {

        public static IEnumerable<Exam> GetAllExam(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("spReadALLExam", con);
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all Exam > {ex.Message}");
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
                    yield return reader.ToDisplayExam();
                }
            }
            reader?.Close();
        }
        public static Exam GetOneExam(SqlConnection con, int subid,int stuid)
        {
            SqlCommand cmd = new SqlCommand("spReadOneExam", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@subid", subid);
            cmd.Parameters.AddWithValue("@stuid", stuid);
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting exam with subject id, {subid}, and with student id, {stuid} > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
            Exam? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToDisplayExam();
                }
            }
            reader?.Close();
            return result;
        }
        public static bool AddExam(SqlConnection con, Exam exam)
        {
            SqlCommand cmd = new SqlCommand("spInsertExam", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@subid", exam.SubjectID);
            cmd.Parameters.AddWithValue("@stuid", exam.StudentID);
            cmd.Parameters.AddWithValue("@scor", exam.ExamScore);
            cmd.Parameters.AddWithValue("@grade", exam.Grade);
            cmd.Parameters.AddWithValue("@GPA", exam.GPA);
            cmd.Parameters.AddWithValue("@subn", exam.SubjectName);
            try
            {
                int effected = cmd.ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in adding new Exam > {ex.Message}");

            }
            finally
            {
                cmd.Dispose();
            }
        }
        public static bool UpdateExam(SqlConnection con, Exam exam)
        {
            SqlCommand cmd = new SqlCommand("spUpdateExam", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@subid", exam.SubjectID);
            cmd.Parameters.AddWithValue("@stuid", exam.StudentID);
            cmd.Parameters.AddWithValue("@scor", exam.ExamScore);
            cmd.Parameters.AddWithValue("@grade", exam.Grade);
            cmd.Parameters.AddWithValue("@GPA", exam.GPA);
            cmd.Parameters.AddWithValue("@subn", exam.SubjectName);
            try
            {
                int effected = cmd.ExecuteNonQuery();
                return (effected > 0);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating existing Exam > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
        }

    }
}
