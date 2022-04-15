using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    internal sealed class ScoreFactory
    {
        #region Fields

        private readonly ScoreData _scoreData;
        private readonly Transform _positionTransformForSCore;
        private ScoreView _scoreView;

        #endregion


        #region ClassLifeCycles

        public ScoreFactory(ScoreData scoreData, UnityEngine.Transform placeForUi)
        {
            _scoreData = scoreData;
            _positionTransformForSCore = placeForUi;
        }

        #endregion


        #region Methods

        internal ScoreView GetScoreView()
        {
            if (_scoreView == null)
            {
                _scoreView = Object.Instantiate(_scoreData.ScoreViewPrefab, _positionTransformForSCore);
            }
            return _scoreView;
        }

        #endregion
    }
}