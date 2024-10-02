﻿using System;
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

            //Type data casting
            //implisit casting otomatis
            //int x = 8;
            //double y = x;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            ////exmplisit casting manual untuk menentukan type data yg di inginkan
            //double a = 8.5;
            //int b = (int) a; /* hati2 cara penulisan .!! agar jadi integer */
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.ReadLine();

            //Operator matematika
            //int angkaPertama = 32;
            //int angkaKedua = 23;
            //int hasilTambah = angkaPertama + angkaKedua;
            //int hasilKurang = angkaPertama - angkaKedua;
            //int hasilBagi = angkaPertama / angkaKedua; /* Pastikan type data hasil operator sesuai keinginan karna dari hasil bagi, kali bisa menjadi bil pecahan*/
            //int hasilkali = angkaPertama * angkaKedua; /* Pastikan type data hasil operator sesuai keinginan karna dari hasil bagi, kali bisa menjadi bil pecahan*/
            //angkaPertama++;/*bertambah 1*/
            //angkaKedua--; /*berkurang 1*/
            //Console.WriteLine(hasilTambah);
            //Console.WriteLine(hasilKurang);
            //Console.WriteLine(hasilBagi);
            //Console.WriteLine(hasilkali);
            //Console.WriteLine(angkaPertama % angkaKedua); /* hasil sisa pembagian dua bilangan*/
            //Console.WriteLine(angkaPertama);
            //Console.WriteLine(angkaKedua);
            //Console.ReadLine();


            //Operator Penugasan

            //// 1. =
            //int a = 3;

            //// 2. +=
            //int b = 3;
            //b += 5;

            //// 3. -=
            //int c = 8;
            //c -= 2; 

            //// 4. *=
            //int d = 3;
            //d *= 5;

            //// 4. /=
            //int e = 8;
            //e /= 2;

            //// 4. %=
            //int f = 10;
            //f %= 5;

            //// 4. &=
            //int g = 3;
            //g &= 5;

            //// 4. |=
            //int h = 3;
            //h |= 5;

            //// 4. ^=
            //int i = 3;
            //i ^= 5;

            //// 4. >>=
            //int j = 3;
            //j >>= 5;

            //// 4. <<=
            //int k = 3;
            //k <<= 5;

            //Console.WriteLine("  " + a + " samadengan = ");           
            //Console.WriteLine("  " + b + " tambah");            
            //Console.WriteLine("  " + c + " kurang");            
            //Console.WriteLine("  " + d + " kali");           
            //Console.WriteLine("  " + e + " bagi ");           
            //Console.WriteLine("  " + f + " Mudolus");           
            //Console.WriteLine("  " + g + " dan");           
            //Console.WriteLine("  " + h + " atau");           
            //Console.WriteLine("  " + i + " ^ ntah apa.!!");           
            //Console.WriteLine("  " + j );           
            //Console.WriteLine("  " + k + " hasilnya.!!?" );           
            //Console.ReadLine();           

            //Operator perbandingan

            //int x = 3;
            //int y = 5;
            //int z = 3;
            //Console.WriteLine(x == y); /* kembalian type datanya  false karna 3 tidak sama dengan 5 */
            //Console.WriteLine(x != y); /* kembalian type datanya true karna 3 tidak sama dengan 5*/
            //Console.WriteLine(x > y); /* kembalian type datanya false karna salah 3 lebih kecil dari 5*/
            //Console.WriteLine(x < y); /* kembalian type datanya true karna benar 3 lebih kecil dari 5*/
            //Console.WriteLine(x >= y); /* kembalian type datanya false karna  3 lebih kecil dari 5*/
            //Console.WriteLine(x <= y); /* kembalian type datanya true karna benar 3 kecil sama dari 5*/
            //Console.WriteLine(x == z); /* kembalian type datanya true 3 sama dengan 3*/           
            //Console.ReadLine();

            //Operator Logika
            // &&
            //int a = 10;
            //int b = 7;
            //Console.WriteLine(a > 6 && b <=7); /* menentukan jika nilai a dan b besar dari 7 maka hasil true, perbandingan logika && kembalian TRUE  */
            //// &&
            //int c = 10;
            //int d = 7;
            //Console.WriteLine(c > 6 || d <=7); /* menentukan jika nilai a dan b besar dari 7 maka hasil true, perbandingan logika && kembalian TRUE  */
            //// &&
            //int e = 10;
            //int f = 7;
            //Console.WriteLine(!(e > 6 && f <=7)); /* Digunakan untuk membalikan hasil.  */
            //Console.ReadLine();

            //Masukan User

            //Console.WriteLine("Masukan nama");
            //string user = Console.ReadLine();
            //Console.WriteLine("selamat malam" + " " + user + " inputnya hampir sama dengan si python.!!");
            //Console.ReadLine();

            // Fungsi bawaan C# 

            // max
            int x = 10;
            double y = 15.6;
            Console.WriteLine(Math.Max(x, y));
            
            // min
            int a = 10;
            double b = 15.1;
            Console.WriteLine(Math.Min(a, b)+ "min");           

            // sqrt atau AKAR
            int c = 10;           
            Console.WriteLine(Math.Sqrt(c) + "akar");           
            
            // abs mengembalikan nilai positif
            double d = -3.8;            
            Console.WriteLine(Math.Abs(d) + "mengembalikan nilai positif");
            
            // abs membulatkan bilangan
            double e = 3.8;            
            double f = 3.4;            
            Console.WriteLine(Math.Round(e) + "membulatkan ke atas");
            Console.WriteLine(Math.Round(f) + "membulatkan ke bawah");
            Console.ReadLine();






        }      
    }
    
}
