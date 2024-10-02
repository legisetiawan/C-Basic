using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basic
{
    // Komnentar sebaris
    /*
     * Komentar multi baris
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //string helloMessage = "Hello world"; /*Type data string helloMesaage Variable tmpat menampung data*/
            //int angka = 35; /*Type data bilangan integer*/
            //long angkaBesar = 3536363663636;  /*Type data angka bilangan besar*/
            //float angkaPecahan = 3.6f;  /*Type data bilangan pecahan di akhir harus ada hruf f menandakan float*/
            //double angkadouble = 3.68878997909877;  /*Type data bilangan pecahan double*/
            //decimal angkadecimal = 3.634242424409877m;  /*Type data bilangan pecahan double* 128bits memori harus ada m di belakang*/
            //bool angkaBool = false;  /*Type data bolean kembalian ada false dan true*/

            //Console.WriteLine(helloMessage); /* Komentar bisa di dalam baris code*/
            //Console.WriteLine(angka);/* bilangan integer*/
            //Console.WriteLine(angkaBesar);/*  bilangan integer  besar*/
            //Console.WriteLine(angkaPecahan);/*  bilangan pecahan*/
            //Console.WriteLine(angkadouble);/*  bilangan pecahan  besar*/
            //Console.WriteLine(angkadecimal);/*  bilangan pecahan decimal*/
            //Console.WriteLine(angkaBool);/*  boolean*/
            //Console.ReadLine();

            //Operator matematika
            int angkaPertama = 32;
            int angkaKedua = 23;
            int hasilTambah = angkaPertama + angkaKedua;
            int hasilKurang = angkaPertama - angkaKedua;
            int hasilBagi = angkaPertama / angkaKedua; /* Pastikan type data hasil operator sesuai keinginan karna dari hasil bagi, kali bisa menjadi bil pecahan*/
            int hasilkali = angkaPertama * angkaKedua; /* Pastikan type data hasil operator sesuai keinginan karna dari hasil bagi, kali bisa menjadi bil pecahan*/
            angkaPertama++;/*bertambah 1*/
            angkaKedua--; /*berkurang 1*/
            Console.WriteLine(hasilTambah);
            Console.WriteLine(hasilKurang);
            Console.WriteLine(hasilBagi);
            Console.WriteLine(hasilkali);
            Console.WriteLine(angkaPertama % angkaKedua); /* hasil sisa pembagian dua bilangan*/
            Console.WriteLine(angkaPertama);
            Console.WriteLine(angkaKedua);
            Console.ReadLine();
                   
                




        }      
    }
    
}
