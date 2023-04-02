using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_Destroyer_02
{
    internal class KuliahMahasiswa_130221025_PRAKTIKAN
    {
        public class MataKuliah
        {
            public string code { get; set; }
            public string name { get; set; }
            public MataKuliah(string code, string name)
            {
                this.code = code;
                this.name = name;
            }
        }


        public class ListMatkulMahasiswa
        {
            public List<MataKuliah> courses { get; set; }
            public ListMatkulMahasiswa(List<MataKuliah> courses)
            {
                this.courses = courses;
            }
        }

        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("../../tp7_2_1302210025.json");
            ListMatkulMahasiswa matkul = JsonSerializer.Deserialize<ListMatkulMahasiswa>(jsonString);

            for (int i = 0; i < matkul.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i + 1) + " " + matkul.courses[i].code + " - " +matkul.courses[i].name);
            }
        }
    }
}
