
using UnityEngine;
using TMPro;

 class Collector : MonoBehaviour
{
    [SerializeField] TMP_Text textField;
    [SerializeField] int wealth = 0;

     void Start()
    {
        UpdateText();
    }

    public void DoCollect(int value)
    {
        if (value <= 0)
            return;
        wealth += value;  //ezt kívülrõl meghívja valaki, akkor sebezni tud minket
        //wealth = Mathf.Max(wealth, 0);  //maximalizáltuk az értékeket - ne mehessen 0 alá a wealth értéke - ez ide most nem kell 

        UpdateText();
    }

    void UpdateText()
    {
        if (textField != null) //ha textfield nem üres,
            textField.text = $"Wealth: {wealth}";  //írja ki az aktuális healthet - kijelöltem, villanykörte, extract cucc, és x helyett 0 lesz
    }

        
}
