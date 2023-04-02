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
            DataMahasiswa_13022130063_PRAKTIKAN Fathur = new DataMahasiswa_13022130063_PRAKTIKAN();
            Fathur.ReadJSON();

            Console.WriteLine("=======================================");
            KuliahMahasiswa_1302210063_PRAKTIKAN Kuliah = new KuliahMahasiswa_1302210063_PRAKTIKAN();
            Kuliah.ReadJSON();
        }
    }
}
