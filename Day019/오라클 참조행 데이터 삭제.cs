
DROP TABLE EMP_FK;
DROP TABLE DEPT_FK;

CREATE TABLE DEPT_FK(
DEPTNO NUMBER(2) CONSTRAINT DDDD PRIMARY KEY,
DNAME VARCHAR2(14),
LOC VARCHAR2(13)
);

CREATE TABLE EMP_FK(
 EMPNO NUMBER(4) PRIMARY KEY,
 DEPTNO NUMBER(2) CONSTRAINT EEEE REFERENCES DEPT_FK(DEPTNO) 
                  ON DELETE CASCADE
);

INSERT INTO DEPT_FK
VALUES (1, '총무', '서울');
INSERT INTO DEPT_FK
VALUES (10, '회계', '서울');

INSERT INTO EMP_FK
VALUES (100,1);
INSERT INTO EMP_FK
VALUES (101,10);

SELECT * FROM DEPT_FK;
SELECT * FROM EMP_FK;

DELETE FROM DEPT_FK
WHERE DEPTNO = 1;
