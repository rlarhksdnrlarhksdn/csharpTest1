#################################################
# # 리스트 
# # 여러 개의 값을 일괄적으로 관리
# # 타 프로그래밍의 배열 과 동일한 구조
# # 등록 된 값의 개별 항목을 요소, 원소 라고 한다. 
#################################################
# # 타입을 같이 뭉쳐서 나열하는것이 좋은 코딩이긴하지만 
# # 다른 타입의 값도 수용한다. 
#lists = [1,2,'삼',True]

# # 반복문을 사용한 리스트 요소 추출
# lists = [10,20,30]
# for num in lists :
#     print(num,end = " 점")


# # 리스트 의 범위 지정
# lists = [10,20,30,40,50,60,70,80]
# print(lists[0:2]) # 10, 20 이 출력
# print(lists[2:6:2]) # 30, 50 이 출력


# # 리스트의 범위 에 값을 할당. 
# lists = [10,20,30,40,50,60,70,80]
# lists[2:5] = [4,5]
# print(lists)

# # 범위 가 벗어나더라도 값을할당
# lists = [10,20,30,40,50,60,70,80]

# # 범위는 2개를 선택 하였으나 데이터요소를 7개 등록 하는경우 가능
# lists[2:5] = [4,5,6,7,8,9,10] 
# print(lists)






# # 범위 삭제
# lists = [10,20,30,40,50,60,70,80]
# lists[2:9] = []
# print(lists)



################## 리스트 연산  ##########
# lists1 = ['일','이','삼']
# lists2 = [10,20,30,40,50,60,70,80]

# lists3 = lists1 + lists2
# print(lists3) # 두개의 리스트의 요소를 하나의 리스트 에 할당.

# lists3 = lists1 * 3
# print(lists3) # 곱한 횟수 만큼 리스트의 내용을 반복하여 새로운 리스트 요소로 할당. 




###################################
# # 실습 : 리스트 를 이용한 총점과  평균 구하기
#################################
# scores = [90,80,70,80,80,70,80]
# sum = 0 # 총점을 구할 외부 변수
# for s in scores :
#     sum += s
# print("총점 :", sum , "평균 : ", (sum/len(scores)) )








###########################################
# # 이중 리스트
# # . 리스트의 요소에 리스트를 배치 
# # . 리스트를 담은 리스트 를 생성하여 활용 할 수 있다.
###########################################
# lol = [ [1,2,3] , [4,5]  , [6,7,8,9] ]
# print(lol[0])
# print(lol[0][1]) # 0번요소 리스트의 1번 index 값을 표현


# # 이차원 리스트를 활용하여 학생별 총점과 평균을 구하는 예제
# score = [ [80,90,100,90],
#           [70,90,100,50],
#           [80,80,80, 90]]

# totalscore = 0 # 전체 과목의 총점
# totalsub   = 0 # 전체 과목 수 
# # # student : 학생 
# for student in score :  # score 리스트의 각요소(학생) 리스트를 추출
#     sum = 0 #  학생의 총점 
#     # # subject_score 과목별 점수 
#     for subject_score in student :
#         sum += subject_score
#     subjcount = len(student) # 과목 수
#     print(" 총점 : %d,  평균 : %.2f " % (sum, sum / subjcount))
#     totalscore += sum
#     totalsub += subjcount
# print("전체 과목의 점수 : %d , 전체 과목의 평균 : %.2f "
#        % (totalscore,totalscore/totalsub) )






##############################################################################
# # 실습 
# # 과목 별 총점 과 평균을 구하는 로직 구현
##############################################################################
# score = [ [80,90,100,90],  # 1번 학생 별 과목 점수
#           [70,90,100,50],  # 2번 학생 별 과목 점수
#           [80,80,80, 90]]  # 3번 학생 별 과목 점수



# # # 과목의 수 : 첫번째 학생을 기준으로 요소의 개수
# subject_count = len(score[0]) # 4 => 메인 for 문의 반복 횟수

# # # 과목 별 더해야 하는 학생의 수 
# student_CNT = len(score) # 3 

# # # 과목 별 총점
# sub_totalscore = 0

# # i : score 의 각요소 별 과목에 대한 index
# for i in range(subject_count) : # 0 ~ 3 subject_count : 4, 
#     for j in range(student_CNT) : # 0 ~ 2 학생 요소에 대한 index
#         # 과목 별 총점.
#         sub_totalscore = score[j][i]
#     print("{0} 번째 과목의 총점 : {1}, 평균 {2:.2f}"
#           .format((i + 1),sub_totalscore,sub_totalscore/student_CNT))
#     # # i 번째 과목에 대한 총 점 및 평균을 다 구한상태. 
#     sub_totalscore = 0






#######################################################################
# # 리스트 컴프리핸션 ***
# # - 리스트의 요소 가 일정한 규칙을 가진 수열 일 경우 
# #   간단한 인라인(한줄코드) 으로 리스트의 내용을 할당 하는 문법 
#######################################################################
# # 컴프리핸션의 기본 포멧
# nums = [n * 2 for n in range(1,11)]
# print(nums)

# # # 컴프리핸션의 응용 
# # # 특정한조건을 만족 하는 경우만 리스트로 구성 하고 싶을때
# nums = [n * 2 for n in range(1,11) if n % 2 == 0]
# print(nums)






##################################################
# # 리스트 에 데이터 삽입.
##################################################
# # isnert 와 append 
# nums = [n for n in range(1,11)]
# nums.append(5)
# print(nums)
# nums.insert(2,10) # 2 index 의 위치에 10 을 할당 
#                   # (1. 2 이후 데이터 삭제 , 2. 2위치에 10 할당 , 3. 3위치부터 순차적으로 재배열)
# print(nums)





# # 리스트의 범위 지정 데이터 할당(삽입)
# nums = [n for n in range(1,11)]
# nums[2:2] = [10,20] # 첫번째 범위 에 해당 요소를 삽입.
# print(nums)
# nums[2] = [10,20] # 2 인덱스 위치에 [10,20] 리스트 를 요소로 삽입
# print(nums)



# # extend() 원본 데이터 에 추가 적으로 리스트 내용을 덧붙이기 기능
# list1 = [1,2,3]
# list2 = [2,3,4]
# list1.extend(list2) # 원본리스트.extend(덧붙일리스트)
# print(list1) 
# print(list2) 

# list1 = [1,2,3]
# list2 = [2,3,4]
# print(list1+list2) # 원본 데이터에 관여하지 않는다.
# print(list1) 
# print(list2) 




# # 리스트 의 삭제 
# num = [n * 2 for n in range(1,11) if n % 2 == 0]
# print(num)


# # # 해당 데이터 를 삭제 
# num.remove(4)
# print(num)

# # # 해당 index 를 삭제
# del num[2]
# print(num)


# # # 리스트 범위 삭제 
# num[:2]= []
# print(num)





# # 리스트 의 데이터 일괄 삭제 
# num = [n * 2 for n in range(1,11) if n % 2 == 0]
# print(num)

# num.clear()
# print(num)

# num[:] = []
# print(num)
 
# del num[:]
# print(num)



##############################################################################
# # 리스트의 내용을 삭제 후 반환  pop() (Stack , Queue 의 자료형 알고리즘이 적용되어있는 기능)
# # pop()
# # . 가장 마지막에 등록 된 데이터 부터 추출 후 삭제
# # . 특정 index 를 지칭 가능 
##############################################################################
# # POP()
# score = [10,20,30]
# print(score.pop())
# print(score)
# print(score.pop(0)) # 0 index 추출 후 출력 
# print(score)






# # 검색
# # 특정 값 찾기 
# num = [n * 2 for n in range(1,11) if n % 2 == 0]
# find_num = num.index(8) # 해당 값이 있을경우 index 를 반환 없을 경우 오류 
# print("8 의 위치는 %d  위치에 있습니다." %find_num)
# num = [10,10,10,20,20,20,20,30,30,30,30,40,40,40,50,50]

# count_num = num.count(10)
# print("10 의 개수는 %d  개 입니다." %count_num)


# # 최대값 과 최소값 찾기
# num = [n * 2 + 1 / 3 for n in range(1,100) if n % 2 == 0]
# print(max(num)) # 최대값
# print(min(num)) # 최소값



# # 리스트 의 응용 예제 1 
# ans = input("얼마를 인출 하시겠습니까?")
# result = ['천원', '이천원', '삼천원', '사천원']
# if ans in result : 
#     print("인출에 성공하였습니다.")
# else : 
#     print("인출에 성공하지 못했습니다.")


# # 리스트 의 요소 의 데이터 형이 일치 하지 않은 경우는 for 문을 사용\
# ans = input("얼마를 인출 하시겠습니까?")
# result = ['천원', 1000, 1,000, '일천원']
# sucessflag = False
# for fac in result : 
#     if  ans == str(fac) : 
#         print("인출에 성공하였습니다.")
#         sucessflag = True
#         break
# if not sucessflag :
#     print("인출에 성공하지 못했습니다.")




# # 정렬 (데이터 의 오름차순 과 내림차순)
# num = [n * 2  + 1 * 2  for n in range(1,100) if n % 2 == 0]
# num.sort() # 오름차순
# print(num) # num 리스트 원본 을 정렬 
# num.reverse() # 내림차순
# print(num)
# num.sort(reverse=False) # reverse=True 내림차순
# print(num)


# # 문자의 정렬
# values = ['korea', 'CHINA' , 'america', 'japan']
# values.sort()
# print(values) # 대문자가 우선순위 


# # # 대소문자 관계없이 정렬.
# values.sort(key=str.lower) # ***
# print(values) # 대문자가 우선순위 

# # 원본은 그대로 두고 정렬한 결과만 새로운 리스트로 생성.
# # 후속 로직 에 원본의 데이터를 그대로 사용하여야 할 경우. ( 원본을 복사 -> 정렬 )
# values = ['korea', 'CHINA' , 'america', 'japan'] 
# values2 = sorted(values) # 원본 리스트를 정렬한 결과를 values2 에 할당. 
# print(values)
# print(values2)




############################################################################################
# # 실습
# # . 사용자로부터 5 개 의 성적을 입력 받아 리스트에 저장 하고 오름차순으로 정렬후 출력 해보세요
############################################################################################
inputs = [] # 값을 입력 받을 빈 깡통 리스트.
for i in range(5):
    inputs.append(int(input("값을 입력하세요 : ")))
inputs.sort()
print(inputs)
