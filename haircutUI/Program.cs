using datalayers;
using datalayers.Abstract;
using datalayers.Concrate;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<context>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Register Repositories (Dal)
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));



builder.Services.AddScoped<IBeautyCardInfoDal, BeautyCardInfoDal>();
builder.Services.AddScoped<IBeautyCategoryDal, BeautyCategoryDal>();
builder.Services.AddScoped<IBeautyItemDal, BeautyItemsDal>();
builder.Services.AddScoped<IBeautyServiesItemDal, BeautymultiItemsServiceDal>();
builder.Services.AddScoped<IBeautysServicesDal, BeautysServicesDal>();
builder.Services.AddScoped<ICompanyDal, CompanyDal>();
builder.Services.AddScoped<IContactDal, ContactDal>();
builder.Services.AddScoped<IFaqDal, FaqDal>();
builder.Services.AddScoped<IHaircutMenuCategoryDal, HaircutMenuCategoryDal>();
builder.Services.AddScoped<IHaircutMenuItemDal, HaircutMenuItemDal>();
builder.Services.AddScoped<IHaircutServicesCategoryDal, HaircutServicesCategoryDal>();
builder.Services.AddScoped<IHaircutServiceDal, HaircutServicesDal>();
builder.Services.AddScoped<IHaircutSupServiceDal, HairCutSupServicesDal>();
builder.Services.AddScoped<IHairCutTeammemberDal, HairCutTeammemberDal>();
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
