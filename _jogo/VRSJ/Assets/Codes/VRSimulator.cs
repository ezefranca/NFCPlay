using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRSimulator : MonoBehaviour
{

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //teste no editor este cara nao roda no celular
#if (UNITY_EDITOR)
        Cursor.lockState = CursorLockMode.Locked; //linha q trava o mousena tela

        //movimento de pescoço na camera
        Vector3 neckmov = new Vector3(-Input.GetAxis("Mouse Y"), 0, 0);
        transform.Rotate(neckmov);
        //movimento de torçao no corpo
        Vector3 bodymov = new Vector3(0, Input.GetAxis("Mouse X"), 0);
        transform.parent.Rotate(bodymov);
#endif

    }
}
