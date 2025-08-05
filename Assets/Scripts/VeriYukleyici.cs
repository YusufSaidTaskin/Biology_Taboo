using UnityEngine;

public class VeriYukleyici : MonoBehaviour
{
    public TextAsset jsonDosyasi;

    public TabuKartListesi kartListesi;

    void Start()
    {
        kartListesi = JsonUtility.FromJson<TabuKartListesi>(jsonDosyasi.text);

        // Test: �lk kelimeyi Konsola yazal�m
        Debug.Log("�lk kelime: " + kartListesi.kartlar[0].anaKelime);
    }
}
