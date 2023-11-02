namespace Arrays_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        void Fire()
        {

        }
        void Reload()
        {

        } // bjhsfdjhxfdjhsfdjhlfdssfd dsfjh
        void ShowHUD()
        {

        }
        string[] WeaponNames = new string[6];
        float[] FireRate = new float[5];
        string[] WeaponDamage = new string[4];

        int[] MyArray = new int[10];

        MyArray[1] = 6;
        MyArray[2] = 7;
        MyArray[3] = 8;
        MyArray[4] = 9;
        MyArray[5] = 10;
        MyArray[6] = 11;
        MyArray[7] = 12;
        MyArray[8] = 13;
        MyArray[9] = 14;
      
    int TestAddition = 5 * MyArray[1];
        int TestAddition1 = 5 * MyArray[2];
        int TestAddition2 = 5 * MyArray[3];
        int TestAddition3 = 5 * MyArray[4];
        int TestAddition4 = 5 * MyArray[5];
        int TestAddition5 = 5 * MyArray[6];
        int TestAddition6 = 5 * MyArray[7];
        Console.WriteLine(MyArray[5]);
    Console.ReadKey(true);

    string ActiveWeapon;
        int WeaponAmmo;

        string[] Weapons = new string[3];
    {
        Weapons[1] = "Fist";
        Weapons[2] = "Club";
        Weapons[3] = "Saber";

    }
    int[] Ammo = new int[3];
    {
        Ammo[1] = 20;
        Ammo[2] = 10;
        Ammo[3] = 6;
    }

int[] ClipSize = new int[3];
{
    ClipSize[1] = Ammo[1] / 2;
    ClipSize[2] = Ammo[2] / 2;
    ClipSize[3] = Ammo[3] / 2;
}
// test for github commit
void CheckActiveWeapon()
{
    ActiveWeapon = Weapons[0];
    WeaponAmmo = Ammo[0];
}
void Fire()
{
    if (ActiveWeapon == Weapons[1])
    {
        Ammo[1] -= 1;
    }

}
void Reload()
{
    if (ActiveWeapon == Weapons[1]) { Ammo[1] = Ammo[1] - ClipSize[1]; }
    if (ActiveWeapon == Weapons[2]) { Ammo[2] = Ammo[2] - ClipSize[2]; }
    if (ActiveWeapon == Weapons[3]) { Ammo[3] = Ammo[3] - ClipSize[3]; }
}
void ShowHUD()
{
    Console.WriteLine(ActiveWeapon);
}
    

  
}
}