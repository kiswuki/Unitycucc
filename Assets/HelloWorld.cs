using UnityEngine;

class HelloWorld : MonoBehaviour
{
    void Start() //start metódus
    {
        Debug.Log("Hello World");
        Debug.Log("Sziasztok"); // ez meg egysoros komment, kód elé nem írható, csak utána, v önmagában, de akkoris csak egy sor lehet.
        Debug.Log($"My name is {name}"); //kiadja a gameobject nevét (script)
    }

    /* Több soros kommentet így kell írni
     * Addig tart a komment,
    Amíg be nem fejezem így. 
    */
}
