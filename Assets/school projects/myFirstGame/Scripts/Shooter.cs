
using UnityEngine;

class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrototype;
    [SerializeField] KeyCode button;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(button))
        {
            // Gameobject newGameObject = new GameObject();
            GameObject newGameObject = Instantiate(projectilePrototype); //másolatot készít a Golyszlira
            newGameObject.transform.position = transform.position;
            newGameObject.transform.rotation = transform.rotation;

            //de lehet úgyis h Instantiate(projectilePrototype, transform.position, transform.rotation);
        }
    }
}
