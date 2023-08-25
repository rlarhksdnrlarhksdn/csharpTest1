using Microsoft.EntityFrameworkCore;
using System;
using static EntityFrameworkApp01.Program;

namespace EntityFrameworkApp01
{
    internal class Program
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int MathGrade { get; set; }
            public int ScienceGrade { get; set; }
            public int HistoryGrade { get; set; }
            public int EnglishGrade { get; set; }
            public double AverageGrade { get; set; }
            public string GradeLetter { get; set; }
        }
        public class StudentContext : DbContext
        {
            public DbSet<Student> StudentGrades { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseOracle("User Id=c##scott;Password=tiger;Data Source=127.0.0.1/XE;");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Student>()
                 .Property(p => p.GradeLetter)
                 .HasMaxLength(2);

                modelBuilder.Entity<Student>()
                    .HasKey(p => p.StudentID);

                modelBuilder.Entity<Student>()
                    .Property(p => p.StudentName)
                    .HasMaxLength(50);

                modelBuilder.Entity<Student>()
                    .Property(p => p.MathGrade);

                modelBuilder.Entity<Student>()
                    .Property(p => p.ScienceGrade);

                modelBuilder.Entity<Student>()
                    .Property(p => p.HistoryGrade);

                modelBuilder.Entity<Student>()
                    .Property(p => p.EnglishGrade);

                modelBuilder.Entity<Student>()
                    .Property(p => p.AverageGrade);
            }
        }
        private static int n = 0;
        static void Main(string[] args)
        {
            ShowMenu();

            while (true)
            {
                switch (n)
                {
                    case 1:
                        using (var context = new StudentContext())
                        {
                            context.Database.EnsureDeleted();
                            context.Database.EnsureCreated();

                            var students = new List<Student> { };

                            context.StudentGrades.AddRange(students);
                            context.SaveChanges();
                            Console.WriteLine("테이블을 만들었습니다!!");
                        }
                        ShowMenu();
                        break;
                    case 2:
                        Console.WriteLine("학생 성적을 삽입합니다.");
                        Console.Write("학생 아이디: ");
                        int studentID = Int32.Parse(Console.ReadLine());
                        Console.Write("학생 이름: ");
                        string studentName = Console.ReadLine();
                        Console.Write("수학 성적: ");
                        int mathGrade = Int32.Parse(Console.ReadLine());
                        Console.Write("과학 성적: ");
                        int scienceGrade = Int32.Parse(Console.ReadLine());
                        Console.Write("역사 성적: ");
                        int historyGrade = Int32.Parse(Console.ReadLine());
                        Console.Write("영어 성적: ");
                        int englishGrade = Int32.Parse(Console.ReadLine());
                       
                        double averageGrade = (double)(scienceGrade + mathGrade + historyGrade + englishGrade) / 4;

                        string gradeLetter = CalculateGradeLetter(averageGrade);


                        using (var context = new StudentContext())
                        {
                            var student = new Student
                            {
                                StudentID = studentID,
                                StudentName = studentName,
                                MathGrade = mathGrade,
                                ScienceGrade = scienceGrade,
                                HistoryGrade = historyGrade,
                                EnglishGrade = englishGrade,
                                GradeLetter = gradeLetter,
                                AverageGrade = averageGrade
                            };

                            context.StudentGrades.Add(student);
                            context.SaveChanges();
                            Console.WriteLine("학생 성적 데이터가 성공적으로 삽입되었습니다.");
                        }
                        ShowMenu();
                        break;

                    case 3:
                        using (var context = new StudentContext())
                        {
                            Console.Write("삭제할 학생의 학번: ");
                            int deleteStudentID = Int32.Parse(Console.ReadLine());

                            var studentToDelete = context.StudentGrades.FirstOrDefault(s => s.StudentID == deleteStudentID);

                            if (studentToDelete != null)
                            {
                                context.StudentGrades.Remove(studentToDelete);
                                context.SaveChanges();
                                Console.WriteLine($"{deleteStudentID}번 학생 데이터를 삭제하였습니다.");
                            }
                            else
                            {
                                Console.WriteLine("해당 학생 데이터를 찾을 수 없습니다.");
                            }
                           
                        }
                        ShowMenu();
                        break;
                    case 4:
                        using (var context = new StudentContext())
                        {
                            Console.WriteLine("학생 성적을 수정합니다.");
                            Console.Write("수정할 학생의 학번: ");
                            int changeStudentID = Int32.Parse(Console.ReadLine());

                            var studentToEdit = context.StudentGrades.FirstOrDefault(s => s.StudentID == changeStudentID);

                            if (studentToEdit != null)
                            {
                                Console.Write("새로운 수학 성적: ");
                                int newMathGrade = Int32.Parse(Console.ReadLine());
                                Console.Write("새로운 과학 성적: ");
                                int newScienceGrade = Int32.Parse(Console.ReadLine());
                                Console.Write("새로운 역사 성적: ");
                                int newHistoryGrade = Int32.Parse(Console.ReadLine());
                                Console.Write("새로운 영어 성적: ");
                                int newEnglishGrade = Int32.Parse(Console.ReadLine());
                                
                                double newaverageGrade = (double)(newScienceGrade + newMathGrade + newHistoryGrade + newEnglishGrade) / 4;

                                string newgradeLetter = CalculateGradeLetter(newaverageGrade);

                                studentToEdit.MathGrade = newMathGrade;
                                studentToEdit.ScienceGrade = newScienceGrade;
                                studentToEdit.HistoryGrade = newHistoryGrade;
                                studentToEdit.EnglishGrade = newEnglishGrade;
                                studentToEdit.GradeLetter = newgradeLetter;
                                studentToEdit.AverageGrade = newaverageGrade;

                                context.SaveChanges();
                                Console.WriteLine($"{changeStudentID}번 학생 성적 데이터가 성공적으로 수정되었습니다.");
                            }
                            else
                            {
                                Console.WriteLine("해당되는 학생 성적 데이터를 찾지 못하였습니다.");
                            }
                          
                        }
                        ShowMenu();
                        break;
                    case 5:
                        using (var context = new StudentContext())
                        {
                            Console.WriteLine("학생 성적을 조회합니다.");
                            Console.WriteLine($"{nameof(Student.StudentID),-10} {nameof(Student.StudentName),-15} " +
                                              $"{nameof(Student.MathGrade),-10} {nameof(Student.ScienceGrade),-10} " +
                                              $"{nameof(Student.HistoryGrade),-10} {nameof(Student.EnglishGrade),-10} " +
                                              $"{nameof(Student.AverageGrade),-10} {nameof(Student.GradeLetter),-10}");

                            Console.WriteLine(new string('-', 110));

                            var studentGrades = context.StudentGrades.ToList();

                            foreach (var student in studentGrades)
                            {
                                Console.WriteLine($"{student.StudentID,-10} {student.StudentName,-15} " +
                                                  $"{student.MathGrade,-10} {student.ScienceGrade,-10} " +
                                                  $"{student.HistoryGrade,-10} {student.EnglishGrade,-10} " +
                                                  $"{student.AverageGrade,-10}"+ $"{student.GradeLetter,-10}");
                            }
                            
                        }
                        ShowMenu();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static string CalculateGradeLetter(double averageGrade)
        {
            if (averageGrade >= 90)
            {
                return "A";
            }
            else if (averageGrade >= 80)
            {
                return "B";
            }
            else if (averageGrade >= 70)
            {
                return "C";
            }
            else if (averageGrade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        static void ShowMenu()
        {


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("██╗     ██╗███╗   ██╗███████╗");
            Console.WriteLine("██║     ██║████╗  ██║██╔════╝");
            Console.WriteLine("██║     ██║██╔██╗ ██║███████╗");
            Console.WriteLine("██║     ██║██║╚██╗██║╚════██║");
            Console.WriteLine("███████╗██║██║ ╚████║███████║");
            Console.WriteLine("╚══════╝╚═╝╚═╝  ╚═══╝╚══════╝");

            Console.ResetColor();

            Console.WriteLine("------------------------------");
            Console.WriteLine("1. 성적 테이블 생성");
            Console.WriteLine("2. 학생 성적 삽입");
            Console.WriteLine("3. 학생 성적 삭제");
            Console.WriteLine("4. 학생 성적 수정");
            Console.WriteLine("5. 학생 성적 조회");
            Console.WriteLine("6. 프로그램 종료");

            Console.Write("메뉴: ");
            n = Int32.Parse(Console.ReadLine());
        }
    }
}
