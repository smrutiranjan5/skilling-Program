USE CognizantDB;
GO

CREATE PROCEDURE sp_GetEmployeeCountByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT
        COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

EXEC sp_GetEmployeeCountByDepartment 101;

EXEC sp_GetEmployeeCountByDepartment 102;

EXEC sp_GetEmployeeCountByDepartment 104;