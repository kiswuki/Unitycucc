
using UnityEngine;
using TMPro;  //ki�r�shoz kell
using System;
using System.Collections;

class Damagable : MonoBehaviour
{
    [SerializeField] int startHealth = 10;  //alapbe�ll�t�s
    [SerializeField] TMP_Text textField;   //ki�rja a healthet a textben, ez majs ahhoz kelll
    [SerializeField] Color fullHealthColor = Color.green;
    [SerializeField] Color zeroHealthColor = Color.red;

    [SerializeField] GameObject gameOverCanvas;

    [SerializeField] MonoBehaviour turnOffAtDeath;

    [SerializeField] float invincibilityTIme = 1;

    bool isInvincible = false;

    int health;

    void Start()

     
    {
        health = startHealth;  //bels� health, amihez az editorb�l senki sem f�r hozz�

        UpdateText();   //ki fogja �rni m�r az elej�t�l a 10-es alap�rtelmezett Healthet
    }
    public void DoDamage(int value)  //publicba kell rakni hogy k�v�lr�l (egy m�sik scriptb�l) h�vj�k meg
    {
        if (value <= 0)
            return;
        health -= value;  //ezt k�v�lr�l megh�vja valaki, akkor sebezni tud minket
        health = Mathf.Max(health, 0);  //maximaliz�ltuk az �rt�keket - ne mehessen 0 al� a health �rt�ke

        if (isInvincible)
            return;

        if (health == 0)
        {
            gameOverCanvas.SetActive(true);
            turnOffAtDeath.enabled = false;
        }
            


        UpdateText(); //ki fogja �rni m�r az elej�t�l a 10-es alap�rtelmezett Healthet
        StartCoroutine(InvincibilityCoroutine());
    }

    IEnumerator InvincibilityCoroutine()
    {
        isInvincible = true;

        MeshRenderer[] allRenderers = GetComponentsInChildren<MeshRenderer>();
        SetVisibility(allRenderers, false);

        const float flickTime = 0.1f;
        bool visible = false;

        for (int i = 0; i < invincibilityTIme / flickTime; i++)
        {

            SetVisibility(allRenderers, visible);
            visible = !visible;
            yield return new WaitForSeconds(invincibilityTIme);
        }

        SetVisibility(allRenderers, true);
        isInvincible = false;
    }

    void SetVisibility(MeshRenderer[] allRenderers, bool visible)
    {
        foreach (var renderer in allRenderers)
            renderer.enabled = visible;
    }

    void UpdateText() //ki fogja �rni m�r az elej�t�l a 10-es alap�rtelmezett Healthet
    {
        if (textField != null)
        {
            textField.text = $"Health: {health}";  //�rja ki az aktu�lis healthet - kijel�ltem, villanyk�rte, extract cucc, �s x helyett 0 lesz

            Color fullHealthColor = Color.green;
            Color zeroHealthColor = Color.red;
            float t = (float)health / startHealth;
            textField.color =
                Color.Lerp(zeroHealthColor, fullHealthColor, t);
        }
            
        
    }
}
