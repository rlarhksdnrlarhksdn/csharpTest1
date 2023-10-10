#######################################################################################
# # 튜플 
# # 값이 한번 초기화 된 후 임의의 데이터를 할당 할 수 없는 자료구조(자료집합, 상수)
# # . 값의 변경을 하고 재배치하는 프로세스 의 메모리를 소비하지 않으므로 리스트보다는 가볍다.
# # . 데이터가 변질되면 안되는 경우 . 상수 형태의 튜플로 작성해 두면 오류를 방지 할 수 있다.
########################################################################################
# # 튜플의 선언 
# score = 10,20,30,40,50 
# print(type(score), score)

# score = (10,20,30,40,50) # 튜플은 ( ) 를 통해 선언 하는것이 개발자 국룰
# print(type(score), score)

# score = 10, # 상수 형태로 생성 가능
# print(type(score), score)




# # 함수 (메서드)  의 반환 결과 : 튜플
# def DoSomthing() :
#     return '첫번쨰 반환값','튜플',100,True

# result = DoSomthing()
# # #result[0] = 'aaaa' 튜플로 전달 받은 값은 변경 할 수 없다. 
# print(result)



# # 함수 결과 반환 두번째 (개별적 반환 값의 경우 해당 자료형으로 반환)
# def DoSomthing() :
#     return '첫번쨰 반환값','튜플',100,True

# re1,re2,re3,re4 = DoSomthing()
# print(type(re1), re1) # str 
# print(type(re2), re2) # str 
# print(type(re3), re3) # int 
# print(type(re4), re4) # bool



# # 리스트 -> 튜플 
# score = [10,20,30,40,50]
# tu = tuple(score)
# print(type(tu), tu)
# # # 튜플 -> 리스트 
# lists = list(tu)
# print(type(lists), lists)
