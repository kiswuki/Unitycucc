
using UnityEngine;

class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float speedMultiplier;
    [SerializeField] float angularSpeed;

       void Update()
    {
        // Debug.Log(name);  ki�rja a Jani nev�t FPS sz�m szerint folyamatosan
        //lejjebb Janit elmozd�tom x �rt�kkel minden updateben

        /*float x = transform.position.x;
         x += 0.01f;
         transform.position = new Vector3(x, 0, 0);.*/


        //le van e nyomva az ir�nygomb a billenty�n

       // �rhatom k�l�n is, nem musz�j 1 sorban || -val elv�lasztani
        bool up = Input.GetKey(KeyCode.W) ||  Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.S) ||  Input.GetKey(KeyCode.DownArrow);
        bool right = Input.GetKey(KeyCode.D) ||  Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.A) ||  Input.GetKey(KeyCode.LeftArrow);


        //�gy is fel�rhatjuk else iffel kicsit bonyolultabban
        float x = 0;
        if (left && right)
            x = 0;
        else if (right)
            x += 1;
        else if (left)
            x = -1;


        // ha 1x-re nyomjuk, akkor -1 lesz, mert egyszerre futnak a sorok, �s -1 van utolj�ra
        //fel�l�rha�tn�nk egy harmadik if-fel, hogy if right and left legyen 0, m�sk�l�nben nem lesz

        float y = 0;
        if (up)
            y += 1;
        if (down)
            y -= 1;

        //ha mind2t nyomom egyszerre akkor 0 lesz, mert hozz� is adok meg ki is vonok egyet (-=) miatt

        Vector3 velocity = new Vector3(x,0,y);
        velocity.Normalize();

        velocity *= speed;


        //fusson a Jani left shifttel
        bool run =
            Input.GetKey(KeyCode.LeftShift);
        //ha fut a jani, akkor sokszoroz�djon meg a sebess�ge
        if (run)
            velocity *= speedMultiplier;
        //el�z� update �ta eltelt id� (ha soma mozg�st akarunk, ami framrate f�ggetlen)
        velocity *= Time.deltaTime;


        transform.position += velocity;

        //forgat�s
        var rot = transform.rotation;
        //ki�rhatn�m �gyis hogy Quaternion rot = transform.rotation

        //Vector3 euler = rot.eulerAngles;


        if (velocity != Vector3.zero)
        {
            //transform.rotation = Quaternion.LookRotation(velocity);
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                Quaternion.LookRotation(velocity),
                angularSpeed * Time.deltaTime);
        }
        // szeretn�m ha fix sebess�ggel forogna a rotation�m 


    }
}
