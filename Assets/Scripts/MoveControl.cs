using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Moving SpaceShip- Bu uzun yol:

        //Rigidbody2D myRigidBody2D = GetComponent<Rigidbody2D>();
        //myRigidBody2D.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);

        //Bu daha kısa:

        GetComponent<Rigidbody2D>().AddForce(new Vector2(-6, 5), ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Fasten your seat belts!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
