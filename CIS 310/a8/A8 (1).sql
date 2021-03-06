﻿--A8
--72
SELECT MOVIE_TITLE, MOVIE_YEAR, MOVIE_GENRE
FROM MOVIE

--73
SELECT MOVIE_YEAR, MOVIE_TITLE, MOVIE_COST
FROM MOVIE
ORDER BY MOVIE_YEAR DESC, MOVIE_COST DESC

--74
SELECT MOVIE_TITLE, MOVIE_YEAR, MOVIE_GENRE
FROM MOVIE
ORDER BY MOVIE_GENRE ASC, MOVIE_YEAR DESC
--75
SELECT MOVIE_NUM, MOVIE_TITLE, PRICE_CODE
FROM MOVIE
WHERE MOVIE_TITLE LIKE 'R%'

--76
SELECT MOVIE_TITLE,MOVIE_YEAR,MOVIE_COST
FROM MOVIE
WHERE MOVIE_TITLE LIKE '%HOPE%'
--77
SELECT MOVIE_TITLE, MOVIE_YEAR, MOVIE_GENRE
FROM MOVIE 
WHERE MOVIE_GENRE = 'ACTION'
--78
SELECT MOVIE_NUM, MOVIE_TITLE, MOVIE_COST
FROM MOVIE
WHERE MOVIE_COST > 40.00
--79
SELECT MOVIE_NUM, MOVIE_TITLE, MOVIE_COST, MOVIE_GENRE
FROM MOVIE
WHERE MOVIE_COST < 50.00 AND
 (MOVIE_GENRE = 'ACTION' OR
 MOVIE_GENRE = 'COMEDY')
ORDER BY MOVIE_GENRE ASC
--80
SELECT MOVIE_NUM, CONCAT(MOVIE_TITLE ,' (', MOVIE_YEAR,') ' , MOVIE_GENRE) AS [MOVIE DESCRIPTION]
FROM MOVIE
--81
SELECT MOVIE_GENRE, COUNT(*) AS [NUMBER OF MOVIES]
FROM MOVIE
GROUP BY MOVIE_GENRE
--82
SELECT AVG(MOVIE_COST) AS [AVERAGE MOVIE COST]
FROM MOVIE
--83
SELECT MOVIE_GENRE, AVG(MOVIE_COST) AS [AVERAGE COST]
FROM MOVIE
GROUP BY MOVIE_GENRE
--84
SELECT M.MOVIE_TITLE, M.MOVIE_GENRE, P.PRICE_DESCRIPTION, P.PRICE_RENTFEE
FROM MOVIE M INNER JOIN PRICE P
ON M.PRICE_CODE = P.PRICE_CODE
--85
SELECT M.MOVIE_GENRE, AVG(PRICE_RENTFEE) AS [AVERAGE RENTAL FEE]
FROM MOVIE M INNER JOIN PRICE P
ON M.PRICE_CODE = P.PRICE_CODE
GROUP BY M.MOVIE_GENRE
--86
SELECT M.MOVIE_TITLE, M.MOVIE_YEAR, (M.MOVIE_COST / P.PRICE_RENTFEE) AS [BREAKEVEN RENTALS]
FROM MOVIE M INNER JOIN PRICE P
ON M.PRICE_CODE = P.PRICE_CODE
--87
SELECT MOVIE_TITLE, MOVIE_YEAR
FROM MOVIE
WHERE PRICE_CODE IS NOT NULL
--88
SELECT MOVIE_TITLE, MOVIE_YEAR, MOVIE_COST
FROM MOVIE
WHERE MOVIE_COST BETWEEN 44.99 AND 49.99
--89
SELECT M.MOVIE_TITLE,M.MOVIE_YEAR,P.PRICE_DESCRIPTION,P.PRICE_RENTFEE,M.MOVIE_GENRE
FROM MOVIE M INNER JOIN PRICE P
ON M.PRICE_CODE = P.PRICE_CODE
WHERE MOVIE_GENRE = 'FAMILY' OR MOVIE_GENRE = 'COMEDY' OR MOVIE_GENRE = 'DRAMA'
--90
SELECT MOVIE_NUM, MOVIE_TITLE, MOVIE_YEAR
FROM MOVIE
WHERE MOVIE_NUM NOT IN (SELECT MOVIE_NUM FROM VIDEO);
--91
SELECT MEM_NUM, MEM_FNAME, MEM_LNAME, MEM_BALANCE
FROM MEMBERSHIP
WHERE MEM_NUM IN (SELECT MEM_NUM FROM RENTAL);
--92
SELECT ​MIN (MEM_BALANCE) AS [Minimum Balance],
	   ​​MAX(MEM_BALANCE) AS [Maximum Balance],
​​	   AVG(MEM_BALANCE) AS [Average Balance]
FROM ​MEMBERSHIP
WHERE ​MEM_NUM IN (SELECT MEM_NUM FROM RENTAL);
--93
SELECT CONCAT(​MEM_FNAME, ' ' , MEM_LNAME) AS [Membership Name],
	   CONCAT​​(MEM_STREET , ' ' , MEM_CITY , ', ' , MEM_STATE , '  ' , MEM_ZIP)
	   ​​AS [Membership Address]
FROM ​MEMBERSHIP;
--94
SELECT ​RENTAL.RENT_NUM, RENT_DATE, VIDEO.VID_NUM, MOVIE_TITLE,
​	DETAIL_DUEDATE, DETAIL_RETURNDATE
FROM ​RENTAL, DETAILRENTAL, VIDEO, MOVIE
WHERE ​RENTAL.RENT_NUM = DETAILRENTAL.RENT_NUM
	AND​ DETAILRENTAL.VID_NUM = VIDEO.VID_NUM
	AND​ VIDEO.MOVIE_NUM = MOVIE.MOVIE_NUM
ORDER BY RENTAL.RENT_NUM, MOVIE_TITLE;
--95
SELECT ​RENTAL.RENT_NUM, RENT_DATE, VIDEO.VID_NUM, MOVIE_TITLE,
	​DETAIL_DUEDATE, DETAIL_RETURNDATE,
​	DETAIL_RETURNDATE – DETAIL_DUEDATE AS "Days Past Due"
FROM ​RENTAL, DETAILRENTAL, VIDEO, MOVIE
WHERE ​RENTAL.RENT_NUM = DETAILRENTAL.RENT_NUM
	AND ​DETAILRENTAL.VID_NUM = VIDEO.VID_NUM
	AND​ VIDEO.MOVIE_NUM = MOVIE.MOVIE_NUM
	AND​ DETAIL_RETURNDATE > DETAIL_DUEDATE
ORDER BY RENTAL.RENT_NUM, MOVIE_TITLE;
--96
SELECT ​RENTAL.RENT_NUM, RENT_DATE, MOVIE_TITLE, DETAIL_FEE
FROM ​RENTAL, DETAILRENTAL, VIDEO, MOVIE
WHERE ​RENTAL.RENT_NUM = DETAILRENTAL.RENT_NUM
		AND​ DETAILRENTAL.VID_NUM = VIDEO.VID_NUM
		AND​ VIDEO.MOVIE_NUM = MOVIE.MOVIE_NUM
		AND ​DETAIL_RETURNDATE <= DETAIL_DUEDATE;
--97
SELECT ​MEMBERSHIP.MEM_NUM, MEM_LNAME, MEM_FNAME,
		​SUM(DETAILRENTAL.DETAIL_FEE) AS "Rental Fee Revenue"
FROM ​MEMBERSHIP, RENTAL, DETAILRENTAL
WHERE ​MEMBERSHIP.MEM_NUM = RENTAL.MEM_NUM
		AND​ RENTAL.RENT_NUM = DETAILRENTAL.RENT_NUM
GROUP BY MEMBERSHIP.MEM_NUM, MEM_LNAME, MEM_FNAME;
--98
SELECT ​MOVIE_NUM, M.MOVIE_GENRE, AVGCOST AS "Average Cost",
​MOVIE_COST,
​((MOVIE_COST – AVGCOST)/AVGCOST * 100) AS "Percent Difference"
FROM ​MOVIE M, ​(SELECT MOVIE_GENRE, AVG(MOVIE_COST) AS AVGCOST
​FROM MOVIE
​GROUP BY MOVIE_GENRE) S
WHERE M.MOVIE_GENRE = S.MOVIE_GENRE;
 

