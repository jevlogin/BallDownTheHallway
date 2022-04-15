namespace WORLDGAMEDEVELOPMENT
{
    internal class ScoreController : IInitialization
    {
        #region Fields

        private readonly ScoreView _scoreView;

        #endregion


        #region ClassLifeCycles

        public ScoreController(ScoreView scoreView)
        {
            _scoreView = scoreView;
        }

        #endregion


        #region Methods

        public void Initialization()
        {
            _scoreView.ScoreText.gameObject.SetActive(true);
            _scoreView.LifeText.gameObject.SetActive(true);
        }

        #endregion
    }
}