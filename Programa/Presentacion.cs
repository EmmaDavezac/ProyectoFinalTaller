using BibliotecaTrabajoEnSegundoPlano;
using Quartz;
using Quartz.Impl;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Programa
{   /// <summary>
/// RESUMEN: Programa principal de la aplicacion
/// </summary>
    class Presentacion
    {/// <summary>
     /// Resumen:Tarea Principal del Programa
     /// </summary>
     /// <returns></returns>
        [STAThread]

        private static async Task Main()
        { 
            IScheduler scheduler = await Class1.factory.GetScheduler();//creamos un  planificador
            await scheduler.Start();//esperamos que el planificador inicie   
            await Class1.schedulerBuilder(scheduler);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login ventana = new Login();//Creamos una ventana de login
            Application.Run(ventana);//asignamos a la aplicacion el formulario inicial y la ejecutamos

        }

    }
}
