using System;

namespace DemoLibrary
{
    public class Closed : IAccountState
    {
        public IAccountState Close()
        {
            return this;
        }

        public IAccountState Deposit(Action addToBalance)
        {
            return this;
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
            return this;
        }
    }
}
