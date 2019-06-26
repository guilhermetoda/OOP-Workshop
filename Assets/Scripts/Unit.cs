using UnityEngine;

public class Unit : MonoBehaviour, IJump, IWeapon
{
    private IWeapon _weapon;
    private IJump _jump;

    public void Attack() 
    {
        _weapon.Attack();
    }

    public void Jump() 
    {
        _jump.Jump();
    }

    void Start() 
    {
        _jump = GetComponent<IJump>();
        _weapon = GetComponent<IWeapon>();
        Attack();
        Jump();
    }
}
