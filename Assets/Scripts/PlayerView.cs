using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private TextMeshPro _nicknameTMP;
    [SerializeField] private TextMeshPro _coinsTMP;
    [SerializeField] private TextMeshPro _lapTMP;
    [SerializeField] private TextMeshPro _bestTMP;

    [SerializeField] private GameObject _gameOverUI;
    private void Start()
    {
        _gameOverUI.SetActive(false);
        Time.timeScale = 1.0f;
    }

    private void Update()
    {
        _nicknameTMP.text = GameManager.Nickname;
        _coinsTMP.text = $"X{GameManager.Coins}";
        _lapTMP.text = GameManager.Lap.ToString();
        _bestTMP.text = GameManager.Best.ToString();

        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            _gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}