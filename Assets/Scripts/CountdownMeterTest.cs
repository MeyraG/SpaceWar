using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownMeterTest : MonoBehaviour
{
    CountdownMeter countdownMeter;      //Burada diyoruz ki, bu classtan bi tane instance oluştur,kalıp olarak da CountdownMeter'i kullan.
                                        //Sayacı çalıştırmak için başka bi şeye gerek yok,ama ne kadar süre  geçtiğini görmek için
                                        //..başladığı zamanki süreyi de bi değişkene alalım.

    float startingTime;


    void Start()
    {
        countdownMeter = gameObject.AddComponent<CountdownMeter>(); //Bu satır bu component'i GameObject'e ekliyor

        countdownMeter.TotalTime = 5;              //5 sn sayacak
        
        countdownMeter.Run();

        startingTime = Time.time;                  //Sayaç bittiği zaman gerçekte ne kadar süre geçtiğini görmek için yazıyoruz.

    }

    //Her frame sayaca Bitti mi diye soracağız. 
    void Update()
    {
        if (countdownMeter.Finished)                //Sayaç bittiği zaman burası true olacak ve altındaki blok çalışacak
        {
            float passingTime = Time.time - startingTime;
            Debug.Log(passingTime);


            //Sayaç bittikten sonra tekrar çalışsın istersek;
            startingTime = Time.time;                  //Başlangıç zamanını şu anki zamana eşitledik.
            countdownMeter.Run();
        }

    }
}
