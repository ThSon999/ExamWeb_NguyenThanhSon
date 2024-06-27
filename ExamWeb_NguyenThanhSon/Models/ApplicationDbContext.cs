using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamWeb_NguyenThanhSon.Models;

namespace ExamWeb_NguyenThanhSon.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> ops) : base(ops)
        {

        }

        public DbSet<DiaNhac> DiaNhacs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaNhac>().HasData(
                  new DiaNhac { Id = 1, TuaCD = "CD Nỗi buồn gác trọ", NGheSi = "A", TrongNuoc = true, GiaBan = 12000, SoLuong = 10 },
                  new DiaNhac { Id = 2, TuaCD = "CD Bài ca tình đêm", NGheSi = "A", TrongNuoc = true, GiaBan = 12000, SoLuong = 15 },
                  new DiaNhac { Id = 3, TuaCD = "CD BABYMONSTER", NGheSi = "A", TrongNuoc = false, GiaBan = 12000, SoLuong = 10 },
                  new DiaNhac { Id = 4, TuaCD = "CD Chuyện chúng mình", NGheSi = "A", TrongNuoc = true, GiaBan = 12000, SoLuong = 15 },
                  new DiaNhac { Id = 5, TuaCD = "CD Today US-UK Hit", NGheSi = "A", TrongNuoc = false, GiaBan = 12000, SoLuong = 10 },
                  new DiaNhac { Id = 6, TuaCD = "CD Đoá hồng nhạc việt", NGheSi = "A",TrongNuoc = true, GiaBan = 12000, SoLuong = 15 }
                  );
        }
    }
}
