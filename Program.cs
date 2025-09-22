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
        static int[] maxAmmo = { 20, 30, 50, 90 };
        static int[] currentAmmo = { 20, 30, 50, 90 };
        static int currentWeapon = 0;
        static float[] fireRate = { 1f, 2f, 3f, 4f }; //bullets per second
        

        static void Main()
        {
            ShowHUD();

            Fire();
            Fire();
            Reload();
            ShowHUD();

            SwitchWeapon(2); // Switch to Gun3
            Fire();
            PickUpAmmo(2, 10);
            ShowHUD();
        }

        //show HUD
        private static void ShowHUD()
        {
            //for the HUD
            Console.WriteLine("\n================== HUD =================");
            for (int i = 0; i < weaponNames.Length; i++) // i is short for Index used in Loops
            {
                string selected = (i == currentWeapon) ? "<-- Equipped" : "";
                Console.WriteLine($"{weaponNames[i]}: {currentAmmo[i]}/{maxAmmo[i]}    | Power: {weaponPower[i]}    | Rate: {fireRate[i]} {selected}");
            }
            Console.WriteLine("========================================\n");
        }

        //fire 
        static void Fire()
        {
            //fire gun
            if (currentAmmo[currentWeapon] > 0)
            {
                currentAmmo[currentWeapon]--;
                RangeChecking();
                Console.WriteLine($"{weaponNames[currentWeapon]} Fired! Ammo left: {currentAmmo[currentWeapon]}");
            }
            else
            {
                Console.WriteLine($"{weaponNames[currentWeapon]} is out of ammo! Reload!");
            }
            
        }

        //reload
        static void Reload()
        {
            //reload gun
            currentAmmo[currentWeapon] = maxAmmo[currentWeapon];
            Console.WriteLine($"{weaponNames[currentWeapon]} reladed. Ammo: {currentAmmo[currentWeapon]}");
        }

        //range checking
        private static void RangeChecking()
        {
            for(int i = 0; i < currentAmmo.Length; i++)
            {
                if (currentAmmo[i] < 0)
                    currentAmmo[i] = 0;
                if (currentAmmo[i] > maxAmmo[i])
                    currentAmmo[i] = maxAmmo[i];
            }
        }

        static void PickUpAmmo(int weaponIndex, int amount)
        {
            currentAmmo[weaponIndex] += amount;

            if (currentAmmo[weaponIndex] > maxAmmo[weaponIndex])
                currentAmmo[weaponIndex] = maxAmmo[weaponIndex];

            Console.WriteLine($"Picked up {amount} {weaponNames[weaponIndex]} ammo. Now: {currentAmmo[weaponIndex]}");
        }

        static void SwitchWeapon(int newWeapon)
        {
            if (newWeapon >= 0 && newWeapon < weaponNames.Length)
            {
                currentWeapon = newWeapon;
                Console.WriteLine($"Switched To {weaponNames[currentWeapon]}");
            }
            else
            {
                Console.WriteLine("Invalid weapon index!");
            }
        }
    }
}
