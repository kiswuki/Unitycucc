
using UnityEngine;

class ValtozoGyakorlas : MonoBehaviour
{

    void Start()
    {
        int PotatoCount = 0; //l�trehoztunk egy PotatoCount nev� v�ltoz�t, aminek az �rt�ke eg�sz sz�m (int) �s pontosan 0

        int BananaCount = 10; //ugyan az, mint eggyel feljebb

        // int = a v�ltoz� t�pusa, azt jelenti, eg�sz sz�m

        PotatoCount = PotatoCount + 3;
        BananaCount = BananaCount - 5; //megv�ltoztathatom sim�n �gy a v�ltoz�k �rt�k�t

        //MINDEN UTAS�T�S UT�N PONTOSVESSZ�T TESZ�NK

        string utols�; //l�trehozok egy v�ltoz�t, aminek a neve utols�
        // a string azt jelenti, hogy sz�veges tartalma lesz a v�ltoz�nak

        utols� = "Smith"; //adtam neki egy sz�veges �rt�ket

        utols� = "Johnson";

        utols� = "SzintisFeri"; //sim�n v�ltoztathatok a v�ltoz� �rt�k�n

        // egy v�ltoz� neve c++ban kisbet�vel kezd�dj�n
        // javasolt angolul megadni


        /* V�LTOZ�K T�PUSAI
         * int = eg�sz sz�mokt
         * float = tizedes t�rt
         * string = sz�veg
         * bool = eld�ntend� k�rd�sre ad v�laszt. Felvehet� �rt�kek: true/false.
         */

        //SZ�M T�PUS� V�LTOZ�K

        //int = eg�sz sz�m
        //float = tizedes t�rt, m�g� egy "f"-et rakunk

        int i = 1;

        float f = 5.3f;

        //t�bb inf� a VariablePractice r�szen


    }

    