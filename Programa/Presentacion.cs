﻿using System;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;
using Quartz.Logging;
using System.Windows.Forms;
using Nucleo;

namespace Programa
{
    class Presentacion
    {
        
        public class Trabajo : IJob
        {
            public async Task Execute(IJobExecutionContext context)
            {
                FachadaNucleo interfaz = new FachadaNucleo();
                interfaz.NotificarPrestamosProximosAVencer();
                interfaz.NotificarPrestamosRetrasados();
                MessageBox.Show("Prestamos Proximos a vencer y retrasados notificados!");
                await Task.CompletedTask;
            }
            [STAThread]
            private static async Task Main(string[] args)
            {
                const int tiempo = 60;

                // solicita una instancia de Scheduler de la Factory
                StdSchedulerFactory factory = new StdSchedulerFactory();
                IScheduler scheduler = await factory.GetScheduler();

                // y la inicia
                await scheduler.Start();

                // define the job and tie it to our HelloJob class define el job y lo asigna a nuestro job
                IJobDetail job = JobBuilder.Create<Trabajo>()
                    .WithIdentity("job1", "group1")
                    .Build();

                // el disparador activa el job para que corra, y repite  esta accion cada 5 segundos
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("trigger1", "group1")
                    .StartNow()
                    .WithSimpleSchedule(x => x
                        .WithIntervalInMinutes(tiempo)
                        .RepeatForever())
                    .Build();

                //le indica a quartz para programar el trabajo usando el disparador anterior
                await scheduler.ScheduleJob(job, trigger);//accion periodica
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            }
        }
    }
}
