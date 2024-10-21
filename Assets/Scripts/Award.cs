
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diamonds : MonoBehaviour
{
    public int rewardCount = 0; 
    public TextMeshProUGUI rewardText;

    private void OnTriggerEnter(Collider Reward)
    {
        if (Reward.gameObject.tag == "Reward") 
        {
            rewardCount++; 
            Debug.Log("Reward collected! ");
            rewardText.text = "Collected: " + rewardCount.ToString();
            Destroy(Reward.gameObject);

            if (rewardCount >= 3)
            {
                Debug.Log("All rewards collected! ");
                SceneManager.LoadScene("WinGame");
            }
        }
    }
}
