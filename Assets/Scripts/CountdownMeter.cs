using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownMeter : MonoBehaviour
{
    //Field'larımı yazıyorum:
    float totalTime = 0;
    float passingTime = 0;
    bool working = false;
    bool started = false;

    //Fieldları private yaptım, ama sayacın kaç sn çalışacağı gibi bilgileri de değişkenlere değer atamaları yapmalıyım.
    //o yüzden public bi prop tanımlıyorum:
    public float TotalTime 
    {
        set                                 //Değer ataması yaptığım için set kullanırım
        {
            if (!working)
            {
                totalTime = value;
            }
               
        }
    }

    //Geri sayım işleminin bittiğini söyleyen bir prop yazıyorum:
    //Bool yazıyorum, çünkü ya true ya false: bitti-bitmedi
    public bool Finished
    {
        get
        {
            return started && !working;     //Başlamış ve çalışmıyor olması lazım ki bitmiş/durmuş olsun 
        }
    }
    public void Run()
    {
        if(totalTime > 0)                   //Sayaç ne zaman çalışır? totalTime 0dan büyük olduğu zaman, başlamış demektir
        {
            working = true;                 //Bu method çağrıldığı zaman working değişkeni true olur
            started = true;                 //Aynı şekilde started değişkeni de true olur
            passingTime = 0;                //henüz süre geçmediği için 0
        }
    }

    //Yukarıdaki değişkenler true olduğu an, aşağıdaki if bloğunun içi çalışmaya başlar.Sonra da geçen sürenin artması gerek (+)
    void Update()
    {
        if (working)
        {
            passingTime += Time.deltaTime;   //Time, unity'den gelen bi class, deltaTime da bu classa ait bi property
            if (passingTime > totalTime)
            {
                working = false;
            }
        }
    }
}
