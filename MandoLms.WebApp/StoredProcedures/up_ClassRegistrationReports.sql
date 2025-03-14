CREATE PROCEDURE ClassRegistrationReport
AS
BEGIN
	SELECT
		Cls.ClassName,
		Tch.TeacherName,
		COUNT(CASE WHEN ClReg.HasPaidFees = 1 THEN ClReg.Student_ID END) AS NumberOfStudentsWithPaidFees,  
		COUNT(ClReg.Student_ID) AS NumberOfRegisteredStudents
		FROM [dbo].[Class] Cls
	LEFT JOIN [dbo].[Teacher] Tch
		ON Cls.Teacher_ID = Tch.Teacher_ID
	FULL OUTER JOIN [dbo].[ClassRegistration] ClReg
		ON ClReg.Class_ID = Cls.Class_ID
	LEFT JOIN [dbo].[Student] Stu
		ON ClReg.Student_ID = Stu.Student_ID
	GROUP BY Cls.ClassName, Tch.TeacherName;
END
GO