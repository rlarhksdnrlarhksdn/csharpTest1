using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        internal class Program
        {
            static int n = 0;
            static List<Addressbook> addressBook = new List<Addressbook>();
            static void Main(string[] args)
            {
                while(true)
                {
                    int addr_id;
                    string name, hp;
                    UIinit();
                    switch (n)
                    {

                        
                        case 1:
                            
                            //데이터 추가

                            Console.WriteLine("데이터를 삽입합니다.");

                            Console.Write("ADDR_ID: ");

                            addr_id = Int32.Parse(Console.ReadLine());

                            Console.Write("이름 : ");

                            name = Console.ReadLine();

                            Console.Write("전화번호 : ");

                            hp = Console.ReadLine();

                            addressBook.Add(new Addressbook(addr_id, name, hp));

                            Console.WriteLine("데이터가 성공적으로 삽입되었습니다.");

                            break;

                        case 2:
                            //데이터 삭제
                            Console.WriteLine("데이터를 삭제합니다.");

                            Console.Write("삭제할 ADDR_ID: ");

                            addr_id = Int32.Parse(Console.ReadLine());

                            Addressbook entry2 = addressBook.Find(x => x.ADDR_ID == addr_id);

                            if (entry2 != null)
                            {
                                addressBook.Remove(entry2);
                                Console.Write("성공적으로 삭제하였습니다. ");
                            }
                            else
                                Console.WriteLine("해당 번호가 존재하지 않습니다.");
                            Console.WriteLine();
  
                            break;

                        case 3:
                            //데이터 조회
                            Console.WriteLine("데이터를 조회합니다");
                            Console.WriteLine("순서   / 이름 / 전화번호 ");
                            
                            foreach (Addressbook entry4 in addressBook)
                            {
                                Console.WriteLine($"{entry4.ADDR_ID}\t{entry4.Name}\t{entry4.HP}");
                            }
                            break;
                        case 4:
                            //데이터 수정
                            
                            Console.WriteLine("\n데이터를 수정합니다.");
                            Console.Write("수정할 ADDR_ID: ");
                            addr_id = Int32.Parse(Console.ReadLine());
                            
                            Addressbook entry3 = addressBook.Find(x => x.ADDR_ID == addr_id);

                            if (entry3 != null)
                            {
                                Console.Write("새로운 이름: ");
                                name = Console.ReadLine();
                                Console.Write("새로운 전화번호: ");
                                hp = Console.ReadLine();

                                entry3.Name = name;
                                entry3.HP = hp;

                                Console.WriteLine("데이터가 성공적으로 수정되었습니다.\n");
                            }
                            else
                            {
                                Console.WriteLine("주어진 ADDR_ID를 가진 데이터를 찾을 수 없습니다.\n");
                            }
                            break;
                        case 5:
                            Console.WriteLine("\n프로그램을 종료합니다.\n");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.Write("잘못된 메뉴를 입력하였습니다.");
                                break;
                    }
                }
                
            }
            static void UIinit()
            {
                Console.WriteLine("1. 데이터 삽입");
                Console.WriteLine("2. 데이터 삭제");
                Console.WriteLine("3. 데이터 조회");
                Console.WriteLine("4. 데이터 수정");
                Console.WriteLine("5. 프로그램 종료");

                Console.Write("메뉴 : ");
                n = Int32.Parse(Console.ReadLine());
            }
            

        }
    }
}
