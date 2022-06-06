using UnityEngine;
using UnityEngine.SceneManagement;

namespace Session5
{
    public class ScreenCanvas : MonoBehaviour
    {
        public GameObject worldCanvas;

        public void ButtonClicked()
        {
            Debug.Log("ButtonClicked");
        }

        public void ToggleWorldMenu()
        {
            Debug.Log("ToggleWorldMenu");

            worldCanvas.SetActive(!worldCanvas.activeSelf);

            // Equivalent to
            //if (worldCanvas.activeSelf)
            //{
            //    worldCanvas.SetActive(false);
            //}
            //else
            //{
            //    worldCanvas.SetActive(true);
            //}
        }

        public void ReloadScene()
        {
            SceneManager.LoadScene(0);
            // Equivalent to
            SceneManager.LoadScene("5 UI");
        }
    }
}
