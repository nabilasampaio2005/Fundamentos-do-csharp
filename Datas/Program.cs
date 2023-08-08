using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Date
{
    class Program 
    {
        static void Main(string[] args)
        {
          //Dates();
          //FormDate();
          //PadForm();
          //AddVal();
          //CompDate();
          //CultureInfo();
          //TimeZone();
          //TimeSpan();
        }
        static void Dates()
        {
            //var date = DateTime.Now;
        
           var date = new DateTime(2023, 08, 01, 9, 29, 32); 

           Console.WriteLine(date);
           Console.WriteLine(date.Year);
           Console.WriteLine(date.Month);
           Console.WriteLine(date.Day);
           Console.WriteLine(date.Hour);
           Console.WriteLine(date.Minute);
           Console.WriteLine(date.Second);

           Console.WriteLine((int)date.DayOfWeek);
           
           Console.WriteLine((int)date.DayOfYear);
        }

        static void FormDate()
        {
            Console.Clear();
           var date = new DateTime(2023, 08, 01, 9, 29, 32);

           //mes e ano        
           //var formato = String.Format("{0:y}", date);

           //Mes e dia          
           //var formato = String.Format("{0:M}", date);
           
           //minutos         
           //var formato = String.Format("{0:mm}", date);

           //var formato = String.Format("{0:yyyy-MM-dd}", date);

           var formato = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", date);
          
           Console.WriteLine(formato); 
        }
        
        static void PadForm()
        {
            Console.Clear();

            var date = DateTime.Now;

            //var formato = String.Format("0:D", date);
            //var formato = String.Format("0:f", date);
            //var formato = String.Format("0:g", date);
            //var formato = String.Format("0:s", date);
            var formato = String.Format("0:u", date);
            Console.WriteLine(formato);
        }
    
        static void AddVal()
        {
            Console.Clear();

            var date = DateTime.Now;
            Console.WriteLine(date);
            
            //para adicionar ou subtrair dias na data atual
            Console.WriteLine(date.AddDays(12));
            
            //para adicionar ou subtrair meses na data atual 
            Console.WriteLine(date.AddMonths(1));
            
            //para adicionar ou subtrair anos na data atual
            Console.WriteLine(date.AddYears(1));
            
        }
    
        static void CompDate()
        {
            Console.Clear();

            //data nula 
            //DateTime? date = null;
            
            var date = DateTime.Now;

            if(date.Date == DateTime.Now)
            {
                Console.WriteLine("É igual");
            }

            Console.WriteLine(date);
        }
    
        static void CultureInfo()
        {
            Console.Clear();

            //var pt = new System.Globalization.CultureInfo("pt-BR");

            var pt = new CultureInfo("pt-PT"); //Portugal
            var br = new CultureInfo("pt-BR"); //Brasil
            var uk = new CultureInfo("en-UK"); //Britanico
            var en = new CultureInfo("en-US"); //Americano
            var de = new CultureInfo("de-DE"); //Dinamarca
            //var atual = CultureInfo.CurrentCulture; 

            //Console.WriteLine(string.Format("D", atual));
        }
    
        static void TimeZone()
        {
            Console.Clear();

            var dateTime = DateTime.UtcNow;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(dateTime);

            Console.WriteLine(dateTime.ToLocalTime());

            var timezoneAustralia =
            TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var horaAustralia = 
            TimeZoneInfo.ConvertTimeToUtc(dateTime,timezoneAustralia);
            Console.WriteLine(timezoneAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach(var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime,timezone));
                Console.WriteLine("_____________________");
            }
            
        }
    
        static void TimeSpan()
        {
            Console.Clear();
            
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanosegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanosegundos);
            
            var timeSpanHoraMinutoSegundo = new TimeSpan(5,12,8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3,5,50,10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15,12,55,8,100);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12,0,0)));

        }
            
    }
}