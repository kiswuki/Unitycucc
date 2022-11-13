
using UnityEngine;

 class PhysicsPlayer2D : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] float jumpForce = 5;
    [SerializeField] float movementAcceleration = 5;
    [SerializeField, Min(0)] float maxHorizontalSpeed = 2;
    [SerializeField] int airJumpCount = 1;

    [SerializeField] float groundAccelerationMultiplier = 2;  //földön legyen egy szorzója a gyorsulásnak

    int airJumpBudget = 0;
    bool onGround;

    PlatformerSurfaceModifier modifier;


    void Start()
    {
        airJumpBudget = airJumpCount;
    }

    void OnValidate()
    {  //adja hozzá onvalidateben a rigidbody 2d-t ehhez a scripthez - manuálisan is lehet
        if (rigidbody == null)
            rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        bool canJump =
            (onGround || airJumpBudget > 0) && //v a füöldön vagyunk v a levegõben de akkor van airjumpunk
            Input.GetKeyDown(KeyCode.Space);  //megnyomom a gombot - ennek a 2 feltételnek kell teljesülnie

        //ha megnyomom a spacet, akkor ugrik
        if (canJump)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 0); //nem áll meg a mozgásban, ha ugrok egyet
            // rigidbody.velocity = new Vector2(0,0); - megállna ugráskor, ha jobbrabalra megyek

            float vel = jumpForce;
            if (modifier != null)
                vel *= modifier.jumpVelocityMultiplier;

            rigidbody.AddForce(Vector2.up * vel * rigidbody.mass, ForceMode2D.Impulse);


            if(!onGround)  // !- negálás, trueból false, falseból truet csinál
            airJumpBudget--;  //ha ugrunk, akkor elhasználunk egy ugrás lehetõséget

        }  //jumpforcet majd unityban be kell allitani kb 400-ra, hogy el tudjon ugrani
           // ForceMode2D.Force egységesen gyorsítod a tárgyat (kg*m/s^2) - folyamatos
           // ForceMode2D.Impulse - gombnyomással adok hozzá egységnyi erõt (lendületet) mennyit változik 1 pillanat alatt a sebesség (kg*m/s)
           // itt már elég az 5 400 helyett
           // jumpForce * rigidbody.mass - tomegtol fuggetlenne tesszu az ugrás sebességét

        


    }

    private void FixedUpdate()  //minden updatetel fixen le fog futni, mind1 h milyen gépen, fix idõközönként fog lefutni
    {
        float x = Input.GetAxis("Horizontal");

        x *= movementAcceleration;
        if (onGround)
            x *= groundAccelerationMultiplier;


        x *= rigidbody.mass;
        rigidbody.AddForce(new Vector2(x, 0));

        float xVel = rigidbody.velocity.x;
        xVel = Mathf.Clamp(xVel, -maxHorizontalSpeed, maxHorizontalSpeed);  // ne gyorsulhasson v lassulhasson 1 bizonyos érték alá/felé
        rigidbody.velocity = new Vector2(xVel, rigidbody.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        modifier = collision.gameObject.GetComponent<PlatformerSurfaceModifier>();  //az adott gameobjectnek van e ilyen modifiere, ha vminek nincs, akkor null az alapértelmezett értéke
        airJumpBudget = airJumpCount;
        onGround = true;

        if (modifier != null)
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, modifier.bounciness);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;  //amikor elhagyjuk a talajt, akkor ezt a változót false-ba állítjuk
    }
}
