using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject spotlight;
    void Start()
    {
        spotlight.GetComponent<Light>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btnLight()
    {
            if (spotlight.GetComponent<Light>().enabled == true)
            {
                spotlight.GetComponent<Light>().enabled = false;
            }
            else
            {
                spotlight.GetComponent<Light>().enabled = true;
            }
    }
}
