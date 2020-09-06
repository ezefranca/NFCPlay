using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NFC;

public class Raycaster : MonoBehaviour
{
    public TextMesh textDebug;
    public GameObject crosshair;
    float counter = 2;
    public FPSWalk fpswalk;
    float length = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void UpdateTagInfo(NFCTag tag)
    {
        string technologiesString = string.Empty;
        NFCTechnology[] technologies = tag.Technologies;
        length = technologies.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit, 6))
        {

            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            //coloca o nome do objeto na frente do raio na saida de debug
            textDebug.text = hit.transform.name;
            //posiciona o crosshair no ponto de impacto do raio
            crosshair.transform.position = hit.point;
            //crosshair.transform.forward = hit.normal;

            //faz o crosshair sempre se alinhar com a camera
            crosshair.transform.forward = -transform.forward;

            //se o objeto tiver tag player (iteragivel)
            if (hit.transform.gameObject.CompareTag("Player"))
            {
                //troca cor do crosshair
                crosshair.GetComponent<Image>().CrossFadeColor(Color.green, .5f, false, false);
                //decrementa o contador 

                //se o contador for < 0 chama a funça no objeto ButtonAction()
                if (length > 0)
                {
                    hit.transform.gameObject.SendMessageUpwards("ButtonAction");
                }
            } // senao verifica se o objeto é com o tag andavel
            else if (hit.transform.gameObject.CompareTag("Walkable"))
            {
                crosshair.GetComponent<Image>().CrossFadeColor(Color.blue, .5f, false, false);

                if (length > 0)
                {
                    //anda com o personagem até o ponto de caminhada
                    fpswalk.positionToGo = hit.transform.position;
                }
            }
        }

        else
        {
            //se nao da raycast o crosshair some
            crosshair.GetComponent<Image>().CrossFadeColor(Color.black, .0f, false, false);
        }
        length = 0;
    }
}