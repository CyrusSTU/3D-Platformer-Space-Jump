using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralController : MonoBehaviour
{
    public int rotationSpeed = 30;

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its local Y axis at rotationSpeed degrees per second
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
    }
}