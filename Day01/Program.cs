/*
 *  Output:
 *  10
 *  50
 *
 *  30
 *  30
 */

Weapon dagger = new Weapon();
Weapon ak47 = new Weapon();
ak47.Damage = 70;


Weapon bowAndArrow = dagger;
bowAndArrow.Damage = 50;

Console.WriteLine($"Dagger damage: {dagger.Damage}");
Console.WriteLine($"Bow and Arrow damage: {bowAndArrow.Damage}");

WeaponStats blade = new WeaponStats();
blade.Damage = 20;

WeaponStats quarterstaff = blade;
quarterstaff.Damage = 30;

Console.WriteLine($"Blade damage: {blade.Damage}");
Console.WriteLine($"Quarterstaff damage: {quarterstaff.Damage}");

class Weapon
{
    public int Damage;
}

struct WeaponStats
{
    public int Damage;
    
}




