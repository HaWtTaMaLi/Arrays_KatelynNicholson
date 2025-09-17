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

        //array for weaponNames
        string[] weaponNames = { "Gun1", "Gun2", "Gun3", "Gun4" };

        //array for weapion power
        int[] weaponPower = { 10, 20, 30, 40 };

        //add weapon fire rate (shot/second)
        float[] fireRate = { 1f, 2f, 3f, 4f };


        static void Main()
        {

            

            Console.WriteLine($"Weapon: {weaponNames[0]},  Power: {weaponPower[0]}, Rate: {fireRate[0]} bullts/s. ");
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
