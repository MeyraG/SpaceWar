using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
     GameObject asteroidPrefab;

    GeriSayimSayaci geriSayimSayaci;

    void Start()
    {
        geriSayimSayaci = gameObject.AddComponent<GeriSayimSayaci>();
        geriSayimSayaci.ToplamSure = 3;
        geriSayimSayaci.Calistir();
          
    }

    void Update()
    {
        if (geriSayimSayaci.Bitti)
        {
            SpawnAsteroid();

            //Spawn Game Object

            geriSayimSayaci.Calistir();
        }
    }

    void SpawnAsteroid()
    {
        Instantiate(asteroidPrefab);
    }
}
