
using UnityEngine;

public class Collectable : MonoBehaviour
{

    [SerializeField] Bounds volume;
    [SerializeField] int collect = 1;



    void OnTriggerEnter(Collider other)
    {
        Collector collector = other.GetComponent<Collector>();

        if (collector != null)
        {
            collector.DoCollect(collect);
            TeleportToNext();
        }
            



    }

     void TeleportToNext()
    {
        float x = Random.Range(volume.min.x, volume.max.x);
        float y = Random.Range(volume.min.y, volume.max.y);
        float z = Random.Range(volume.min.z, volume.max.z);

        Vector3 newPos = new (x,y,z);
        transform.position = newPos;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireCube(volume.center, volume.size);
    }
}





