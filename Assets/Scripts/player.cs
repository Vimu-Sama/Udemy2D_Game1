using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float sp = 10f;
    [SerializeField] float st = 80f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float steer = Input.GetAxis("Horizontal") * st * Time.deltaTime ;
        float speed = Input.GetAxis("Vertical") * sp * Time.deltaTime;
        transform.Rotate(0, 0, -steer);
        transform.Translate(0, speed, 0);
    }
}
