using UnityEngine;

class StringPractice : MonoBehaviour
{
   
    void Start()
    {
        string myFirstString = "This is a string!";

        string s1 = "Wuki";
        string s2 = $"My name is {s1}, this GameObjects is {name}";

        Debug.Log(s2);

        int myAge = 28;
        float myHeight = 158.9f;

        string introduction = $"My name is {s1}, I'm {myHeight}m height and {myAge} years old.";

        Debug.Log(introduction);

        string aaa = "Hello ";
        string bbb = "Strings";
        string ccc = aaa + bbb;

        string ddd = "erty" + myAge;

        Debug.Log(ddd);

        int i = 3;
        int j = 5;
        string s = "S";

        string s3 = i + j + s;  //8S
        string s4 = j + s + i;  //5S3
        string s5 = s + i + j;  //S35

        string s6 = i.ToString();  //"3"
        string s7 = 44.55f.ToString();  //"44.55"



    }

    
}
