using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_Destroyer_02
{
    internal class DataMahasiswa_1302213121_PRAKTIKAN
    {
        public Nama nama { get; set; }
        public int nim { get; set; }
        public String fakultas { get; set; }

        public DataMahasiswa_1302213121_PRAKTIKAN() { }
        public DataMahasiswa_1302213121_PRAKTIKAN(Nama nama, int nim, String fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\Kuliah\\SEMESTER 4\\KPL\\TP_MOD7_Destroyer\\TP_MOD7_Destroyer\\tpmodul7_Destroyer_02\\tpmodul7_Destroyer_02\\tp7_1_1302213121.json");
            DataMahasiswa_1302213121_PRAKTIKAN mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302213121_PRAKTIKAN>(jsonString);
            Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim +" dari fakultas " + mahasiswa.fakultas);
        }
        public class Nama
        {
            public String depan { get; set; }
            public String belakang { get; set; }

            public Nama(String depan, String belakang)
            {
                this.depan = depan;
                this.belakang = belakang;
            }
        }
    }
}
