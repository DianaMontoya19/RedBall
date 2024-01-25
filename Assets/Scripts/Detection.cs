using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public GameObject imagen;
    public TextMeshProUGUI[] dialogo;
    public GameObject[] ListaCamaras;
  
    public MeshRenderer myMeshRenderer;
    public Move myMovimiento;
    public Exit EndGame;

 


    private void Start()
    { 
       
        ListaCamaras[0].gameObject.SetActive(true);
        ListaCamaras[1].gameObject.SetActive(false);
        desactivar();
       


    }


    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("Detection")|| collision.gameObject.CompareTag("Cannon"))
        {

            myMeshRenderer.enabled = false;

            gameObject.transform.position = new Vector3(-10.0500002f, 3.03999996f, 11.3400002f);

            myMeshRenderer.enabled = true;


            ListaCamaras[1].gameObject.SetActive(true);
            ListaCamaras[0].gameObject.SetActive(false);

            myMovimiento.enabled = false;

            activar();

        }
        if (collision.gameObject.CompareTag("Ending"))
        {
            
            EndGame.GameOver.SetActive(true);
            EndGame.Pause.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Reappear"))
        {
            gameObject.transform.position = new Vector3(1.41999996f, 3.0940001f, 10.880000f);
        }

        if (collision.gameObject.CompareTag("ReapJump"))
        {
            gameObject.transform.position = new Vector3(20.6599998f, 3.0940001f, 11.5f);
        }
        if (collision.gameObject.CompareTag("ReapStart"))
        {
            gameObject.transform.position = new Vector3(-36.9700012f, -0.430999994f, 11.3199997f);
        }
        
        if (collision.gameObject.CompareTag("Floor3"))
        {
            ListaCamaras[1].gameObject.SetActive(false);
            ListaCamaras[0].gameObject.SetActive(true);

            myMovimiento.enabled = true;
            desactivar();
        }


    }
    void activar()
    {
        dialogo[0].gameObject.SetActive(true);
        dialogo[1].gameObject.SetActive(true);
        dialogo[2].gameObject.SetActive(true);
        imagen.gameObject.SetActive(true);
    }
    void desactivar()
    {

        dialogo[0].gameObject.SetActive(false);
        dialogo[1].gameObject.SetActive(false);
        dialogo[2].gameObject.SetActive(false);
        imagen.gameObject.SetActive(false);
    }
}
