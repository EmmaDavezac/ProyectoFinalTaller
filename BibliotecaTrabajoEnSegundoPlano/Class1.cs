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
        public static StdSchedulerFactory factory = new StdSchedulerFactory();//creamos una instancia de StdSchedulerFactory (fabrica de planificador) 




        public static IJobDetail jobBuilder()
        {
            return JobBuilder.Create<NotificacionJob>()//creamos una instancia de trabajo y la asignamos al grupo group1
                .WithIdentity("job1", "group1")
                .Build();
        }

        public static ITrigger triggerBuilder()
        {
            return TriggerBuilder.Create()//creamos un disparador
               .WithIdentity("trigger1", "group1")//asignamos el disparador al grupo group1
               .StartNow()//activamos el disparador
               .WithSimpleSchedule(x => x
                   .WithIntervalInMinutes(60)//se activara cada tantos minutos como lo indique el atributo tiempo
                   .RepeatForever())//se repetira por siempre
               .Build();
        }
        public static Task schedulerBuilder(IScheduler scheduler)   
            {

            IJobDetail job = jobBuilder();
        ITrigger trigger= triggerBuilder();
            return scheduler.ScheduleJob(jobBuilder() , triggerBuilder()); }
    }
}
