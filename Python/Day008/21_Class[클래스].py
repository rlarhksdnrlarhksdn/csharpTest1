#########################################################
# # 클래스 
# # . 구현하고자 하는 대상을 모듈(파트, 코드블럭) 별로 나누어서 미리설계(작성, 프로그래밍)
# #   하여 두고 프로그램 구현 시 필요한 부분에서 호출(인스턴스화) 하여 사용하는 요소
# # 캡슐화 
# # .  연관있는 기능 들을 클래스에 등록하여 두고 클래스 인스턴스가 호출하여 사용 할수 있도록
# #    클래스 내부에 필요한 기능들을 구성하는 단계
# # 인스턴스 변수 
# # . 인스턴스 화 된 객체 에서 단독으로 사용 할 수 있는 변수 


# # 클래스 생성 과 캡슐화, 클래스 의 인스턴스 화 예제
# class Account :  # 클래스 이름 및 클래스 생성 선언.
#     # 클래스 생성자 멤버 (클래스가 인스턴스화 될때 자동으로 호출)
#     def __init__(self, blance , bankname) :
#         # 생성자는 클래스 인스턴스 변수 초기화 
#         self.blance   = blance # self.blance : 
#                                # Account 클래스의 인스턴스 변수
#                                # 객체가 소멸되기 전까지 계속 객체 별로 값을 유지 한다.
#         self.bankname = bankname 

#      # 클래스의 메서드 멤버 
#      # 개발자가 클래스를 사용하기 위하여 필요한 로직을 임의로 작성해 두는곳 
#      # 예금 관련 메서드 
#     def deposit(self, money) :
#         # 객체 의 잔액을 증가 
#         self.blance += money 

#     def withdraw(self, money) :
#         # 객체의 잔액을 차감 
#         self.blance = self.blance - money

#     def inquire(self) :
#         # 은행 별 잔액을 확인
#         return self.bankname, self.blance
    

# # Account 클래스 의 인스턴스 화 및 객체화 
# # 인스턴스화 : 클래스 를 heap 메모리 영역에 등록
# # 객체화 : stack 에 등록해둔 객체의 이름 에 클래스 인스턴스 주소를 전달하는 과정

# # sinhan 이라는 객체에 Account 클래스를 인스턴스화 하여 주소를 전달(객체화)
# sinhan = Account(8000, '신한은행') 
# sinhan.deposit(10000) 
# # sinhan 객체의 이름과 잔고 를 알고 싶을떄
# info = sinhan.inquire()  
# print("%s 은행의 잔고는 %d 입니다." %(info[0], info[1]))


# nonghyup = Account(10000, '농협')
# nonghyup.withdraw(2000) # 농협 계좌에서 2000원을 인출 
# info = nonghyup.inquire()
# print("%s 은행의 잔고는 %d 입니다." %(info[0], info[1]))
# # balance 라는 민감한 정보를 외부에 노출하지 않고 주어진 기능으로만 은행의 업무를
# # 수행하는 프로그래밍을 구현 할 수 있다.
 






##########################
# # 클래스 상속 
# # . 공통 기능을 구현하는 클래스(부모클래스) 를 구현해 두고 
# #   부모 클래스를 상속받은 자식 클래스는 각각 특징적인 기능을 구현하게 한다.
# # . 공통 기능을 하나로 만들어 두고 호출하는 방식 으로 재사용성과 유지 보수성을 향상시킬수 있다.

# #  다른 클래스에 상속을 할 부모 Humnan 클래스
# #  자식클래스의 생성자(__init__) 에서 직접 부모 클래스 인스턴스 변수를 지칭하여
# #  age, name 을 초기화(값을최초등록) 할수 있다.
# class Human :
#     def __init__(self, age, name):
#         self.age   = age
#         self.name  = name
    
#     def intro(self) :
#         print(f"저는 {self.age} 살 {self.name} 입니다.")

# class Student(Human) :
#     def __init__(self, age, name, Id):
#         self.age = age    # 부모 클래스의 age 인스턴스 변수
#         self.name = name  # 부모 클래스의 name 인스턴스 변수
#         self.stuId = Id   # Student 클래스만의 인스턴스 변수
    
#     def intro(self):
#         super().intro() # 나이와 이름을 소개하는 기능
#         print(f"학번은 {self.stuId} 입니다.")

# man = Human(30,"이수")
# man.intro()
    
# stu = Student(30,'아이유',1111281)     
# stu.intro() # student 클래스의 intro 를 호출








# # 그러나 부모 클래스의 인스턴스 변수 의 이름이 변경 될 경우
# # 자식클래스에서 지칭한 age 와 name 은 더이상 부모클래스의 인스턴스 변수를 바라보지않는다.
# # 부모클래스의 intro() 를 호출 시 초기화 오류가 발생한다.

# class Human :
#     def __init__(self, age, name):
#         # 부모 클래스의 인스턴스 변수 이름을 변경하였을 경우
#         self.age_F   = age 
#         self.name_F   = name
    
#     def intro(self) :
#         print(f"저는 {self.age_F} 살 {self.name_F} 입니다.")

# class Student(Human) :
#     def __init__(self, age, name, Id):
#         self.age = age    # Student 클래스만의 age 인스턴스 변수
#         self.name = name  # Student 클래스만의 name 인스턴스 변수
#         self.stuId = Id   # Student 클래스만의 인스턴스 변수
    
#     def intro(self):
#         super().intro() # 나이와 이름을 소개하는 기능
#         print(f"학번은 {self.stuId} 입니다.")

# man = Human(30,"이수")
# man.intro()
    
# stu = Student(30,'아이유',1111281)     
# stu.intro() # student 클래스의 intro 를 호출
# # 부모 클래스의 age_F , 와 name_F 가 자식 클래스에서 초기화 하는 로직이 수정되지 
# # 않았다. 자식클래스의 age 와 name 은 자식클래스 만의 인스턴스 변수 가 되었다.
# # 부모클래스의 intro() 를 호출 할때 초기화 되지않은 age_F, name_F 를 호출하여 
# # 오류가 발생한다.


# # 클래스 간의 상호 의존성 
# # 하나의 클래스 를 상속 받거나 객체화 하여 사용할 경우 
# # 상위 클래스 또는 대상 클래스 의 로직이 변경 될때 하위 클래스에 영향을 미치는 경우 
# # 하위 클래스가 상위 클래스를 의존 한다 라고 한다.
# # 의존성이 있는 프로그램 코딩의 경우 유지보수성이 많이 떨어지기 때문에 의존성을 끊어주는
# # 패턴 디자인 프로그래밍을 할 필요가 있다.

# class Human :
#     def __init__(self, age, name):
#         # 부모 클래스의 인스턴스 변수 이름을 변경하였을 경우
#         self.age_F = age 
#         self.name_F   = name
    
#     def intro(self) :
#         print(f"저는 {self.age_F} 살 {self.name_F} 입니다.")

# class Student(Human) :
#     def __init__(self, age, name, Id):
#         super().__init__(age,name) # 부모 클래스의 init 메서드에 age 와 name 을 전달 하고
#                                    # 부모클래스의 init 에서 전달받은 age 와 name 을 
#                                    # 각각 부모 클래스 만의 인스턴스 변수에 담기 때문에 
#                                    # 부모클래스의 내용이 변경 되어도 자식클래스 의 로직에는
#                                    # 영향을 미치지 않는다.

#         self.stuId = Id   # Student 클래스만의 인스턴스 변수
    
#     def intro(self):
#         super().intro() # 나이와 이름을 소개하는 기능
#         print(f"학번은 {self.stuId} 입니다.")

# # man = Human(30,"이수")
# # man.intro()
    
# stu = Student(30,'아이유',1111281)     
# stu.intro() # student 클래스의 intro 를 호출

#
#############################################################
# # 파이썬 클래스의 멤버 (필드, 생성자, 메서드)는 외부에서 누구나 쉽게 엑세스 할 수 있다.
# # 클래스 내부의 민감한 데이터 를 보호하는 패턴 
#############################################################

# # 1. 일정한 규칙을 마련해 두고 외부의 요인으로부터의 변질 막기.
# class Data : 
#     def __init__(self, month):
#         self.inner_month  = month # inner_month 클래스에서 보호해야할 값이 담긴 변수

# dt = Data(10)
# dt.inner_month = 100 # inner_month 는 1월부터 12월 까지를 나타낼 수 이지만
#                      # 외부에서 직접 접근할 수 있는 구조 떄문에 변질 될수 있다.


# 민감한 내용을 담은 변수 자체를 공개 하지 않고 관리 할수 있는 기법
class Data : 
    def __init__(self, month):
        self.inner_month  = month # inner_month 클래스에서 보호해야할 값이 담긴 변수
    def getmonth(self) :
        '''월 을 호출 받았을때 표현할 함수.'''
        return self.inner_month
    def setmonth(self, month) :
        '''월을 입력 받았을때 셋팅하는 함수.
        월은 1 ~ 12 만 받을수 있으므로 
        잘못된 월을 입력하였을 경우 변질을 막는 로직을 구현 해 둘 수 있다.'''
        if 1 <= month <= 12 :
            self.inner_month = month
        else : 
            print("월은 1~12 까지만 등록 할수 이떠염")

# dt = Data(10)
# # # 월을 셋팅할떄 
# dt.setmonth(15) # inner_month 인스턴스 변수에 직접 접근하지 않고 외부에서 변경
# print(dt.getmonth())




# # 3. 프로퍼티 를 통한 Get , Set 기능의 통합
# # getmonth() 메서드 와 setmonth() 메서드 가 inner_month 변수를 관리하는
# # 메서드 임을 표현하고 외붕에서 접근가능한 객체를 제공 함으로서 
# # inner_month 변수를 대신하는 역할을 하는 기능을 구현 할 수 있다.

# class Data : 
#     def __init__(self, month):
#         self.inner_month  = month # inner_month 클래스에서 보호해야할 값이 담긴 변수
#     def getmonth(self) :
#         '''월 을 호출 받았을때 표현할 함수.'''
#         return self.inner_month
#     def setmonth(self, month) :
#         '''월을 입력 받았을때 셋팅하는 함수.
#         월은 1 ~ 12 만 받을수 있으므로 
#         잘못된 월을 입력하였을 경우 변질을 막는 로직을 구현 해 둘 수 있다.'''
#         if 1 <= month <= 12 :
#             self.inner_month = month
#         else : 
#             print("월은 1~12 까지만 등록 할수 이떠염")
#     month = property(getmonth,setmonth)
#     # # getmonth() 와 setmonth() 메서드 자체도 공개하지 않는다. 

# dt = Data(10)
# # # 월을 셋팅할떄 
# dt.month = 1
# print(dt.month)





# # 4. 프로퍼티 를 데코레이터 로 구현
# # 외부에 공개 할 프로퍼티 이름으로 get 과 set 에관련된 메서드 를 작성해 두고 
# # 데코레이터를 통해 getter 와 setter 역활을 수행하는 기능을 추가 할 수 있다.
# class Data : 
#     def __init__(self, month):
#         self.inner_month  = month # inner_month 클래스에서 보호해야할 값이 담긴 변수
    
#     @property # month 프로퍼티 의 getter 메서드 기능을 적용 하는 데코레이터
#     def month(self) :
#         '''월 을 호출 받았을때 표현할 함수.'''
#         return self.inner_month
    
#     @month.setter # month 프로퍼티의 setter 메서드 기능을 적용 하는 데코레이터
#     def month(self, month) :
#         '''월을 입력 받았을때 셋팅하는 함수.
#         월은 1 ~ 12 만 받을수 있으므로 
#         잘못된 월을 입력하였을 경우 변질을 막는 로직을 구현 해 둘 수 있다.'''
#         if 1 <= month <= 12 :
#             self.inner_month = month
#         else : 
#             print("월은 1~12 까지만 등록 할수 이떠염")

# dt = Data(8)
# # # 월을 셋팅할떄 
# dt.month = 15
# print(dt.month)
