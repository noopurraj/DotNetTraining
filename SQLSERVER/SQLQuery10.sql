/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [customerID]
      ,[Name]
      ,[address]
      ,[country]
  FROM [customersDB].[dbo].[customers]