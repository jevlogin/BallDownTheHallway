using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    internal sealed class GameController : Controllers
    {
        #region Fields

        private readonly Transform _placeForUi;
        private readonly ProfilePlayer _profilePlayer;
        private InitializationController _initializationController;
        private readonly Camera _camera;

        #endregion


        #region ClassLifeCycles

        public GameController(Transform placeForUi, InitializationController initializationController)
        {
            _camera = Camera.main;
            _placeForUi = placeForUi;
            _initializationController = initializationController;
            _profilePlayer = _initializationController.GetProfilePlayer();
            _profilePlayer.PlayerModel.PlayerComponents.TransformPlayer.gameObject.SetActive(true);

            var platformFactory = new PlatformFactory(_initializationController.Data.PlatformData);
            var platformController = new PlatformController(platformFactory);
            Add(platformController);

            var parallaxManager = new ParallaxManager(_camera);

            //Add(parallaxManager);


            var scoreFactory = new ScoreFactory(_initializationController.Data.ScoreData, placeForUi);
            var scoreController = new ScoreController(scoreFactory.GetScoreView());
            Add(scoreController);



            Initialization();
        }

        #endregion



    }
}