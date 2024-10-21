using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String : MonoBehaviour
{
    [SerializeField] private string message1;
    [SerializeField] private string message2;
    [SerializeField] private string message3;
    [SerializeField] private string name;
    // Start is called before the first frame update
    void Start()
    {
        //cach 1
        message1 = "Hello World!";
        //cach 2
        message2 = "Hello " + "Unity!";
        //cach 3
        name = "Kien";
        message3 = $"Xin chao {name}!";

        Debug.Log(message1);
        Debug.Log(message2);
        Debug.Log(message3);

        //do dai string
        int dodai;
        dodai = message1.Length;
        Debug.Log("Do dai mess1 la: " + dodai);

        //viethoa
        string viethoa;
        viethoa = message2.ToUpper();
        Debug.Log("mess2 sau khi viet hoa la: " + viethoa);

        //vietthuong
        string vietthuong;
        vietthuong = message3.ToLower();
        Debug.Log("mess3 sau khi viet  la: " + vietthuong);

        //ghi de
        string ghide;
        ghide = message1.Replace("l", "n");
        Debug.Log("mess1 sau khi chuyen l thanh n la: " + ghide);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
