
using UnityEngine;
using UnityEngine.UI;

public class WhenPressed : MonoBehaviour
{
    public ScoreManager scoreManager;

    private Button button;

    void Start()
    {
        button = GetComponent<Button>();

        // Listen for button clicks
        button.onClick.AddListener(OnPressed);
    }

    void OnPressed()
    {
        scoreManager.Click();
    }
}
