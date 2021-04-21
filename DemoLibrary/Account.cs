using System;

namespace DemoLibrary
{
    public class Account
    {
        public decimal Balance { get; private set; }
        private bool IsVerified { get; set; } = true;
        private bool IsClosed { get; set; } = false;

        private IAccountState _freezable { get; set; }

        public Account(Action onUnfreeze)
        {
            _freezable = new Active(onUnfreeze);
        }

        public void Create()
        {
            Balance = 0.0m;
        }

        public void Deposit(decimal amount)
        {
            if (IsClosed == true)
            {
                return;
            }

            _freezable = _freezable.Deposit();

            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (IsVerified == false)
            {
                return;
            }
            if (IsClosed == true)
            {
                return;
            }

            _freezable = _freezable.Withdraw();

            Balance -= amount;
        }

        public void VerifyOwner()
        {
            IsVerified = true;
        }

        public void CloseAccount()
        {
            IsClosed = true;
        }

        public void Freeze()
        {
            _freezable = _freezable.Freeze();
        }

    }
}
