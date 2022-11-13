
using UnityEngine;

 class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed = 360;
    [SerializeField] Space space;  //ki tudom választani, hogyan forogjon a tárgy (saját koordináta rendszer v world szerint)
   
    void Update()
    {
        transform.Rotate(0,angularSpeed*Time.deltaTime,0, space);


    }
}
