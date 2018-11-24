using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Видеокарта
//2. Оперативная память
//3. Винчестер
//4. Устройство чтения оптических дисков
//5. Блок питания
//6. Датчики
namespace PC_facade
{
    class VideoCard
    {
        //6
        public string Up()
        {
            return "Видеокарта: запуск.";
        }
        //7
        public string UpIsChecMonitor()
        {
            return "Видеокарта: проверка связи с монитором.";
        }//16
        public string UpInfoDisc()
        {
            return "Видеокарта: вывод информации об устройстве чтения дисков.";
        }
        //20
        public string UpInfoWinchester()
        {
            return "Видеокарта: вывод данных о винчестере.";
        }
        //12
        public string UpRAMInfo()
        {
            return "Видеокарта: вывод данных об оперативной памяти.";
        }
        //4-
        public string Down()
        {
            return "Видео карта: вывести на монитор данные прощальное сообщение.";
        }
    }
    class RAM
    {
        //10
        public string Up()
        {
            return "Оперативная память: запуск устройств";
        }
     //   11
        public string UpAnalis()
        {
            return "Оперативная память: анализ памяти.";
        }
        //2-
        public string DownRam()
        {
            return "Оперативная память: очистка памяти.";
        }
        //3-
        public string DownAnalisRam()
        {
            return "Оперативная память: анализ памяти.";
        }
    }
    class Winchester
    {
        //18
        public string Up()
        {
            return "Винчестер: запуск.";
        }
        //19
        public string IsCheced()
        {
            return "Винчестер: проверка загрузочного сектора.";


        }
        //1-
        public string Stop()
        {
            return "Винчестер: остановка устройства.";
        }
    }
    class OpticalDiscReader
    {//14
        public string Up()
        {
            return "Устройство чтения оптических дисков: запуск.";
        }//15
        public string IsCheced()
        {
            return "Устройство чтения оптических дисков: проверка наличия диска.";
        }
        public string Down()//5-
        {
            return "Устройство чтения дисков: вернуть в исходную позицию.";
        }
    }
    class PowerSupply
    {
        public string Up()//1
        {
            return "Блок питания: подать питание.";
        }
        public string UpVideoCard()//5
        {
            return "Блок питания: подать питание на видеокарту.";
        }
        public string UpRAM()//9
        {
            return "Блок питания: подать питание на оперативную память.";
        }
        public string UpDisc()//13
        {
            return "Блок питания: подать питание на устройство чтения дисков.";
        }
        public string UpWinchester()//17
        {
            return " Блок питания: подать питание на винчестер.";
        }
       
        public string DownVideoCard()//6-
        {
            return "Блок питания: прекратить питание видео карты.";
        }
        public string DownRAM()//7-
        {
            return "Блок питания: прекратить питание оперативной памяти.";
        }
        public string DownDisc()//8-
        {
            return "Блок питания: прекратить питание устройства чтения дисков.";
        }
        public string DownWinhester()//9-
        {
            return "Блок питания: прекратить питание винчестера.";
        }
        public string Down()//11-
        {
            return "Блок питания: выключение.";
        }
    }
    class Sensors
    {
        public string UpIsChecPower()//2
        {
            return "Датчики: проверить напряжение.";
        }
        public string UpIsChecTemperaturePower()//3
        {
            return "Датчики: проверить температуру в блоке питания.";
        }
        public string UpIsChecTemperaturePowerCard()//4
        {
            return "Датчики: проверить температуру в видеокарте.";
        }
        public string UpIsChecTemperatureRAM()//8
        {
            return "Датчики: проверить температуру в оперативной памяти.";
        }
        public string UpIsChecTemperatureAllSystem()//21
        {
            return "Датчики: проверить температуру всех систем";
        }

        public string Down()
        {
            return "Датчики проверить напряжение.";
        }
    }
   
    class PC
    {
        public PC(AllMessage elem)
        {
            message_ = elem;
        }
        AllMessage message_;
        Sensors sensors=new Sensors();
        VideoCard videoCard = new VideoCard();
        RAM ram = new RAM();
        Winchester winchester = new Winchester();
        OpticalDiscReader opticalDiscReader = new OpticalDiscReader();
        PowerSupply powerSupply = new PowerSupply();
        
        public void UP()
        {
            message_.Write("1 "+powerSupply.Up());
            message_.Write("2 " + sensors.UpIsChecPower());
            message_.Write("3 " +sensors.UpIsChecTemperaturePower());
            message_.Write("4 " +sensors.UpIsChecTemperaturePowerCard());
            message_.Write("5 " +powerSupply.UpVideoCard());
            message_.Write("6 " +videoCard.Up());
            message_.Write("7 " +videoCard.UpIsChecMonitor());
            message_.Write("8 " +sensors.UpIsChecTemperatureRAM());
            message_.Write("9 " +powerSupply.UpRAM());
            message_.Write("10 " +ram.Up());
            message_.Write("11 " +ram.UpAnalis());
            message_.Write("12 " +videoCard.UpRAMInfo());
            message_.Write("13 " +powerSupply.UpDisc());
            message_.Write("14 " +opticalDiscReader.Up());
            message_.Write("15 " +opticalDiscReader.IsCheced());
            message_.Write("16 " +videoCard.UpInfoDisc());
            message_.Write("17 " +powerSupply.UpWinchester());
            message_.Write("18 " +winchester.Up());
            message_.Write("19 " +winchester.IsCheced());
            message_.Write("20 " +videoCard.UpInfoWinchester());
            message_.Write("21 " +sensors.UpIsChecTemperatureAllSystem());
            message_.Write(" ");
        }
        public void Down()
        {
            message_.Write("1 " + winchester.Stop());
            message_.Write("2 " + ram.DownRam());
            message_.Write("3 " + ram.DownAnalisRam());
            message_.Write("4 " + videoCard.Down());
            message_.Write("5 " + opticalDiscReader.Down());
            message_.Write("6 " + powerSupply.DownVideoCard());
            message_.Write("7 " + powerSupply.DownRAM());
            message_.Write("8 " + powerSupply.DownDisc());
            message_.Write("9 " + powerSupply.DownWinhester());
            message_.Write("10 " + sensors.Down());
            message_.Write("11 " + powerSupply.Down());
            message_.Write(" ");
        }

    }
    public delegate void Message(string str);



    class Program
    {
        static void Main(string[] args)
        {
            PC my_pc = new PC(new ConsoleWriter());
            my_pc.UP();
            my_pc.Down();
        }
    }
}
