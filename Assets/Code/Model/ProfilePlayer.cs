namespace WORLDGAMEDEVELOPMENT
{
    internal sealed class ProfilePlayer
    {
        public SubscriptionProperty<GameState> CurrentState { get; }
        public PlayerModel PlayerModel;

        public ProfilePlayer(Data data, PlayerModel playerModel)
        {
            CurrentState = new SubscriptionProperty<GameState>();
            PlayerModel = playerModel;
        }
    }
}