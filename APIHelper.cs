using System;

namespace Chayatath.CodeLibrary.Helper
{
    public class FunctionHelper
    {
        public void SampleCall(){
            AttemptCall(() => SampleFunction(), 3);
        }
        
        public T AttemptCall<T>(Func<T> callback, int count)
        {
            T result = default(T);
            Exception exception = null;
            for(int i = 0; i < count; i++)
            {
                try
                {
                    result = callback();
                    if (result != null) return (T)result;
                }
                catch (Exception ex) { exception = ex; }
            }

            if (exception != null) throw exception;
            return (T)result;
        }
    }
}
