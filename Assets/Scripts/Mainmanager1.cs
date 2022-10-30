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
    string das;
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

    private void Start()
    {
       
    }
    private void Update()
    {
        
    }
    public void CenaPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void SaveName()
    {
        //nametext2.text = nametext.text;
        
        
       // PlayerPrefs.SetString("nome_jogador", nametext.text);
       nametext2.text= PlayerPrefs.GetString("nome_jogador");
    }
}