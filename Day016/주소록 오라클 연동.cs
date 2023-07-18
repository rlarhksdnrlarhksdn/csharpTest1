using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace 주소록_만들기
{
    class Addressbook
    {
        public int ADDR_ID { get; set; }
        public string Name { get; set; }
        public string HP { get; set; }

        public Addressbook(int addr_id, string name, string hp)
        {
            ADDR_ID = addr_id;
            Name = name;
            HP = hp;
        }
    }

    class Program
    {
        static List<Addressbook> addressBook = new List<Addressbook>();
        static int n = 0;

        static void Main(string[] args)
        {
            string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)));" +
                "User Id=hr;Password=hr;";

            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();

            LoadDataFromDatabase(conn);

            while (true)
            {
                UIinit();

                switch (n)
                {
                    case 1:
                        Console.WriteLine("데이터를 삽입합니다.");
                        Console.Write("ADDR_ID: ");
                        int addr_id = Int32.Parse(Console.ReadLine());
                        Console.Write("이름: ");
                        string name = Console.ReadLine();
                        Console.Write("전화번호: ");
                        string hp = Console.ReadLine();


                        Addressbook entry = new Addressbook(addr_id, name, hp);
                        addressBook.Add(entry);

                        OracleCommand insertCmd = new OracleCommand();
                        insertCmd.Connection = conn;
                        insertCmd.CommandText = "INSERT INTO PhoneBook (ID, NAME, HP) VALUES (:id, :name, :hp)";
                        insertCmd.Parameters.Add(":id", entry.ADDR_ID);
                        insertCmd.Parameters.Add(":name", entry.Name);
                        insertCmd.Parameters.Add(":hp", entry.HP);
                        insertCmd.ExecuteNonQuery();

                        Console.WriteLine("데이터가 성공적으로 삽입되었습니다.");
                        break;

                    case 2:
                        Console.WriteLine("데이터를 삭제합니다.");
                        Console.Write("삭제할 ADDR_ID: ");
                        int deleteID = Int32.Parse(Console.ReadLine());

                        Addressbook deleteEntry = addressBook.Find(x => x.ADDR_ID == deleteID);

                        if (deleteEntry != null)
                        {
                            addressBook.Remove(deleteEntry);

                            OracleCommand deleteCmd = new OracleCommand();
                            deleteCmd.Connection = conn;
                            deleteCmd.CommandText = "DELETE FROM PhoneBook WHERE ID = :id";
                            deleteCmd.Parameters.Add(":id", deleteEntry.ADDR_ID);
                            deleteCmd.ExecuteNonQuery();

                            Console.WriteLine("데이터가 성공적으로 삭제되었습니다.");
                        }
                        else
                        {
                            Console.WriteLine("해당 ADDR_ID가 존재하지 않습니다.");
                        }

                        break;

                    case 3:
                        Console.WriteLine("데이터를 조회합니다.");
                        Console.WriteLine("순서\t이름\t전화번호");

                        foreach (Addressbook entry4 in addressBook)
                        {
                            Console.WriteLine($"{entry4.ADDR_ID}\t{entry4.Name}\t{entry4.HP}");
                        }

                        break;

                    case 4:
                        Console.WriteLine("데이터를 수정합니다.");
                        Console.Write("수정할 ADDR_ID: ");
                        int editID = Int32.Parse(Console.ReadLine());

                        Addressbook editEntry = addressBook.Find(x => x.ADDR_ID == editID);

                        if (editEntry != null)
                        {
                            Console.Write("새로운 이름: ");
                            string newName = Console.ReadLine();
                            Console.Write("새로운 전화번호: ");
                            string newHP = Console.ReadLine();

                            editEntry.Name = newName;
                            editEntry.HP = newHP;

                            OracleCommand updateCmd = new OracleCommand();
                            updateCmd.Connection = conn;
                            updateCmd.CommandText = "UPDATE PhoneBook SET NAME = :name, HP = :hp WHERE ID = :id";
                            updateCmd.Parameters.Add(":name", editEntry.Name);
                            updateCmd.Parameters.Add(":hp", editEntry.HP);
                            updateCmd.Parameters.Add(":id", editEntry.ADDR_ID);
                            updateCmd.ExecuteNonQuery();

                            Console.WriteLine("데이터가 성공적으로 수정되었습니다.");
                        }
                        else
                        {
                            Console.WriteLine("주어진 ADDR_ID를 가진 데이터를 찾을 수 없습니다.");
                        }

                        break;

                    case 5:
                        Console.WriteLine("프로그램을 종료합니다.");
                        conn.Close();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("잘못된 메뉴를 입력하였습니다.");
                        break;
                }
            }
        }

        static void LoadDataFromDatabase(OracleConnection conn)
        {
            OracleCommand selectCmd = new OracleCommand();
            selectCmd.Connection = conn;
            selectCmd.CommandText = "SELECT * FROM PhoneBook";

            OracleDataReader reader = selectCmd.ExecuteReader();

            while (reader.Read())
            {
                int addr_id = Convert.ToInt32(reader["ID"]);
                string name = reader["NAME"].ToString();
                string hp = reader["HP"].ToString();

                Addressbook entry = new Addressbook(addr_id, name, hp);
                addressBook.Add(entry);
            }

            reader.Close();
        }

        static void UIinit()
        {
            Console.WriteLine("1. 데이터 삽입");
            Console.WriteLine("2. 데이터 삭제");
            Console.WriteLine("3. 데이터 조회");
            Console.WriteLine("4. 데이터 수정");
            Console.WriteLine("5. 프로그램 종료");

            Console.Write("메뉴: ");
            n = Int32.Parse(Console.ReadLine());
        }
    }
}
