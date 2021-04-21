using System;

namespace DemoLibrary
{
    public class NotVerified : IAccountState
    {
        private readonly Action _onUnfreeze;

        public NotVerified(Action onUnfreeze)
        {
            _onUnfreeze = onUnfreeze;
        }

        public IAccountState Close()
        {
            return new Closed();
        }

        public IAccountState Deposit(Action addToBalance)
        {
            addToBalance();
            return this;
        }

        public IAccountState Freeze()
        {
            return this;
        }

        public IAccountState HolderVerified()
        {
            return new Active(_onUnfreeze);
        }

        public IAccountState Withdraw(Action substractFromBalance)
        {
            return this;
        }
    }
}
