# # 동적 코드 eval()
# # 프로그램 실행 중 여러가지 상황에서
# # 유연하게 프로그래밍 된다.

# result = eval("1+2+6+8")
# print(result)

# a = 2
# print(eval("a+3"))

# lists = eval("['A','B','C']")
# print(lists)
# print(type(lists))

# # 동적 코드 : 코드를 유연하게 작성할수 있도록 해주는 편의 기능이나
# #            잠재적인 오류를 발생시킬 가능성이 높은 문법이므로
# #            가급적 사용을 지양한다.



class Myclass :
    def __init__(self,lists):
        self.list = lists
mylists = Myclass([10,20,30,40,50])
print(mylists.list)

