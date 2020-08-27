using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilecolor : MonoBehaviour
{

    public Color altColor = Color.black;
    public Renderer rend;
    
    // Start is called before the first frame update
    void SetDefCol(){
        altColor.g = 0f;
        altColor.r = 0f;
        altColor.b = 0f;
        altColor.a = 0f;
    }
    
    void Start()
    {
        SetDefCol();
        rend = GetComponent<Renderer>();
        rend.material.color = altColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)){
            altColor.r += 0.1f;
            rend.material.color = altColor;
        }
        if (Input.GetKey(KeyCode.G)){
            altColor.g += 0.1f;
            rend.material.color = altColor;
        }
        if (Input.GetKey(KeyCode.B)){
            altColor.b += 0.1f;
            rend.material.color = altColor;
        }
        if (Input.GetKey(KeyCode.W)){
            altColor.a += 0.1f;
            rend.material.color = altColor;
        }
        if (Input.GetKey(KeyCode.S)){
            altColor.a -= 0.1f;
            rend.material.color = altColor;
        }
    }
}
