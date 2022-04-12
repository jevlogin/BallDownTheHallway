using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    internal sealed class GameController : BaseController
    {
        private Transform _placeForUi;
        private ProfilePlayer _profilePlayer;

        public GameController(Transform placeForUi, ProfilePlayer profilePlayer)
        {
            _placeForUi = placeForUi;
            _profilePlayer = profilePlayer;
            _profilePlayer.PlayerModel.PlayerComponents.TransformPlayer.gameObject.SetActive(true);
        }
    }
}