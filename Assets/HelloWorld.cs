using UnityEngine;

class HelloWorld : MonoBehaviour
{
    void Start() //start met�dus
    {
        Debug.Log("Hello World");
        Debug.Log("Sziasztok"); // ez meg egysoros komment, k�d el� nem �rhat�, csak ut�na, v �nmag�ban, de akkoris csak egy sor lehet.
        Debug.Log($"My name is {name}"); //kiadja a gameobject nev�t (script)
    }

    /* T�bb soros kommentet �gy kell �rni
     * Addig tart a komment,
    Am�g be nem fejezem �gy. 
    */
}
