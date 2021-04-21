using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class Verified : IAccountState
    {
        public IAccountState Close()
        {
            return this;
        }

        public IAccountState Deposit()
        {
            return this;
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
            return this;
        }
    }
}
