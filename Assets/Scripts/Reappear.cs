using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reappear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Reappear"))
        {
            gameObject.transform.position = new Vector3(1.41999996f, 3.0940001f, 10.880000f);
        }

        if(collision.gameObject.CompareTag("ReapJump"))
        {
            gameObject.transform.position = new Vector3(20.6599998f, 3.0940001f, 11.5f);
        }
    }
}
