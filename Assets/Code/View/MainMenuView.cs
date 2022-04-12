using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


namespace WORLDGAMEDEVELOPMENT
{
    internal sealed class MainMenuView : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Button _buttonStart;

        #endregion


        #region ClassLifeCicles

        private void OnDestroy()
        {
            _buttonStart.onClick.RemoveAllListeners();
        }

        #endregion


        #region Methods

        internal void Init(UnityAction startGame)
        {
            _buttonStart.onClick.AddListener(startGame);
        }

        #endregion
    }
}