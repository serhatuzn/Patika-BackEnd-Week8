var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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


/*
    Açıklamalar:

    - Controller: Uygulamanın kullanıcı isteklerini işleyen kısmıdır. Örnek: HomeController.
    - Action: Controller içinde bulunan, belirli bir görevi gerçekleştiren metodlardır.
    - Model: Uygulamanın veri yapısını temsil eder. Örnek: Product modeli.
    - View: Kullanıcıya sunulan HTML/CSS gibi çıktıları temsil eder.
    - Razor: C# kodlarını HTML içinde yazmamıza olanak tanıyan bir şablon motorudur.
    - RazorView: Razor şablonlarını işleyen yapı.
    - wwwroot: Statik dosyaların (CSS, JS, görüntüler vb.) bulunduğu klasördür.
    
    - builder.Build(): Uygulama yapılandırmasını tamamlar ve bir "WebApplication" örneği oluşturur.
    - app.Run(): Uygulamayı başlatır ve gelen HTTP isteklerini dinler.
    
*/