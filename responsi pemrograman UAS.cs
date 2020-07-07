using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCustomer
{
    class Program
    {
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4:
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            
            Console.WriteLine("Pilih Menu\n");
            Console.WriteLine("1. Tambah customer");
            Console.WriteLine("2. Hapus customer");
            Console.WriteLine("3. Tampilkan customer");
            Console.WriteLine("4. Exit");
        }

        static void TambahCustomer()
        {
            Console.Clear();

           
            Customer customer = new Customer();

            Console.WriteLine("Tambah data customer\n");

            Console.Write("Kode customer: ");
            customer.kodeCustomer = Console.ReadLine();

            Console.Write("Nama customer: ");
            customer.namaCustomer = Console.ReadLine();

            Console.Write("Total Piutang: ");
            customer.totalPiutang = Convert.ToDouble(Console.ReadLine());

            daftarCustomer.Add(customer);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            Console.WriteLine("Hapus data customer\n");
            Console.Write("Kode customer: ");
            string kodehapus = Console.ReadLine();
            if (daftarCustomer.Any(a => a.kodeCustomer == kodehapus))
            {
                daftarCustomer.RemoveAll(b => b.kodeCustomer == kodehapus);
                Console.WriteLine("\nData customer berhasil dihapus\n");
            }
            else
            {
                Console.WriteLine("Kode customer tidak ditemukan\n");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            
            Console.WriteLine("\n");
            int i = 1;
            foreach (Customer customer in daftarCustomer)
            {
                Console.WriteLine("{0}. {1}, {2}, {3:N0}",
                    i, customer.kodeCustomer, customer.namaCustomer, customer.totalPiutang);
                i++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}