using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeriSayimTest : MonoBehaviour
{
    GeriSayimSayaci geriSayimSayaci;
    float baslangicZamani;
    void Start()
    {
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayaci>();
        geriSayimSayaci.ToplamSure = 3;
        geriSayimSayaci.Calistir();
        baslangicZamani = Time.time;
    }
     

    void Update()
    {
        if (geriSayimSayaci.Bitti)
        {
            float gecenSure = Time.time - baslangicZamani;
            Debug.Log(gecenSure);

            baslangicZamani = Time.time;
            geriSayimSayaci.Calistir();
        }
    }
}
