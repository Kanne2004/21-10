using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMethods : MonoBehaviour
{
    [SerializeField] private Vector3 vector1;
    [SerializeField] private Vector3 vector2;
    [SerializeField] private float tichVoHuong;
    [SerializeField] private Vector3 tichCoHuong;
    [SerializeField] private float doDaiVecto;
    [SerializeField] private Vector3 normalized;

    // Start is called before the first frame update
    void Start()
    {
        vector1 = new Vector3(1, 2, 3);
        vector2 = new Vector3(4, 5, 6);
        tichVoHuong = Vector3.Dot(vector1, vector2);
        tichCoHuong = Vector3.Cross(vector1, vector2);
        doDaiVecto = vector1.magnitude;
        normalized = vector1.normalized;
        Debug.Log("Dot Product: " + tichVoHuong);
        Debug.Log("Cross Product: " + tichCoHuong);
        Debug.Log("Magnitude: " + doDaiVecto);
        Debug.Log("Normalized: " + normalized);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
