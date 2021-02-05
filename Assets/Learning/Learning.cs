using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
   
    void Start()
    {
        //If Yapısı

        int kalanAsteroid = 3;
        int oyuncuHp = 88;

        if (kalanAsteroid <=2 || oyuncuHp >= 90)
        {
            Debug.Log("Perfect!");
        }
        else if (kalanAsteroid >=3 && kalanAsteroid<=5 && oyuncuHp >= 80 && oyuncuHp <=89 )
        {
            Debug.Log("Very good!");
        }
        else
        {
            Debug.Log("Dont worry, try again");
        }
        
        // if ((kalanAsteroid == 0) || (kalanAsteroid == 1))
        // {
        //     Debug.Log("you're the best of besties!");
        // }
        // else if (kalanAsteroid == 2)
        // {
        //     Debug.Log("You're the best");
        // }
        // else if (kalanAsteroid == 3)
        // {
        //     Debug.Log("You're the winner");
        // }
        //else
        // {
        //     Debug.Log("you should play another game :( ");
        // } 

        //Switch Yapısı
        //switch (kalanAsteroid)
        //{
        //    case 0:
        //        Debug.Log("You're at the top of space!");
        //        break;
        //    case 1:
        //        Debug.Log("You're the best!");
        //        break;
        //    case 2:
        //        Debug.Log("You're really good at this!");
        //        break;
        //    case 3:
        //        Debug.Log("You're so close");
        //        break;
        //    case 4:
        //        Debug.Log("You can do it");
        //        break;
        //    case 5:
        //        Debug.Log("Give a break");
        //        break;
        //    default:
        //        Debug.Log("Maybe next time");
        //        break;
        //}
    }

    
    void Update()
    {
        
    }
}
