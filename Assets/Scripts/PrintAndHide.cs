using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide: MonoBehaviour
{
    int i;
    public Renderer rend;
    int a = Random.Range(150, 250);
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + ++i);

        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
  
        if (gameObject.tag == "Blue" && i == a)
        {
            rend.enabled = false;
        }

    }
}
