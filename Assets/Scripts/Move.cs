using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move: MonoBehaviour
{
    
 
    public float velocidad;
    public float fuerzaSalto = 5f;
    private Vector3 gravedad = new Vector3(0f, 9.8f, 0f);
    private Vector3 gravedad2 = new Vector3(0f, -9.8f, 0f);
    private bool puedoSaltar;
    public LayerMask layerSuelo;



    private Rigidbody rb;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
     
    }

   public void FixedUpdate()
    {


        float movimientoHor = Input.GetAxisRaw("Horizontal");
        float xSpeed = movimientoHor * velocidad;
        float movimientoVer = Input.GetAxisRaw("Vertical");
        float zSpeed = movimientoVer * velocidad;

        Vector3 movimiento = new Vector3(zSpeed, rb.velocity.y, -xSpeed);


        rb.velocity = movimiento;


    }

   private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && puedoSaltar)
        {
            Vector3 movimientoFuerza = Vector3.up * fuerzaSalto;
            rb.AddForce(movimientoFuerza, ForceMode.Impulse);
        }
        puedoSaltar = Physics.Raycast(transform.position, Vector3.down, 1f, layerSuelo);

    }
  

    void OnCollisionEnter(Collision collision)
    {
          

          
            if (collision.gameObject.CompareTag("Fly"))
            {
                rb.useGravity = false;
                rb.AddForce(gravedad, ForceMode.Acceleration);

               

                             
            }
            if (collision.gameObject.CompareTag("Out"))
            {
                    rb.useGravity = true;

                
            }



    }


}
