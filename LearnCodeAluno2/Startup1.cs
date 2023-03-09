using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(LearnCodeAluno2.Startup1))]

namespace LearnCodeAluno2
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions // Metodo pra realizar a Autentificação
            {
                //Ctrl+espaço ele mostra as propriedades que já estão definidas aqui na aplicação
                AuthenticationType = "ApplicationCookie",
                //Rota (Endereço,URL)
                LoginPath= new PathString("/Atenticacao/Login")
            }); 
        }
    }
}
