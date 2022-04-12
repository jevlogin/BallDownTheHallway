using System;


namespace WORLDGAMEDEVELOPMENT
{
    public interface IReadOnlySubscriptionProperty<T>
    {
        T Value { get; }
        void SubscriptionOnChange(Action<T> subscriptionAction);
        void UnSubscriptionOnChange(Action<T> unsubscriptionAction);
    }
}