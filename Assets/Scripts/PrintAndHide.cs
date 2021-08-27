using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    int i,r;

    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        r = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name+":"+i);

        if (i == 100 && GameObject.FindGameObjectWithTag("Red")!=null)
            GameObject.FindWithTag("Red").SetActive(false);

        if (i == r)
            GameObject.FindWithTag("Blue").GetComponent<Renderer>().enabled = false;
    }
}
