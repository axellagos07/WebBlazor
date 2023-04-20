using Modelos;

namespace Datos.Interfaces
{
    public interface ILoginRepositorio
    {
        //Declaramos los metodos 
        //Para poderlos utilizar e implementarlos en las clases 

        Task<bool> ValidarUsuarioAsync(Login login);

    }
}
