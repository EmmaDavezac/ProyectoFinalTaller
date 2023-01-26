
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace BibliotecaTrabajoEnSegundoPlano
{
    public static class SchedulerBuilder

    {


        /// <summary>
        /// Resumen: Fabrica de planificadores
        /// </summary>
        public static StdSchedulerFactory factory = new StdSchedulerFactory();



       
 
   
        public static Task build(IScheduler scheduler)   
            {

            IJobDetail job = BibliotecaTrabajoEnSegundoPlano.JobBuilder.build();
            ITrigger trigger= BibliotecaTrabajoEnSegundoPlano.TriggerBuilder.build();
            return scheduler.ScheduleJob(job, trigger); }
    }
}
