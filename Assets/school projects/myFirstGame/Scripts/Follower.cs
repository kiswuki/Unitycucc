
using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] AnimationCurve speedOverDistance;

  
    void Update()
    {  //k�veti a Zsanett a Janit
        Vector3 velocity = target.position - transform.position;

        float targetDistance = velocity.magnitude;
        //float targetDistance2 = Vector3.Distance(target.position, transform.transform.position); - �gyis lehet

        float speed = speedOverDistance.Evaluate(targetDistance);

        Vector3 direction = velocity.normalized;

        // *speed-et is tegyuk oda

        float stepLength = Time.deltaTime * speed;

        if (targetDistance < stepLength)
            stepLength = targetDistance;

        //transform.position += direction * stepLength; - DE �gy is lehet: vmilyen �llapotb�l eljutni a m�sikba �s tudjuk mekkor�t l�pj�nk
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            Time.deltaTime * speed
            );

        //�gy nem rezeg a Zsanett ha utol�ri Janit

        // ne forogjon a Zsanett ha pont ott van, mint mi

        if(direction != Vector3.zero)
        transform.rotation = Quaternion.LookRotation(direction);

        



    }
}
