
using UnityEngine;

class VariablePractice : MonoBehaviour
{
    void Start()
    {
        // This is a comment.
        /*bello*/

        int myFirstVariable;   //Declarate
        myFirstVariable = 5;  //Definition

        myFirstVariable = 34;  //Change value

        Debug.Log(myFirstVariable);
        myFirstVariable = 56789;
        Debug.Log(myFirstVariable);

        int a = 3 + 5;   //8
        int b = a - 11;  //-3
        int c = a * b;   //-24
        int d = a / 3;   //2


        float f1 = 45.76f;
        float f2=22, f3=32.4f, f4=45;

        float sum = f1 + f2;
        float difference = f1 - f2;
        float product = f1 * f2;
        float rate = f1 / f2;

        int rateInt = 11 / 3;   //3
        int moduloInt = 11 % 3; //2


        //kasztolas
        float fff = 5;  //Implicit casting
        int iii = (int) 5.5f;   //Explicit casting

        int x, y, z;

        x = 1;
        y = 2;
        z = x + y;
        z = 44;

        a = a + 5;
        a += 5;

        a = a + 1;
        a += 1;
        a++;

        float fffff = 3 + 4 * 2;


        var xxx = 4;
        var mmm = 4.45f;


    }
}
