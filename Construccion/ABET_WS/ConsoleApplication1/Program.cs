using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //CarreraWS.CarreraClient carreraClient = new CarreraWS.CarreraClient();
                //CarreraWS.CarreraCollectionDC resultado = carreraClient.ListarCarreras();

                //for (int i = 0; i < resultado.Count; i++)
                //    Console.WriteLine("{0} - {1}", resultado[i].CarreraId, resultado[i].CarreraNombre);

                //CursoWS.CursoClient cursoClient = new CursoWS.CursoClient();
                //CursoWS.CursoCollectionDC resultado = cursoClient.ListarCursosPorTipoCursoCarreraId(1, 1);

                //for (int i = 0; i < resultado.Count; i++)
                //    Console.WriteLine("{0} - {1}", resultado[i].CursoId, resultado[i].CursoNombre);

                //OutcomeWS.OutcomeClient outcomeClient = new OutcomeWS.OutcomeClient();
                //OutcomeWS.OutcomeCollectionDC resultado = outcomeClient.ListarOutcomePorCarreraId(1);

                //for (int i = 0; i < resultado.Count; i++)
                //    Console.WriteLine("{0} - {1} - {2}", resultado[i].OutcomeId, resultado[i].OutcomeNombre, resultado[i].OutcomeDescripcion);

                //PeriodoWS.PeriodoClient periodoClient = new PeriodoWS.PeriodoClient();
                //PeriodoWS.PeriodoCollectionDC resultado = periodoClient.ListarPeriodoPorCarreraId(1);

                //for (int i = 0; i < resultado.Count; i++)
                //    Console.WriteLine("{0} - {1}", resultado[i].PeriodoId, resultado[i].PeriodoNombre);

                /* actualizar curso */
                //CursoWS.CursoClient cursoClient = new CursoWS.CursoClient();
                //cursoClient.ActualizarCursosPorCarreraPorNivelPorPeriodoActual(22,false,true);

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex.Message);
            }
        }
    }
}
