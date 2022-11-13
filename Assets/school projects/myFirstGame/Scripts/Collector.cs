
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
        wealth += value;  //ezt k�v�lr�l megh�vja valaki, akkor sebezni tud minket
        //wealth = Mathf.Max(wealth, 0);  //maximaliz�ltuk az �rt�keket - ne mehessen 0 al� a wealth �rt�ke - ez ide most nem kell 

        UpdateText();
    }

    void UpdateText()
    {
        if (textField != null) //ha textfield nem �res,
            textField.text = $"Wealth: {wealth}";  //�rja ki az aktu�lis healthet - kijel�ltem, villanyk�rte, extract cucc, �s x helyett 0 lesz
    }

        
}
