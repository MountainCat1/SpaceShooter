using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class MainMenuUI : MonoBehaviour
    {
        public void OnStartButtonClicked()
        {
            StartGame();
        }
        
        public void OnQuitButtonClicked()
        {
            Application.Quit();
        }

        private void StartGame()
        {
            Debug.Log("Game started :D");
            SceneManager.LoadScene("Game");
        }
    }
}
