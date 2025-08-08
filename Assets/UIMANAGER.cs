using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIMANAGER : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelCounter;

    private const string PlayCountKey = "PlayCount";

    void Awake()
    {
        UpdatePlayCount();
        UpdateLevelCounterUI();
    }

    public void RestartScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }

    private void UpdatePlayCount()
    {
        int playCount = PlayerPrefs.GetInt(PlayCountKey, 0);
        playCount++;
        PlayerPrefs.SetInt(PlayCountKey, playCount);
        PlayerPrefs.Save();
    }

    private void UpdateLevelCounterUI()
    {
        if (levelCounter != null)
        {
            int playCount = PlayerPrefs.GetInt(PlayCountKey, 1);
            levelCounter.text = $"Level {playCount}";
        }
    }
}
