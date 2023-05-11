namespace CalismaProje
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();           //site içerisinde yönlendirme kullanacağını belirtiyor
            app.UseEndpoints(endpoints =>       //sitenin özelliklerini belirlediğimiz alan
            {
                endpoints.MapControllerRoute(
                name: "defalut",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}