namespace UTS_1;

class Program
{
    static void Intro()
    {
        Console.WriteLine("Adu Dadu\n");
        Console.WriteLine("Pada game ini anda dan komputer akan bermain 10 ronde");
        Console.WriteLine("Setiap putaran dadu akan dilempar menghasilkan nilai tertentu");
        Console.WriteLine("Nilai dadu tertinggi akan menjadi pemenang ronde tersebut");
        Console.WriteLine("Siapa yang akan menang? Selamat berjuang\n");
        Console.Write("Mulai main...");
        Console.ReadLine();

    }
    static int lempar_dadu()
    {
    // Random 
    Random rnd = new Random();
    return rnd.Next (1, 7);
    }
     static void Main(string[] args)
    {
        // Deklarasi Variabel
        int skor_pemain = 0,
            skor_komputer = 0,
            dadu_pemain,
            dadu_komputer;
     
            // Intro
            Intro();

            // looping ronde
            for (int ronde = 1;ronde <= 10; ronde++)
            {
                Console.WriteLine($"Ronde {ronde}");
                dadu_komputer = lempar_dadu();
                Console.WriteLine($"Nilai komputer : {dadu_komputer}");
                Console.Write("Lempar dadu anda ...");
                Console.ReadLine();
                dadu_pemain = lempar_dadu();
                Console.WriteLine($"Nilai anda : {dadu_pemain}");

                // Perbandingan jika sama 
                if (dadu_komputer == dadu_pemain){
                    Console.WriteLine("Hasil seri pada ronde ini .");
                }
                else if (dadu_komputer > dadu_pemain)
                {
                 Console.WriteLine("Komputer menang di ronde ini.");
                //  Skor komputer
                 skor_komputer++;
                }
                else{
                    Console.WriteLine("Player menang di ronde ini.");
                    // skor pemain
                    skor_pemain++;
                }
                Console.WriteLine($"Skor - Anda : {skor_pemain} | Komputer : {skor_komputer}");
                Console.ReadLine();
            }
            // Hasil akhir
        Console.WriteLine("Permainan Selesai.");
        Console.WriteLine($"Skor Akhir - Anda : {skor_pemain} | Komputer : {skor_komputer}");

        if(skor_komputer == skor_pemain)
        {
            Console.WriteLine("Hasil Seri.");
        }
        else if (skor_komputer > skor_pemain)
        {
            Console.WriteLine("Sayang sekali, Anda kalah!");
        }
        else 
        {
            Console.WriteLine("Selamat,Anda menang!.");
        }
        Console.WriteLine("Terima kasih sudah bermain...");
    
    }
}
