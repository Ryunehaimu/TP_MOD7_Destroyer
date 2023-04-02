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
            DataMahasiswa_1302210025_PRAKTIKAN Dede = new DataMahasiswa_1302210025_PRAKTIKAN();
            Dede.ReadJSON();

            Console.WriteLine("=======================================");
            KuliahMahasiswa_130221025_PRAKTIKAN Kuliah = new KuliahMahasiswa_130221025_PRAKTIKAN();
            Kuliah.ReadJSON();
        }
    }
}
