
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GhostManager : MonoBehaviour
{
    public int lives = 4;
    public TextMeshProUGUI lifeText;

    public void Start()
    {
        UpdateLives();
    }

    private void OnTriggerEnter(Collider Enemy)
    {
        if (Enemy.gameObject.tag == "Enemy") 
        {
            lives--;
            Debug.Log("Enemy reached you");
            lifeText.text = "Lives: " + lives.ToString();
            if (lives <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    public void UpdateLives()
    {
        lifeText.text="Lives: "+lives.ToString();
    }
}
