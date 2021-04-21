using System;

namespace DemoLibrary
{
    public class Active : IAccountState
    {
        private readonly Action _onUnfreezing;

        public Active(Action onUnfreezing)
        {
            _onUnfreezing = onUnfreezing;
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
            return new Frozen(_onUnfreezing);
        }

        public IAccountState HolderVerified()
        {
            return this;
        }

        public IAccountState Withdraw(Action substractFromBalance)
        {
            substractFromBalance();
            return this;
        }
    }
}
