using businesslayers.Interfaces;
using businesslayers.Services;
using datalayers;
using datalayers.Abstract;
using datalayers.Concrate;
using entitylayers;
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
builder.Services.AddScoped<IBeautyItemDal, BeautyItemDal>();
builder.Services.AddScoped<IBeautyServiesItemDal, BeautyServiesItemDal>();
builder.Services.AddScoped<IBeautysServicesDal, BeautysServicesDal>();
builder.Services.AddScoped<ICompanyDal, CompanyDal>();
builder.Services.AddScoped<IContactDal, ContactDal>();
builder.Services.AddScoped<IFaqDal, FaqDal>();
builder.Services.AddScoped<IHaircutMenuCategoryDal, HaircutMenuCategoryDal>();
builder.Services.AddScoped<IHaircutMenuItemDal, HaircutMenuItemDal>();
builder.Services.AddScoped<IHaircutServicesCategoryDal, HaircutServicesCategoryDal>();
builder.Services.AddScoped<IHaircutServiceDal, HaircutServiceDal>();
builder.Services.AddScoped<IHaircutSupServiceDal, HaircutSupServiceDal>();
builder.Services.AddScoped<IHairCutTeammemberDal, HairCutTeammemberDal>();

////////////////////////////////////////////////////////////////
////// business services register///////
///////////////////////////////////////////////////////////////
builder.Services.AddScoped<IBeautyCardInfoService, BeautyCardInfoService>();
builder.Services.AddScoped<IBeautyCategoryService, BeautyCategoryService>();
builder.Services.AddScoped<IBeautyItemService, BeautyItemService>();
builder.Services.AddScoped<IBeautyServiesItemService, BeautyServiesItemService>();
builder.Services.AddScoped<IBeautysServicesService, BeautysServicesService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<IFaqService, FaqService>();
builder.Services.AddScoped<IHaircutMenuCategoryService, HaircutMenuCategoryService>();
builder.Services.AddScoped<IHaircutMenuItemService, HaircutMenuItemService>();
builder.Services.AddScoped<IHaircutServicesCategoryService, HaircutServicesCategoryService>();
builder.Services.AddScoped<IHaircutServiceService, HaircutServiceService>();
builder.Services.AddScoped<IHaircutSupServiceService, HaircutSupServiceService>();
builder.Services.AddScoped<IHairCutTeammemberService, HairCutTeammemberService>();
/////////////////////////////////////////////////////////////////
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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
