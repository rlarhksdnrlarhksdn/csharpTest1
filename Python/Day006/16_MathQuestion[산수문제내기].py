# #############################################
# # # 임의의 수 2개 덧셈 맞추기 
# import random
# a = random.randint(1,9) # 1 ~ 9 임의의값
# b = random.randint(1,9) # 1 ~ 9 임의의값
# question = "%s + %s = " %(a,b)
# ans  = int(input(question)) # 질/답 동기화
# if ans == a + b:
#     print("정답입니다.")
# else : 
#     print("틀렸습니다.")




#############################################
# # 임의의 수 2개 덧셈 맞추기 
# # 반복 해서 물어보되 0 을입력하면 프로그램 종료하기
# # 총 질문의 횟수 와 정답의 횟수 를 종료 전 표현

# import random

# questionCnt = 0 # 질문의 횟수
# resultCnt   = 0 # 정답 횟수
# while True :
#     questionCnt += 1 # 질문의 횟수 증가
#     a = random.randint(1,9) # 1 ~ 9 임의의값
#     b = random.randint(1,9) # 1 ~ 9 임의의값
#     question = "%s + %s = " %(a,b)
#     ans  = int(input(question)) # 질/답 동기화
#     if ans == 0 : 
#         break
#     elif ans == a + b :
#         resultCnt += 1 # 정답 횟수가 1 증가
#         print("정답입니다.")
#     else : 
#         print("틀렸습니다.")
# print("총 %d 문제 중 정답횟수는 %d" % (questionCnt, resultCnt))






#############################################
# # 임의의 수 2개 덧셈 맞추기 
# # 반복 해서 물어보되 0 을입력하면 프로그램 종료하기
# # 총 질문의 횟수 와 정답의 횟수 를 종료 전 표현 
# # 사칙 연산 을 임의로 받아서 결과 를 비교 하기. 

import random

questionCnt = 0 # 질문의 횟수
resultCnt   = 0 # 정답 횟수
op = ['+','-','*','/'] # 임의로 추출 할 사칙 연산 기호


def rans() : # 정답을 맞추었을때 실행할 함수
    global resultCnt
    resultCnt += 1 # 정답 횟수가 1 증가
    print("정답입니다.")


while True :
    questionCnt += 1 # 질문의 횟수 증가
    a = random.randint(1,9) # 1 ~ 9 임의의값
    b = random.randint(1,9) # 1 ~ 9 임의의값
    r = random.randrange(len(op)) # 0 ~ 3  사칙연산 리스트에서 임의의 기호 받아내기
    question = "%s %s %s = " %(a,op[r],b)
    ans  = int(input(question)) # 질/답 동기화
    if ans == 0 : 
        break
    elif r == 0 and ans == a + b :
        rans()
    elif r == 1 and ans == a - b :
        rans()
    elif r== 2 and ans == a * b :
        rans()
    elif r== 3 and ans == a / b :
        rans()
    else : 
        print("틀렸습니다.")
print("총 %d 문제 중 정답횟수는 %d" % (questionCnt, resultCnt))





        
