using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Session5
{
    public class WorldCanvas : MonoBehaviour
    {
        public Image imageToResize;
        public TextMeshProUGUI scoreText;

        public void ChangeImageSize(float size)
        {
            Debug.Log("ChangeImageSize: " + size);

            imageToResize.rectTransform.localScale = size * Vector3.one;
            scoreText.text = "Score: " + size.ToString("F2");
        }
    }
}
