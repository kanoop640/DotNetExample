namespace DotNetExample
{
    /// <summary>
    /// Every Member of interface can inherit form another interface
    /// should be implemented under the child class of the interface
    /// without fail, But while implementinging we don't require to 
    /// to use override modifier just like we have done in case of 
    /// abstract class
    /// </summary>
    /// <seealso cref="DotNetExample.IMathComputation" />
    interface IMathComputation1 :IMathComputation
    {
        void Mul(int a, int b);
    }
}
