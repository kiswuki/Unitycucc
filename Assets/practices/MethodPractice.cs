
using UnityEngine;

class MethodPractice : MonoBehaviour
{

    [SerializeField] float number, number2;

    [SerializeField] float absNumber;
    [SerializeField] float signOfNumber;
    [SerializeField] float min, max;

    void OnValidate()
    {
        //Debug.Log("xyzzs");

        absNumber = Mathf.Abs(number);
        signOfNumber = Mathf.Sign(number);

        min = Mathf.Min(number, number2);
        max = Mathf.Max(number, number2);
    }

    float Abs(float n)  //vissza fog térni egy floattal - n számnak az abszolút értékét számoljuk ki
    {
        if (n < 0)
            n *= -1;

        return n;
    }

    float Sign(float n)
    {
        if (n < 0)
            return -1;
        else
            return 1;  //1-et v -1-et adjon vissza


    }

    float Min(float a, float b)
    {
        if (a < b)
            return a;
        else
            return b;  //ha a kisebb, mint b, akkor a minimumot mutassa, return a, máskülönben b lesz ha nem teljesül a feltétel
    }



}
