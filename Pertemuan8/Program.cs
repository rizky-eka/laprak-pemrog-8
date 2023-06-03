namespace Pertemuan8
{
    public class Program
{
    static void Main(string[] args)
    {
        Console.Write('\n');
        Person person1 = new Person();
        person1.Name = "Rizky Eka Haryadi";
        person1.Age = 19;
        person1.infoPerson();

        Person person2 = new Person("Eka", 19);


        Karyawan karyawan1 = new Karyawan();
        karyawan1.karyawanID = 22114829;
        karyawan1.subject = "Rizky Eka";
        karyawan1.infoKaryawan();

        Karyawan karyawan2 = new Karyawan("Mobile Developemnt");
    }
}
}