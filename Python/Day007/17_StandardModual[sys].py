# # 프로그램 시스템의 정보 확인하기 ##############################
# # 이기종 간의 통신 ( 다른 설비 나 장비 등에 통신을 할경우 규약 을 확인하고 맞출 수 있기)
# # 컴퓨터가 메모리에 데이터를 저장 할 때 처리하는 방식 을 확인할 수 있다.


# import sys

# print('버전' ,   sys.version)
# print("플랫폼" , sys.platform)
# if (sys.platform == 'win32'):
#     print(sys.getwindowsversion())
# # little 엔디언 : 데이터를 통신할때 방식, 작은데이터를 우선으로 받아서 처리
# # big 엔디언 : 큰 데이터를 우선으로 받는다. 
# # little 작은것 부터 0 ~ 100 데이터가 저장.
# # Big 큰것부터 0 ~ 100 데이터가 저장. 
# print('바이트순서' ,sys.byteorder) # little 
# print('모듈 경로', sys.path)



# ##### 외부 에서 파이썬 모듈 실행하기 ########
# # # 달력 의 정보를 표현 (인수에 따른 다른 결과)
# import sys
# import time
# import calendar

# # 외부에서 모듈을 실행하였을때 전달 인수를 1개만 주었을경우(모듈에 대한 명칭)
# if (len(sys.argv)) == 1 :
#     t = time.time()
#     tm = time.localtime()
#     calendar.prmonth(tm.tm_year, tm.tm_mon) 
# # 프로그램 명칭 , 년도 를 외부에서 전달 하였을 경우.
# elif (len(sys.argv)) == 2 :
#     print(calendar.calendar(int(sys.argv[1]))) # 전달 받은 년도의 달력 보여주기.
# # 프로그램 명칭 , 년도 , 월 외부에서 전달 하였을 경우.
# elif (len(sys.argv)) == 3 :
#      # 전달 받은 년도/ 월 의 달력 보여주기.
#     print(calendar.prmonth(int(sys.argv[1]) , int(sys.argv[2])))
# else :
#     print("전달 받은 값의 개수 가 정확하지 않습니다.")




### 기념일 계산하기 #######
# # time.mktim() 
# # 년, 월, 일,시, 분, 초....  을 튜플로 전달 받아 기준시간 에서 경과된 초 를 구하는 함수

import time

year  = int(input('년도 : '))
month = int(input('월 : '))
day   = int(input("일 : "))

# # 데이터를 전달하기 위해 튜플.
# # 튜플의 인수는 총 9 개 로 세부적인 시간에 대한 정보를 필수로 입력해야한다.
#     년    월     일   시  분  초   mis   (X)   (X)
tm = (year, month, day, 0,  0,  0,  0,    0,    0)
#  time.time()    : 현재 시각 
# time.mktime(tm) : 과거 시각
# (time.time() - time.mktime(tm))  : 경과 된 초 
# / (24 * 60 * 60) : 초를 일 단위로 변경
ellaps = int((time.time() - time.mktime(tm)) / (24 * 60 * 60))
print(str(ellaps) + "일째 입니다.")
