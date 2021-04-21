using System;

namespace DemoLibrary
{
    public class Account
    {
        public decimal Balance { get; private set; }

        private IAccountState _state { get; set; }

        public Account(Action onUnfreeze)
        {
            Balance = 0.0m;

            _state = new NotVerified(onUnfreeze);
        }

        public void Deposit(decimal amount)
        {
            _state = _state.Deposit(() => { Balance += amount; });
        }

        public void Withdraw(decimal amount)
        {
            _state = _state.Withdraw(() => { Balance -= amount; });
        }

        public void VerifyOwner()
        {
            _state = _state.HolderVerified();
        }

        public void CloseAccount()
        {
            _state = _state.Close();
        }

        public void Freeze()
        {
            _state = _state.Freeze();
        }

    }
}
