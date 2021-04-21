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
            throw new NotImplementedException();
        }

        public IAccountState Deposit()
        {
            return this;
        }

        public IAccountState Freeze()
        {
            return new Frozen(_onUnfreezing);
        }

        public IAccountState HolderVerified()
        {
            throw new NotImplementedException();
        }

        public IAccountState Withdraw()
        {
            return this;
        }
    }
}
