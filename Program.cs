ImageProcessor Kertas = new ImageProcessor();

Kertas.Resize(-50);
Kertas.Resize(50);
Kertas.Resize(100);
Kertas.Resize(150);

Kertas.Resize(720, 1080);

Kertas.Resize("F4");

class ImageProcessor
{
    public void Resize(int presentase)
    {
        if (presentase <= 0)
        {
            Console.WriteLine("Error! Presentase tidak boleh nol(0) atau negatif");
        }
        else if (presentase < 100)
        {
            Console.WriteLine($"Mengecilkan gambar menjadi {presentase}%");
        }
        else if (presentase > 100)
        {
            Console.WriteLine($"Memperbesar gambar menjadi {presentase}%");
        }
        else
        {
            Console.WriteLine("Ukuran tetap (100%). Tidak ada perubahan");
        }
    }

    public void Resize(int lebar, int tinggi)
    {
        Console.WriteLine($"Mengubah ukuran menjadi {lebar} x {tinggi}");
    }

    public void Resize(string ukKertas)
    {
        Console.WriteLine($"Menyesuaikan ke format kertas {ukKertas}");
    }
}
