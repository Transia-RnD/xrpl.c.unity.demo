using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Xrpl.Client;
public class Test : MonoBehaviour
{

    private static IRippleClient client;
    private static string serverUrl = "wss://xls20-sandbox.rippletest.net:51233";
    
    // Start is called before the first frame update
    public void Awake()
    {
        client = new RippleClient(serverUrl);
        client.Connect();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
