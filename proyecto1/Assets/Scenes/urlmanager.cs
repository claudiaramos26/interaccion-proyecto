using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urlmanager : MonoBehaviour
{

    public string web1;
    public string web2;
    public string web3;
    public string web4;
    public string web5;
    public string web6;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void google ()
    {
        Application.OpenURL(web1);
  
    }

    public void notion ()
    {
        Application.OpenURL(web2);

    }
    public void udg ()
    {
        Application.OpenURL(web3);

    }
    public void cnn ()
    {
        Application.OpenURL(web4);

    }
    public void amazon ()
    {
        Application.OpenURL(web5);

    }
    public void wiki ()
    {
        Application.OpenURL(web6);

    }

}
