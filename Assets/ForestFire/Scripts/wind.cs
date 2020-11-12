using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{
    public int WindSpeed;
    public int WindVectorX;
    public int WindVectorY;
    // Start is called before the first frame update
    void Start()
    {
        WindSpeed = UnityEngine.Random.Range(0, 3);
        WindVectorX = UnityEngine.Random.Range(-1, 1);
        WindVectorY = UnityEngine.Random.Range(-1, 1);
        Debug.Log("windspeed is " + WindSpeed);
        Debug.Log("wind Direction is (" + WindVectorX + "," + WindVectorY + ")");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
