CREATE OR REPLACE NONEDITIONABLE PROCEDURE "SYSTEM"."YEMEKEKLEME" (x1 IN NVarchar2 ,x2 IN NVarchar2,x3 IN NVarchar2,x4 IN NVarchar2,x5 IN NVarchar2,x6 IN NVARCHAR2, f1 OUT SYS_REFCURSOR) AS BEGIN 
IF x6='EXIST' THEN OPEN f1 FOR SELECT * FROM yyemek WHERE YemekId =x1;
ELSIF x6= 'INSERT' THEN INSERT INTO YYEMEK(Tarih,Corba,AnaYemek,TATLI)VALUES(x2,x3,x4,x5);
ELSIF x6='UPDATE' THEN UPDATE YYEMEK SET Tarih=x2,CORBA=x3 ,ANAYEMEK=x4 ,Tatli=x5 WHERE YemekId=x1;
ELSIF x6='SELECT' THEN OPEN f1 FOR SELECT * FROM yyemek  ORDER BY Tarih ASC;
ELSIF x6='DELETE' THEN DELETE FROM YYEMEK WHERE YEMEKID=x1;
END IF ;
END;