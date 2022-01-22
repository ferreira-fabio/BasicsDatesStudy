using System;
using System.Globalization;
using System.Threading;

namespace TestingDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Testando Datas e Horários Locais");
            System.Console.WriteLine("---------------------------------");
            Thread.Sleep(1000);

            System.Console.WriteLine("");
            System.Console.WriteLine("Sua data atual é:");
            Thread.Sleep(500);
            var horaAtual = DateTime.Now; //Chamando a propriedade Now de da Classe DateTime para mostrar a hora atual de acordo com o dispositivo usado.
            System.Console.WriteLine(horaAtual); 
            var br =  new CultureInfo("pt-BR"); //Criando um padrão conforme regiao com a instancia da classe culture info
            
            System.Console.WriteLine("No formato brasileiro:");
            System.Console.WriteLine(horaAtual.ToString("g" , br)+ " - Em Portugal"); //Formatando com ToString e usando oo objeto criado de CultureInfo
            var horaBahia = TimeZoneInfo.FindSystemTimeZoneById("Bahia Standard Time"); //chamando o método FindSystemTimeZoneById(string id) para saber o valor utc
            System.Console.WriteLine(horaBahia);
            var convertHora = TimeZoneInfo.ConvertTime(horaAtual,  horaBahia);//usando o método TimeZoneInfo.ConvertTime(DateTime,TimeZoneInfo) para converter a hora local 
            System.Console.WriteLine(convertHora.ToString("g", br));         //em hora de determinada regiao com os parametro recebidos.

           
            /*foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
            
                Console.WriteLine(z.Id);
            
*/      //Laço usado para buscar o Id para o timeZoneInfo,para entao poder inserir dentro do método TimeZoneInfo.ConvertTime(DateTime, TimeZoneInfo, TimeZoneInfo).

            

        }
    }
}
