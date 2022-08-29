using System.Threading.Tasks;
using Quartz;
using Nucleo;

namespace BibliotecaTrabajoEnSegundoPlano
{
    public class NotificacionJob : IJob
    {
        public async Task Execute(IJobExecutionContext context) //este metodo es la tarea asincronica a ejecutarse
        {
            FachadaNucleo fachada = new FachadaNucleo();
            fachada.NotificarUsuarios();//Notificamos a los usuarios con prestamos vencidos o proximos a vencer(en el caso de ser la hora correcta)
            await Task.CompletedTask;//Se espera que la tarea se complete para terminar el proceso
        }
    }
}
