
## Mestrado profissional em Desenvolvimento de Jogos Digitais (PUC-SP)

<p align="center">
<img class="mestrado" src="https://raw.githubusercontent.com/ezefranca/Damas/master/logo_mestrado.png" width="30%" height="30%">
</p>

# NFC Play (CardBoard Upgrade)
### Disciplina: Laboratório 1 
### Professor Dr. Reinaldo Augusto de Oliveira Ramos

<p align="center">
<img class="mestrado" src="https://raw.githubusercontent.com/ezefranca/VRNFC/master/Design/logo03.png" width="70%" height="70%">
</p>

### Problema

A entrada do usuário (neste caso toque na tela) tem sido um problema na industria de jogos. Algumas soluções com a utlização de temporizadores (aguardar olhando algo para realizar a ação) foram propostas e vêm sendo utilizadas em diversos jogos.

### Contextualização

Alguns modelos do [Cardboard]() V1 possuiam um botão magnético na lateral. Todavia este botão causava interferência no magnetômetro e no módulo GPS(AGPS), módulos importantes para o desenvolvimento de jogos utilizando *Virtual Reality* (VR). 

O modelo [V2 do Cardboard]() trocou este mecanismo por uma pequena alavanca que realiza o toque na tela.

### Solução Proposta

Este trabalho propõe a utilização de uma tag NFC (*Near Field Communication*) como mecanismo de entrada para o jogador. 

### Implementação

Implementação de um *framework* desenvolvido em código nativo para iOS e Android e unificado em um *wrapper* para Unity3D. O framework funciona como um subscribe baseado em eventos, que é ativado por qualquer tag NFC, chamando um método e assim conseguimos nele simular um toque em um objeto no jogo.

Exemplo de utilização

```c#
using UnityEngine;
using NFC;

public class Example : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void UpdateTagInfo(NFCTag tag)
    {
      // Uma tag foi encostada
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
```

### Demonstração

<p align="center">
  <a href="https://youtu.be/l8VaDQliRLA">
<img class="mestrado" src="http://i3.ytimg.com/vi/l8VaDQliRLA/hqdefault.jpg" width="50%" height="50%">
  </a>
</p>
