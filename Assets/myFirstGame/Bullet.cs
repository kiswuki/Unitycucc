
using UnityEngine;

class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float duration;

    Camera cam;

    float lifeTime = 0;

  void Start()
    {
        if (cam == null)
            cam = Camera.main;


    }

    // Update is called once per frame
    void Update()
    {

        // Movement
        transform.position += transform.forward * speed * Time.deltaTime;


        //Destruction based on distance from camera
        float distance = Vector3.Distance(cam.transform.position, transform.position);
        if (cam.farClipPlane < distance)
        {
            Destroy(gameObject);
        }

        //Destruction based on lifetime
        lifeTime += Time.deltaTime;
        if (lifeTime >= duration)
            Destroy(gameObject);
    }


}
