using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{

    public AudioSource sound;
    public bool enableordisable=true;
    public GameObject toEnable;
    public Rigidbody rdb;
    public bool autodestroy=false;

    public Vector3 force;

    //quando o jogador entra no trigger
    private void OnTriggerEnter(Collider other)
    {
        //toca o som
        if (sound)
        {
            sound.Play();
        }
        //objeto pra ativar
        if (toEnable)
        {
            toEnable.SetActive(enableordisable);
        }
        //rigidbody pra aplicar força 
        if (rdb)
        {
            rdb.AddForce(force * 5, ForceMode.Impulse);
        }
        //autodestruiçao do objeto
        if (autodestroy)
        {
            Destroy(gameObject,5);
        }
    }

}
