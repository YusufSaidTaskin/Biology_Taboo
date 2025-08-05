using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;




public class LanguageDropdown : MonoBehaviour
{
    public TMP_Dropdown nesne;
    public Sprite[] bayraklar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nesne.ClearOptions();
        List<TMP_Dropdown.OptionData> bayraklistesi = new List<TMP_Dropdown.OptionData>();

        foreach (var bayrak in bayraklar)
        {
            string bayrakIsim = bayrak.name;
            var secim = new TMP_Dropdown.OptionData();
            secim.text = bayrakIsim;
            secim.image = bayrak;

            bayraklistesi.Add(secim);
        }

        nesne.AddOptions(bayraklistesi);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//using System.Collections.Generic;
//using TMPro;
//using UnityEngine;

//public class LanguageDropdown : MonoBehaviour
//{
//    public TMP_Dropdown nesne;
//    public Sprite[] bayraklar;

//    void Start()
//    {
//        nesne.ClearOptions();

//        List<TMP_Dropdown.OptionData> bayraklistesi = new List<TMP_Dropdown.OptionData>();

//        foreach (var bayrak in bayraklar)
//        {
//            string bayrakIsim = bayrak.name;

//            var secim = new TMP_Dropdown.OptionData();
//            secim.text = bayrakIsim;
//            secim.image = bayrak;

//            bayraklistesi.Add(secim);
//        }

//        nesne.AddOptions(bayraklistesi);
//    }
//}

