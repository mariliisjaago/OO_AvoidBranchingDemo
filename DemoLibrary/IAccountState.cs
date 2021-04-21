namespace DemoLibrary
{
    public interface IAccountState
    {
        IAccountState Deposit();
        IAccountState Withdraw();
        IAccountState Freeze();
        IAccountState HolderVerified();
        IAccountState Close();
    }
}
