using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject Jugador;

    // Update is called once per frame
    void Update()
    {
        transform.position = Jugador.transform.position + new Vector3(-1f, 0.2f, 0f);
    }
}
