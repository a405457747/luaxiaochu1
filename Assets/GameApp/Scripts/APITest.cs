using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APITest : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        List<int> a = new List<int>() { 3, 2, 1 };

        a.AddRange(new List<int>() { 2, 3 });
        Debug.Log(a);

        List<string> kk;
        Debug.Log(transform.name);
    }


}
