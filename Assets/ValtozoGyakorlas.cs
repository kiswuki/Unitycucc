
using UnityEngine;

class ValtozoGyakorlas : MonoBehaviour
{

    void Start()
    {
        int PotatoCount = 0; //létrehoztunk egy PotatoCount nevû változót, aminek az értéke egész szám (int) és pontosan 0

        int BananaCount = 10; //ugyan az, mint eggyel feljebb

        // int = a változó típusa, azt jelenti, egész szám

        PotatoCount = PotatoCount + 3;
        BananaCount = BananaCount - 5; //megváltoztathatom simán így a változók értékét

        //MINDEN UTASÍTÁS UTÁN PONTOSVESSZÕT TESZÜNK

        string utolsó; //létrehozok egy változót, aminek a neve utolsó
        // a string azt jelenti, hogy szöveges tartalma lesz a változónak

        utolsó = "Smith"; //adtam neki egy szöveges értéket

        utolsó = "Johnson";

        utolsó = "SzintisFeri"; //simán változtathatok a változó értékén

        // egy változó neve c++ban kisbetûvel kezdõdjön
        // javasolt angolul megadni


        /* VÁLTOZÓK TÍPUSAI
         * int = egész számokt
         * float = tizedes tört
         * string = szöveg
         * bool = eldöntendõ kérdésre ad választ. Felvehetõ értékek: true/false.
         */

        //SZÁM TÍPUSÚ VÁLTOZÓK

        //int = egész szám
        //float = tizedes tört, mögé egy "f"-et rakunk

        int i = 1;

        float f = 5.3f;

        //több infó a VariablePractice részen


    }

    