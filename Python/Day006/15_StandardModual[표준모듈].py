############################################################
# # 모듈 
# # 파이썬 코드를 작성해 놓은 스클립트 파일,  함수, 변수, 클래스 등이 정의되어있는 파일
# # . 누군가가 작성해둔 복잡한 로직을 활용하여 프로그램의 개발 생산성을 향상 시킬수 있다.
# # . import : 외부 모듈을 참조. 
############################################################


### math 모듈 의 import
# import math
# print(math.sqrt(2)) # 2의 제곱근

# def sqrt(value) :
#     return value**2

# print(sqrt(2))


#### from , import 
# # math 모듈 에서 sqrt 함수만 사용
# from math import sqrt
# # 사용할 때는 math 를 붙이지 않아도 된다.
# print(sqrt(2))

### 모든 함수 참조하기
# from math import *
# # 사용할 때는 math 를 붙이지 않아도 된다.
# print(sqrt(2))
# print(log(2))


############## 모듈에 별칭주기. as
# import  math as m
# # 사용할 때는 math 를 붙이지 않아도 된다.
# print(m.sqrt(2))
# print(m.log(2))

############## 모듈 함수에  별칭주기. as
# from math import sqrt as sq
# # 사용할 때는 math 를 붙이지 않아도 된다.
# print(sq(2))


############# math 모듈을 이용하여 sin 곡선 그리기
# import math
# import turtle as t  # 그림을 그려주는 모듈

# t.penup()       # 그림판 open
# t.goto(-720,0)  # 붓펜의 위치 이동
# t.pendown()     # 붓펜 그리기시작. 
# for x in range(-720 , 720) :
#     t.goto(x,math.sin(math.radians(x)) * 100 )
# t.done() # 그리기 종료





##############################현재 시각을 나타내는 모듈
# import time
# print(time.time()) # 1970 년 1월1일 자정 부터의 초.

# # # 현재 일시를 나타내기 
# t = time.time()
# print(time.localtime(t)) # 키와 값 형태의 데이터로 추출

# now = time.localtime(t)
# print("%d 년 %d 월 %d 일" %(now.tm_year, now.tm_mon, now.tm_mday))



# # 프로그램의 구동 시간을 확인
# import time
# start = time.time() # 시작 시간
# for i in range(1,10000) : 
#     i*i
# end = time.time() # 종료 시간
# print("프로그램 구동 시간 은 : " , end - start)



# # 프로세스의 일시 정지.
# import time
# print("안녕하세요")
# time.sleep(1) # 1초간 프로세스 홀딩
# print("밤에 성시경이 두명있으면 뭘까요?")
# time.sleep(3)
# print("야간 투시경 입니다.")



############################################
# # 달력 모듈 calendar

# import calendar as c
# print(c.calendar(2021))
# print(c.month(2021,9))





# # 찾고자하는 일의 요일을 확인
# import calendar as ca
# yoil = ['월', '화', '수', '목', '금', '토', '일']
# day  = ca.weekday(1995,8,15)
# print("1995 년 광복절은 %s 요일입니다."  %yoil[day])



##################################################
# # 난수 Random
# # 임의의 수를 무작위로 생성하여 전달하는 모듈


# # 난수생성 함수 
# import random as ran
# print(ran.random()) # 0~0.999999 까지의 난수 생성
# print(ran.randint(1,10)) # 1 ~ 10 까지의 난수 생성. 
# print(ran.uniform(1,100)) # 일정한  알고리즘을 통하여 난수의 결과를 반환 
#                           # 데이터의 암호화 를 작성할때 사용
#                           # 시작값 + ( 종료값 - 시작값) * 난수



# # 컬렉션에서 임의의 값을 추출하는 함수. choice 
# import random as ran
# food = ["자장면", "짬뽕", "탕수육" , "군만두"]
# print(ran.choice(food))



# # randint() 와 randrange()
# import random as ran
# food = ["자장면", "짬뽕", "탕수육" , "군만두"]
# i = ran.randint(0,len(food) - 1 ) # randint 는 이상 이하의 범위
# print(food[i])
# i = ran.randrange(len(food)) # randrange 는 이상 , 미만의 범위.
# print(food[i])



# # 리스트의 내용을 임의로 뒤섞기 
# import random as ran
# food = ["자장면", "짬뽕", "탕수육" , "군만두"]
# ran.shuffle(food) # 원본 리스트의 배열을 바꾼다.
# print(food)


# # 임의의 6개 데이터 추출하기
# import random as ran
# num = [n for n in range(1,46)]
# print(ran.sample(num,6))

