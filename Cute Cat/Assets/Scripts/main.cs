using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tamagotchi : MonoBehaviour
{
    public Image fomeBar;
    public Image higieneBar;
    public Image felicidadeBar;
    public Image sonoBar;

    public float maxFome = 100f;
    public float maxHigiene = 100f;
    public float maxFelicidade = 100f;
    public float maxSono = 100f;

    private float fome;
    private float higiene;
    private float felicidade;
    private float sono;

    public float fomePerSecond = 1f;
    public float higienePerSecond = 1f;
    public float felicidadePerSecond = 1f;
    public float sonoPerSecond = 0.5f;

    public float feedAmount = 20f;
    public float bathAmount = 20f;
    public float playAmount = 20f;
    public float sleepAmount = 20f;

    private bool isGameOver = false;

    void Start()
    {
        fome = maxFome;
        higiene = maxHigiene;
        felicidade = maxFelicidade;
        sono = maxSono;
    }

    void Update()
    {
        // Verifica se o jogo não acabou
        if (!isGameOver)
        {
            // Calcula o tempo passado desde o último frame
            float deltaTime = Time.deltaTime;

            // Diminui as barras com base na taxa de redução e no tempo passado
            fome -= fomePerSecond * deltaTime;
            higiene -= higienePerSecond * deltaTime;
            felicidade -= felicidadePerSecond * deltaTime;
            sono -= sonoPerSecond * deltaTime;

            // Atualiza as barras na interface com base nos valores atuais
            fomeBar.fillAmount = fome / maxFome;
            higieneBar.fillAmount = higiene / maxHigiene;
            felicidadeBar.fillAmount = felicidade / maxFelicidade;
            sonoBar.fillAmount = sono / maxSono;

            // Verifica se alguma barra chegou a zero
            if (fome <= 0 || higiene <= 0 || felicidade <= 0 || sono <= 0)
            {
                // Define o jogo como acabado
                isGameOver = true;
                // Carrega a cena de Game Over
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    public void Feed()
    {
        fome += feedAmount;
        fome = Mathf.Clamp(fome, 0f, maxFome);
    }

    public void Bath()
    {
        higiene += bathAmount;
        higiene = Mathf.Clamp(higiene, 0f, maxHigiene);
    }

    public void Play()
    {
        felicidade += playAmount;
        felicidade = Mathf.Clamp(felicidade, 0f, maxFelicidade);
    }

    public void Sleep()
    {
        sono += sleepAmount;
        sono = Mathf.Clamp(sono, 0f, maxSono);
    }
}