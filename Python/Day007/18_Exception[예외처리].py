################################################################
# # 예외 처리
# # try / except
# # . 프로그램을 실행할대 개발자가 미연에 알아차리지 못한 오류 나 사용자의 
# # 




### 예외 상황 검출 Assert
# # try / except 를 간결하게 처리 할 수 있도록 줄인 구문
# # 특정 시점의 예외 상황을 발생 시켜 로직을 검증할때 사용

# value = input("점수를 입력하세요.")

# try:
#     score = int(value)
#     # 100이하가 아니라면 예외상황을 발생
#     assert score <= 100 , "114행 : 점수 범위 초과"
# except ValueError : # 값의 형식을 잘못 입력하였을 경우.
#     print("타입 형변환 실패")
#     print("데이터 복구 rollback")
#     score = 20
# except AssertionError as ae:
#     print(ae)
# print(score)


