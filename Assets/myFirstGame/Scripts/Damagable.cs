
using UnityEngine;
using TMPro;  //kiíráshoz kell

 class Damagable : MonoBehaviour
{
    [SerializeField] int startHealth = 10;  //alapbeállítás
    [SerializeField] TMP_Text textField;   //kiírja a healthet a textben, ez majs ahhoz kelll
    [SerializeField] Color fullHealthColor = Color.green;
    [SerializeField] Color zeroHealthColor = Color.red;

    [SerializeField] GameObject gameOverCanvas;

    [SerializeField] MonoBehaviour turnOffAtDeath;

    int health;

    void Start()

     
    {
        health = startHealth;  //belsõ health, amihez az editorból senki sem fér hozzá

        UpdateText();   //ki fogja írni már az elejétõl a 10-es alapértelmezett Healthet
    }
    public void DoDamage(int value)  //publicba kell rakni hogy kívülrõl (egy másik scriptbõl) hívják meg
    {
        if (value <= 0)
            return;
        health -= value;  //ezt kívülrõl meghívja valaki, akkor sebezni tud minket
        health = Mathf.Max(health, 0);  //maximalizáltuk az értékeket - ne mehessen 0 alá a health értéke

        if (health == 0)
        {
            gameOverCanvas.SetActive(true);
            turnOffAtDeath.enabled = false;
        }
            


        UpdateText(); //ki fogja írni már az elejétõl a 10-es alapértelmezett Healthet

    }

     void UpdateText() //ki fogja írni már az elejétõl a 10-es alapértelmezett Healthet
    {
        if (textField != null)
        {
            textField.text = $"Health: {health}";  //írja ki az aktuális healthet - kijelöltem, villanykörte, extract cucc, és x helyett 0 lesz

            Color fullHealthColor = Color.green;
            Color zeroHealthColor = Color.red;
            float t = (float)health / startHealth;
            textField.color =
                Color.Lerp(zeroHealthColor, fullHealthColor, t);
        }
            
        
    }
}
