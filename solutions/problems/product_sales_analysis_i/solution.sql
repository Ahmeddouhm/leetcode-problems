/* Write your T-SQL query statement below */
SELECT product_name, year, price
FROM Product P RIGHT OUTER JOIN Sales S
ON P.product_id = S.product_id
