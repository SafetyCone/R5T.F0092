using System;


namespace R5T.F0092
{
    public static class Instances
    {
        public static F0000.ICommandLineOperator CommandLineOperator => F0000.CommandLineOperator.Instance;
        public static F0000.IStringOperator StringOperator => F0000.StringOperator.Instance;
    }
}