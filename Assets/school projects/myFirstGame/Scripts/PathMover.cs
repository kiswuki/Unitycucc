
using UnityEngine;

class PathMover : MonoBehaviour
{
    [SerializeField] Vector3 pointA, pointB;
    [SerializeField, Range(0,1)] float startPosition;
    [SerializeField] float speed;

    bool toA = false;

    private void OnValidate()
    {
        // közepére tesszük be transform.position = (pointA + pointB) / 2;
        //nem pontosan a közepére tesszük be, változtathatunk rajta, és mindig kiszámolja, hogy hova tegye be
        
        transform.position = Vector3.Lerp(pointA, pointB, startPosition);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = toA ? pointA : pointB;
        transform.position = Vector3.MoveTowards(
            transform.position,
            target,
            speed * Time.deltaTime
            );

        if (transform.position == target)
        {
            toA = !toA;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(pointA, 0.1f);
        Gizmos.DrawWireSphere(pointB, 0.1f);
        Gizmos.DrawLine(pointA, pointB);


    }

}
