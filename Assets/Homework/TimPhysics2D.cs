
using UnityEngine;

 class TimPhysics2D : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] float jumpForce = 5;
    [SerializeField] float movementAcceleration = 5;
    [SerializeField, Min(0)] float maxHorizontalSpeed = 2;
    [SerializeField] int airJumpCount = 1;


    [SerializeField] float groundAccelerationMultiplier = 2;

    int airJumpBudget = 0;
    bool onGround;

    HomeWorkSurfaceModifier modifier;

     void Start()
    {
        airJumpBudget = airJumpCount;
    }

    void OnValidate()
    {
        if (rigidbody == null)
            rigidbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        bool canJump =
            (onGround || airJumpBudget > 0) && //v a f��ld�n vagyunk v a leveg�ben de akkor van airjumpunk
            Input.GetKeyDown(KeyCode.Space);  //megnyomom a gombot - ennek a 2 felt�telnek kell teljes�lnie


        if (canJump)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 0); //nem �ll meg a mozg�sban, ha ugrok egyet
            // rigidbody.velocity = new Vector2(0,0); - meg�llna ugr�skor, ha jobbrabalra megyek

            float vel = jumpForce;
            if (modifier != null)
                vel *= modifier.jumpVelocityMultiplier;

            rigidbody.AddForce(Vector2.up * vel * rigidbody.mass, ForceMode2D.Impulse);


            if (!onGround)  // !- neg�l�s, trueb�l false, falseb�l truet csin�l
                airJumpBudget--;  //ha ugrunk, akkor elhaszn�lunk egy ugr�s lehet�s�get





        }

    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");

        x *= movementAcceleration;
        if (onGround)
            x *= groundAccelerationMultiplier;


        x *= rigidbody.mass;
        rigidbody.AddForce(new Vector2(x, 0));

        float xVel = rigidbody.velocity.x;
        xVel = Mathf.Clamp(xVel, -maxHorizontalSpeed, maxHorizontalSpeed);  // ne gyorsulhasson v lassulhasson 1 bizonyos �rt�k al�/fel�
        rigidbody.velocity = new Vector2(xVel, rigidbody.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        modifier = collision.gameObject.GetComponent<HomeWorkSurfaceModifier>();  //az adott gameobjectnek van e ilyen modifiere, ha vminek nincs, akkor null az alap�rtelmezett �rt�ke
        airJumpBudget = airJumpCount;
        onGround = true;

        if (modifier != null)
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, modifier.bounciness);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;  //amikor elhagyjuk a talajt, akkor ezt a v�ltoz�t false-ba �ll�tjuk
    }
}

