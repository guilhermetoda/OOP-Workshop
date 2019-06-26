using UnityEngine;

public class LaserGun : MonoBehaviour, IWeapon
{
    public void Attack()
    {
        print("Attack with LaserGun");
    }
}
