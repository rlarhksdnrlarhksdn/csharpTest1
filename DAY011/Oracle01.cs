
SELECT * FROM employees;

employees employees;

SELECT FIRST_NAME FROM employees;
SELECT LAST_NAME FROM employees;
SELECT FIRST_NAME, LAST_NAME FROM employees;

SELECT * FROM COUNTRIES;
SELECT COUNTRY_NAME FROM COUNTRIES;

SELECT * FROM employees;
SELECT FIRST_NAME, SALARY FROM employees
order by SALARY DESC;

#사원정보
DESC emp;
#문서정보
DESC DEPT;
#사원 급여 정보
DESC SALGRADE;
#p80
SELECT * FROM EMP;
SELECT EMPNO, ENAME, DEPTNO
FROM EMP;

#1분 복습
SELECT EMPNO, DEPTNO
FROM EMP;

SELECT DEPTNO
FROM EMP;

# 중복을 제거하고 싶어요
SELECT DISTINCT DEPTNO
FROM EMP;

SELECT JOB, DEPTNO FROM EMP
ORDER BY DEPTNO;

SELECT ALL JOB, DEPTNO FROM EMP;

#P81 컬렁을 가지고 연산을 할수있습니다??
SELECT ENAME, SAL, SAL*12+NVL(COMM,0) As 연봉, NVL (COMM,0) FROM EMP;
