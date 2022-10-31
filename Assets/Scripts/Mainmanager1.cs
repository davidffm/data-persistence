using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Mainmanager1 : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static Mainmanager1 Instance;
    public TextMeshProUGUI nametext;
    public TextMeshProUGUI nametext2;
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

  
    public void CenaPlay()
    {
        SceneManager.LoadScene(1);
        
    }

    public void SaveName()
    {
        PlayerPrefs.SetString("nome_jogador", nametext.text);
      
    }
}