using System;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    internal sealed class MainController : Controllers, IDisposable
    {
        #region Fields

        private readonly Transform _placeForUi;
        private readonly ProfilePlayer _profilePlayer;

        private MainMenuController _mainMenuController;
        private GameController _gameController;
        private InitializationController _initializationController;

        #endregion


        #region ClassLifeCycles

        public MainController(Transform placeForUi, InitializationController initializationController)
        {
            _placeForUi = placeForUi;
            _initializationController = initializationController;

            _profilePlayer = _initializationController.GetProfilePlayer(); ;
            _profilePlayer.CurrentState.Value = GameState.Start;

            OnChangeGameState(_profilePlayer.CurrentState.Value);
            _profilePlayer.CurrentState.SubscriptionOnChange(OnChangeGameState);
        }

        public void Dispose()
        {
            _mainMenuController?.Cleanup();
            _gameController?.Cleanup();
            _profilePlayer.CurrentState.UnSubscriptionOnChange(OnChangeGameState);
            base.Cleanup();
        }

        #endregion


        #region Methods

        private void OnChangeGameState(GameState state)
        {
            switch (state)
            {
                case GameState.Start:
                    _mainMenuController =
                        new MainMenuController(_placeForUi, _profilePlayer);
                    _gameController?.Cleanup();
                    break;
                case GameState.Game:
                    _gameController = new GameController(_placeForUi, _initializationController);
                    _mainMenuController?.Cleanup();
                    break;
                default:
                    _gameController?.Cleanup();
                    _mainMenuController?.Cleanup();
                    break;
            }
        }

        #endregion
    }
}