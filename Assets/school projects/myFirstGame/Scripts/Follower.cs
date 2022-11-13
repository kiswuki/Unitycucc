
using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] AnimationCurve speedOverDistance;

  
    void Update()
    {  //követi a Zsanett a Janit
        Vector3 velocity = target.position - transform.position;

        float targetDistance = velocity.magnitude;
        //float targetDistance2 = Vector3.Distance(target.position, transform.transform.position); - ígyis lehet

        float speed = speedOverDistance.Evaluate(targetDistance);

        Vector3 direction = velocity.normalized;

        // *speed-et is tegyuk oda

        float stepLength = Time.deltaTime * speed;

        if (targetDistance < stepLength)
            stepLength = targetDistance;

        //transform.position += direction * stepLength; - DE így is lehet: vmilyen állapotból eljutni a másikba és tudjuk mekkorát lépjünk
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            Time.deltaTime * speed
            );

        //így nem rezeg a Zsanett ha utoléri Janit

        // ne forogjon a Zsanett ha pont ott van, mint mi

        if(direction != Vector3.zero)
        transform.rotation = Quaternion.LookRotation(direction);

        



    }
}
