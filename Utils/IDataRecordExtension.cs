using SFaSMS.Models;
using System.Data;

namespace SFaSMS.Utils;

public static class IDataRecordExtension

{
    #region Get Staff INFO. To Display On ListBox and Display Staff on TextBox When Click on ListBox
    public static Staff ToDisplayStaff(this IDataReader record)
    {
        int index = record.GetOrdinal("StaffID");
        int id = record.GetInt32(index);
        index = record.GetOrdinal("StaffNameKH");
        string? staffnameKH = record.GetString(index);
        return new Staff()
        {
            StaffID = id,
            StaffNameKH = staffnameKH,
        };
    }
    public static Staff ToDisplayStaffID(this IDataReader record)
    {
        int index = record.GetOrdinal("StaffID");
        int id = record.GetInt32(index);

        return new Staff()
        {
            StaffID = id,
        };
    }

    public static Staff ToStaffAllData(this IDataReader record)
    {
        int index = record.GetOrdinal("StaffID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("StaffNameKH");
        string? staffnameKH = record.GetString(index);

        index = record.GetOrdinal("StaffNameEN");
        string? staffnameEN = record.GetString(index);

        index = record.GetOrdinal("Gender");
        string? gender = record.GetString(index);

        index = record.GetOrdinal("BirthDate");
        DateTime birthdate = record.GetDateTime(index);

        index = record.GetOrdinal("StaffPosition");
        string? staffposition = record.GetString(index);

        index = record.GetOrdinal("StaffAddress");
        string? staffaddress = record.GetString(index);

        index = record.GetOrdinal("ContactNumber");
        string? contactnumber = record.GetString(index);

        index = record.GetOrdinal("PersonalNumber");
        string? personalnumber = null;
        if (!record.IsDBNull(index)) personalnumber = record.GetString(index);

        index = record.GetOrdinal("HiredDate");
        DateTime hireddate = record.GetDateTime(index);

        index = record.GetOrdinal("Photo");
        byte[] photo = null;
        if (!record.IsDBNull(index)) photo = (byte[])record[index];



        return new Staff()
        {
            StaffID = id,
            StaffNameKH = staffnameKH,
            StaffNameEN = staffnameEN,
            Gender = gender,
            BirthDate = birthdate,
            StaffPosition = staffposition,
            StaffAddress = staffaddress,
            ContactNumber = contactnumber,
            PersonalNumber = personalnumber,
            HiredDate = hireddate,
            Photo = photo,

        };
    }

    public static Staff ToStaffNameKHandPosition(this IDataReader record)
    {

        int index = record.GetOrdinal("StaffNameKH");
        string? staffnameKH = record.GetString(index);

        index = record.GetOrdinal("StaffPosition");
        string? staffposition = record.GetString(index);

        return new Staff()
        {
            StaffNameKH = staffnameKH,
            StaffPosition = staffposition,
        };
    }

    #endregion

    #region Get Student INFO. To Display On ListBox and Display Student on TextBox When Click on ListBox
    public static Student ToDisplayStudent(this IDataReader record)
    {
        int index = record.GetOrdinal("StudentID");
        int id = record.GetInt32(index);
        index = record.GetOrdinal("StudentNameKH");
        string? studentnameKH = record.GetString(index);
        return new Student()
        {
            StudentID = id,
            StudentNameKH = studentnameKH,
        };
    }
    public static Student ToStudentGetNameKH(this IDataReader record)
    {
        int index = record.GetOrdinal("StudentNameKH");
        string? studentnameKH = record.GetString(index);
        return new Student()
        {
            StudentNameKH = studentnameKH
        };
    }
    public static Student ToDisplayStudentID(this IDataReader record)
    {
        int index = record.GetOrdinal("StudentID");
        int studentid = record.GetInt32(index);
        return new Student()
        {
            StudentID = studentid
        };
    }
    public static Student ToStudentIDandPhoto(this IDataReader record)
    {
        int index = record.GetOrdinal("StudentNameKH");
        string? studentnameKH = record.GetString(index);

        index = record.GetOrdinal("Photo");
        byte[] photo = null;
        if (!record.IsDBNull(index)) photo = (byte[])record[index];
        return new Student()
        {
            StudentNameKH = studentnameKH,
            Photo = photo
        };
    }
    public static Student ToStudentAllData(this IDataReader record)
    {
        int index = record.GetOrdinal("StudentID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("StudentNameKH");
        string? studentnameKH = record.GetString(index);

        index = record.GetOrdinal("StudentNameEN");
        string? studentnameEN = record.GetString(index);

        index = record.GetOrdinal("Gender");
        string? gender = record.GetString(index);

        index = record.GetOrdinal("BirthDate");
        DateTime birthdate = record.GetDateTime(index);

        index = record.GetOrdinal("StudentAddress");
        string? studentaddress = record.GetString(index);

        index = record.GetOrdinal("PersonalNumber");
        string? personalnumber = record.GetString(index);

        index = record.GetOrdinal("ParentNumber");
        string? parentnumber = record.GetString(index);

        index = record.GetOrdinal("Photo");
        byte[] photo = null;
        if (!record.IsDBNull(index)) photo = (byte[])record[index];

        return new Student()
        {
            StudentID = id,
            StudentNameKH = studentnameKH,
            StudentNameEN = studentnameEN,
            Gender = gender,
            BirthDate = birthdate,
            StudentAddress = studentaddress,
            PersonalNumber = personalnumber,
            ParentNumber = parentnumber,
            Photo = photo,

        };
    }
    #endregion

    #region Get Lecturer INFO. To Display On ListBox and Display Lecturer on TextBox When Click on ListBox
    public static Lecturer ToDisplayLecturer(this IDataReader record)
    {
        int index = record.GetOrdinal("LecturerID");
        int id = record.GetInt32(index);
        index = record.GetOrdinal("LecturerNameKH");
        string? lecturernameKH = record.GetString(index);
        return new Lecturer()
        {
            LecturerID = id,
            LecturerNameKH = lecturernameKH,
        };
    }
    public static Lecturer ToDisplayLecturerID(this IDataReader record)
    {
        int index = record.GetOrdinal("LecturerID");
        int id = record.GetInt32(index);

        return new Lecturer()
        {
            LecturerID = id,

        };
    }
    public static Lecturer ToDisplayLecturerNameKH(this IDataReader record)
    {

        int index = record.GetOrdinal("LecturerNameKH");
        string? lecturernameKH = record.GetString(index);
        return new Lecturer()
        {

            LecturerNameKH = lecturernameKH,
        };
    }

    public static Lecturer ToLecturerAllData(this IDataReader record)
    {
        int index = record.GetOrdinal("LecturerID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("LecturerNameKH");
        string? lecturernameKH = record.GetString(index);

        index = record.GetOrdinal("LecturerNameEN");
        string? lecturernameEN = record.GetString(index);

        index = record.GetOrdinal("Gender");
        string? gender = record.GetString(index);

        index = record.GetOrdinal("BirthDate");
        DateTime birthdate = record.GetDateTime(index);

        index = record.GetOrdinal("LecturerAddress");
        string? lectureraddress = record.GetString(index);

        index = record.GetOrdinal("ContactNumber");
        string? contactnumber = record.GetString(index);

        index = record.GetOrdinal("PersonalNumber");
        string? personalnumber = record.GetString(index);

        index = record.GetOrdinal("Photo");
        byte[] photo = null;
        if (!record.IsDBNull(index)) photo = (byte[])record[index];

        return new Lecturer()
        {
            LecturerID = id,
            LecturerNameKH = lecturernameKH,
            LecturerNameEN = lecturernameEN,
            Gender = gender,
            BirthDate = birthdate,
            LecturerAddress = lectureraddress,
            ContactNumber = contactnumber,
            PersonalNumber = personalnumber,
            Photo = photo,

        };
    }
    #endregion

    #region #region Get Subject INFO. To Display On DataGridView and Display Subject on TextBox When Click on DataGridView
    public static Subject ToDisplaySubject(this IDataReader record)
    {
        int index = record.GetOrdinal("SubjectID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("SubjectName");
        string? subjectname = record.GetString(index);

        index = record.GetOrdinal("SubjectDescription");
        string? subjectdescription = null;
        if (!record.IsDBNull(index)) subjectdescription = record.GetString(index);

        return new Subject()
        {
            SubjectID = id,
            SubjectName = subjectname,
            SubjectDescription = subjectdescription,
        };
    }
    public static Subject ToDisplaySubjectID(this IDataReader record)
    {
        int index = record.GetOrdinal("SubjectID");
        int id = record.GetInt32(index);
        return new Subject()
        {
            SubjectID = id,
        };
    }
    public static Subject ToDisplaySubjectName(this IDataReader record)
    {
        int index = record.GetOrdinal("SubjectName");
        string? subjectname = record.GetString(index);
        return new Subject()
        {
            SubjectName = subjectname,
        };
    }
    #endregion

    #region #region Get Room INFO. To Display On DataGridView and Display Room on TextBox When Click on DataGridView
    public static Room ToDisplayRoom(this IDataReader record)
    {
        int index = record.GetOrdinal("RoomNo");
        int no = record.GetInt32(index);

        index = record.GetOrdinal("RoomNumber");
        int roomnumber = record.GetInt32(index);

        index = record.GetOrdinal("BuildingLetter");
        string? buildingletter = record.GetString(index);

        return new Room()
        {
            RoomNo = no,
            RoomNumber = roomnumber,
            BuildingLetter = buildingletter,
        };
    }
    public static Room ToDisplayRoomNo(this IDataReader record)
    {
        int index = record.GetOrdinal("RoomNo");
        int no = record.GetInt32(index);

        return new Room()
        {
            RoomNo = no,
        };
    }
    #endregion

    #region #region Get Major INFO. To Display On DataGridView and Display Major on TextBox When Click on DataGridView
    public static Major ToDisplayMajor(this IDataReader record)
    {
        int index = record.GetOrdinal("MajorID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("MajorNameKH");
        string? majornameKH = record.GetString(index);

        index = record.GetOrdinal("MajorNameEN");
        string? majornameEN = record.GetString(index);

        index = record.GetOrdinal("MajorNameAbbreviation");
        string? majornameabbreviation = record.GetString(index);

        index = record.GetOrdinal("MajorCost");
        decimal majorcost = record.GetDecimal(index);

        index = record.GetOrdinal("MajorDescription");
        string? majordescription = null;
        if(!record.IsDBNull(index))majordescription = record.GetString(index);
        return new Major()
        {
            MajorID = id,
            MajorNameKH = majornameKH,
            MajorNameEN = majornameEN,
            MajorNameAbbreviation = majornameabbreviation,
            MajorCost = majorcost,
            MajorDescription = majordescription,
        };
    }
    public static Major ToDisplayMajorID(this IDataReader record)
    {
        int index = record.GetOrdinal("MajorID");
        int id = record.GetInt32(index);

        return new Major()
        {
            MajorID = id,
        };
    }
    public static Major ToDisplayMajorNameEN(this IDataReader record)
    {
        int index = record.GetOrdinal("MajorNameEN");
        string? majornameEN = record.GetString(index);

        return new Major()
        {
            MajorNameEN = majornameEN,
        };

    }
    public static Major ToDisplayMajorNameKH(this IDataReader record)
    {
        int index = record.GetOrdinal("MajorNameKH");
        string? majornameKH = record.GetString(index);

        return new Major()
        {
            MajorNameKH = majornameKH,
        };

    }
    public static Major ToDisplayMajorCost(this IDataReader record)
    {
        int index = record.GetOrdinal("MajorCost");
        decimal majorcost = record.GetDecimal(index);

        return new Major()
        {
            MajorCost = majorcost,
        };
    }
    #endregion

    #region #region Get StudentSummary INFO. To Display On ListBox and Display StudentSummary on TextBox When Click on ListBox
    public static StudentSummary ToDisplayStudentSummary(this IDataReader record)
    {
        int index = record.GetOrdinal("StuSumID");
        int id = record.GetInt32(index);
        index = record.GetOrdinal("StudentNameKH");
        string? studentnameKH = record.GetString(index);
        return new StudentSummary()
        {
            StuSumID = id,
            StudentNameKH = studentnameKH,
        };
    }
    public static StudentSummary ToStudentSummaryAllData(this IDataReader record)
    {
        int index = record.GetOrdinal("StuSumID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("RegisterDate");
        DateTime registerdate = record.GetDateTime(index);

        index = record.GetOrdinal("Degree");
        string? degree = record.GetString(index);

        index = record.GetOrdinal("StudentID");
        int studentid = record.GetInt32(index);

        index = record.GetOrdinal("RoomNo");
        int roomno = record.GetInt32(index);

        index = record.GetOrdinal("MajorID");
        int majorid = record.GetInt32(index);

        index = record.GetOrdinal("StudentNameKH");
        string? studentnameKH = record.GetString(index);

        index = record.GetOrdinal("MajorNameKH");
        string? majornameKH = record.GetString(index);

        return new StudentSummary()
        {
            StuSumID = id,
            RegisterDate = registerdate,
            Degree = degree,
            RoomNo = roomno,
            MajorID = majorid,
            StudentID = studentid,
            StudentNameKH = studentnameKH,
            MajorNameKH = majornameKH,
        };
    }

    #endregion

    #region #region Get Schedule INFO. To Display On DataGridView and Display Schedule on TextBox When Click on DataGridView
    public static Schedule ToDisplaySchedule(this IDataReader record)
    {
        int index = record.GetOrdinal("ScheduleID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("MajorNameEN");
        string majornameEN = record.GetString(index);

        index = record.GetOrdinal("StudyYears");
        byte studyyear = record.GetByte(index);

        index = record.GetOrdinal("RoomNumber");
        int roomnumber = record.GetInt32(index);

        index = record.GetOrdinal("Shifts");
        string shift = record.GetString(index);

        index = record.GetOrdinal("StartDate");
        DateTime starttime = record.GetDateTime(index);

        index = record.GetOrdinal("EndDate");
        DateTime enddate = record.GetDateTime(index);
        return new Schedule()
        {
            ScheduleID = id,
            MajorNameEN = majornameEN,
            StudyYears = studyyear,
            room = new Room() { RoomNumber = roomnumber },
            Shifts = shift,
            StartDate = starttime,
            EndDate = enddate,
        };
    }
    public static Schedule ToScheduleAllData(this IDataReader record)
    {
        int index = record.GetOrdinal("ScheduleID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("Semester");
        byte semester = record.GetByte(index);

        index = record.GetOrdinal("MajorID");
        int majorid = record.GetInt32(index);

        index = record.GetOrdinal("StudyYears");
        byte studyyear = record.GetByte(index);

        index = record.GetOrdinal("RoomNo");
        int roomno = record.GetInt32(index);

        index = record.GetOrdinal("Shifts");
        string shift = record.GetString(index);

        index = record.GetOrdinal("Session");
        byte session = record.GetByte(index);

        index = record.GetOrdinal("StartDate");
        DateTime starttime = record.GetDateTime(index);

        index = record.GetOrdinal("EndDate");
        DateTime enddate = record.GetDateTime(index);

        index = record.GetOrdinal("MajorNameEN");
        string majornameEN = record.GetString(index);

        return new Schedule()
        {
            ScheduleID = id,
            Semester = semester,
            MajorID = majorid,
            StudyYears = studyyear,
            Session = session,
            RoomNo = roomno,
            Shifts = shift,
            StartDate = starttime,
            EndDate = enddate,
            MajorNameEN = majornameEN,
        };
    }
    public static ScheduleLecturerDetail ToScheduleLecturerDetail(this IDataReader record)
    {
        int index = record.GetOrdinal("LecturerID");
        int lectuereID = record.GetInt32(index);

        index = record.GetOrdinal("LecturerNameKH");
        string? lecturernameKH = record.GetString(index);

        index = record.GetOrdinal("DaysOfTheWeek");
        string? dayoftheweek = record.GetString(index);

        return new ScheduleLecturerDetail()
        {
            LecturerID = lectuereID,
            LecturerNameKH = lecturernameKH,
            DaysOfTheWeek = dayoftheweek,
        };
    }
    public static ScheduleSubjectDetail ToScheduleSubjectDetail(this IDataReader record)
    {
        int index = record.GetOrdinal("SubjectID");
        int SubjectID = record.GetInt32(index);

        index = record.GetOrdinal("SubjectName");
        string? subjectname = record.GetString(index);

        index = record.GetOrdinal("DaysOfTheWeek");
        string? dayoftheweek = record.GetString(index);

        return new ScheduleSubjectDetail()
        {
            SubjectID = SubjectID,
            SubjectName = subjectname,
            DaysOfTheWeek = dayoftheweek,
        };
    }

    #endregion

    #region #region Get PaymentStatus INFO. To Display On ListBox and Display PaymentStatus on TextBox When Click on ListBox
    public static PaymentStatus ToDisplayPaymentStatus(this IDataReader record)
    {
        int index = record.GetOrdinal("PaymentStatusID");
        int id = record.GetInt32(index);
        index = record.GetOrdinal("StudentNameKH");
        string? studentnameKH = record.GetString(index);
        return new PaymentStatus()
        {
            PaymentStatusID = id,
            StudentNameKH = studentnameKH,
        };
    }
    public static PaymentStatus ToPaymentStatusAllData(this IDataReader record)
    {
        int index = record.GetOrdinal("PaymentStatusID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("SemesterOneStatus");
        bool semesteronestatus =record.GetBoolean(index);


        index = record.GetOrdinal("SemesterTwoStatus");
        bool semestertwostatus = record.GetBoolean(index);


        index = record.GetOrdinal("OneYearStatus");
        bool oneyearstatus = record.GetBoolean(index);

        index = record.GetOrdinal("StudentID");
        int studentid = record.GetInt32(index);

        index = record.GetOrdinal("StudentNameKH");
        string? studentnameKH = record.GetString(index);

        return new PaymentStatus()
        {
            PaymentStatusID = id,
            SemesterOneStatus = semesteronestatus,
            SemesterTwoStatus = semestertwostatus,
            OneYearStatus = oneyearstatus,
            StudentID = studentid,
            StudentNameKH = studentnameKH,

        };
    }
    public static PaymentStatus ToDisplayPaymentStatusID(this IDataReader record)
    {
        int index = record.GetOrdinal("PaymentStatusID");
        int id = record.GetInt32(index);
        index = record.GetOrdinal("SemesterOneStatus");
        bool semesteronestatus = record.GetBoolean(index);


        index = record.GetOrdinal("SemesterTwoStatus");
        bool semestertwostatus = record.GetBoolean(index);


        index = record.GetOrdinal("OneYearStatus");
        bool oneyearstatus = record.GetBoolean(index);

        return new PaymentStatus()
        {
            PaymentStatusID = id,
            SemesterOneStatus = semesteronestatus,
            SemesterTwoStatus = semestertwostatus,
            OneYearStatus = oneyearstatus,
        };
    }

    #endregion

    #region #region Get Payment INFO. To Display On ListBox and Display Payment on TextBox When Click on ListBox

    public static Payment ToDisplayPayment(this IDataReader record)
    {
        int index = record.GetOrdinal("PaymentNo");
        int no = record.GetInt32(index);
        index = record.GetOrdinal("StudentNameKH");
        string? studentnameKH = record.GetString(index);
        return new Payment()
        {
            PaymentNo = no,
            student = new Student() { StudentNameKH = studentnameKH }
        };
    }
    public static Payment ToPaymentAllData(this IDataReader record)
    {
        int index = record.GetOrdinal("PaymentNo");
        int no = record.GetInt32(index);

        index = record.GetOrdinal("PayDate");
        DateTime paydate = record.GetDateTime(index);

        index = record.GetOrdinal("PaidAmount");
        decimal paidamount = record.GetDecimal(index);

        index = record.GetOrdinal("PaymentStatusID");
        int paymentstatusid = record.GetInt32(index);

        index = record.GetOrdinal("StaffID");
        int staffid = record.GetInt32(index);

        index = record.GetOrdinal("MajorID");
        int majorid = record.GetInt32(index);

        index = record.GetOrdinal("StaffNameKH");
        string? staffnameKH = record.GetString(index);

        index = record.GetOrdinal("StaffPosition");
        string? staffposition = record.GetString(index);

        index = record.GetOrdinal("MajorCost");
        decimal majorcost = record.GetDecimal(index);
        return new Payment()
        {
            PaymentNo = no,
            PayDate = paydate,
            PaidAmount = paidamount,
            PaymentStatusID = paymentstatusid,
            StaffID = staffid,
            MajorID = majorid,
            MajorCost = majorcost,
            StaffNameKH = staffnameKH,
            StaffPosition = staffposition,
        };
    }

    #endregion

    #region #region Get Exam INFO. To Display On DataGridView and Display Exam on TextBox When Click on DataGridView
    public static Exam ToDisplayExam(this IDataReader record)
    {
        int index = record.GetOrdinal("SubjectID");
        int subjectid = record.GetInt32(index);

        index = record.GetOrdinal("StudentID");
        int studentid = record.GetInt32(index);

        index = record.GetOrdinal("ExamScore");
        int examscore = record.GetInt32(index);

        index = record.GetOrdinal("Grade");
        string? grade = record.GetString(index);

        index = record.GetOrdinal("GPA");
        string? gpa = record.GetString(index);

        index = record.GetOrdinal("SubjectName");
        string? subjectname = record.GetString(index);

        return new Exam()
        {
            SubjectID = subjectid,
            StudentID = studentid,
            ExamScore = examscore,
            Grade = grade,
            GPA = gpa,
            SubjectName = subjectname,
        };
    }

    #endregion

    #region Get User INFO. To Display On ListBox and Display User on TextBox When Click on ListBox
    public static User ToDisplayUser(this IDataReader record)
    {
        int index = record.GetOrdinal("UserID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("Username");
        string? username = record.GetString(index);
        return new User()
        {
            UserID = id,
            Username = username,
        };
    }
    public static User ToUserAllData(this IDataReader record)
    {
        int index = record.GetOrdinal("UserID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("Username");
        string? username = record.GetString(index);

        index = record.GetOrdinal("Password");
        string? password = record.GetString(index);

        index = record.GetOrdinal("StaffID");
        int staffID = record.GetInt32(index);

        index = record.GetOrdinal("StaffNameKH");
        string? staffnameKH = record.GetString(index);

        index = record.GetOrdinal("StaffPosition");
        string? staffposition = record.GetString(index);

        return new User()
        {
            UserID = id,
            Username = username,
            Password = password,
            StaffID = staffID,
            StaffNameKH = staffnameKH,
            StaffPosition = staffposition,
        };
    }
    #endregion

    #region #region Get Attendance INFO. To Display On DataGridView and Display Attendance on TextBox When Click on DataGridView
    public static Attendance ToDisplayAttendance(this IDataReader record)
    {
        int index = record.GetOrdinal("AttendanceID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("StudentID");
        int studentid = record.GetInt32(index);

        index = record.GetOrdinal("TimeRecorded");
        DateTime timeOnly = record.GetDateTime(index);
        TimeSpan timerecorded = timeOnly.TimeOfDay;

        index = record.GetOrdinal("DateRecorded");
        DateTime daterecorded = record.GetDateTime(index);

        index = record.GetOrdinal("Status");
        bool status = record.GetBoolean(index);

        index = record.GetOrdinal("StudentNameKH");
        string? studentnameKH = record.GetString(index);

        return new Attendance()
        {
            AttendanceID = id,
            StudentID = studentid,
            TimeRecorded = timerecorded,
            DateRecorded = daterecorded,
            Status = status,
            StudentNameKH = studentnameKH,
        };
    }
    public static Attendance ToAttendanceAllData(this IDataReader record)
    {
        int index = record.GetOrdinal("AttendanceID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("TimeRecorded");
        DateTime timeOnly = record.GetDateTime(index);
        TimeSpan timerecorded = timeOnly.TimeOfDay;

        index = record.GetOrdinal("DateRecorded");
        DateTime daterecorded = record.GetDateTime(index);

        index = record.GetOrdinal("Status");
        bool status = record.GetBoolean(index);

        index = record.GetOrdinal("Generation");
        int generation = record.GetInt32(index);

        index = record.GetOrdinal("StudyYear");
        DateTime studyyear = record.GetDateTime(index);

        index = record.GetOrdinal("Class");
        string? classes = record.GetString(index);

        index = record.GetOrdinal("StudentID");
        int studentid = record.GetInt32(index);

        index = record.GetOrdinal("StudentNameKH");
        string? studentnameKH = record.GetString(index);
        return new Attendance()
        {
            AttendanceID = id,
            TimeRecorded = timerecorded,
            DateRecorded = daterecorded,
            Status = status,
            Generation = generation,
            StudyYear = studyyear,
            Class = classes,
            StudentID = studentid,
            StudentNameKH = studentnameKH,
        };
    }

    #endregion

}
