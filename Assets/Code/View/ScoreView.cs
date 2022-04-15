using TMPro;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    public sealed class ScoreView : MonoBehaviour
    {
        #region Fields

        [SerializeField] private TextMeshProUGUI _lifeText;
        [SerializeField] private TextMeshProUGUI _scoreText;

        #endregion


        #region Properties

        public TextMeshProUGUI LifeText => _lifeText;
        public TextMeshProUGUI ScoreText => _scoreText;

        #endregion
    }
}
