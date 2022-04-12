using System.IO;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    public sealed class Root : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Transform _placeForUi;
        [SerializeField] private string _dataPath;

        private Data _data;
        private MainController _mainController;
        private InitializationController _initializationController;

        #endregion


        #region UnityMethods
        
        private void Awake()
        {
            _data = Resources.Load<Data>(Path.Combine(ManagerPath.DATA, ManagerPath.DATA));
            if (_data == null) _data = Resources.Load<Data>(_dataPath);

            _initializationController = new InitializationController(_data);

            ProfilePlayer profilePlayer = _initializationController.GetProfilePlayer();

            profilePlayer.CurrentState.Value = GameState.Start;

            _mainController = new MainController(_placeForUi, profilePlayer);

        } 

        #endregion


        #region ClassLifeCycles

        private void OnDestroy()
        {
            _mainController?.Dispose();
        } 

        #endregion
    }
}
