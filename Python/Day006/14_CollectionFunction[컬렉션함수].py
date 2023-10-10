######### enumerate() 함수
# # # 순서 아 값을 순차적을 반한하는 함수

# # # 이부 변수 를 이용하여 현재 루프의 순번 찾아내기.
# lists = [10,20,30,40,50]
# iCnt = 0
# for num in lists :
#     iCnt += 1
#     print(iCnt , " 번째의 숫자는 ", num)

# # # enumerate(lists,1) : lists 를 인자로,  1 부터 1씩 증가하는 값을 반환
# for no, value in enumerate(lists,1) :
#     print(no , " 번째의 숫자는 ", value)


#### n  개의 컬렛션 합치기 Zip
# # 쌍이 맞는 개수 만큼만 반환
# yoil = ['월',    '화',   '수',    '목',    '금','토','일']
# food = ['자장면','볶음밥','돈가스','삼겹살']
# menu = zip(yoil,food) # yoil 리스트 와 food 리스트를 1:1 로 매핑.
# print(menu) # <zip object at 0x000001F9C28205C0> 데이터를 출력하는 기능이 구현되어 있지 않다.
# for y,f in menu:
#     print("%s 요일의 음식은 %s 입니다." %(y,f) )


# # zip 객체를 dict 객체로 변환하기.
# yoil = ['월',    '화',   '수',    '목',    '금','토','일']
# food = ['자장면','볶음밥','돈가스','삼겹살']
# menu = dict(zip(yoil,food)) # zip 의 결과를 dict 형태로 변환 가능
# print(menu) # dict 형태는 데이터 출력 기능이 구현되어 있다.
# # {'월': '자장면', '화': '볶음밥', '수': '돈가스', '목': '삼겹살'}



# # Any() 와 All() 
# # any() : 하나라도 True 이면  True 
# # all() : 모두다   True 이어야 True
# lists = [True,True, False]
# print(any(lists)) # True
# print(all(lists)) # Flse


# # filter() 
# # 함수 와 리스트를 인자로 전달 받아서 True 인 결과 만 리스트로 생성하여 반환
# #  . 함수의 return 은 True/False 이어야 한다. 
# def MyFunction(s) :
#     return s < 60 # bool 반환 유형

# lists = [20,30,40,50,60,70,80] 
# lists2 = filter(MyFunction, lists)
# print(lists2) # 출력 기능이 구현되어 있지 않다.
# for value in lists2 : 
#     print(value, end = ',')



# # map()
# # 함수와 리스트를 인자로 받아서 연산의 결과 를 리스트로 생성
# def half(s) :
#     return s/2

# score = [45,46,47,48,48,60] 
# for value in map(half,score) :
#     print(value, end = ',')



# # map 을 이용한 연산처리 예제 
# def f_sum(v1,v2) :
#     return v1 + v2

# score1 = [45,46,47,48,48,60] 
# score2 = [22,33,43,]  # 원소의 쌍이 같은 데이터 만 처리하여 반환
# for value in map(f_sum,score1,score2) :
#     print(value, end = ',')



# # f_sum : 함수의 이름
# # 함수 이름을 제외한 함수의 기능만 설명 하는것을 메서드(함수) 의 시그니처 
# # (v1,v2) 인자 
# #  return v1 + v2   반환하는 식
# def (v) :  
#     return v * 2
# # 람다 : 함수의 이름을 제외한 메서드 시그니처 만 가지고 기능을 할 수  있도록 도와주는 기능
 

#############################################################################
# # Lambda
# # 이름이 없는 메서드(무명메서드) 를 간결하게 작성해서 사용할수 있도록 하는 문법(기능)
# # . 재사용을 하지 않는 로직일 경우 (2번이상 사용하지 않는다) 메서드(함수) 를 굳이 작성할 필요없다.
# # . 함수 를 전달받는 인자 가 있을경우 
# #   재사용을 하지 않는 메서드는 람다로 간결하게 구성하여 전달 할 수 있다.
#############################################################################
# # 메서드(함수)의 시그니처 
# # 메서드(함수) 의 이름을 제외한 인자유형, 반환 유형을 메서드의 시그니처 라고 한다.
# # 람다는 함수의 이름을 제외하고 함수를전달받는 인자에게 메서드의 시그니처만 전달하는 유형


# # # 람다 의 구현 예제
# def Myfunction_anClass(func, v1, v2) : # 외부 에서 작성한 개발자가 접근할수 없는 메서드 (함수)
#     return func(v1,v2)

# # # Myfunction_anClass 를 사용하는 개발자 가 호출할때
# def mf(v,s) :
#     return v+s

# # # print(Myfunction_anClass(mf, 10, 20))

# # # 함수 를 만들 필요 없이 람다 로 생성 하여 호출한다.
# print(Myfunction_anClass(lambda x,y : x + y , 10, 20))


# # filter 함수의 lambad
# # 함수를 받기로 약속되어있는 클래스
# score = [10,20,30,40,50]
# for num in filter(lambda x : x % 8 == 0 , score) :
#     print(num)







###################################################################################
# # 실습 
# # 아래 map 클래스의 기능을 f_sum 함수를 사용하지 않고 lambda 를 통해 간략히 구현해 보세요

# def f_sum(v1,v2) :
#     return v1 + v2

# score1 = [45,46,47,48,48,60] 
# score2 = [22,33,43,]  # 원소의 쌍이 같은 데이터 만 처리하여 반환
# for value in map(f_sum,score1,score2) :
#     print(value, end = ',')
###################################################################################
# score1 = [45,46,47,48,48,60] 
# score2 = [22,33,43,]  # 원소의 쌍이 같은 데이터 만 처리하여 반환
# for value in map(lambda  t,j : t+j, score1,score2) :
#     print(value, end = ',')















####### 리스트의 얕은 복사
# # 리스트 를 직접 변수에 할당할 경우 참조형식으로 데이터 주소를 전달한다. 
# # 원본 과 데이터를 공유한다.
# score = [45,50,4,5,6,7,9]
# score_back = score
# score_back[0] = 10
# print(score_back)
# print(score) # 얕은 복사 로 인해 원본 데이터가 변질 된것을 확인 할 수 있다.


######## 리스트의 깊은 복사 1 
# score = [45,50,4,5,6,7,9]
# score_back = score.copy() # 원본 리스트의 깊은 복사 
# score_back[0] = 10
# print(score_back)
# print(score) # 깊은복사 로 인해 원본 데이터 변질을 막을수 있다.



######## 리스트의 깊은 복사 2 범위 지정
# score = [45,50,4,5,6,7,9]
# score_back = score[:] # 범위 지정을 통한 원본 리스트의 깊은 복사 
# score_back[0] = 10
# print(score_back)
# print(score) # 깊은복사 로 인해 원본 데이터 변질을 막을수 있다.




############ 중첩 리스트의 깊은 복사 
# import copy # 복사를 위한 상세한 기능이 모여있는 외부 모듈

# score = [45,[10,20,30],4,5,6,7,9]
# # score_back = score.copy()  # 중첩 리스트의 경우 cpoy() 메서드로는 깊은복사를 할 수 없다.
# score_back = copy.deepcopy(score)
# score[1][1] = 0
# print(score_back)
# print(score) # 깊은복사 로 인해 원본 데이터 변질을 막을수 있다.



################## 같은 메모리를 참조 하고있는지 (같은 메모리 주소를 공유하고있는지) 확인 
# # is 연산자
# list1 = [10,20,30]
# list2 = list1        # 얕은 복사
# list3 = list1.copy() # 깊은 복사 

# print("list1 과 list2 는 같은 주소를 바라보고있나요 ? ", list1 is list2) # True  
# print("list2 과 list3 는 같은 주소를 바라보고있나요 ? ", list2 is list3) # False
# print("list1 과 list3 는 같은 주소를 바라보고있나요 ? ", list1 is list3) # False




############################### 변수의 참조 변경 
# # str , int 유형의 데이터 는 값형식
# # 파이썬의 경우 값형식이라도 데이터 주소를 공유 
# a = '가'
# b = a 
# print("a 와 b 는 같은 주소를 바라보고있나요 ? ", a is b) # True
# b = '나'
# print(a)
# print(b)
# print("a 와 b 는 같은 주소를 바라보고있나요 ? ", a is b) # Flase





####################################################
# # 실습 
# # 1 ~ 100 정수 리스트 , 1 ~ 100 제곱 리스트 ,병합 -> 사전  
# # 6의 제곱 값 출력
####################################################
# list1 = [i   for i in range(1,101)]
# list2 = [i*i for i in range(1,101)]
# # # 두 리스트의 병합
# lsit3 = zip(list1, list2)
# dic = dict(lsit3)
# print(dic)
# print(dic[6])






#######################################################################
# # 실습 2
# # price 4개 값 리스트  , map() 클래스 사용, 20% 할인된 가격 출력.
#######################################################################
# price = [1000, 2000, 3000, 4000]
# for result in map(lambda x : x * 0.8 , price ):
#     print(result, end =", ")
