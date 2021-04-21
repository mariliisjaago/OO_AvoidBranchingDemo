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
            throw new NotImplementedException();
        }

        public IAccountState Deposit()
        {
            _onUnfreezing();
            return new Active(_onUnfreezing);
        }

        public IAccountState Freeze()
        {
            return this;
        }

        public IAccountState HolderVerified()
        {
            throw new NotImplementedException();
        }

        public IAccountState Withdraw()
        {
            _onUnfreezing();
            return new Active(_onUnfreezing);
        }
    }
}
