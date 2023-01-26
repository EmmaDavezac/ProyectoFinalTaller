using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace BibliotecaTrabajoEnSegundoPlano
{
    static class TriggerBuilder
    {
        /// <summary>
        /// Resumen: Este metodo devuelve un constructor de Triggers
        /// </summary>
        /// <returns></returns>
        public static ITrigger build()
        {
            return Quartz.TriggerBuilder.Create()//creamos un disparador
               .WithIdentity("trigger1", "group1")//asignamos el disparador al grupo group1
               .StartNow()//activamos el disparador
               .WithSchedule(CronScheduleBuilder.CronSchedule("0 0 9 ? * MON-FRI"))//Expresion Cron que establece que la accion se va a ejecutar de Lunes a Viernes a las 9:00 AM

               .Build();
        }
    }
}
