
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public int clickPower = 1;
    public int buffCost = 10;

    public int rebirthCount = 0;
    public int memoryResidue = 0;

    public TMP_Text scoreText;
    public TMP_Text buffText;
    public TMP_Text rebirthText;

    void Start()
    {
        UpdateUI();
    }

    // Called by your existing click button
    public void Click()
    {
        int multiplier = rebirthCount + 1;

        score += clickPower * multiplier;
        UpdateUI();
    }

    // Called by the Buy Buff button
    public void BuyBuff()
    {
        if (score < buffCost)
            return;

        score -= buffCost;
        clickPower += 1;
        buffCost *= 2;

        UpdateUI();
    }

    // Called by the Rebirth button
    public void Rebirth()
    {
        int rebirthCost = 50 * (rebirthCount + 1);

        if (score < rebirthCost)
            return;

        score = 0;
        clickPower = 1;
        buffCost = 10;

        rebirthCount++;
        memoryResidue++;

        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = "PROCESSING CYCLES: " + score;

        buffText.text = "BUY OPTIMIZATION: " + buffCost;

        int rebirthCost = 50 * (rebirthCount + 1);
        rebirthText.text = "REINITIALIZED: " + rebirthCost;
    }
}
