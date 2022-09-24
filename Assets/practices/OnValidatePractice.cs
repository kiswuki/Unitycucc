using UnityEngine;

class OnValidatePractice : MonoBehaviour
{
    [SerializeField, Min(0)] int intField;  //nem tudok 0 ala menni, megadtam a minimum attributumot, lehet egybe v két szogletes zarojelben kulon
    [SerializeField] float floatField;
    [SerializeField] string stringField;
    [SerializeField] bool boolField;
    [Space]  //unitynek int ele kell tenni egy kis szunetet
    [SerializeField] int number;
    [SerializeField] bool isNumberEven;


    void OnValidate()
    {
        // Debug.Log(intField);
        int moduloTwo = number % 2;
        isNumberEven = moduloTwo % 2 == 0;


    }

    //hennnlo 2022.09.18
}
