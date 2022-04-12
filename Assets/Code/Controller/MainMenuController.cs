using System.IO;
using UnityEngine;
using Object = UnityEngine.Object;


namespace WORLDGAMEDEVELOPMENT
{
    internal sealed class MainMenuController : BaseController
    {
        #region Fields

        private Transform _placeForUi;
        private ProfilePlayer _profilePlayer;
        private MainMenuView _view;

        #endregion


        #region ClassLifeCycles

        public MainMenuController(Transform placeForUi, ProfilePlayer profilePlayer)
        {
            _placeForUi = placeForUi;
            _profilePlayer = profilePlayer;
            _view = LoadView<MainMenuView>(_placeForUi, 
                Path.Combine(ManagerPath.DATA, ManagerPath.MAINMENU, 
                    ManagerPath.BUTTON, ManagerName.BUTTONSTART));
            _view.Init(StartGame);
        }

        #endregion


        #region Methods

        private void StartGame()
        {
            _profilePlayer.CurrentState.Value = GameState.Game;
        }

        private T LoadView<T>(Transform parrentPosition, string pathMenu) where T : Component
        {
            var viewPrefab = Resources.Load<T>(pathMenu);
            var view = Object.Instantiate(viewPrefab, parrentPosition, false);
            AddGameObjects(view.gameObject);
            return view.GetComponent<T>();
        }

        #endregion
    }
}