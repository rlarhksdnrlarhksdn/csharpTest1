<INDEX 뷰>
@model Diary

@{
    ViewData["Title"] = "DIARY";
}

<h1 class="text-center">@ViewData["Title"]</h1>
<div class="text-center mt-4">
    <p>나만의 다이어리를 작성해보세요.</p>
</div>

<div class="text-center">
    <img src="~/image/캡처.png" />
</div>

<div>
    <form method="post" asp-action="Create">
        <h2>Number</h2><input asp-for="No" class="form-control" placeholder="번호을 적어주세요." value="" />
        <br />
        <h2>Title</h2><input asp-for="Title" class="form-control" placeholder="제목을 적어주세요." value="" />
        <br />
        <h2>Writer</h2><input asp-for="Writer" class="form-control" placeholder="작성자를 적어주세요." value="" />
        <br />
        <h2>Content</h2>
        <textarea asp-for="Content" rows="24" cols="169" placeholder="최소 60자 이상 적어주세요." class="form-control"></textarea>
        <br />
        <h2>Date</h2> <input asp-for="Date" class="form-control" value="@DateTime.Now.ToString("yyyy-MM-dd")" />
        <br />
        <button type="submit" class="btn btn-primary">Save</button>
    </form>
</div>

<HOMECONTROLLER>

using Diary01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Diary01.Controllers
{
    public class HomeController : Controller
    {
        private readonly DiaryDbContext diaryDbContext;
        public HomeController(DiaryDbContext studentDb)
        {
            this.diaryDbContext = studentDb;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Result()
        {
            var savedDiaries = diaryDbContext.Diary.ToList();
            return View(savedDiaries);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("No, Title, Content, Date, Writer")] Diary diary)
        {
            if (ModelState.IsValid)
            {
                diaryDbContext.Add(diary);
                await diaryDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Result));
            }
            return View(await diaryDbContext.Diary.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteSelected(int[] selectedDiaries)
        {
            if (selectedDiaries == null || selectedDiaries.Length == 0)
            {
                return RedirectToAction(nameof(Result));
            }

            var diariesToDelete = await diaryDbContext.Diary
                .Where(d => selectedDiaries.Contains(d.No))
                .ToListAsync();

            diaryDbContext.Diary.RemoveRange(diariesToDelete);
            await diaryDbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Result));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stdData = await diaryDbContext.Diary.FirstOrDefaultAsync(x => x.No == id);

            if (stdData == null)
            {
                return NotFound();
            }

            return View(stdData);
        }

        [HttpPost]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}

<PROGRAM.CS>
using Diary01.Models;
using Microsoft.EntityFrameworkCore;

namespace Diary01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var provider = builder.Services.BuildServiceProvider();
            var config = provider.GetRequiredService<IConfiguration>();
            builder.Services.AddDbContext<DiaryDbContext>(item => item.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

<SQL 연결>

{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "DefaultConnection": "Server=(local)\\SQLEXPRESS;Database=SmartFactory;Trusted_Connection=True;"
  },
  "AllowedHosts": "*"
}

<DiaryDbContext>

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Diary01.Models
{
    public class DiaryDbContext : DbContext
    {
        public DiaryDbContext(DbContextOptions options) : base(options)
        {
        }
        //테이블 만들기
        public DbSet<Diary> Diary { get; set; }
    }
}

<Result View>

@model List<Diary01.Models.Diary>

@{
    ViewData["Title"] = "Saved Diaries";
}

<h1>@ViewData["Title"]</h1>

<div class="text-center">
    <img src="~/image/12.png" />
</div>

<div class="text-center mt-4">
    <p><h1>성공적으로 저장되었습니다.</h1></p>
</div>

<form asp-action="DeleteSelected" method="post">
    <button type="submit">선택한 항목 삭제</button>
    <table class="table">
        <thead>
            <tr>
                <th></th>
                <th>No</th>
                <th>Title</th>
                <th>Date</th>
                <th>Writer</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            @foreach (var diary in Model)
            {
                <tr>
                    <td><input type="checkbox" name="selectedDiaries" value="@diary.No" /></td>
                    <td>@diary.No</td>
                    <td>@diary.Title</td>
                    <td>@diary.Date.ToString("yyyy-MM-dd")</td>
                    <td>@diary.Writer</td>
                    <td><button type="button" onclick="location.href='@Url.Action("Details", new { id = diary.No })'">내용보기</button></td>
                </tr>
            }
        </tbody>
    </table>
</form>

<div>
    <div>
        <a asp-action="Index" class="btn btn-primary">다시 작성하기</a>
    </div>
</div>

<Details 뷰>

@model Diary01.Models.Diary

@{
    ViewData["Title"] = "다이어리 불러오기";
}

<h1>다이어리 불러오기</h1>
<img src="~/image/일기.png" />
<div>
    <h4>Diary</h4>
    <hr />
    <dl class="row">
        <dt class = "col-sm-2">
            @Html.DisplayNameFor(model => model.Title)
        </dt>
        <dd class = "col-sm-10">
            @Html.DisplayFor(model => model.Title)
        </dd>
        <dt class = "col-sm-2">
            @Html.DisplayNameFor(model => model.Date)
        </dt>
        <dd class = "col-sm-10">
            @Html.DisplayFor(model => model.Date)
        </dd>
        <dt class = "col-sm-2">
            @Html.DisplayNameFor(model => model.Content)
        </dt>
        <dd class = "col-sm-10">
            @Html.DisplayFor(model => model.Content)
        </dd>
        <dt class = "col-sm-2">
            @Html.DisplayNameFor(model => model.Writer)
        </dt>
        <dd class = "col-sm-10">
            @Html.DisplayFor(model => model.Writer)
        </dd>
    </dl>
</div>
<div>
    <div>
        <a asp-action="Index" class="btn btn-primary">작성 페이지로 돌아가기</a>
        <a asp-action="Result" class="btn btn-primary">저장된 다이어리 페이지로 돌아가기</a>
    </div>
</div>
