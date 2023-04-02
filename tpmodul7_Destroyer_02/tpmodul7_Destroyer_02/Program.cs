using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_Destroyer_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302210086_PRAKTIKAN Rizqi = new DataMahasiswa_1302210086_PRAKTIKAN();
            Rizqi.ReadJSON();

            Console.WriteLine("=======================================");
            KuliahMahasiswa_1302210086_PRAKTIKAN Kuliah = new KuliahMahasiswa_1302210086_PRAKTIKAN();
            Kuliah.ReadJSON();
        }
    }
}
