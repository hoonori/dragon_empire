using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject tilman;
    void Start()
    {
        tilman = GameObject.Find("TileManager");
    }

    // Update is called once per frameß
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Debug.Log(Input.mousePosition);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast (ray, out hit))
            {
                Debug.Log(hit.transform.name);
                string grid = hit.transform.name.Substring(hit.transform.name.IndexOf("(") + 1, 3);
                Debug.Log(grid);
                tilman.SendMessage("chColor", grid);
            }
        }
        

    }
}
