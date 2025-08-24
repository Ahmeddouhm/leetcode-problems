/* Write your T-SQL query statement below */
SELECT DISTINCT(customer_id) , COUNT(customer_id) count_no_trans
FROM Visits V LEFT OUTER JOIN Transactions T
ON V.visit_id = T.visit_id
WHERE T.visit_id IS NULL
GROUP BY customer_id
ORDER BY count_no_trans ASC