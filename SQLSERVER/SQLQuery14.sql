/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [studentID]
      ,[Name]
      ,[marks]
      ,[Quality]
      ,[CategoryID]
  FROM [studentsDB].[dbo].[students]