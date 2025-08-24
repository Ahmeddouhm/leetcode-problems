/* Write your T-SQL query statement below */
SELECT unique_id , name 
FROM Employees E LEFT OUTER JOIN EmployeeUNI EUNI
ON EUNI.id = E.id