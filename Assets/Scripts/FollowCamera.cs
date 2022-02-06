using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject gb;
    void Update()
    {
        transform.position = new Vector3(gb.transform.position.x, gb.transform.position.y, transform.position.z);
    }
}
