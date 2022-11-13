
using UnityEngine;

 class VectorPractice : MonoBehaviour
{

    [SerializeField] Vector2 myFirst2DVector;
    [SerializeField] Vector3 myFirst3DVector;

    [SerializeField] Vector2 sum;
    [SerializeField] Vector3 difference;
    [SerializeField] Vector3 product;

    void OnValidate()
    {

         //Vector2 v2a = new Vector2();  // (0,0) vektort hozunk létre így
        Vector2 v2b = new Vector2(2.33f, 3f);  // (2.33, 3)
        Vector3 v3a = new Vector3(2.33f, 3f); // (2.33, 3, 0)
        Vector3 v3b = new Vector3(2.33f, 3f, 2); // (2.33, 3, 2)
        //Vector3 v3c = new Vector3(); // (0,0,0)

        Vector3 v3d = Vector3.up; //(0,1,0) - y tengelyen lévõ mozgás, felfele lépés
        Vector3 v3e = Vector3.back; // (0,0,-1) z tengelyen odavissza, most 1 visszalépés van, szóval -1

        Vector3 v3f = Vector3.zero; // (0,0,0)
        Vector3 v3g = Vector3.one; // (1,1,1)

        //MÛVELETEK

        sum = new Vector2(1, 2) + v2b; //(3.33, 5)

        difference = (Vector3)myFirst2DVector - myFirst3DVector; //2dbõl nem tudsz 3d-t kivonni, de kaszolni lehet a 2d-t 3d-re, és menni fog

        // ilyet ne csináljunk, egymassal: product = myFirst2DVector * myFirst3DVector; 

        //skalárral meg tudjuk szorozni

        product = 2 * myFirst3DVector;

        // hossz-t megnézni:
        float lenght = v3b.magnitude;


        // normalizálás
        Vector3 normalized = v3b.normalized;



    }

    
}
