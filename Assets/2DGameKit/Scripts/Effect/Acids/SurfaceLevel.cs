using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<BuoyancyEffector2D>().surfaceLevel = 0.9f;
    }
}
