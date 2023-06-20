using System.Reflection;

namespace Reflection_
{

    public class Ref
    {
        public T Copy<T>(object item) where T : class, new()
        {
            Type t1 = typeof(T);

            Type t2 = item.GetType();

            ConstructorInfo constructor= t1.GetConstructor(new Type[] { });
            object result=constructor.Invoke(new object[] { });

           PropertyInfo[] t2prprties = t2.GetProperties();

           PropertyInfo[] t1prprties = t1.GetProperties();

            foreach(PropertyInfo pi in t2prprties)
            {
                foreach(PropertyInfo p1 in t1prprties)
                {
                    if(pi.Name == p1.Name)
                    {
                        p1.SetValue(result, pi.GetValue(item));
                    }
                }
            }
            return (T)result;
              

        }   
    }
}
