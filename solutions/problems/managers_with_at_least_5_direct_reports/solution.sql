/* Write your T-SQL query statement below */
SELECT MGR.name 
FROM Employee MGR INNER JOIN Employee EMP
ON MGR.id = EMP.managerId 
GROUP BY MGR.name , MGR.id
HAVING COUNT(EMP.managerId) >= 5
