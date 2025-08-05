using UnityEngine;

public class VeriYukleyici : MonoBehaviour
{
    public TextAsset jsonDosyasi;

    public TabuKartListesi kartListesi;

    void Start()
    {
        kartListesi = JsonUtility.FromJson<TabuKartListesi>(jsonDosyasi.text);

        // Test: Ýlk kelimeyi Konsola yazalým
        Debug.Log("Ýlk kelime: " + kartListesi.kartlar[0].anaKelime);
    }
}
