using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{

    public Color altColor = Color.black;
    public Renderer rend;
    int x, z;
    float timer;

    void SetDefCol(){
        altColor.g = 0f;
        altColor.r = 0f;
        altColor.b = 0f;
        altColor.a = 0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        x = -1;
        z = 0;
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
        if (timer >= 1.0f){
            if (x < 5){
                x += 1;
            }
            else{
                z += 1;
                x = 0;
            }
            chColor(x,z);
            timer = 0.0f;
        }
    }
    
    void chColor(int x, int z)
    {
        string tilename = "Cube (" + x.ToString() + "," + z.ToString() + ")";
        Debug.Log(tilename);
        rend = GameObject.Find(tilename).GetComponent<Renderer>();
        rend.material.color = altColor;
    }
}
