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
            DataMahasiswa_1302210093_PRAKTIKAN Ghaza = new DataMahasiswa_1302210093_PRAKTIKAN();
            Ghaza.ReadJSON();

            Console.WriteLine("=======================================");
            KuliahMahasiswa_1302210093_PRAKTIKAN Kuliah = new KuliahMahasiswa_1302210093_PRAKTIKAN();
            Kuliah.ReadJSON();
        }
    }
}
