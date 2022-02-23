using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nucleo
{
    public class TrabajoSecundario : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        //este metodo es la tarea asincronica a ejecutarse
        {
            FachadaNucleo interfaz = new FachadaNucleo();
            interfaz.NotificarUsuarios();//Notificamos a los usuarios con prestamos vencidos o proximos a vencer(en el caso de ser la hora correcta)
            await Task.CompletedTask;//se da por finalizada la tarea
        }


    }
}
