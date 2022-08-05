using Quartz;
using Quartz.Impl;
using System.Threading.Tasks;


namespace Nucleo
{
    public class ServiciosAsincronos : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        //este metodo es la tarea asincronica a ejecutarse
        {
            FachadaNucleo interfaz = new FachadaNucleo();
            interfaz.NotificarUsuarios();//Notificamos a los usuarios con prestamos vencidos o proximos a vencer(en el caso de ser la hora correcta)
            await Task.CompletedTask;//se da por finalizada la tarea
        }

        public async Task NotificarUsuarioAsincrono(int pIntervaloTiempoMin) 
        {
            StdSchedulerFactory factory = new StdSchedulerFactory();//creamos una instancia de StdSchedulerFactory (fabrica de planificador)
            IScheduler scheduler = await factory.GetScheduler();//creamos una  planificador


            await scheduler.Start();//esperamos que el planificador inicie


            IJobDetail job = JobBuilder.Create<ServiciosAsincronos>()//creamos una instancia de trabajo y la asignamos al grupo group1
                .WithIdentity("job1", "group1")
                .Build();

            // el disparador activa el job para que corra, y repite  esta accion cada tantos minutos como lo indique el atributo tiempo
            ITrigger trigger = TriggerBuilder.Create()//creamos un disparador
                .WithIdentity("trigger1", "group1")//asignamos el disparador al grupo group1
                .StartNow()//activamos el disparador
                .WithSimpleSchedule(x => x
                    .WithIntervalInMinutes(pIntervaloTiempoMin)//se activara cada tantos minutos como lo indique el atributo tiempo
                    .RepeatForever())//se repetira por siempre
                .Build();


            await scheduler.ScheduleJob(job, trigger);//le asignamos el disparador al trabajo en segundo plano
        }
    }
}
