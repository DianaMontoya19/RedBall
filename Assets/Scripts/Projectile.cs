using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour

{

    Cannon lanzamiento;
    public float initialSpeed = 5f;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lanzamiento = FindObjectOfType<Cannon>();

        Debug.Log(lanzamiento.grados);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.End))
        {

            launchProjectile();
        }
    }

    void launchProjectile()
    {
        // calcular las componentes vertical y horizontal
        float launchAngleRad = lanzamiento.grados * Mathf.Deg2Rad;
        float initialVelocityX = initialSpeed * Mathf.Cos(launchAngleRad);
        float initialVelocityY = initialSpeed * Mathf.Sin(launchAngleRad);
        Vector3 initialVelocity = new Vector3(initialVelocityX, initialVelocityY, 0f);

        //Asignar velocidad inicial al proyectil



        rb.velocity = initialVelocity;

    }

}
