using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Olá mundo"); 
       TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

       UnityEngine.Vector3 direção = new UnityEngine.Vector3(x, 0, y);
        rb.AddForce(direção * velocidade * Time.deltaTime, ForceMode.Impulse);
    }
}
