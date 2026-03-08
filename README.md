# 🎮 Estudos Unity 3D

![Unity](https://img.shields.io/badge/Unity-2021.3+-black?style=for-the-badge&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Status](https://img.shields.io/badge/Status-Em_Desenvolvimento-jany?style=for-the-badge)

Repositório criado para o estudo da criação de ambientes 3D, manipulação de assets e integração de animações complexas dentro da Unity. Este repositório serve como base para o estudo de movimentação de personagens, sistemas de áudio e organização de prefabs. Desenvolvido durante o Bootcamp de Desenvolvimento de Jogos da SoulCode Academy.

---

## 🚀 Tecnologias e Assets

O projeto utiliza uma combinação de ferramentas e pacotes de alta qualidade:

*   **Engine:** [Unity](https://unity.com/)
*   **Linguagem:** C# (C-Sharp)
*   **Asset Pack (Animais):** `Animals_FREE` (Modelos de cavalos, tigres, pinguins e mais).
*   **Asset Pack (Animações):** `Blink Art - Animations Starter Pack` (Animações completas de combate, movimentação e coleta).
*   **Ambiente de Desenvolvimento:** [VS Code](https://code.visualstudio.com/) com extensões recomendadas para Unity.

---

## 📁 Estrutura do Projeto

A organização segue as melhores práticas da Unity para facilitar a manutenção:

```text
├── Assets/
│   ├── Animals_FREE/      # Modelos 3D, Materiais e Prefabs de animais
│   ├── Audios/            # Temas musicais e efeitos sonoros (.wav)
│   ├── Blink/             # Biblioteca extensiva de animações (Mecanim compatível)
│   │   ├── Combat/        # Ataques, magias e hits
│   │   ├── Movement/      # Run, Sprint, Roll, Jump
│   │   └── Gathering/     # Mineração e coleta
│   └── Scenes/            # Cenas do projeto (Overview.unity)
├── .vscode/               # Configurações de Debug e IntelliSense
└── .gitignore             # Filtro de arquivos temporários da Unity
```

---

## 📦 Instalação

Para rodar este projeto em sua máquina local:

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/flaviare1s/unity-aula-projeto3d.git
    ```
2.  **Abra o Unity Hub.**
3.  Clique em **Add** e selecione a pasta do projeto clonado.
4.  Certifique-se de estar usando a versão **2021.3 LTS** ou superior da Unity.
5.  Ao abrir, aguarde a importação dos assets e o processamento dos metadados.

---

## 🎮 Como Usar

### Explorando a Cena
Abra a pasta `Assets/Animals_FREE/Scenes/` e carregue a cena **Overview.unity**. Nela, você encontrará a disposição inicial dos modelos e testes de ambiente.

### Sistema de Animações
As animações localizadas em `Assets/Blink/Art/Animations/` estão prontas para serem arrastadas para um **Animator Controller**. Elas incluem:
-   **Locomoção:** Mistura de Idle, Walk e Run.
-   **Combate:** Teste o `MeleeAttack_OneHanded` para mecânicas de RPG.
-   **VFX/Áudio:** Utilize os arquivos na pasta `Assets/Audios/` para ambientação de fundo.

---

## 🛠️ Configuração do Editor (VS Code)

Para garantir que o IntelliSense funcione corretamente, o projeto já inclui o arquivo `extensions.json`. Ao abrir a pasta no VS Code, aceite a recomendação de instalar as extensões:
-   *C# for Visual Studio Code*
-   *Debugger for Unity*

---
> *Este projeto é para fins educacionais. Os assets gratuitos pertencem aos seus respectivos criadores na Unity Asset Store.*