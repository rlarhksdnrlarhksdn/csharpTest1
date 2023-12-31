######################################################################################
# # 지역 변수
# # 단위 함수 안에서만 선언되고 사용되는 변수
######################################################################################
# # 지역 변수의 사용 범위
def MyFunction():
    temp = "안녕하세요"
    print(temp)

# 지역 변수는 외부에서 호출 할 수 없다.
# 함수 또는 코드 블럭에서 호출되고 코드블럭이 끝나는 순간 지역 변수는 메모리에서 소멸된다.

# print(temp)

# # 지역 변수 간의 관계
# # 함수 별로 같은 이름의 지역 변수를 생성하더라도 별개의 변수로 동작한다.

######################################################################################
# # 전역 변수
######################################################################################
# # 전역변수와 같은 이름으로 지역 변수를 생성시
# # 지역변수는 전역변수와는 별개의 변수로 메모리에 등록되며 함수 코드블럭 종료 시
# # 자동으로 메모리에서 소거된다.

price = 1000
def sale():
    price = 500
    print(price) # 지역 변수 price 호출

print(price) # 전역변수 price
sale()
print(price) # 전역변수 price



# # 함수 내에서 전역변수의 사용
# # global 함수 내에서 전역 변수를 사용 할 권한을 위임 받기

# price = 1000
# def sale():
#     global price # price 라는 변수는 전역 변수의 price를 사용하겠다.
#     price = 500 # 전역 변수 price에 500을 할당
#     print(price) # 전역 변수 price를 호출 : 500

# print(price) # 전역변수 price : 1000
# sale()
# print(price) # 전역변수 price : 500

# # # 함수의 전역 변수 사용이 아닌 코드블럭에서는 global을 호출 하지 않는다.
# sum = 0
# for i in range(1,101):
#     sum += i
# print(sum)

######################################################################################
# # docstring
# # 함수에 대한 주석을 관리하는 기능.
# # 삼겹 따옴표로 함수의 주석을 처리 할 수 있다.
######################################################################################
# def sale():
#   """미완성 sale 함수 입니다."""
#   pass

# print(sale._doc_)
