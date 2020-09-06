using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoBehavior : MonoBehaviour
{
    public string functiontocall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //funcao que é chamada pelo player
    public void ButtonAction()
    {
        Invoke(functiontocall,0);
    }

    public void LoadGame()
    { 
        //carrega uma cena
        SceneManager.LoadScene("level1");
    }

    public void QuitAction()
    {
        //sai do jogo
        Application.Quit();
    }
}
