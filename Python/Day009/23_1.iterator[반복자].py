#####################################################################################
# # Iterable 클래스
# # 반복 가능한 클래스 ()
# # 요소가 열거되어 있는 (n개 이상의 요소를 가지고 있는)
# # 자료형 구조에서 순차적으로 요소를 추출 할수 있는 기능이 포함된 클래스
# # . nest()-> __next__()

# # 데이터를 순차적으로 반환하는 반복 가능한 클래스 만들기
# class Mylist:
#     def __init__(self,*data):
#         self.data = data
#         self.index = -1 # 추출하는 요소의 index를 나타내는 인스턴스 변수
#     def __next__(self) :
#         # 요소를 하나씩 추출하여
#         #  반환하는 메서드
#         self.index += 1
#         if self.index == len(self.data):
#             #요소의 끝까지 모두 반환을 다한 상태라면
#             #while을 종료하는 시그널을 보내주어야 하는데
#             # return -1 : 실제 요소의 값이 -1이라면 정상적인 요소 추출을 할 수 없다.
#             raise Exception # 예외 상황
#         return self.data[self.index]
# lists = Mylist(10,20,30,40,50,60)
# while True:
#     # result 추출한 요소를 담을 변수
#     result = next()
#     print(result)


## 위의 MyList를 For에 적용한다.
# class Mylist:
#     def __init__(self,*data):
#         self.data = data
#         self.index = -1 # 추출하는 요소의 index를 나타내는 인스턴스 변수
#     def __next__(self) :
#         # 요소를 하나씩 추출하여
#         #  반환하는 메서드
#         self.index += 1
#         if self.index == len(self.data):
#             #요소의 끝까지 모두 반환을 다한 상태라면
#             #while을 종료하는 시그널을 보내주어야 하는데
#             # return -1 : 실제 요소의 값이 -1이라면 정상적인 요소 추출을 할 수 없다.
#             raise Exception # 예외 상황
#         return self.data[self.index]
# lists = Mylist(10,20,30,40,50,60)

# # # list 클래스는 반복적으로 처리하는 구문이 포함되어 있지만
# # # For 문법이 구동할 수 있는 반복자
# for value in lists :
#     print(value)
