#Q1
#EMP 테이블을 사용화여 다음과 같이 사원 이름이 s로 끝나는 사원 데이터를 모두 출력
SELECT * FROM EMP 
WHERE ENAME LIKE '%S';

#Q2
#EMP 테이블을 사용하여 30번 부서에서 근무하고 있는 사원 중에 직책이 SALESMAN인 사원
#사원 번호, 이름, 직책, 급여 부서 번호를 출력하는 SQL문 작성
SELECT EMPNO, ENAME, JOB, SAL, DEPTNO FROM EMP
WHERE DEPTNO =30
INTERSECT
SELECT EMPNO, ENAME, JOB, SAL, DEPTNO FROM EMP 
WHERE JOB IN 'SALESMAN';

#Q3
#EMP 테이블을 사용하여 20번, 30번 부서에 근무하고 있는 사원 중 급여가 2000 초과인 사원
#집합연산자가 아닌 방식, 집합 연산자

# 집합연산자가 아닌 방식
SELECT EMPNO , ENAME , JOB , SAL , DEPTNO FROM EMP 
WHERE DEPTNO =20 AND SAL >2000 OR DEPTNO =30 AND SAL >2000;
# 집합 연산자
SELECT EMPNO, ENAME, JOB, SAL, DEPTNO FROM EMP 
WHERE DEPTNO = 20 AND SAL > 2000
UNION
SELECT EMPNO, ENAME, JOB, SAL, DEPTNO FROM EMP
WHERE DEPTNO =30 AND SAL > 2000;

# Q4 이번에는 NOT BETWEEN A AND B연사자를 쓰지 않고
# 급여 열 값이 2000 이상 3000 이하 범위 이외의 값을 가진 데이터만
SELECT EMPNO, ENAME, JOB, SAL, DEPTNO FROM EMP
WHERE NOT (SAL>=2000 AND SAL<=3000);

# Q5 사원 이름에 E가 포함되어 있는 30번 부서의 사원 중 급여가 1000~2000사이가 아닌
# 사원이름, 사원 번호, 급여, 부서 번호를 출력하는 SQL문 작성
SELECT ENAME,EMPNO,SAL,DEPTNO FROM EMP 
WHERE ENAME LIKE '%E%' AND SAL NOT BETWEEN 1000 AND 2000 AND DEPTNO=30;

# Q6 추가 수당이 존재하지 않고 상급자가 있고 직책이 MANAGER, CLERK인 사원 중에서 사원 이름의 두번째
#글자가 L이 아닌 사원의 정보를 출력하는 SQL문
SELECT * FROM EMP
WHERE COMM IS NULL
AND MGR IS NOT NULL
AND JOB IN ('MANAGER', 'CLERK') 
AND ENAME NOT LIKE '_L%'; 
