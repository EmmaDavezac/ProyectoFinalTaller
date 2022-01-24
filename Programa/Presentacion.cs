using Nucleo;
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

        public class Trabajo : IJob
            //Esta clase representa a la tarea que se va a ejecutar en segundo plano de manera asincronica
        {
            public async Task Execute(IJobExecutionContext context)
                //este metodo es la tarea asincronica a ejecutarse
            {
                FachadaNucleo interfaz = new FachadaNucleo();
                interfaz.NotificarUsuarios();//Notificamos a los usuarios con prestamos vencidos o proximos a vencer(en el caso de ser la hora correcta)
                await Task.CompletedTask;//se da por finalizada la tarea
            }
            [STAThread]
            private static async Task Main()
                //tarea a ejecutarse en primer plano
            {
                const int tiempo = 60;//esta constante representa cada cuanto tiempo (en minutos) se ejecutara la tarea en segundo plano

                
                StdSchedulerFactory factory = new StdSchedulerFactory();//creamos una instancia de StdSchedulerFactory (fabrica de planificador)
                IScheduler scheduler = await factory.GetScheduler();//creamos una  planificador

                
                await scheduler.Start();//esperamos que el planificador inicie

               
                IJobDetail job = JobBuilder.Create<Trabajo>()//creamos una instancia de trabajo y la asignamos al grupo group1
                    .WithIdentity("job1", "group1")
                    .Build();

                // el disparador activa el job para que corra, y repite  esta accion cada tantos minutos como lo indique el atributo tiempo
                ITrigger trigger = TriggerBuilder.Create()//creamos un disparador
                    .WithIdentity("trigger1", "group1")//asignamos el disparador al grupo group1
                    .StartNow()//activamos el disparador
                    .WithSimpleSchedule(x => x
                        .WithIntervalInMinutes(tiempo)//se activara cada tantos minutos como lo indique el atributo tiempo
                        .RepeatForever())//se repetira por siempre
                    .Build();

                
                await scheduler.ScheduleJob(job, trigger);//le asignamos el disparador al trabajo en segundo plano
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Login ventana=new Login();//Creamos una instancia del formulario login, lel cual va a ser el formulario inicial
                Application.Run(ventana);//asignamos a la aplicacion el formulario inicial y la ejecutamos
            }
        }
    }
}
