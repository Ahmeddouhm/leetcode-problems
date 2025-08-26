/* Write your T-SQL query statement below */
SELECT W.id 
FROM Weather W INNER JOIN Weather WC
ON DATEADD(day, -1, W.recordDate) = WC.recordDate and W.Temperature> WC.Temperature
