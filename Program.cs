using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_KatelynNicholson
{
    internal class Program
    {

        //array for weapon information
        static string[] weaponNames = { "Gun1", "Gun2", "Gun3", "Gun4" };
        static int[] weaponPower = { 10, 20, 30, 40 };
        static int[] ammoAmount = { 30, 60, 90, 120 };
        static float[] fireRate = { 1f, 2f, 3f, 4f }; //bullets per second
        

        static void Main()
        {

            Console.WriteLine($"Weapon: {weaponNames[0]}, Power: {weaponPower[0]}, Ammo: {ammoAmount[0]},  Rate: {fireRate[0]} bullets/s.");
            Console.WriteLine($"Weapon: {weaponNames[1]}, Power: {weaponPower[1]}, Ammo: {ammoAmount[1]},  Rate: {fireRate[1]} bullets/s.");
            Console.WriteLine($"Weapon: {weaponNames[2]}, Power: {weaponPower[2]}, Ammo: {ammoAmount[2]},  Rate: {fireRate[2]} bullets/s.");
            Console.WriteLine($"Weapon: {weaponNames[3]}, Power: {weaponPower[3]}, Ammo: {ammoAmount[3]}, Rate: {fireRate[3]} bullets/s.");
            
            Console.ReadKey();
            //ammo must be gun specific
            //firing and reloading only applied to current gun

        }

        //show HUD
        private static void HUD()
        {
            //for the HUD
        }

        //fire 
        static void fireGun()
        {
            //fire gun
        }

        //reload
        static void reloadGun()
        {
            //reload gun
        }

        //range checking
        private static void RangeChecking()
        {
            //Check range
        }

    }
}
