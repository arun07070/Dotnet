CREATE DATABASE Assignment4;
USE  Assignment4;

DECLARE @num INT = 5; 
DECLARE @fact BIGINT = 1;
DECLARE @i INT = 1;
WHILE @i <= @num
BEGIN
    SET @fact = @fact * @i;
    SET @i = @i + 1;
END
PRINT 'Factorial of ' + CAST(@num AS VARCHAR) + ' is ' + CAST(@fact AS VARCHAR);

CREATE PROCEDURE GenerateTable
    @num INT,
    @limit INT
AS
BEGIN
    DECLARE @i INT = 1;
    WHILE @i <= @limit
    BEGIN
        PRINT CAST(@num AS VARCHAR) + ' x ' + 
              CAST(@i AS VARCHAR) + ' = ' + 
              CAST(@num * @i AS VARCHAR);
        SET @i = @i + 1;
    END
END;
EXEC GenerateTable 5, 10;

CREATE TABLE Student (
    Sid INT PRIMARY KEY,
    Sname VARCHAR(50)
);
CREATE TABLE Marks (
    Mid INT PRIMARY KEY,
    Sid INT,
    Score INT
);

INSERT INTO Student VALUES
(1, 'Jack'),
(2, 'Rithvik'),
(3, 'Jaspreeth'),
(4, 'Praveen'),
(5, 'Bisa'),
(6, 'Suraj');
INSERT INTO Marks VALUES
(1, 1, 23),
(2, 6, 95),
(3, 4, 98),
(4, 2, 17),
(5, 3, 53),
(6, 5, 13);

CREATE FUNCTION dbo.GetResult (@score INT)
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @status VARCHAR(10);
    IF @score >= 50
        SET @status = 'Pass';
    ELSE
        SET @status = 'Fail';
    RETURN @status;
END;
SELECT 
    s.Sid,
    s.Sname,
    m.Score,
    dbo.GetResult(m.Score) AS Result
FROM Student s
JOIN Marks m ON s.Sid = m.Sid;