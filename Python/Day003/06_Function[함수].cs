######################################################################################
# # 함수의 필요성
######################################################################################
# 순차적인 정수를 누적 합산하는 값을 구하는 문제가 있다고 할때
# 아래와 같이 누적 합산 로직을 하나하나 작성하여 프로그래밍 할 수 있다. ( 틀린 결과는 아님 )
# sum = 1
# for num in range(5):
#     sum += num
# print(" ~ 4합은 : ", sum)

# sum = 1
# for num in range(6):
#     sum += num
# print(" ~ 5합은 : ", sum)

# sum = 1
# for num in range(7):
#     sum += num
# print(" ~ 6합은 : ", sum)

# sum = 1
# for num in range(8):
#     sum += num
# print(" ~ 7합은 : ", sum)

# # 만약 누적합산이 아닌 누적 곱이라고 할때
# # 모든 로직을 수정해야한다. (유지 보수성이 떨어진다.)

# sum = 1
# for num in range(5):
#     sum *= num
# print(" ~ 4합은 : ", sum)

# sum = 1
# for num in range(6):
#     sum *= num
# print(" ~ 5합은 : ", sum)

# sum = 1
# for num in range(7):
#     sum *= num
# print(" ~ 6합은 : ", sum)

# sum = 1
# for num in range(8):
#     sum += num # 만약 누락할 경우 원하는 결과를 얻을수 없다.
# print(" ~ 7합은 : ", sum)


# 1부터 100까지의 모든 합을 표현하는 로직을 구현할때
# 100 번의 반복되는 로직을 모두 작성해야한다. (반복성)

######################################################################################
# # 함수 ( 재 사용성과 유지 보수성의 증가)
# # . 반복적인 코드를 작성해 두고 언제든지 재 사용 할 수 있도록 할 수 있다.
# # . 함수의 내용을 수정 시 함수를 호출하는 모든 구문의 결과가 일괄 수정된다.
######################################################################################

# 함수의 생성 def
# def MyFunction():
#     print("안녕하세요")

# # 함수의 호출
# MyFunction()

# 함수의 인수와 인자. (아! 수주 받자매 파)
# 함수로 전달하는 값 : 인수
# 함수가 전달받기로 약속한 값 : 인자

# def MyFunction(parem): # param : 인자 (어떠한 값을 받을수 있는 변수 명)
#     print(parem)

# MyFunction("안녕하세요")

# # 잘못된 함수의 호출 (약속된 인자의 값을 전달하지 않았을 경우 오류)
# def MyFunction(parem):
#     print(parem)

# MyFunction()

######################################################################################
# # 위의 예제에서 반복되는 구문 만들기
######################################################################################
# 반복되는 구문 삭제후 함수로 만들기
# sum = 1
# for num in range(5):
#     sum *= num
# print(" ~ 4합은 : ", sum)

 
# # 함수가 처리해야 할 상황에 따른 인자 값 설정
# def MyFunction(iValue):
#     sum = 1
#     for num in range(iValue +1):
#         sum += num
#     print(" ~ ", iValue, "합은 : ",sum)

# # 함수를 호출하여 테스트
# MyFunction(5)
# MyFunction(6)
# MyFunction(7)
# MyFunction(8)
# MyFunction(9)

# # 완성된 결과에서 한번더 검토. (함수를 반복 호출하는 구문도 리펙터맇)
# def MyFunction(iValue):
#     sum = 1
#     for num in range(iValue +1):
#         sum += num
#     print(" ~ ", iValue, "합은 : ",sum)

# # # i : 함수를 실행할때 더해져야 하는 정수
# for i in range(5,10) :
#     MyFunction

######################################################################################
# # 함수의 결과를 반환하는 return
# # 파이썬의 경우 함수 반환 데이터 유형을 지정 하지 않아도 유동적으로 데이터를
# # 함수를 호출한 곳으로 반환할 수 있다.
######################################################################################
# # 함수의 결과를 호출한곳으로 반환함으로 결과값으로 로직을 이어서 구현하기 위함.
# def calsum(end):
#     sum=0
#     for i in range(end+1):
#         sum += i
#     return sum

# print(' 합은 ', calsum(10), '입니다.')
# print('입력한 값의 누적 합은', calsum(result), '입니다.')

# # 인자를 n개 생성 할수 있다.

# def calsum(end,end2,end3):
#     sum=0
#     for i in range(end+1):
#         sum += i
#     return sum
# calsum(10) # 인수를 3개 전달해야 한다. (오류)

# # pass
# # 로직을 완성하지 않았지만 미완성 로직으로 인해 오류를 잠정적으로 막고싶을때.
# # 인터프리터 언어 (프로그램을 실행 할때 비로소 오류)
for i in range(10):
    pass # 로직의 완성을 미룰떄 사용 
print("1")


######################################################################################
# # 실습.
# # 정수로 시작 과 끝의 범위 와 몇배수 인지 의 정보를 인자로 받는 함수 를 작성하여 
# # 시작 과 끝 범위 내에 있는 배수 를 모두 표현하는 로직을 구현해 보세요.
######################################################################################
# def Multiprint(sv,ev,mv):
#     message = ''
#     for i in range(sv,ev+1):
#         if i % mv == 0 : #i가 mv의 배수?
#             message += i + ','
#     return message

# fvalue = int(input("시작 값 : "))
# evalue = int(input("종료 값 : "))
# mvalue = int(input("배수 값 : "))
# print(mvalue, " 의 배수 나열 데이터 : ", Multiprint(fvalue,evalue,mvalue))

######################################################################################
# # 재귀 호출
# # . 자기 자신을 반복적으로 호출하도록 구현된 함수.
# # . 코드가 간결해 지고 가독성이 높아진다.
# # . 일반적으로 풀어내는 로직보다 실행하는데 시간이 오래 걸릴수 있다.
# # . 반드시 종료하는 시점의 값을 리턴하는 구문이 필요
######################################################################################

def factorial(n):
    if n  == 0:
        return 1
    else :
        return n * factorial(n-1)

result = factorial(5)
print(result) # 120
