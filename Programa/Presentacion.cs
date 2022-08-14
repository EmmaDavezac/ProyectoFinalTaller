using BibliotecaQuartz;
using Quartz;
using Quartz.Impl;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Programa
{
    class Presentacion
    //Programa principal de la aplicacion
    {
        [STAThread]
        private static async Task Main()
        //tarea a ejecutarse en primer plano
        {
            StdSchedulerFactory factory = new StdSchedulerFactory();//creamos una instancia de StdSchedulerFactory (fabrica de planificador)
            IScheduler scheduler = await factory.GetScheduler();//creamos una  planificador
            await scheduler.Start();//esperamos que el planificador inicie   
            IJobDetail job = JobBuilder.Create<NotificacionJob>()//creamos una instancia de trabajo y la asignamos al grupo group1
                .WithIdentity("job1", "group1")
                .Build();
            // el disparador activa el job para que corra, y repite  esta accion cada tantos minutos como lo indique el atributo tiempo
            ITrigger trigger = TriggerBuilder.Create()//creamos un disparador
                .WithIdentity("trigger1", "group1")//asignamos el disparador al grupo group1
                .StartNow()//activamos el disparador
                .WithSimpleSchedule(x => x
                    .WithIntervalInMinutes(60)//se activara cada tantos minutos como lo indique el atributo tiempo
                    .RepeatForever())//se repetira por siempre
                .Build();
            await scheduler.ScheduleJob(job, trigger);//le asignamos el disparador al trabajo en segundo plano
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login ventana = new Login();//Creamos una instancia del formulario login, lel cual va a ser el formulario inicial
            Application.Run(ventana);//asignamos a la aplicacion el formulario inicial y la ejecutamos
        }

    }
}
