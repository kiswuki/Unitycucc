
using System;
using UnityEngine;

public class ClickExplosions : MonoBehaviour
{
    [SerializeField] float range;
    [SerializeField] float maxExplosionForce;
    [SerializeField] ParticleSystem particleSys;

    Rigidbody[] rigidbodies;


    Vector3 lastHit;

    void Start()
    {
        rigidbodies = FindObjectsOfType<Rigidbody>();
    }


    void Update()
    {
        Camera camera = Camera.main;  //így tudjuk lekérni a fõkameránkat

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        bool isHit = Physics.Raycast(ray, out RaycastHit hit);

        if (isHit)
        {


            Debug.Log($"HIT: {hit.collider.name}   {hit.point}");
            lastHit = hit.point;

            if (Input.GetMouseButtonDown(0))
            {
                Explosion(hit.point);
            }
        }
    }

    void Explosion(Vector3 point)
    {
        transform.position = point;
        particleSys.Play();
        for (int i=0; i<rigidbodies.Length; i++)
        {
            Rigidbody rg = rigidbodies[i];
            ExplosionOne(rg, point);
        }
    }

    void ExplosionOne(Rigidbody rg, Vector3 p)
    {
        Vector3 direction = rg.transform.position - p;
        float  distance = direction.magnitude;

        if (distance >= range)
            return;


        direction /= distance;

        float forceMultiplier = 1 - (distance / range);
        Vector3 force = forceMultiplier * direction * maxExplosionForce;

        rg.AddForce(force, ForceMode.Impulse);
    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawSphere(lastHit, 0.3f);
    }
}
