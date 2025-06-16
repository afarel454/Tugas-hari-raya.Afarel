public class Karyawan
{
    private string nama;
    private string id;
    private double gajiPokok;

    public Karyawan(string nama, string id, double gajiPokok)
    {
        this.nama = nama;
        this.id = id;
        this.gajiPokok = gajiPokok;
    }

    public string GetNama() => nama;
    public void SetNama(string nama) => this.nama = nama;

    public string GetId() => id;
    public void SetId(string id) => this.id = id;

    public double GetGajiPokok() => gajiPokok;
    public void SetGajiPokok(double gajiPokok) => this.gajiPokok = gajiPokok;

    public void DisplayInfo()
    {
        Console.WriteLine("Nama: " + nama);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Gaji Pokok: " + gajiPokok);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Karyawan k = new Karyawan("Advent", "001", 5000000);
        k.DisplayInfo();
    }
}
