using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
   // public PhysicMaterial myMaterial;
    //public GameObject Jugador;

    void OnCollisionEnter(Collision collision)
    {
       // Renderer rend = Jugador.GetComponent<Renderer>();

        if (collision.gameObject.CompareTag("Jugador"))
        {
            Desaparecer();
           
           // rend.enabled = myMaterial; 


        }
 

    }
    void Desaparecer()
    {
        Destroy(gameObject);
    }
    
}
