
using UnityEngine;

class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float speedMultiplier;
    [SerializeField] float angularSpeed;

       void Update()
    {
        // Debug.Log(name);  kiírja a Jani nevét FPS szám szerint folyamatosan
        //lejjebb Janit elmozdítom x értékkel minden updateben

        /*float x = transform.position.x;
         x += 0.01f;
         transform.position = new Vector3(x, 0, 0);.*/


        //le van e nyomva az iránygomb a billentyûn

       // írhatom külön is, nem muszáj 1 sorban || -val elválasztani
        bool up = Input.GetKey(KeyCode.W) ||  Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.S) ||  Input.GetKey(KeyCode.DownArrow);
        bool right = Input.GetKey(KeyCode.D) ||  Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.A) ||  Input.GetKey(KeyCode.LeftArrow);


        //így is felírhatjuk else iffel kicsit bonyolultabban
        float x = 0;
        if (left && right)
            x = 0;
        else if (right)
            x += 1;
        else if (left)
            x = -1;


        // ha 1x-re nyomjuk, akkor -1 lesz, mert egyszerre futnak a sorok, és -1 van utoljára
        //felülírhaítnánk egy harmadik if-fel, hogy if right and left legyen 0, máskülönben nem lesz

        float y = 0;
        if (up)
            y += 1;
        if (down)
            y -= 1;

        //ha mind2t nyomom egyszerre akkor 0 lesz, mert hozzá is adok meg ki is vonok egyet (-=) miatt

        Vector3 velocity = new Vector3(x,0,y);
        velocity.Normalize();

        velocity *= speed;


        //fusson a Jani left shifttel
        bool run =
            Input.GetKey(KeyCode.LeftShift);
        //ha fut a jani, akkor sokszorozódjon meg a sebessége
        if (run)
            velocity *= speedMultiplier;
        //elõzõ update óta eltelt idõ (ha soma mozgást akarunk, ami framrate független)
        velocity *= Time.deltaTime;


        transform.position += velocity;

        //forgatás
        var rot = transform.rotation;
        //kiírhatnám úgyis hogy Quaternion rot = transform.rotation

        //Vector3 euler = rot.eulerAngles;


        if (velocity != Vector3.zero)
        {
            //transform.rotation = Quaternion.LookRotation(velocity);
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                Quaternion.LookRotation(velocity),
                angularSpeed * Time.deltaTime);
        }
        // szeretném ha fix sebességgel forogna a rotationöm 


    }
}
