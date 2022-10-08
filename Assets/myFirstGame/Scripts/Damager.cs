 
using UnityEngine;

 public class Damager : MonoBehaviour
{
    [SerializeField] int damage = 1;

    void OnTriggerEnter(Collider other)
    {
        Damagable damagable = other.GetComponent<Damagable>();

        if(damagable != null)
        {
            //Debug.Log(damagable.name);

            damagable.DoDamage(damage);
        }
    }
}
