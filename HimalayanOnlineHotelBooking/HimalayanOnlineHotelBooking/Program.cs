using BusinessLogicLayer.BLL;
using BusinessLogicLayer.InterfacesBLL;
using BusinessLogicLayer.InterfacesDAL;
using DataAccessLayer.DAL;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddMvc();

builder.Services.AddAuthorization();

builder.Services.AddScoped<IBookingBLL, BookingBLL>();
builder.Services.AddScoped<IBookingDAL, BookingDAL>();

builder.Services.AddScoped<IUserBLL, UserBLL>();
builder.Services.AddScoped<IUserDAL, UserDAL>();

builder.Services.AddScoped<IRoomBookedDAL, RoomBookedDAL>();
builder.Services.AddScoped<IRoomBookedBLL, RoomBookedBLL>();

builder.Services.AddScoped<IRoomDAL, RoomDAL>();
builder.Services.AddScoped<IRoomBLL, RoomBLL>();

builder.Services.AddScoped<IRoomTypeDAL, RoomTypeDAL>();
builder.Services.AddScoped<IRoomTypeBLL, RoomTypeBLL>();

builder.Services.AddScoped<IGuestDAL, GuestDAL>();
builder.Services.AddScoped<IGuestBLL, GuestBLL>();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddHttpContextAccessor();

builder.Services.AddSession(options =>
{
    options.Cookie.Name = "HotelBookingSessionCookie";
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.Name = "HotelBookingSessionCookie";
        options.Cookie.HttpOnly = true;
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
        options.LoginPath = "/Hotel/Account/Login";
    });
builder.Services.AddAuthorization(option =>
{
    option.AddPolicy("Guest", policy => policy.RequireClaim(ClaimTypes.Role, "G"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();

app.MapRazorPages();

app.Run();





