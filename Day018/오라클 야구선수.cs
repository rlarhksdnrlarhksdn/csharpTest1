using Oracle.ManagedDataAccess.Client;
using System;

namespace OracleApp_create
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string player_name, position;
            int player_id, age, uniform_number;

            while (true)
            {
                string strConn = "Data Source=(DESCRIPTION=" +
                    "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                    "(HOST=localhost)(PORT=1521)))" +
                    "(CONNECT_DATA=(SERVER=DEDICATED)" +
                    "(SERVICE_NAME=xe)));" +
                    "User Id=hr;Password=hr;";

                OracleConnection conn = new OracleConnection(strConn);

                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                Console.WriteLine("1. 테이블 만들기");
                Console.WriteLine("2. 테이블 삭제");
                Console.WriteLine("3. 데이터 삽입");
                Console.WriteLine("4. 데이터 삭제");
                Console.WriteLine("5. 데이터 수정");
                Console.WriteLine("6. 데이터 검색");
                Console.WriteLine("7. 프로그램 종료");
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        cmd.CommandText = "Create Table samsung_lions " +
                            "(ID number(4) PRIMARY KEY,  " +
                            "NAME varchar2(50), " +
                            "POSITION varchar2(30), " +
                            "AGE number(3), " +
                            "UNIFORM_NUMBER number(2))";

                        try
                        {
                            cmd.ExecuteNonQuery();
                            Console.WriteLine(" 삼성 라이온즈 선수 테이블이 생성되었습니다. ");
                        }
                        catch { Console.WriteLine("이미 데이터베이스가 있습니다. "); }

                        break;

                    case 2:
                        Console.WriteLine();
                        cmd.CommandText = "drop table samsung_lions";
                        try
                        {
                            cmd.ExecuteNonQuery();
                            Console.WriteLine(" 삼성 라이온즈 선수 테이블이 삭제되었습니다. ");
                        }
                        catch { Console.WriteLine("테이블이 없습니다."); }
                        conn.Close();
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.Write("이름을 입력해주세요 : ");
                        player_name = Console.ReadLine();
                        Console.Write("포지션을 입력해주세요 : ");
                        position = Console.ReadLine();
                        Console.Write("나이를 입력해주세요 : ");
                        age = int.Parse(Console.ReadLine());
                        Console.Write("등번호를 입력해주세요 : ");
                        uniform_number = int.Parse(Console.ReadLine());
                        cmd.CommandText = "insert into samsung_lions (ID, NAME, POSITION, AGE, UNIFORM_NUMBER) " +
                            $"values (seq_a1.nextval, '{player_name}', '{position}', {age}, {uniform_number})";
                        cmd.ExecuteNonQuery();
                        Console.WriteLine(" 데이터가 삽입되었습니다. ");
                        conn.Close();
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.Write("삭제할 ID를 입력해주세요 : ");
                        int b = int.Parse(Console.ReadLine());
                        cmd.CommandText = "delete from samsung_lions where ID = " + b;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine(" 데이터가 삭제되었습니다. ");
                        conn.Close();
                        break;

                    case 5:
                        Console.WriteLine();
                        Console.Write("수정할 ID를 입력해주세요 : ");
                        player_id = int.Parse(Console.ReadLine());
                        Console.Write("수정할 이름를 입력해주세요 : ");
                        player_name = Console.ReadLine();
                        Console.Write("수정할 포지션을 입력해주세요 : ");
                        position = Console.ReadLine();
                        Console.Write("수정할 나이를 입력해주세요 : ");
                        age = int.Parse(Console.ReadLine());
                        Console.Write("수정할 등번호를 입력해주세요 : ");
                        uniform_number = int.Parse(Console.ReadLine());
                        cmd.CommandText = "update samsung_lions set NAME = '" + player_name + "', POSITION = '" + position + "', AGE = " + age +
                            $", UNIFORM_NUMBER = {uniform_number} where ID = " + player_id;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        break;

                    case 6:
                        Console.Write("검색할 ID를 입력해주세요 : ");
                        player_id = int.Parse(Console.ReadLine());
                        cmd.CommandText = "select * from samsung_lions where ID = " + player_id;
                        OracleDataReader rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                        {
                            player_id = int.Parse(rdr["ID"].ToString());
                            player_name = rdr["NAME"] as string;
                            position = rdr["POSITION"] as string;
                            age = int.Parse(rdr["AGE"].ToString());
                            uniform_number = int.Parse(rdr["UNIFORM_NUMBER"].ToString());
                            Console.WriteLine($"ID   NAME          POSITION    AGE    UNIFORM_NUMBER");
                            Console.WriteLine($"{player_id}    {player_name}      {position}        {age}       {uniform_number}");
                        }
                        conn.Close();
                        break;

                    case 7:
                        conn.Close();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
