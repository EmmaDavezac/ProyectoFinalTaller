using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace BibliotecaTrabajoEnSegundoPlano
{
    public static class Class1
    {


        /// <summary>
        /// Resumen: Fabrica de planificadores
        /// </summary>
        public static StdSchedulerFactory factory = new StdSchedulerFactory();



        /// <summary>
        /// Resumen: Este metodo devuelve un constructor de trabajo (NotificacionTrabajo)
        /// </summary>
        /// <returns></returns>
        public static IJobDetail jobBuilder()
        {
            return JobBuilder.Create<NotificacionJob>()//creamos una instancia de trabajo y la asignamos al grupo group1
                .WithIdentity("job1", "group1")
                .Build();
        }

        /// <summary>
        /// Resumen: Este metodo devuelve un constructor de Triggers
        /// </summary>
        /// <returns></returns>
        public static ITrigger triggerBuilder()
        {
            return TriggerBuilder.Create()//creamos un disparador
               .WithIdentity("trigger1", "group1")//asignamos el disparador al grupo group1
               .StartNow()//activamos el disparador
               .WithSchedule(CronScheduleBuilder.CronSchedule("0 0 9 ? * MON-FRI"))//Expresion Cron que establece que la accion se va a ejecutar de Lunes a Viernes a las 9:00 AM
 
               .Build();
        }

        /// <summary>
        /// Resumen: Este metodo devuelve un constructor de planificadores
        /// </summary>
        /// <param name="scheduler"></param>
        /// <returns></returns>
        public static Task schedulerBuilder(IScheduler scheduler)   
            {

            IJobDetail job = jobBuilder();
        ITrigger trigger= triggerBuilder();
            return scheduler.ScheduleJob(jobBuilder() , triggerBuilder()); }
    }
}
