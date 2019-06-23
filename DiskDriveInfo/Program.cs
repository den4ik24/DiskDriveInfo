using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskDriveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var drive in DriveInfo.GetDrives())
            {
                try
                {
                    Console.WriteLine("Имя диска: " + drive.Name);
                    Console.WriteLine("Метка тома диска: " + drive.VolumeLabel);
                    Console.WriteLine("корневой каталог диска: " + drive.RootDirectory);
                    Console.WriteLine("Готовность диска: " + drive.IsReady);
                    Console.WriteLine("Тип диска: " + drive.DriveType);
                    Console.WriteLine("Файловая система: " + drive.DriveFormat);
                    Console.WriteLine("Размер диска (Мб): " + drive.TotalSize / 1048576);
                    Console.WriteLine("Общий объем свободного места доступного надиске (Мб): " + drive.TotalFreeSpace / 1048576);
                    Console.WriteLine("Объем доступного свободного места (Мб): " + drive.AvailableFreeSpace / 1048576);
                }
                catch { }

                Console.ReadLine();
            }
        }
    }
}
