using UnityEngine;

class ControlStructures : MonoBehaviour
{
    [SerializeField] int number;

    void Start()
    {
        bool isEven = number % 2 == 0;

        if (isEven)
        {
            Debug.Log("Páros");
        }
        else
        {
            Debug.Log("Páratlan");
        }


        //....

        if (number >= 1)
        {
            Debug.Log("Positive");
        }
        else if (number <= -1)
        {
            Debug.Log("Negative");
        }
        else
        {
            Debug.Log("Zero");
        }


        //LOOP...

        int i = 1;
        while (i < number)
        {
            Debug.Log(i);
            i++;
        }

        //FOR LOOP


        for (int j = 1; j <= number; j++)
        {
            Debug.Log(j);
        }

    }


}
