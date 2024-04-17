using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour
{
    // References to UI elements
    [SerializeField] private Text countdownText;      // Text for displaying countdown
    [SerializeField] private Text gameOverText;       // Text for displaying game over message
    [SerializeField] private Button playAgainButton;  // Button for playing again

    //public GameManager gameManager; // Reference to GameManager

    void Start()
    {
        // Find and assign the GameManager in the scene
       // gameManager = FindObjectOfType<GameManager>();
    }

    // Method called to start the game
    public void StartGame()
    {
        // Start countdown coroutine
        StartCoroutine(StartCountdown());
    }

    // Coroutine for the countdown
    IEnumerator StartCountdown()
    {
        // Loop for 3 seconds countdown
        for (int i = 3; i > 0; i--)
        {
            countdownText.text = i.ToString(); // Update countdown text
            yield return new WaitForSeconds(1f); // Wait for 1 second
        }

        countdownText.gameObject.SetActive(false); // Disable countdown text
        //gameManager.StartGame(); // Start the game in GameManager
    }

    // Method to show game over message
    public void ShowGameOver(string message)
    {
        gameOverText.text = message; // Update game over message
        gameOverText.gameObject.SetActive(true); // Show game over text
        playAgainButton.gameObject.SetActive(true); // Show play again button
    }

    // Method called when play again button is clicked
    public void PlayAgain()
    {
        gameOverText.gameObject.SetActive(false); // Hide game over text
        playAgainButton.gameObject.SetActive(false); // Hide play again button
       // gameManager.ResetGame(); // Reset the game in GameManager
    }
}
