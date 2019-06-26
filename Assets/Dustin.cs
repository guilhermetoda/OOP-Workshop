using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dustin : MonoBehaviour
{
    int y;
    // Start is called before the first frame update
    void Start()
    {
        int y = 5;
        FDustin(y);
        Debug.Log("AFTER FD"+y);
        ReferenceFDustin(ref y);
        Debug.Log("AFTER REF"+y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FDustin(int y) 
    {
        y = 10;
        y = 120;
        Debug.Log("FD"+y);
    }

    void ReferenceFDustin(ref int y) 
    {
        y = 15;
    }
}
