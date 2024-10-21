using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    [SerializeField] private int[] number = new int[5];
    // Start is called before the first frame update
    void Start()
    {
        number[0] = 1;
        number[1] = 2;
        number[2] = 3;
        number[3] = 4;
        number[4] = 5;

        for (int i = 0; i < number.Length; i++)
        {
            Debug.Log($"number[{i}]: "+ number[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
