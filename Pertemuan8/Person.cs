using System;
namespace Pertemuan8
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }

        public Person(string isName, int isAge)
        {
            this.Name = isName;
            this.Age = isAge;

            Console.WriteLine("Nama saya : {0} \nUmur saya :  {1} tahun", Name, Age);
            Console.WriteLine();
        }

        public void infoPerson()
        {
            Console.WriteLine("Nama Saya {0}, dan umur saya {1} tahun", Name, Age);
            Console.WriteLine();
        }
    }

    public class Karyawan : Person
    {
        public int karyawanID { get; set; }
        public string subject { get; set; }

        public Karyawan()
        {

        }

        public Karyawan(string subject)
        {
            this.subject = subject;
            Console.WriteLine("Saya disini sebagai {0}", this.subject);
            Console.WriteLine();
        }
        public void infoKaryawan()
        {
            Console.WriteLine("ID Karyawan : {0} \nNama Karyawan : {1}", karyawanID, subject);
            Console.WriteLine();
        }

    }

}