namespace ArrayCopy.Lib
{
    public static class ArrayHelper<T>
    {
        public static T[] MakeCopy(T[] sourceArray)
        {
            T[] resultArray = new T[sourceArray.LongLength];

            for (int i = 0; i < sourceArray.LongLength; i++)
            {
                resultArray[i] = sourceArray[i];
            }

            return resultArray;
        }
    }
}