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
    public class ScheduleFunc
    {
        public static IEnumerable<Schedule> GetAllSchedule(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("spReadALLSchedule", con);
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all schedule > {ex.Message}");
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
                    yield return reader.ToDisplaySchedule();
                }
            }
            reader?.Close();
        }
        public static Schedule GetOneSchedule(SqlConnection con, int id)
        {
            SqlCommand cmd = new SqlCommand("spReadOneSchedule", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting Schedule with id, {id} > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
            Schedule? result = null;
            if (reader != null && reader.HasRows == true)
            {
                if (reader.Read() == true)
                {
                    result = reader.ToScheduleAllData();
                }
            }
            reader?.Close();
            return result;
        }
        public static List<ScheduleLecturerDetail> GetOneScheduleLecturerDetail(SqlConnection con, int id)
        {
            List<ScheduleLecturerDetail> listOfScheduleLecturer = new List<ScheduleLecturerDetail> ();
            SqlCommand cmd = new SqlCommand("spReadOneLecScheDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting Schedule with id, {id} > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
            while (reader.Read())
            {
               ScheduleLecturerDetail lectScheDetail =  reader.ToScheduleLecturerDetail();
              listOfScheduleLecturer.Add(lectScheDetail);
            }
           
            reader?.Close();
            return listOfScheduleLecturer;

        }
        public static List<ScheduleSubjectDetail> GetOneScheduleSubjectDetail(SqlConnection con, int id)
        {
            List<ScheduleSubjectDetail> listOfScheduleSubject = new List<ScheduleSubjectDetail>();
            SqlCommand cmd = new SqlCommand("spReadOneSubScheDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting Schedule with id, {id} > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
            while (reader.Read())
            {
                ScheduleSubjectDetail subScheDetail = reader.ToScheduleSubjectDetail();
                listOfScheduleSubject.Add(subScheDetail);
            }

            reader?.Close();
            return listOfScheduleSubject;

        }

        public static bool AddSchedule(SqlConnection con, Schedule schedule)
        {
            SqlCommand cmd = new SqlCommand("spInsertSchedule", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sem", schedule.Semester);
            cmd.Parameters.AddWithValue("@sy", schedule.StudyYears);
            cmd.Parameters.AddWithValue("@sd", schedule.StartDate);
            cmd.Parameters.AddWithValue("@ed", schedule.EndDate);
            cmd.Parameters.AddWithValue("@sess", schedule.Session);
            cmd.Parameters.AddWithValue("@shi", schedule.Shifts);
            cmd.Parameters.AddWithValue("@rn", schedule.RoomNo);
            cmd.Parameters.AddWithValue("@mid", schedule.MajorID);
            cmd.Parameters.AddWithValue("@mnEN", schedule.MajorNameEN);

            try
            {
                int effected = cmd.ExecuteNonQuery();
                return effected > 0 ;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in adding new Schedule  > {ex.Message}");

            }
            finally
            {
                cmd.Dispose();
            }
        }
        public static bool AddScheduleLecturer(SqlConnection con, ScheduleLecturerDetail scheduleLecturerDetail)
        {
            SqlCommand cmd = new SqlCommand("spInsertLecScheDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@lecID", scheduleLecturerDetail.LecturerID);
            cmd.Parameters.AddWithValue("@scheID", scheduleLecturerDetail.ScheduleID);
            cmd.Parameters.AddWithValue("@lecnKH", scheduleLecturerDetail.LecturerNameKH);
            cmd.Parameters.AddWithValue("@dotw", scheduleLecturerDetail.DaysOfTheWeek);
            try
            {
                int effected = cmd.ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in adding new Schedule Lecturer Detail  > {ex.Message}");

            }
            finally
            {
                cmd.Dispose();
            }
        }
        public static bool AddScheduleSubject(SqlConnection con, ScheduleSubjectDetail scheduleSubjectDetail)
        {
            SqlCommand cmd = new SqlCommand("spInsertSubScheDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@subID", scheduleSubjectDetail.SubjectID);
            cmd.Parameters.AddWithValue("@scheID", scheduleSubjectDetail.ScheduleID);
            cmd.Parameters.AddWithValue("@subn", scheduleSubjectDetail.SubjectName);
            cmd.Parameters.AddWithValue("@dotw", scheduleSubjectDetail.DaysOfTheWeek);
            try
            {
                int effected = cmd.ExecuteNonQuery();
                return effected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in adding new Schedule Subject Detail  > {ex.Message}");

            }
            finally
            {
                cmd.Dispose();
            }
        }
        public static bool UpdateSchedule(SqlConnection con, Schedule schedule)
        {
            SqlCommand cmd = new SqlCommand("spUpdateSchedule", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", schedule.ScheduleID);
            cmd.Parameters.AddWithValue("@sem", schedule.Semester);
            cmd.Parameters.AddWithValue("@sy", schedule.StudyYears);
            cmd.Parameters.AddWithValue("@sd", schedule.StartDate);
            cmd.Parameters.AddWithValue("@ed", schedule.EndDate);
            cmd.Parameters.AddWithValue("@sess", schedule.Session);
            cmd.Parameters.AddWithValue("@shi", schedule.Shifts);
            cmd.Parameters.AddWithValue("@rn", schedule.RoomNo);
            cmd.Parameters.AddWithValue("@mid", schedule.MajorID);
            cmd.Parameters.AddWithValue("@mnEN", schedule.MajorNameEN);
            try
            {
                int effected = cmd.ExecuteNonQuery();
                return (effected > 0);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating existing Schedule > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
        }
        public static bool UpdateScheduleLecturer(SqlConnection con, ScheduleLecturerDetail scheduleLecturerDetail, int oldLecturerID)
        {

            SqlCommand cmd = new SqlCommand("spUpdateLecScheDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@oldlecid", oldLecturerID);
            cmd.Parameters.AddWithValue("@lecID", scheduleLecturerDetail.LecturerID);
            cmd.Parameters.AddWithValue("@scheID", scheduleLecturerDetail.ScheduleID);
            cmd.Parameters.AddWithValue("@lecnKH", scheduleLecturerDetail.LecturerNameKH);

            try
            {
                int effected = cmd.ExecuteNonQuery();
                return (effected > 0);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating existing Schedule lecturer > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
        }

        public static bool UpdateScheduleSubject(SqlConnection con, ScheduleSubjectDetail scheduleSubjectDetail,int oldSubjectID)
        {

            SqlCommand cmd = new SqlCommand("spUpdateSubScheDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@oldsubid", oldSubjectID);
            cmd.Parameters.AddWithValue("@subID", scheduleSubjectDetail.SubjectID);
            cmd.Parameters.AddWithValue("@scheID", scheduleSubjectDetail.ScheduleID);
            cmd.Parameters.AddWithValue("@subn", scheduleSubjectDetail.SubjectName);
          
            try
            {
                int effected = cmd.ExecuteNonQuery();
                return (effected > 0);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed in updating existing Schedule subject > {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
            }
        }

    }
}
