using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Transform doorMesh;
    bool closed=true;
   

   //funcao de corotina roda em paralelo com a funçao padrao da unity "update"
    public IEnumerator Abre()
    {
        float ang=0; //posicao da porta inicial
        while (ang>-148) //enquanto o angulo for menor q -148
        {
            ang = Mathf.Lerp(ang, -150,Time.deltaTime); // interpola para -150
            doorMesh.transform.rotation = Quaternion.Euler(0, ang, 0); //aplica a rotaçao 
          
            yield return new WaitForEndOfFrame(); //espera o loop até o fim do update

        }
        closed = false; // seta a booleanada porta como aberta
    }
    //mesma coisa só q ao contrario
    public IEnumerator Fecha()
    {
        float ang = -150;
        while (ang<0)
        {
            ang = Mathf.Lerp(ang, 1, Time.deltaTime);
            doorMesh.transform.rotation = Quaternion.Euler(0, ang, 0);

            yield return new WaitForEndOfFrame();

        }

        closed = true;

    }
    //chama a corotina se o jogador tiver olhando pra ela 
    public void ButtonAction()
    {
        if (closed) //se fechada
        {
            StartCoroutine(Abre()); //incia a corotina de abrir 

        }
        else
        {
            StartCoroutine(Fecha()); // inverso
        }
    }

}
