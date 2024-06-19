using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{
    public GameObject Empty;
    public GameObject[] lista;
    public int currentindex;
    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentindex == 0)
            {
                currentindex = 14;
            }
            else
            {
                currentindex -= 1;
            }
            Restar();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentindex == 14)
            {
                currentindex = 0;
            }
            else
            {
                currentindex += 1;
            }

            Sumar();
        }
    }

    public void DeactivateAll()
    {
        for (int i = 0; i < lista.Length; i++)
        {
            lista[i].SetActive(false);
        }

    }

    public void Restar()
    {
        DeactivateAll();
        lista[currentindex].SetActive(true);
    }

    public void Sumar()
    {
        DeactivateAll();
        lista[currentindex].SetActive(true);
    }
}
