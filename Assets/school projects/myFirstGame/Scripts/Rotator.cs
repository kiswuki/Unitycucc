
using UnityEngine;

 class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed = 360;
    [SerializeField] Space space;  //ki tudom v�lasztani, hogyan forogjon a t�rgy (saj�t koordin�ta rendszer v world szerint)
   
    void Update()
    {
        transform.Rotate(0,angularSpeed*Time.deltaTime,0, space);


    }
}
