using UnityEngine;
using System.Linq; // Filtreleme i�in

public class VeriYukleyici : MonoBehaviour
{
    public TextAsset jsonDosyasi;
    public TabuKartListesi kartListesi;

    void Start()
    {
        // JSON'dan t�m kartlar� oku
        kartListesi = JsonUtility.FromJson<TabuKartListesi>(jsonDosyasi.text);

        // LevelSecim singleton'�ndan se�ilen level'i al
        int secilenLevel = LevelSecim.Instance.secilenLevel;
        Debug.Log("Se�ilen Level: " + secilenLevel);

        // Filtrele: sadece se�ilen levele ait kartlar� al
        var secilenKartlar = kartListesi.kartlar
            .Where(kart => kart.level == secilenLevel)
            .ToList();

        // Konsola yaz
        foreach (var kart in secilenKartlar)
        {
            Debug.Log("Ana Kelime: " + kart.anaKelime);
            Debug.Log("Yasakl�lar: " + string.Join(", ", kart.yasakliKelimeler));
        }

        // Ek olarak bu kartlar� ba�ka bir yerde kullanacaksan:
        // bunlar� bir listede tutabilir ya da ba�ka bir metoda ge�irebilirsin.
    }
}
