using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Nobel
    {
        int evszam;
        string tipus, keresztnev, vezeteknev;

        public int Evszam { get => evszam; set => evszam = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Keresztnev { get => keresztnev; set => keresztnev = value; }
        public string Vezeteknev { get => vezeteknev; set => vezeteknev = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Nobel.csv");
            string elsosor = sr.ReadLine();
            List<Nobel> adatok= new List<Nobel>();
            while(!sr.EndOfStream)
            {
                adatok.Add(new Nobel());
            }
            //4
            string irodalmi2017 = adatok.Where(x => x adatok[0] == 2017
                && adatok[1] == "irodalmi").Concat(adatok[2],adatok[3]);
            Console.WriteLine(irodalmi2017);
            //6
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[3].Contains("Curie"))
                {
                    Console.WriteLine($"{adatok[0]}: {adatok[2]} {adatok[3]}({adatok[1]})");
                }
            }
            //7
            int fizikai, kemiai, orvosi, irodalmi, beke, kozigazgatasi;

            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[2] == "fizikai")
                {
                    fizikai++;
                }
                else if (adatok[2] == "kémiai")
                {
                    kemiai++;
                }
                else if (adatok[2] == "orvosi")
                {
                    orvosi;
                }
                else if (adatok[2] == "irodalmi")
                {
                    irodalmi++;
                }
                else if (adatok[2] == "béke")
                {
                    beke++;
                }
                else {
                    kozigazgatasi++;
                }
            }
            Console.WriteLine($"fizikai:{fizikai} db\nkémiai:{kemiai} db\norvosi:{orvosi} db\nirodalmi:{irodalmi} db\nbéke:{beke} db\nközigazgatási:{kozigazgatasi} db\n");
            //8
            StreamWriter sw = new StreamWriter("orvosi.txt");
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[1] == "orvosi") {
                    sw.WriteLine($"{adatok[0]}:{adatok[2]} {adatok[3]}");
                }
                
            }
            sr.Close();
        }
    }
}
