Linux Commands
연습할 파일 생성
pi@raspberrypi ~ $ ls > sample.txt
ls 명령에 의한 출력결과를 sample.txt로 보냄
pi@raspberrypi ~ $ cat sample.txt
복사 
pi@raspberrypi ~ $ mkdir workspace
복사
pi@raspberrypi ~ $ cp ./sample.txt ./workspace
pi@raspberrypi ~ $ ls
확인
pi@raspberrypi ~ $ cd workspace
	pi@raspberrypi ~/worksapce $ ls
삭제
pi@raspberrypi ~/worksapce $ rm sample.txt
pi@raspberrypi ~/worksapce $ ls
pi@raspberrypi ~/worksapce $ cd
pi@raspberrypi ~ $

이동(잘라내기 & 붙여 넣기)
pi@raspberrypi ~ $ mv sample.txt ./workspace 
pi@raspberrypi ~ $ ls
pi@raspberrypi ~ $ cd workspace
pi@raspberrypi ~/workspace $ ls

이름 변경
pi@raspberrypi ~/workspace $ mv sample.txt s.txt
pi@raspberrypi ~/workspace $ ls
