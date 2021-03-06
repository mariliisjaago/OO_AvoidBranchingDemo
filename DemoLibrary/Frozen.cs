using System;

namespace DemoLibrary
{
    public class Frozen : IAccountState
    {
        private readonly Action _onUnfreezing;

        public Frozen(Action onUnfreezing)
        {
            _onUnfreezing = onUnfreezing;
        }

        public IAccountState Close()
        {
            return this;
        }

        public IAccountState Deposit(Action addToBalance)
        {
            _onUnfreezing();
            addToBalance();
            return new Active(_onUnfreezing);
        }

        public IAccountState Freeze()
        {
            return this;
        }

        public IAccountState HolderVerified()
        {
            return this;
        }

        public IAccountState Withdraw(Action substractFromBalance)
        {
            _onUnfreezing();
            substractFromBalance();
            return new Active(_onUnfreezing);
        }
    }
}
