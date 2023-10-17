# #################################################
# # # 파일을 다루는데 사용되는 모듈 shutil, os 
# # # 파일을 이동 , 복사 


# # # 파일 복사의 예제
# import shutil 
# shutil.copy('word.txt', 'word2.txt')


# ##########################
# # # 절대 경로 : 루트 부터 파일 의 이름까지를 나타낸 경로 (C:\User\a.exe)
# # # 상대 경로 : 특정 파일의 이름만 나타낸것을 (a.exe)





# # # 절대 경로인지 상대 경로 인지 확인하기
# # import os

# # # 상대 경로
# # realPath = 'example.txt'
# # isreal = os.path.isabs(realPath)
# # print(f"'{realPath}' 는 절대 경로인가요? {isreal}")

# # # 절대 경로
# # absPath = '/Users/Username/Documents/example.txt'
# # isabse = os.path.isabs(absPath)
# # print(f"'{absPath}' 는 절대 경로인가요? {isabse}")







# # # 파일의 절대 경로 를 문자열로 만들기 
# # import os

# # # 현재 스크립트의 파일 경로 
# # script_path = os.path.abspath(__file__)

# # # 현재 스크립트 파일이 위치한 디렉토리 이름까지만 걸러내기 
# # script_dir = os.path.dirname(script_path)

# # # 파일 의 절대 경로를 표현할 파일 상대 경로
# # file_abs = 'word.txt'

# # # 절대 파일 경로 만들어주는 함수
# # # 운영 체제에 따라 파일 경로를 지정하는 표현식이 다르다. 
# # # window : \ , mac,unnix : / 
# # # join 시 절대 경로 의 표현식을 운영체제에 맞게 표현해 준다. 
# # file_full_path = os.path.join(script_dir, file_abs) 

# # # print("특정 파일의 {0} 의 절대경로 {1}".format(file_abs,file_full_path))
# # print(f"특정 파일의 {file_abs} 의 절대경로 {file_full_path}")









# ################# 파일 검색 및 출력 하기 ##########################
# # # 1. 폴더 내의 항목 검색 
# # import os
# # filelist = os.listdir(r"C:\Python\MP3")
# # for file in filelist : 
# #     print(file)



# # # 2. 함수의 재귀 호출을 통하여 폴더에 존재하는 (n 개의 폴더 포함) 모든 mp3 파일 찾기
# import os

# # 폴더를 검색하는 함수 , 모든 파일 찾아내기, 정렬하기
# def searchDir(dirpath) :
#     # 해당 폴더에 있는 모든 파일의 리스트 작성. 
#     filelist = os.listdir(dirpath)
#     for file in filelist : 
#         fullpath = os.path.join(dirpath, file)  # C:\Python\MP3\2022 
#         if os.path.isdir(fullpath) : # fillpath 가 폴더 인지 확인.
#             print("[" + fullpath + "]")
#             searchDir(fullpath) # 재귀함수 호출 : 더이상 폴더가 없을때 까지
#         else : # 절대 경로 가 폴더 유형이 아닐 경우 
#             print("\t" + fullpath) #    C:\Python\MP3\2022\a.mp3

# # 검색하기 위한 폴더 명칭을 인수로 전달
# searchDir(r"C:\Python\MP3")



######################
# # 실습 
# # 모든 폴더 내부 항목 검색 실습 - 메인 폴더에 있는 파일 위치 정리하기 
#########################
# # 문제 : 메인 경로를 던져 주었을때 와 
# #        메인경로 내의 재귀함수로 폴더를 검색했을때 
# #        폴더가 아닌 파일의 명칭의 위치를 들여쓰기 해서 표현하는 부분이 똑같다.
# #     * 메인경로 를 던질때랑 재귀함수 처리할 때랑 같은 로직을 구현
# # 해결 : 메인경로를 던질떄랑  ( 123 행 )
# #        재귀함수 호출할 때랑 (118 행 )
# #        다른 로직으로 처리될수 있도록 한다.  (120 행)
# #        ( 메인경로 : 들여쓰기 x , 재귀함수 경로 : 들여쓰기)

# import os

# # 폴더를 검색하는 함수 , 모든 파일 찾아내기, 정렬하기
# def searchDir(dirpath, MainFlag) :
#     # 해당 폴더에 있는 모든 파일의 리스트 작성. 
#     filelist = os.listdir(dirpath)
#     for file in filelist : 
#         fullpath = os.path.join(dirpath, file)  # C:\Python\MP3\2022 
#         if os.path.isdir(fullpath) : # fillpath 가 폴더 인지 확인.
#             print("[" + fullpath + "]")
#             searchDir(fullpath,False) # 재귀함수 호출 : 더이상 폴더가 없을때 까지
#         else : # 절대 경로 가 폴더 유형이 아닐 경우 
#             # 메인경로 를 받아서 처리 하는 로직인지
#             # 재귀하수 에서 경로를 받아서 처리하는 로직인지 구분
#             if MainFlag :
#                 print(fullpath) #    C:\Python\MP3\a.mp3
#             else :
#                 print("\t" + fullpath) #    C:\Python\MP3\2022\a.mp3

# # 검색하기 위한 폴더 명칭을 인수로 전달
# searchDir(r"C:\Python\MP3", True)








#####################################################################
# # 폴더 내의 파일 명칭 바꾸기 
# # 예 - .mp3 파일 의 가수 와 제목의 명칭을 바꿔서 일괄 적용하기
####################################################################
# # 파일의 예
# # 제목 - 가수 .mp3    유형이 정형화 되어있습니다.

# import os

# filepath = r"C:\Python\MP3"
# # 파일 리스트 생성
# files = os.listdir(filepath)
# # 파일 을 하나씩 추출 하여 이름 바꾸기
# for file in files :
#     # - 로 이름이 구분되고 확장자 가  mp3 인 데이터 만 처리
#     #  * 일정한 유형(패턴) 으로 구성되어있는 파일 들만 처리
#     if file.find('-') and file.endswith(".mp3") :
#         # 이름을 바꾸는 로직을 구현 
#         # 1. 확장자를 추출
#         ext = file[-4:] # 확장자
#         # 2. 이름을 추출
#         name = file[0:-4] # 0 ~ -5 의 제목의 문자열을 가변적으로 담아올수있다.
#         # 3. 가수와 제목을 분리 할 패턴 ('-') 를 이용하여 가수 , 제목으로 데이터 나누기
#         namepart = name.split('-')
#         # 4. 가수 와 제목의 위치를 바꾸고 기존 패턴으로 재 적용해 주기
#         rename = namepart[1] + '-' + namepart[0] + ext
#         # 5. os 모듈을 이용하여 파일의 이름을 바꾸기 
#         #    os.rename([바뀌기전 파일 절대경로], [바뀐후의 파일 절대경로])
#         os.rename(filepath + "\\" + file , filepath + "\\" + rename)
#         # 6. 미리 보기
#         print(filepath + "\\" + rename)        




#################################
# # 실습
# # 모든 폴더에 있는 제목, 가수 위치 바꾸기 (재귀 함수 사용)

# import os

# filepath = r"C:\Python\MP3"

# # 폴더 내의 파일을 검색할 재귀 함수.
# def changeaName_re(path, mainpathflag) :
#     '''path : 파일의 경로 
#        mainpathflag : 메인 폴더 경로 인지 확인'''
#     files = os.listdir(path)
#     for file in files :
#         fullpath = path + "\\" + file # 추출한 파일의 절대 경로 
#         if os.path.isdir(fullpath) :
#             print('['  + fullpath  +  ']')
#             changeaName_re(fullpath, False)
#         else : 
#             # 가수와 제목을 바꾸는 로직 적용
#             ext  = file[-4:] # 확장자
#             name = file[0:-4] # 파일의 이름
#             partname = name.split('-')
#             rename = partname[1] + '-' + partname[0] + ext
#             os.rename(fullpath , path + "\\"+ rename)
#             print( rename if mainpathflag else "\t" + rename) # 삼항 연산자


# changeaName_re(filepath , True)


