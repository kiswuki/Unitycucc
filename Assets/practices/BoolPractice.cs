using UnityEngine;

class BoolPractice : MonoBehaviour
{
  
    void Start()
    {
        bool myFirstBool = true;

        myFirstBool = false;

        int a = 22, b = 66;

        bool b1 = a < b;   //true

        bool b2 = a > b;   //false

        bool b3 = a >= 22;  //true

        bool b4 = 77 <= b;  //false

        bool b5 = b == -66;  //false

        bool b6 = b != -66; //true


        //HA
        int ammo = 44;
        bool haveAmmo = ammo > 0;
        bool isCoolDownOver = true;

        bool canIShoot = haveAmmo && isCoolDownOver;


        //VAGY
        int airJumpCount = 1;
        bool isOnGround = false;
        bool canAirJump = airJumpCount < 1;

        bool canJump = isOnGround || canAirJump;

        //LOGICAL NEGATE
        bool canNotJump = !canJump;
        int minusA = -a;







    }

   
}
