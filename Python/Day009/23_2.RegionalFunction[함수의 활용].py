##########################################
# # 함수(메서드의 특징)
# # 다른 변수에 대입할 수 있다.
# # 인수로 전달할 수 있다.
# # 함수 자체를 리턴 할 수 있다.
# # 컬렉션에 저장할 수 있다.

######### 함수를 변수에 대입
# def add(a,b):
#     print(a+b)
# plus = add
# plus(1,2)

##### 함수를 인자로 전달
# def calc(op, a,b):
#     op(a,b)

# def add(a,b):
#     print(a+b)

# calc(add,1,2)


######################### 지역함수
# 함수 내에서만 동작하는 함수
# 주요 로직이 있을경우 외부에 노출하지 않도록 해주어야 하는데
# ..(접근 제한자가 없으므로 기법으로 커버)
# 외부에 노출되는 상위 메스드(함수)가
# 대신 주요 메서드(함수)를 수행하도록 하는 기법

# def calsum(n):
#     #지역함수 생성
#     def add(a,b):
#         return a+b
    
#     sum = 0
#     for i in range(n+1):
#         sum = add(sum,i)

#     return sum

# calsum(10)




########################## 지역함수의 활용
# def makehello(message) :
    
#     def hello(name):
#         print(message + ',' + name)
#     return hello

# # 지역함수 hello를 반환받아서 "good morning" 이라는 문자열리 꾸며주는 결과를
# # 실행 할 수 있도록 해주는 기능(래핑)
# enh = makehello("Good Morning")
# enh("Kim")
# enh("park")


#######################################################################33
# # 함수 데코레이터
# # . 함수에 장식을 붙이듯이 코드의 앞 뒤로 원하는 코드를 추가하는 방법
# # . 함수를 실행하기 전에 별도의 로직을 수행하거나 검증하는 로직을 구현하는 등
# # 일련의 연속적인 일을 정의해 두고 간단하게 호출하여 사용할수 있도록하는 문법

### 함수 데코레이터를 이해하기 전에
########## 함수를 래핑하는 기법 부터 학습
# # 래핑 : 주요 코드를 가운데 두고 별도의 코드를 앞뒤로 붙여서 반복적으로 수행 가능
# #        하도록 만드는 기법

# def inner() :
#     print('결과 출력')

# def outer(func) :
#     print("-" * 20)
#     func()
#     print("-" * 20)

# outer(inner)


#"결과출력"을 표현하기 전에 pint() 기능과 표현 후 print()기능이 덧붙여진
# inner() 함수를 호출한 결과가 도출
# 특정한 로직을 수행할때 반복적으로 수행하여야 하는 로직이 있을경우
# 래핑 기법을 사용하여 일괄적으로 처리할 수 있다.

# # 주요코드는 inner 이지만
# # 마치 outer 함수를 실행하여 결과를 받는것 처럼 보여서 코드의 가독성을 낮출 수가 있다.
# # inner 메서드를 호출하는 것처럼 보이지만 래퍼 기법이 적용된 기능을 구현하도록 하는 기법을
# # 래핑 기법이라고 한다.

# def inner() :
#     print('결과 출력')

# def outer(func) :
#     def wrapper():
#         print("-" * 20)
#         func()
#         print("-" * 20)
#     return wrapper

# inner = outer(inner)

# # outer 를 실행한 결과를 inner 객체에 담아서 마치
# # inner함수를 직접 호출 하는 것처럼 보이게하면 되지 않을까?
# inner()


# def inner() :
#     print('결과 출력')

# def outer(func) :
#     def wrapper():
#         print("-" * 20)
#         func()
#         print("-" * 20)
#     return wrapper
# @ outer
# def inner():
#     print("결과를 출력합니다.")

# # 아래처럼 outer에 inner를 전달하고 wrapper를 inner로 받아서 대신 호출하는
# # 구문이 굉장리 비효율적으로 보인다.
# # inner = outer(inner)
# # inner()
# # # 위의 호출부분을 간단히 처리할수 있도록 해주는 문법 (데코레이터)

# inner()

# # 데코레이터의 활용
# # 웹 페이지의 태그를 자동으로 생성해 주는 데코레이터

# def makeP(func):
#     def wrap():
#             return "<p>" + func() + "<p>"
#     return wrap
# @makeP
# def makeP(func):
#     def wrap():
#             return "<div>" + func() + "</div>"
#     return wrap

# @makeP
# def PrintTag() :
#       return "김범수"

# print(PrintTag())


###########################################################
# # 클래스 데코레이터
# # - 클래스의 객체 를 호출전, 호출후로 수행하는 로직을 작성해 두는 기능
# # . 메인 함수의 클래스 래핑

class outer :
    def __init__(self,func):
        self.func = func

    def caller(self):
        print("****")
        self.func()
        print("****")
@outer
def inner():
    print("결과를 출력합니다.")

inner = outer(inner)







