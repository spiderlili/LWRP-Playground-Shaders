using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToonLight : MonoBehaviour
{
    private new Light light = null;
    // Start is called before the first frame update
    void Start()
    {
        light = this.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        //-(0, 0, 1)
        //update the position to the shader so lighting can update
        //set the value of light dir vector to the position of this light
        Shader.SetGlobalVector("_lightDirection", -this.transform.forward);
    }
}
